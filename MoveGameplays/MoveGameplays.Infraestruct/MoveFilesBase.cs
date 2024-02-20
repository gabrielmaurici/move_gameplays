using MoveGameplays.Domain.Interfaces;

namespace MoveGameplays.Infraestruct
{
    public abstract class MoveFilesBase : IMoveFiles
    {
        public void Move(string moveFromFolder, string moveToFolder)
        {
            MoveAllImages(moveFromFolder, moveToFolder);

            MoveTypeFileImplement(moveFromFolder, moveToFolder);
        }

        private static void MoveAllImages(string moveFromFolder, string moveToFolder)
        {
            try
            {
                Console.WriteLine("Movendo todas as imagens");

                FileInfo[]? files = new DirectoryInfo(moveFromFolder)
                .GetFiles("*.png")
                .ToArray();

                if (files == null) return;

                var moveToFolderImages = moveToFolder + "\\images";

                foreach (var file in files)
                {
                    Console.WriteLine($"Movendo imagem: {file.Name}");

                    string moveToFolderCombine = Path.Combine(moveToFolderImages, file.Name);

                    File.Copy(file.FullName, moveToFolderCombine);
                }

                Console.WriteLine("Todas as imagens foram movidas com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        protected abstract void MoveTypeFileImplement(string moveFromFolder, string moveToFolder);
    }
}