namespace src.Domain.Interfaces
{
    public interface IEjectExternalHdService
    {
        bool Eject(string diskDrive);
    }
}