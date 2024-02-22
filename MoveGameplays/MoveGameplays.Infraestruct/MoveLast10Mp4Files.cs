namespace MoveGameplays.Infraestruct
{
	public class MoveLast10Mp4Files : MoveFilesBase
	{
		protected override async Task MoveTypeFileImplement(string moveFromFolder, string moveToFolder)
		{
			try
			{
				Console.WriteLine("Movendo as últimas 10 gameplays");

				FileInfo[]? last10Mp4Files = GetLast10Mp4File(moveFromFolder);

				if (last10Mp4Files == null) return;

				foreach (var file in last10Mp4Files)
				{
					await MoveFileAsync(moveFromFolder: file.FullName,
										moveToFolder: moveToFolder,
										fileName: file.Name);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Erro ao mover as últimas 10 gameplays para o PC: {ex.Message}");
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