using MoveGameplays.Domain.Enums;

namespace MoveGameplays.Domain.Dtos
{
    public class ProgressGameplayDto
    {
        public bool Success { get; set; }
        public string? FileName { get; set; }
        public short PercentageOfProgress { get; set; }
        public EFileType FileType { get; set; }
        public string NumberOfFiles { get; set; } = null!;
        public string? MessageError { get; set; }
    }
}
