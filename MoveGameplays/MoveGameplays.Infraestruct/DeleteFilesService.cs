using MoveGameplays.Domain.Interfaces;

namespace MoveGameplays.Infraestruct
{
    public class DeleteFilesService : IDeleteFilesService
    {
        public void Delete(string path)
        {
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                File.Delete(file);
            }
        }
    }
}
