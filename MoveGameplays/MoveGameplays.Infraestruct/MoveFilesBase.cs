using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Enums;
using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Domain.Interfaces.Observer;

namespace MoveGameplays.Infraestruct
{
    public abstract class MoveFilesBase : IMoveFiles, IObservedContract<ProgressGameplayDto>
    {
        public List<IObserverContract<ProgressGameplayDto>> _observers = [];

        public void Subscribe(IObserverContract<ProgressGameplayDto> observer)
            => _observers.Add(observer);

        public void Unsubscribe(IObserverContract<ProgressGameplayDto> observer)
            => _observers.Remove(observer);

        public void NotifiesSubscribers(ProgressGameplayDto notification)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(notification);
            }
        }

        public async Task Move(string moveFromFolder, string moveToFolder)
        {
            MoveAllImages(moveFromFolder, moveToFolder);

            await MoveTypeFileImplement(moveFromFolder, moveToFolder);
        }

        public async Task MoveFileAsync(string moveFromFolder, string moveToFolder, string fileName, string numberOfFiles = "1/1")
        {
            const int bufferSize = 4096;
            byte[] buffer = new byte[bufferSize];
            int bytesRead = 0;
            long totalBytesRead = 0;

            using FileStream sourceStream = new(moveFromFolder, FileMode.Open, FileAccess.Read);
            using FileStream destinationStream = new(moveToFolder + $"\\{fileName}", FileMode.Create, FileAccess.Write);

            long totalBytes = sourceStream.Length;

            short previousProgress = 0;

            var progressGameplay = new ProgressGameplayDto()
            {
                Success = true,
                FileName = fileName,
                FileType = EFileType.Mp4,
                NumberOfFiles = numberOfFiles,
            };

            while ((bytesRead = await sourceStream.ReadAsync(buffer)) > 0)
            {
                await destinationStream.WriteAsync(buffer.AsMemory(0, bytesRead));

                totalBytesRead += bytesRead;

                // Notificar progresso (exemplo: em percentagem)
                short progressPercentage = (short)((double)totalBytesRead / totalBytes * 100);
                if (progressPercentage > previousProgress)
                {
                    progressGameplay.PercentageOfProgress = progressPercentage;
                    NotifiesSubscribers(progressGameplay);
                    previousProgress = progressPercentage;
                }
            }
        }

        private void MoveAllImages(string moveFromFolder, string moveToFolder)
        {
            try
            {
                Console.WriteLine("Movendo todas as imagens");

                FileInfo[]? files = new DirectoryInfo(moveFromFolder)
                .GetFiles("*.png")
                .ToArray();

                if (files == null) return;

                var moveToFolderImages = moveToFolder + "\\images";

                var progressGameplay = new ProgressGameplayDto()
                {
                    FileType = EFileType.Png,
                    PercentageOfProgress = 0
                };

                var totalFiles = files.Length;
                var count = 1;

                foreach (var file in files)
                {
                    string moveToFolderCombine = Path.Combine(moveToFolderImages, file.Name);

                    progressGameplay.FileName = file.Name;
                    progressGameplay.NumberOfFiles = $"{count}/{totalFiles}";

                    NotifiesSubscribers(progressGameplay);

                    count++;
                }
            }
            catch (Exception ex)
            {
                NotifyError($"Erro ao mover imagens: {ex.Message}");
            }
        }

        public void NotifyError(string message)
        {
            var notify = new ProgressGameplayDto
            {
                Success = false,
                MessageError = message,
            };

            NotifiesSubscribers(notify);
        }

        protected abstract Task MoveTypeFileImplement(string moveFromFolder, string moveToFolder);
    }
}