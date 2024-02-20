namespace MoveGameplays.Domain.Interfaces
{
    public interface IEjectExternalHdService
    {
        bool Eject(string diskDrive);
    }
}