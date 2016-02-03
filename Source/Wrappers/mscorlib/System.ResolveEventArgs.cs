using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _ResolveEventArgs
{
    
public static IObservable<System.String> get_Name(this IObservable<System.ResolveEventArgs> ResolveEventArgsValue)
{
    return Observable.Select(ResolveEventArgsValue, (ResolveEventArgsValueLambda) => ResolveEventArgsValueLambda.Name);
}


public static IObservable<System.Reflection.Assembly> get_RequestingAssembly(this IObservable<System.ResolveEventArgs> ResolveEventArgsValue)
{
    return Observable.Select(ResolveEventArgsValue, (ResolveEventArgsValueLambda) => ResolveEventArgsValueLambda.RequestingAssembly);
}

}
}