using Microsoft.Extensions.DependencyInjection;
using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Infraestruct;
using MoveGameplays.UseCases.Interface;
using src.UseCases.Interfaces;
using System.Runtime.Versioning;

namespace MoveGameplays.IoC
{
    [SupportedOSPlatform("windows")]
    public static class AppDependeces
    {
        public static IServiceCollection AddInfraDependeces(this IServiceCollection services)
            => services.AddScoped<ICheckExpectedHd, CheckExpectedHd>()
                       .AddScoped<IEjectExternalHdService, EjectExternalHdService>();

        public static IServiceCollection AddUseCasesDependeces(this IServiceCollection services)
            => services.AddScoped<IMoveGameplaysUseCase, MoveGameplaysUseCase>();
    }
}
