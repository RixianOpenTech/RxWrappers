using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
public static class _UnobservedTaskExceptionEventArgs
{
    
public static IObservable<System.Reactive.Unit> SetObserved(this IObservable<System.Threading.Tasks.UnobservedTaskExceptionEventArgs> UnobservedTaskExceptionEventArgsValue)
{
    return Observable.Do(UnobservedTaskExceptionEventArgsValue, (UnobservedTaskExceptionEventArgsValueLambda) => UnobservedTaskExceptionEventArgsValueLambda.SetObserved()).ToUnit();
}


public static IObservable<System.Boolean> get_Observed(this IObservable<System.Threading.Tasks.UnobservedTaskExceptionEventArgs> UnobservedTaskExceptionEventArgsValue)
{
    return Observable.Select(UnobservedTaskExceptionEventArgsValue, (UnobservedTaskExceptionEventArgsValueLambda) => UnobservedTaskExceptionEventArgsValueLambda.Observed);
}


public static IObservable<System.AggregateException> get_Exception(this IObservable<System.Threading.Tasks.UnobservedTaskExceptionEventArgs> UnobservedTaskExceptionEventArgsValue)
{
    return Observable.Select(UnobservedTaskExceptionEventArgsValue, (UnobservedTaskExceptionEventArgsValueLambda) => UnobservedTaskExceptionEventArgsValueLambda.Exception);
}

}
}