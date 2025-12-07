using System.Diagnostics.CodeAnalysis;
using Example.Blazor.Store.CounterUseCase;
using Example.Blazor.Store.CounterUseCase.Actions;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace Example.Blazor.Components.Pages;

public partial class Counter
{
    [Inject]
    private IState<CounterState> CounterState { get; set; }
    
    [Inject]
    public IDispatcher? Dispatcher { get; set; }

    private void IncrementCount()
    {
        var action = new IncrementCounterAction();
        
        Dispatcher?.Dispatch(action);
    }
}