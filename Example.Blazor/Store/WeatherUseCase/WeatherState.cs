using Example.Blazor.Models;
using Fluxor;

namespace Example.Blazor.Store.WeatherUseCase;

public record WeatherState
{
    public bool IsLoading { get; init; }
    public IEnumerable<WeatherForecast>? Forecasts { get; init; }
}

public class WeatherFeature : Feature<WeatherState>
{
    public override string GetName() => "Weather";
    
    protected override WeatherState GetInitialState() => 
        new() {IsLoading = false, Forecasts = Array.Empty<WeatherForecast>()};
}