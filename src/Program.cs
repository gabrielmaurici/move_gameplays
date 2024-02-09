using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using src.Background;
using src.Domain.Services;
using src.Infra;
using System.Runtime.Versioning;

[SupportedOSPlatform("windows")]
class Program
{
    static void Main()
    {
        var builder = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
        {

            var teste = hostContext.Configuration.GetConnectionString("teste");
            Console.WriteLine(teste);

            services.AddScoped<IMonitorExternalHdInput, MonitorExternalHdInput>();

            services.AddHostedService<MoveGameplaysBackGround>();
        });

        var host = builder.Build();
        host.Run();
    }
}