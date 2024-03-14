using MoveGameplays.Domain.Interfaces;
using System.Management;
using System.Runtime.Versioning;

namespace MoveGameplays.Infrastructure
{
    [SupportedOSPlatform("windows")]
    public class CheckExpectedHdService : ICheckExpectedHdService
    {
        public bool Check(string driveDisk, string hdName)
        {
            ManagementObjectSearcher objSearcher = new($"SELECT * FROM Win32_LogicalDisk WHERE DeviceID = '{driveDisk}'");

            var objVolume = objSearcher.Get();

            foreach (var volume in objVolume)
            {
                var volumeName = volume["VolumeName"];

                if (volumeName.Equals(hdName)) return true;
            }

            return false;
        }
    }
}