using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization.Formatters
{
public static class _ServerFault
{
    
public static IObservable<System.String> get_ExceptionType(this IObservable<System.Runtime.Serialization.Formatters.ServerFault> ServerFaultValue)
{
    return Observable.Select(ServerFaultValue, (ServerFaultValueLambda) => ServerFaultValueLambda.ExceptionType);
}


public static IObservable<System.String> get_ExceptionMessage(this IObservable<System.Runtime.Serialization.Formatters.ServerFault> ServerFaultValue)
{
    return Observable.Select(ServerFaultValue, (ServerFaultValueLambda) => ServerFaultValueLambda.ExceptionMessage);
}


public static IObservable<System.String> get_StackTrace(this IObservable<System.Runtime.Serialization.Formatters.ServerFault> ServerFaultValue)
{
    return Observable.Select(ServerFaultValue, (ServerFaultValueLambda) => ServerFaultValueLambda.StackTrace);
}


public static IObservable<System.Reactive.Unit> set_ExceptionType(this IObservable<System.Runtime.Serialization.Formatters.ServerFault> ServerFaultValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(ServerFaultValue, value, (ServerFaultValueLambda, valueLambda) => ServerFaultValueLambda.ExceptionType = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ExceptionMessage(this IObservable<System.Runtime.Serialization.Formatters.ServerFault> ServerFaultValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(ServerFaultValue, value, (ServerFaultValueLambda, valueLambda) => ServerFaultValueLambda.ExceptionMessage = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_StackTrace(this IObservable<System.Runtime.Serialization.Formatters.ServerFault> ServerFaultValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(ServerFaultValue, value, (ServerFaultValueLambda, valueLambda) => ServerFaultValueLambda.StackTrace = valueLambda);
}

}
}