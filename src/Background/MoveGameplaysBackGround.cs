using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using src.Domain.Services;
using src.Infra;
using System.Runtime.Versioning;

namespace src.Background
{
    [SupportedOSPlatform("windows")]
    public class MoveGameplaysBackGround(ILogger<MoveGameplaysBackGround> logger, IMonitorExternalHdInput _monitorExternalHdInput) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                WindowConsole.Close();
                _monitorExternalHdInput.Monitor();

                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "{Message}", ex.Message);
                Environment.Exit(1);
            }
        }
    }
}