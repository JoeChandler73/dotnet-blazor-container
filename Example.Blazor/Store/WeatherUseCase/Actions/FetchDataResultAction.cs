using Example.Blazor.Models;

namespace Example.Blazor.Store.WeatherUseCase.Actions;

public class FetchDataResultAction(IEnumerable<WeatherForecast> forecasts)
{
    public IEnumerable<WeatherForecast> Forecasts { get; } = forecasts;
}