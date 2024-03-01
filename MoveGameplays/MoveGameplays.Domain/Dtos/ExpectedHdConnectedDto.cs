using MoveGameplays.Domain.Models;

namespace MoveGameplays.Domain.Dtos
{
    public record ExpectedHdConnectedDto(string DiskDrive, MoveGameplaysConfigModel MoveGameplaysConfig);
}
