using Example.Blazor.Services;
using Fluxor;
using MudBlazor.Services;

namespace Example.Blazor.Configuration;

public static class ServiceConfiguration
{
    public static WebApplicationBuilder Configure(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddSingleton<IWeatherForecastService, WeatherForecastService>()
            .AddMudServices()
            .AddFluxor(options => options.ScanAssemblies(typeof(Program).Assembly))
            .AddRazorComponents()
            .AddInteractiveServerComponents();
        
        return builder;
    }
}