using System.Management;
using System.Runtime.Versioning;
using Microsoft.Extensions.Configuration;
using src.Domain.Enums;
using src.Domain.Interfaces;

namespace src.Infraestruct
{
    [SupportedOSPlatform("windows")]
    public class MonitorExternalHdInput(IConfiguration configuration, IEjectExternalHdService _ejectExternalHdService) : IMonitorExternalHdInput, IDisposable
    {
        private readonly ManagementEventWatcher _watcher = new();
        private readonly string? _monitorDirectoryName = configuration.GetSection("MonitorDirectoryName")?.Value?.ToString();
        private const string QUERY_VOLUME_CHANGE_EVENT = "SELECT * FROM Win32_VolumeChangeEvent";


        public void Monitor()
        {
            WindowConsole.Open();
            Console.WriteLine(_monitorDirectoryName);

            _watcher.EventArrived += VolumeChanged;
            _watcher.Query = new WqlEventQuery(QUERY_VOLUME_CHANGE_EVENT);
            _watcher.Start();
        }

        void VolumeChanged(object sender, EventArrivedEventArgs e)
        {
            if (sender != _watcher) return;

            GetEventTypeAndDiskDrive(e, out EEventType? eventType, out string? diskDrive);

            if (eventType == EEventType.Arrival && !string.IsNullOrEmpty(diskDrive))
            {
                IMoveFiles _moveFiles = new MoveLastFile();
                _moveFiles.Move($"{diskDrive}\\GameDVR", "E:\\gamplays-cod-teste");

                _ejectExternalHdService.Eject(diskDrive);
            }

        }

        private static void GetEventTypeAndDiskDrive(EventArrivedEventArgs e, out EEventType? eventType, out string? diskDrive)
        {
            var properties = e?.NewEvent?.Properties.Cast<PropertyData>();

            var teste = properties?.Where(p => p.Name.Equals("EventType"))
                                   .SingleOrDefault()?.Value as ushort?;
                                   
            eventType = (EEventType?)teste;

            diskDrive = properties?.Where(p => p.Name.Equals("DriveName"))?
                                   .SingleOrDefault()?.Value as string;
        }

        public void Dispose()
        {
            _watcher.Stop();
            _watcher.Dispose();
        }

        ~MonitorExternalHdInput()
        {
            Dispose();
        }
    }
}