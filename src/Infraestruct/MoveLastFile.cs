using src.Domain.Interfaces;

namespace src.Infraestruct
{
    public class MoveLastFile : IMoveFiles
    {
        public void Move(string moveFromFolder, string moveToFolder)
        {
            FileInfo? lastFile = GetLastFile(moveFromFolder);

            if (lastFile == null) return;

            string moveToFolderCombine = Path.Combine(moveToFolder, lastFile.Name);

            File.Copy(lastFile.FullName, moveToFolderCombine);
        }

        private static FileInfo? GetLastFile(string moveFromFolder)
        {
            return new DirectoryInfo(moveFromFolder)
            .GetFiles("*.mp4")
            .OrderByDescending(f => f.LastWriteTime)
            .FirstOrDefault();
        }
    }
}