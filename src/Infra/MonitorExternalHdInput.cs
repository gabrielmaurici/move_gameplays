using System.Management;
using System.Runtime.Versioning;
using Microsoft.Extensions.Configuration;
using src.Domain.Services;

namespace src.Infra
{
    [SupportedOSPlatform("windows")]
    public class MonitorExternalHdInput(IConfiguration configuration) : IMonitorExternalHdInput, IDisposable
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

            var properties = e?.NewEvent?.Properties.Cast<PropertyData>();

            var eventType = properties?.Where(p => p.Name.Equals("EventType"))
                                       .SingleOrDefault();

            var driveName = properties?.Where(p => p.Name.Equals("DriveName"))?
                                    .SingleOrDefault()?.Value as string;

            if (eventType != null && driveName != null)
            {
                var attachId = (UInt16)2;
                var eventId = (UInt16)eventType.Value;

                if (eventId.Equals(attachId))
                {
                    if (driveName!.Equals(_monitorDirectoryName))
                        WindowConsole.Open();

                    Console.WriteLine("attaching");
                }
            }
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