using Microsoft.Extensions.DependencyInjection;
using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Infraestruct;
using System.Runtime.Versioning;

namespace MoveGameplays.IoC
{
    [SupportedOSPlatform("windows")]
    public static class AppDependeces
    {
        public static IServiceCollection AddInfraDependeces(this IServiceCollection services)
            => services.AddScoped<ICheckExpectedHd, CheckExpectedHd>()
                       .AddScoped<IEjectExternalHdService, EjectExternalHdService>();
    }
}
