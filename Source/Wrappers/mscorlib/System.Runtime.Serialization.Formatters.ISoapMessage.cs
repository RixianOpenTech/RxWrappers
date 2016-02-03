using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization.Formatters
{
public static class _ISoapMessage
{
    
public static IObservable<System.String[]> get_ParamNames(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue)
{
    return Observable.Select(ISoapMessageValue, (ISoapMessageValueLambda) => ISoapMessageValueLambda.ParamNames);
}


public static IObservable<System.Object[]> get_ParamValues(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue)
{
    return Observable.Select(ISoapMessageValue, (ISoapMessageValueLambda) => ISoapMessageValueLambda.ParamValues);
}


public static IObservable<System.Type[]> get_ParamTypes(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue)
{
    return Observable.Select(ISoapMessageValue, (ISoapMessageValueLambda) => ISoapMessageValueLambda.ParamTypes);
}


public static IObservable<System.String> get_MethodName(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue)
{
    return Observable.Select(ISoapMessageValue, (ISoapMessageValueLambda) => ISoapMessageValueLambda.MethodName);
}


public static IObservable<System.String> get_XmlNameSpace(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue)
{
    return Observable.Select(ISoapMessageValue, (ISoapMessageValueLambda) => ISoapMessageValueLambda.XmlNameSpace);
}


public static IObservable<System.Runtime.Remoting.Messaging.Header[]> get_Headers(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue)
{
    return Observable.Select(ISoapMessageValue, (ISoapMessageValueLambda) => ISoapMessageValueLambda.Headers);
}


public static IObservable<System.Reactive.Unit> set_ParamNames(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue, IObservable<System.String[]> value)
{
    return ObservableExt.ZipExecute(ISoapMessageValue, value, (ISoapMessageValueLambda, valueLambda) => ISoapMessageValueLambda.ParamNames = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ParamValues(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue, IObservable<System.Object[]> value)
{
    return ObservableExt.ZipExecute(ISoapMessageValue, value, (ISoapMessageValueLambda, valueLambda) => ISoapMessageValueLambda.ParamValues = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ParamTypes(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue, IObservable<System.Type[]> value)
{
    return ObservableExt.ZipExecute(ISoapMessageValue, value, (ISoapMessageValueLambda, valueLambda) => ISoapMessageValueLambda.ParamTypes = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_MethodName(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(ISoapMessageValue, value, (ISoapMessageValueLambda, valueLambda) => ISoapMessageValueLambda.MethodName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_XmlNameSpace(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(ISoapMessageValue, value, (ISoapMessageValueLambda, valueLambda) => ISoapMessageValueLambda.XmlNameSpace = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Headers(this IObservable<System.Runtime.Serialization.Formatters.ISoapMessage> ISoapMessageValue, IObservable<System.Runtime.Remoting.Messaging.Header[]> value)
{
    return ObservableExt.ZipExecute(ISoapMessageValue, value, (ISoapMessageValueLambda, valueLambda) => ISoapMessageValueLambda.Headers = valueLambda);
}

}
}