using Example.Blazor.Models;

namespace Example.Blazor.Services;

public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetForecastAsync();
}