using Microsoft.Extensions.DependencyInjection;
using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Infrastructure;
using System.Runtime.Versioning;

namespace MoveGameplays.IoC
{
    [SupportedOSPlatform("windows")]
    public static class AppDependeces
    {
        public static IServiceCollection AddInfraDependeces(this IServiceCollection services)
            => services.AddScoped<ICheckExpectedHdService, CheckExpectedHdService>()
                       .AddScoped<IEjectExternalHdService, EjectExternalHdService>()
                       .AddScoped<IMoveGameplaysSettignsService, MoveGameplaysSettingsService>()
                       .AddScoped<IDeleteFilesService, DeleteFilesService>();
    }
}
