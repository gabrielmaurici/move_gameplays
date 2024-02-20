namespace MoveGameplays.Domain.Interfaces
{
    public interface ICheckExpectedHd
    {
        bool Check(string driveDisk, string hdName);
    }
}