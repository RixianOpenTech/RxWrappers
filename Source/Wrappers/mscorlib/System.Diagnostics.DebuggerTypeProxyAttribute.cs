using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics
{
public static class _DebuggerTypeProxyAttribute
{
    
public static IObservable<System.String> get_ProxyTypeName(this IObservable<System.Diagnostics.DebuggerTypeProxyAttribute> DebuggerTypeProxyAttributeValue)
{
    return Observable.Select(DebuggerTypeProxyAttributeValue, (DebuggerTypeProxyAttributeValueLambda) => DebuggerTypeProxyAttributeValueLambda.ProxyTypeName);
}


public static IObservable<System.Type> get_Target(this IObservable<System.Diagnostics.DebuggerTypeProxyAttribute> DebuggerTypeProxyAttributeValue)
{
    return Observable.Select(DebuggerTypeProxyAttributeValue, (DebuggerTypeProxyAttributeValueLambda) => DebuggerTypeProxyAttributeValueLambda.Target);
}


public static IObservable<System.String> get_TargetTypeName(this IObservable<System.Diagnostics.DebuggerTypeProxyAttribute> DebuggerTypeProxyAttributeValue)
{
    return Observable.Select(DebuggerTypeProxyAttributeValue, (DebuggerTypeProxyAttributeValueLambda) => DebuggerTypeProxyAttributeValueLambda.TargetTypeName);
}


public static IObservable<System.Reactive.Unit> set_Target(this IObservable<System.Diagnostics.DebuggerTypeProxyAttribute> DebuggerTypeProxyAttributeValue, IObservable<System.Type> value)
{
    return ObservableExt.ZipExecute(DebuggerTypeProxyAttributeValue, value, (DebuggerTypeProxyAttributeValueLambda, valueLambda) => DebuggerTypeProxyAttributeValueLambda.Target = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_TargetTypeName(this IObservable<System.Diagnostics.DebuggerTypeProxyAttribute> DebuggerTypeProxyAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(DebuggerTypeProxyAttributeValue, value, (DebuggerTypeProxyAttributeValueLambda, valueLambda) => DebuggerTypeProxyAttributeValueLambda.TargetTypeName = valueLambda);
}

}
}