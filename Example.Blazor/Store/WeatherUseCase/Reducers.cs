using Example.Blazor.Store.WeatherUseCase.Actions;
using Fluxor;

namespace Example.Blazor.Store.WeatherUseCase;

public static class Reducers
{
    [ReducerMethod]
    public static WeatherState ReduceFetchDataAction(WeatherState state, FetchDataAction action) =>
        new WeatherState { IsLoading = true };
    
    [ReducerMethod]
    public static WeatherState ReduceFetchDataResultAction(WeatherState state, FetchDataResultAction action) =>
        new WeatherState{ IsLoading = false, Forecasts = action.Forecasts };
}