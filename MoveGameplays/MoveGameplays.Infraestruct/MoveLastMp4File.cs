namespace MoveGameplays.Infraestruct
{
    public class MoveLastMp4File : MoveFilesBase
    {
        protected override void MoveTypeFileImplement(string moveFromFolder, string moveToFolder)
        {
            try
            {
                Console.WriteLine("Movendo a última gameplay");

                FileInfo? lastMp4File = GetLastMp4File(moveFromFolder);

                if (lastMp4File == null) return;

                Console.WriteLine($"Movendo gameplay: {lastMp4File.Name}");

                string moveToFolderCombine = Path.Combine(moveToFolder, lastMp4File.Name);

                File.Copy(lastMp4File.FullName, moveToFolderCombine);

                Console.WriteLine("Última gameplay movida com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao mover a última gameplay para o PC: {ex.Message}");
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