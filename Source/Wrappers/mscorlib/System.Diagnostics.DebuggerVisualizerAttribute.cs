using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics
{
public static class _DebuggerVisualizerAttribute
{
    
public static IObservable<System.String> get_VisualizerObjectSourceTypeName(this IObservable<System.Diagnostics.DebuggerVisualizerAttribute> DebuggerVisualizerAttributeValue)
{
    return Observable.Select(DebuggerVisualizerAttributeValue, (DebuggerVisualizerAttributeValueLambda) => DebuggerVisualizerAttributeValueLambda.VisualizerObjectSourceTypeName);
}


public static IObservable<System.String> get_VisualizerTypeName(this IObservable<System.Diagnostics.DebuggerVisualizerAttribute> DebuggerVisualizerAttributeValue)
{
    return Observable.Select(DebuggerVisualizerAttributeValue, (DebuggerVisualizerAttributeValueLambda) => DebuggerVisualizerAttributeValueLambda.VisualizerTypeName);
}


public static IObservable<System.String> get_Description(this IObservable<System.Diagnostics.DebuggerVisualizerAttribute> DebuggerVisualizerAttributeValue)
{
    return Observable.Select(DebuggerVisualizerAttributeValue, (DebuggerVisualizerAttributeValueLambda) => DebuggerVisualizerAttributeValueLambda.Description);
}


public static IObservable<System.Type> get_Target(this IObservable<System.Diagnostics.DebuggerVisualizerAttribute> DebuggerVisualizerAttributeValue)
{
    return Observable.Select(DebuggerVisualizerAttributeValue, (DebuggerVisualizerAttributeValueLambda) => DebuggerVisualizerAttributeValueLambda.Target);
}


public static IObservable<System.String> get_TargetTypeName(this IObservable<System.Diagnostics.DebuggerVisualizerAttribute> DebuggerVisualizerAttributeValue)
{
    return Observable.Select(DebuggerVisualizerAttributeValue, (DebuggerVisualizerAttributeValueLambda) => DebuggerVisualizerAttributeValueLambda.TargetTypeName);
}


public static IObservable<System.Reactive.Unit> set_Description(this IObservable<System.Diagnostics.DebuggerVisualizerAttribute> DebuggerVisualizerAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(DebuggerVisualizerAttributeValue, value, (DebuggerVisualizerAttributeValueLambda, valueLambda) => DebuggerVisualizerAttributeValueLambda.Description = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Target(this IObservable<System.Diagnostics.DebuggerVisualizerAttribute> DebuggerVisualizerAttributeValue, IObservable<System.Type> value)
{
    return ObservableExt.ZipExecute(DebuggerVisualizerAttributeValue, value, (DebuggerVisualizerAttributeValueLambda, valueLambda) => DebuggerVisualizerAttributeValueLambda.Target = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_TargetTypeName(this IObservable<System.Diagnostics.DebuggerVisualizerAttribute> DebuggerVisualizerAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(DebuggerVisualizerAttributeValue, value, (DebuggerVisualizerAttributeValueLambda, valueLambda) => DebuggerVisualizerAttributeValueLambda.TargetTypeName = valueLambda);
}

}
}