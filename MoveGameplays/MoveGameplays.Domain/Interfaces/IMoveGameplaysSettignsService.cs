using MoveGameplays.Domain.Dtos;

namespace MoveGameplays.Domain.Interfaces
{
    public interface IMoveGameplaysSettignsService
    {
        ChangeGameplaysSettingsDto GetConfigs();
        void UpdateConfigs(ChangeGameplaysSettingsDto model);
    }
}
