namespace MoveGameplays.Domain.Interfaces
{
    public interface IMoveFiles
    {
        Task Move(string moveFromFolder, string moveToFolder);
    }
}