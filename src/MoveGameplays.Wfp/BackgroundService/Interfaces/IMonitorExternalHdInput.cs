using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Interfaces.Observer;

namespace MoveGameplays.Wfp.BackgroundService.Interfaces
{
    public interface IMonitorExternalHdInput : IObservedContract<ExpectedHdConnectedDto>
    {
        void Monitor();
    }
}