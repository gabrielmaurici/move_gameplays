namespace MoveGameplays.Infraestruct
{
    public class MoveLast10Mp4Files : MoveFilesBase
    {
        protected override void MoveTypeFileImplement(string moveFromFolder, string moveToFolder)
        {
            try
            {
                Console.WriteLine("Movendo as últimas 10 gameplays");

                FileInfo[]? last10Mp4Files = GetLast10Mp4File(moveFromFolder);

                if (last10Mp4Files == null) return;

                foreach (var file in last10Mp4Files)
                {
                    Console.WriteLine($"Movendo a gameplay: {file.Name}");

                    string moveToFolderCombine = Path.Combine(moveToFolder, file.Name);

                    File.Copy(file.FullName, moveToFolderCombine);
                }

                Console.WriteLine("As últimas 10 gameplays foram movidas com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao mover as últimas 10 gameplays para o PC: {ex.Message}");
            }
        }

        private static FileInfo[]? GetLast10Mp4File(string moveFromFolder)
        {
            return new DirectoryInfo(moveFromFolder)
                .GetFiles("*.mp4")
                .OrderByDescending(f => f.LastWriteTime)
                .Take(10)
                .ToArray();
        }
    }

}