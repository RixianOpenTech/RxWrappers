using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Tracing
{
public static class _EventSourceOptions
{
    
public static IObservable<System.Diagnostics.Tracing.EventLevel> get_Level(this IObservable<System.Diagnostics.Tracing.EventSourceOptions> EventSourceOptionsValue)
{
    return Observable.Select(EventSourceOptionsValue, (EventSourceOptionsValueLambda) => EventSourceOptionsValueLambda.Level);
}


public static IObservable<System.Diagnostics.Tracing.EventOpcode> get_Opcode(this IObservable<System.Diagnostics.Tracing.EventSourceOptions> EventSourceOptionsValue)
{
    return Observable.Select(EventSourceOptionsValue, (EventSourceOptionsValueLambda) => EventSourceOptionsValueLambda.Opcode);
}


public static IObservable<System.Diagnostics.Tracing.EventKeywords> get_Keywords(this IObservable<System.Diagnostics.Tracing.EventSourceOptions> EventSourceOptionsValue)
{
    return Observable.Select(EventSourceOptionsValue, (EventSourceOptionsValueLambda) => EventSourceOptionsValueLambda.Keywords);
}


public static IObservable<System.Diagnostics.Tracing.EventTags> get_Tags(this IObservable<System.Diagnostics.Tracing.EventSourceOptions> EventSourceOptionsValue)
{
    return Observable.Select(EventSourceOptionsValue, (EventSourceOptionsValueLambda) => EventSourceOptionsValueLambda.Tags);
}


public static IObservable<System.Diagnostics.Tracing.EventActivityOptions> get_ActivityOptions(this IObservable<System.Diagnostics.Tracing.EventSourceOptions> EventSourceOptionsValue)
{
    return Observable.Select(EventSourceOptionsValue, (EventSourceOptionsValueLambda) => EventSourceOptionsValueLambda.ActivityOptions);
}


public static IObservable<System.Reactive.Unit> set_Level(this IObservable<System.Diagnostics.Tracing.EventSourceOptions> EventSourceOptionsValue, IObservable<System.Diagnostics.Tracing.EventLevel> value)
{
    return ObservableExt.ZipExecute(EventSourceOptionsValue, value, (EventSourceOptionsValueLambda, valueLambda) => EventSourceOptionsValueLambda.Level = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Opcode(this IObservable<System.Diagnostics.Tracing.EventSourceOptions> EventSourceOptionsValue, IObservable<System.Diagnostics.Tracing.EventOpcode> value)
{
    return ObservableExt.ZipExecute(EventSourceOptionsValue, value, (EventSourceOptionsValueLambda, valueLambda) => EventSourceOptionsValueLambda.Opcode = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Keywords(this IObservable<System.Diagnostics.Tracing.EventSourceOptions> EventSourceOptionsValue, IObservable<System.Diagnostics.Tracing.EventKeywords> value)
{
    return ObservableExt.ZipExecute(EventSourceOptionsValue, value, (EventSourceOptionsValueLambda, valueLambda) => EventSourceOptionsValueLambda.Keywords = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Tags(this IObservable<System.Diagnostics.Tracing.EventSourceOptions> EventSourceOptionsValue, IObservable<System.Diagnostics.Tracing.EventTags> value)
{
    return ObservableExt.ZipExecute(EventSourceOptionsValue, value, (EventSourceOptionsValueLambda, valueLambda) => EventSourceOptionsValueLambda.Tags = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ActivityOptions(this IObservable<System.Diagnostics.Tracing.EventSourceOptions> EventSourceOptionsValue, IObservable<System.Diagnostics.Tracing.EventActivityOptions> value)
{
    return ObservableExt.ZipExecute(EventSourceOptionsValue, value, (EventSourceOptionsValueLambda, valueLambda) => EventSourceOptionsValueLambda.ActivityOptions = valueLambda);
}

}
}