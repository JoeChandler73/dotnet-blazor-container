using Example.Blazor.Services;
using Example.Blazor.Store.WeatherUseCase.Actions;
using Fluxor;

namespace Example.Blazor.Store.WeatherUseCase.Effects;

public class FetchDataActionEffect(IWeatherForecastService weatherForecastService) : Effect<FetchDataAction>
{
    public override async Task HandleAsync(FetchDataAction action, IDispatcher dispatcher)
    {
        var forecasts = await weatherForecastService.GetForecastAsync();
        dispatcher.Dispatch(new FetchDataResultAction(forecasts));
    }
}