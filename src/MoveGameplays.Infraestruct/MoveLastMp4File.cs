using MoveGameplays.Domain.Dtos;

namespace MoveGameplays.Infrastructure
{
    public class MoveLastMp4File : MoveFilesBase
    {
        protected override async Task MoveTypeFileImplement(string moveFromFolder, string moveToFolder)
        {
            try
            {
                FileInfo? lastMp4File = GetLastMp4File(moveFromFolder);

                if (lastMp4File == null) return;

                await MoveFileAsync(moveFromFolder: lastMp4File.FullName,
                                    moveToFolder: moveToFolder,
                                    fileName: lastMp4File.Name);
            }
            catch (Exception ex)
            {
                NotifyError($"Falha ao mover última gameplay: {ex.Message}");
            }
        }

        private static FileInfo? GetLastMp4File(string moveFromFolder)
        {
            return new DirectoryInfo(moveFromFolder)
                .GetFiles("*.mp4")
                .OrderByDescending(f => f.LastWriteTime)
                .FirstOrDefault();
        }
    }
}