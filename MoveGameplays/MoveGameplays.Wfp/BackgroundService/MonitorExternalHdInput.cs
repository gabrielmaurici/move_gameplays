using MoveGameplays.Domain.Enums;
using MoveGameplays.Wfp.BackgroundService.Interfaces;
using src.UseCases.Interfaces;
using System.Management;
using System.Runtime.Versioning;

namespace MoveGameplays.Wfp.BackgroundService
{
    [SupportedOSPlatform("windows")]
    public class MonitorExternalHdInput(IMoveGameplaysUseCase moveGameplaysUseCase) : IMonitorExternalHdInput, IDisposable
    {
        private readonly ManagementEventWatcher _watcher = new();
        private readonly IMoveGameplaysUseCase _moveGameplaysUseCase = moveGameplaysUseCase;
        private const string QUERY_VOLUME_CHANGE_EVENT = "SELECT * FROM Win32_VolumeChangeEvent";


        public void Monitor()
        {
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
                _moveGameplaysUseCase.Move(diskDrive);
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
            ((IDisposable)this).Dispose();
        }
    }
}