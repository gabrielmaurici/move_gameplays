using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Domain.Models;
using Newtonsoft.Json;

namespace MoveGameplays.Infrastructure
{
    public class MoveGameplaysSettingsService(IConfiguration configuration, MoveGameplaysConfigModel moveGameplayConfigs) : IMoveGameplaysSettignsService
    {
        public ChangeGameplaysSettingsDto GetConfigs()
            => new (ExternalHdName: moveGameplayConfigs.ExternalHdName,
                    FolderGameplaysHd: moveGameplayConfigs.FolderGameplaysHd,
                    PathGameplaysPc: moveGameplayConfigs.PathGameplaysPc);

        public void UpdateConfigs(ChangeGameplaysSettingsDto model)
        {
            try
            {
                var configurationRoot = configuration as IConfigurationRoot;

                // Especifique o caminho absoluto para o arquivo appsettings.json
                var configurationFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

                var appSettingsJson = File.ReadAllText(configurationFilePath);

                dynamic appSettingsObject = JsonConvert.DeserializeObject(appSettingsJson) ??
                    throw new Exception("Erro ao tentar alterar as configurações");

                appSettingsObject["MoveGameplaysConfig"]["ExternalHdName"] = model.ExternalHdName;
                appSettingsObject["MoveGameplaysConfig"]["FolderGameplaysHd"] = model.FolderGameplaysHd;
                appSettingsObject["MoveGameplaysConfig"]["PathGameplaysPc"] = model.PathGameplaysPc;

                var updatedAppSettingsJson = JsonConvert.SerializeObject(appSettingsObject, Formatting.Indented);
                File.WriteAllText(configurationFilePath, updatedAppSettingsJson);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
