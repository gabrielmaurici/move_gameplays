using MoveGameplays.Domain.Dtos;

namespace MoveGameplays.Infrastructure
{
	public class MoveLast10Mp4Files : MoveFilesBase
	{
		protected override async Task MoveTypeFileImplement(string moveFromFolder, string moveToFolder)
		{
			try
			{
				FileInfo[]? last10Mp4Files = GetLast10Mp4File(moveFromFolder);

				if (last10Mp4Files == null) return;

				var totalFiles = last10Mp4Files.Length;
				var count = 1;

				foreach (var file in last10Mp4Files)
				{
					var numberOfFiles = $"{count}/{totalFiles}";

					await MoveFileAsync(moveFromFolder: file.FullName,
										moveToFolder: moveToFolder,
										fileName: file.Name,
										numberOfFiles: numberOfFiles);
					count++;
				}
			}
			catch (Exception ex)
			{
				NotifyError($"Erro ao mover as últimas 10 gameplays: {ex.Message}");
			}
		}

		private static FileInfo[]? GetLast10Mp4File(string moveFromFolder)
		{
			return new DirectoryInfo(moveFromFolder)
				.GetFiles("*.mp4")
				.OrderByDescending(f => f.LastWriteTime)
				.Take(10)
				.ToArray();
		}
	}

}