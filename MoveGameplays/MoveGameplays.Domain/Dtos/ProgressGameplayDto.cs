using MoveGameplays.Domain.Enums;

namespace MoveGameplays.Domain.Dtos
{
    public class ProgressGameplayDto
    {
        public string? FileName { get; set; }
        public short PercentageOfProgress { get; set; }
        public EFileType FileType { get; set; }
        public string NumberOfFiles { get; set; } = null!;
    }
}
