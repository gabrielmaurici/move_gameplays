using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Enums;
using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Domain.Interfaces.Observer;
using MoveGameplays.Domain.Models;
using MoveGameplays.Wfp.BackgroundService.Interfaces;
using System.Management;
using System.Runtime.Versioning;

namespace MoveGameplays.Wfp.BackgroundService
{
    [SupportedOSPlatform("windows")]
    public class MonitorExternalHdInput(ICheckExpectedHdService checkExpectedHd, MoveGameplaysConfigModel configurations) : IMonitorExternalHdInput, IDisposable
    {
        private readonly ManagementEventWatcher _watcher = new();
        private readonly ICheckExpectedHdService _checkExpectedHd = checkExpectedHd;
        private const string QUERY_VOLUME_CHANGE_EVENT = "SELECT * FROM Win32_VolumeChangeEvent";
        private readonly MoveGameplaysConfigModel _configs = configurations;
        private List<IObserverContract<ExpectedHdConnectedDto>> _observers = [];

        public void Subscribe(IObserverContract<ExpectedHdConnectedDto> observer)
            => _observers.Add(observer);

        public void Unsubscribe(IObserverContract<ExpectedHdConnectedDto> observer)
            => _observers.Remove(observer);

        public void NotifiesSubscribers(ExpectedHdConnectedDto notification)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(notification);
            }
        }

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

            if (ItsArrivalAndHasDiskDrive(eventType, diskDrive))
            {
                var isExpectedHd = _checkExpectedHd.Check(diskDrive!, _configs.ExternalHdName);
                if (isExpectedHd)
                {
                    var expectedHd = new ExpectedHdConnectedDto(diskDrive!, _configs);
                    NotifiesSubscribers(expectedHd);
                }
            }
        }

        private static bool ItsArrivalAndHasDiskDrive(EEventType? eventType, string? diskDrive)
        {
            return eventType == EEventType.Arrival && !string.IsNullOrEmpty(diskDrive);
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