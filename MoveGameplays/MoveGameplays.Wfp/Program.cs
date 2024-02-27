using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoveGameplays.Domain.Models;
using MoveGameplays.IoC;
using MoveGameplays.Wfp.BackgroundService;
using MoveGameplays.Wfp.BackgroundService.Interfaces;
using MoveGameplays.Wfp.Views;

namespace MoveGameplays.Wfp
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MonitorHdForm>());
        }
        

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var directory = "E:\\dev\\Projetos\\move_gameplays\\MoveGameplays\\MoveGameplays.Wfp";
                    config.SetBasePath(directory);
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) => {
                    var moveGameplaysConfig = context.Configuration.GetSection("MoveGameplaysConfig")
                                                                   .Get<MoveGameplaysConfigModel>()!;
                    services.AddSingleton(moveGameplaysConfig);
                    services.AddInfraDependeces();
                    services.AddScoped<IMonitorExternalHdInput, MonitorExternalHdInput>();
                    services.AddTransient<MonitorHdForm>();
                });
        }
    }
}