namespace MoveGameplays.Domain.Interfaces
{
    public interface ICheckExpectedHdService
    {
        bool Check(string driveDisk, string hdName);
    }
}