using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _ConsoleCancelEventArgs
{
    
public static IObservable<System.Boolean> get_Cancel(this IObservable<System.ConsoleCancelEventArgs> ConsoleCancelEventArgsValue)
{
    return Observable.Select(ConsoleCancelEventArgsValue, (ConsoleCancelEventArgsValueLambda) => ConsoleCancelEventArgsValueLambda.Cancel);
}


public static IObservable<System.ConsoleSpecialKey> get_SpecialKey(this IObservable<System.ConsoleCancelEventArgs> ConsoleCancelEventArgsValue)
{
    return Observable.Select(ConsoleCancelEventArgsValue, (ConsoleCancelEventArgsValueLambda) => ConsoleCancelEventArgsValueLambda.SpecialKey);
}


public static IObservable<System.Reactive.Unit> set_Cancel(this IObservable<System.ConsoleCancelEventArgs> ConsoleCancelEventArgsValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(ConsoleCancelEventArgsValue, value, (ConsoleCancelEventArgsValueLambda, valueLambda) => ConsoleCancelEventArgsValueLambda.Cancel = valueLambda);
}

}
}