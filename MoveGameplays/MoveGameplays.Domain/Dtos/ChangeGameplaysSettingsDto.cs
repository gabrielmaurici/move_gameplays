namespace MoveGameplays.Domain.Dtos
{
    public record ChangeGameplaysSettingsDto(
        string ExternalHdName,
        string FolderGameplaysHd,
        string PathGameplaysPc,
        bool DeleteFiles
    );
}
