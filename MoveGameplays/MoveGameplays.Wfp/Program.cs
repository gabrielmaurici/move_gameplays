using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoveGameplays.IoC;
using MoveGameplays.Wfp.BackgroundService;
using MoveGameplays.Wfp.BackgroundService.Interfaces;

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

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }
        

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddInfraDependeces();
                    services.AddUseCasesDependeces();
                    services.AddScoped<IMonitorExternalHdInput, MonitorExternalHdInput>();
                    services.AddTransient<Form1>();
                });
        }
    }
}