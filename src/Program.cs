using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using src.Background;
using src.Domain.Interfaces;
using src.Infraestruct;
using System.Runtime.Versioning;

[SupportedOSPlatform("windows")]
class Program
{
    static void Main()
    {
        var builder = new HostBuilder()
        .ConfigureServices((hostContext, services) =>
        {
            var configuration = ObterIConfigurationRoot();

            services.AddSingleton<IConfiguration>(configuration);
            services.AddScoped<IMonitorExternalHdInput, MonitorExternalHdInput>();
            services.AddScoped<ICheckExpectedHd, CheckExpectedHd>();
            services.AddScoped<IEjectExternalHdService, EjectExternalHdService>();

            services.AddHostedService<MoveGameplaysBackGround>();
        });

        var host = builder.Build();
        host.Run();
    }

    private static IConfigurationRoot ObterIConfigurationRoot()
    {
        IConfigurationBuilder builder = new ConfigurationBuilder()
        .AddEnvironmentVariables()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false);

        IConfigurationRoot _configuration = builder.Build();
        return _configuration;
    }
}