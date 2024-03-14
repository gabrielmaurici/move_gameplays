using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Domain.Models;
using Newtonsoft.Json;

namespace MoveGameplays.Infrastructure
{
    public class MoveGameplaysSettingsService(MoveGameplaysConfigModel moveGameplayConfigs) : IMoveGameplaysSettignsService
    {
        public ChangeGameplaysSettingsDto GetConfigs()
            => new (ExternalHdName: moveGameplayConfigs.ExternalHdName,
                    FolderGameplaysHd: moveGameplayConfigs.FolderGameplaysHd,
                    PathGameplaysPc: moveGameplayConfigs.PathGameplaysPc,
                    DeleteFiles: moveGameplayConfigs.DeleteFiles);

        public void UpdateConfigs(ChangeGameplaysSettingsDto model)
        {
            var configurationFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

            var appSettingsJson = File.ReadAllText(configurationFilePath);

            dynamic appSettingsObject = JsonConvert.DeserializeObject(appSettingsJson) ??
                throw new Exception("Erro ao tentar alterar as configurações");

            appSettingsObject["MoveGameplaysConfig"]["ExternalHdName"] = model.ExternalHdName;
            appSettingsObject["MoveGameplaysConfig"]["FolderGameplaysHd"] = model.FolderGameplaysHd;
            appSettingsObject["MoveGameplaysConfig"]["PathGameplaysPc"] = model.PathGameplaysPc;
            appSettingsObject["MoveGameplaysConfig"]["DeleteFiles"] = model.DeleteFiles;

            var updatedAppSettingsJson = JsonConvert.SerializeObject(appSettingsObject, Formatting.Indented);
            File.WriteAllText(configurationFilePath, updatedAppSettingsJson);
        }
    }
}
