using Example.Blazor.Models;
using Example.Blazor.Store.WeatherUseCase;
using Example.Blazor.Store.WeatherUseCase.Actions;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace Example.Blazor.Components.Pages;

public partial class Weather
{
    [Inject]
    private IState<WeatherState> WeatherState { get; set; }
    
    [Inject]
    private IDispatcher? Dispatcher { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        
        Dispatcher?.Dispatch(new FetchDataAction());
    }
}