using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Tracing
{
public static class _EventSource
{
    
public static IObservable<System.Boolean> IsEnabled(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue)
{
    return Observable.Select(EventSourceValue, (EventSourceValueLambda) => EventSourceValueLambda.IsEnabled());
}


public static IObservable<System.Boolean> IsEnabled(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue, IObservable<System.Diagnostics.Tracing.EventLevel> level, IObservable<System.Diagnostics.Tracing.EventKeywords> keywords)
{
    return Observable.Zip(EventSourceValue, level, keywords, (EventSourceValueLambda, levelLambda, keywordsLambda) => EventSourceValueLambda.IsEnabled(levelLambda, keywordsLambda));
}


public static IObservable<System.Boolean> IsEnabled(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue, IObservable<System.Diagnostics.Tracing.EventLevel> level, IObservable<System.Diagnostics.Tracing.EventKeywords> keywords, IObservable<System.Diagnostics.Tracing.EventChannel> channel)
{
    return Observable.Zip(EventSourceValue, level, keywords, channel, (EventSourceValueLambda, levelLambda, keywordsLambda, channelLambda) => EventSourceValueLambda.IsEnabled(levelLambda, keywordsLambda, channelLambda));
}


public static IObservable<System.Guid> GetGuid(IObservable<System.Type> eventSourceType)
{
    return Observable.Select(eventSourceType, (eventSourceTypeLambda) => System.Diagnostics.Tracing.EventSource.GetGuid(eventSourceTypeLambda));
}


public static IObservable<System.String> GetName(IObservable<System.Type> eventSourceType)
{
    return Observable.Select(eventSourceType, (eventSourceTypeLambda) => System.Diagnostics.Tracing.EventSource.GetName(eventSourceTypeLambda));
}


public static IObservable<System.String> GenerateManifest(IObservable<System.Type> eventSourceType, IObservable<System.String> assemblyPathToIncludeInManifest)
{
    return Observable.Zip(eventSourceType, assemblyPathToIncludeInManifest, (eventSourceTypeLambda, assemblyPathToIncludeInManifestLambda) => System.Diagnostics.Tracing.EventSource.GenerateManifest(eventSourceTypeLambda, assemblyPathToIncludeInManifestLambda));
}


public static IObservable<System.String> GenerateManifest(IObservable<System.Type> eventSourceType, IObservable<System.String> assemblyPathToIncludeInManifest, IObservable<System.Diagnostics.Tracing.EventManifestOptions> flags)
{
    return Observable.Zip(eventSourceType, assemblyPathToIncludeInManifest, flags, (eventSourceTypeLambda, assemblyPathToIncludeInManifestLambda, flagsLambda) => System.Diagnostics.Tracing.EventSource.GenerateManifest(eventSourceTypeLambda, assemblyPathToIncludeInManifestLambda, flagsLambda));
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Diagnostics.Tracing.EventSource>> GetSources()
{
    return ObservableExt.Factory(() => System.Diagnostics.Tracing.EventSource.GetSources());
}


public static IObservable<System.Reactive.Unit> SendCommand(IObservable<System.Diagnostics.Tracing.EventSource> eventSource, IObservable<System.Diagnostics.Tracing.EventCommand> command, IObservable<System.Collections.Generic.IDictionary<System.String, System.String>> commandArguments)
{
    return ObservableExt.ZipExecute(eventSource, command, commandArguments, (eventSourceLambda, commandLambda, commandArgumentsLambda) => System.Diagnostics.Tracing.EventSource.SendCommand(eventSourceLambda, commandLambda, commandArgumentsLambda));
}


public static IObservable<System.Reactive.Unit> SetCurrentThreadActivityId(IObservable<System.Guid> activityId)
{
    return Observable.Do(activityId, (activityIdLambda) => System.Diagnostics.Tracing.EventSource.SetCurrentThreadActivityId(activityIdLambda)).ToUnit();
}


public static IObservable<System.Guid> SetCurrentThreadActivityId(IObservable<System.Guid> activityId)
{
    return Observable.Select(activityId, (activityIdLambda) => {
System.Guid oldActivityThatWillContinueOutput = default(System.Guid);
System.Diagnostics.Tracing.EventSource.SetCurrentThreadActivityId(activityIdLambda, out oldActivityThatWillContinueOutput);
return oldActivityThatWillContinueOutput;
});
}


public static IObservable<System.String> GetTrait(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue, IObservable<System.String> key)
{
    return Observable.Zip(EventSourceValue, key, (EventSourceValueLambda, keyLambda) => EventSourceValueLambda.GetTrait(keyLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue)
{
    return Observable.Select(EventSourceValue, (EventSourceValueLambda) => EventSourceValueLambda.ToString());
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue)
{
    return Observable.Do(EventSourceValue, (EventSourceValueLambda) => EventSourceValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue, IObservable<System.String> eventName)
{
    return ObservableExt.ZipExecute(EventSourceValue, eventName, (EventSourceValueLambda, eventNameLambda) => EventSourceValueLambda.Write(eventNameLambda));
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue, IObservable<System.String> eventName, IObservable<System.Diagnostics.Tracing.EventSourceOptions> options)
{
    return ObservableExt.ZipExecute(EventSourceValue, eventName, options, (EventSourceValueLambda, eventNameLambda, optionsLambda) => EventSourceValueLambda.Write(eventNameLambda, optionsLambda));
}


public static IObservable<System.Reactive.Unit> Write<T>(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue, IObservable<System.String> eventName, IObservable<T> data)
{
    return ObservableExt.ZipExecute(EventSourceValue, eventName, data, (EventSourceValueLambda, eventNameLambda, dataLambda) => EventSourceValueLambda.Write(eventNameLambda, dataLambda));
}


public static IObservable<System.Reactive.Unit> Write<T>(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue, IObservable<System.String> eventName, IObservable<System.Diagnostics.Tracing.EventSourceOptions> options, IObservable<T> data)
{
    return ObservableExt.ZipExecute(EventSourceValue, eventName, options, data, (EventSourceValueLambda, eventNameLambda, optionsLambda, dataLambda) => EventSourceValueLambda.Write(eventNameLambda, optionsLambda, dataLambda));
}


public static IObservable<Tuple<System.Diagnostics.Tracing.EventSourceOptions, T>> Write<T>(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue, IObservable<System.String> eventName, IObservable<System.Diagnostics.Tracing.EventSourceOptions> options, IObservable<T> data)
{
    return Observable.Zip(EventSourceValue, eventName, options, data, (EventSourceValueLambda, eventNameLambda, optionsLambda, dataLambda) => {
EventSourceValueLambda.Write(eventNameLambda, ref optionsLambda, ref dataLambda);
return Tuple.Create(optionsLambda, dataLambda);
});
}


public static IObservable<Tuple<System.Diagnostics.Tracing.EventSourceOptions, System.Guid, System.Guid, T>> Write<T>(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue, IObservable<System.String> eventName, IObservable<System.Diagnostics.Tracing.EventSourceOptions> options, IObservable<System.Guid> activityId, IObservable<System.Guid> relatedActivityId, IObservable<T> data)
{
    return Observable.Zip(EventSourceValue, eventName, options, activityId, relatedActivityId, data, (EventSourceValueLambda, eventNameLambda, optionsLambda, activityIdLambda, relatedActivityIdLambda, dataLambda) => {
EventSourceValueLambda.Write(eventNameLambda, ref optionsLambda, ref activityIdLambda, ref relatedActivityIdLambda, ref dataLambda);
return Tuple.Create(optionsLambda, activityIdLambda, relatedActivityIdLambda, dataLambda);
});
}


public static IObservable<System.String> get_Name(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue)
{
    return Observable.Select(EventSourceValue, (EventSourceValueLambda) => EventSourceValueLambda.Name);
}


public static IObservable<System.Guid> get_Guid(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue)
{
    return Observable.Select(EventSourceValue, (EventSourceValueLambda) => EventSourceValueLambda.Guid);
}


public static IObservable<System.Diagnostics.Tracing.EventSourceSettings> get_Settings(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue)
{
    return Observable.Select(EventSourceValue, (EventSourceValueLambda) => EventSourceValueLambda.Settings);
}


public static IObservable<System.Guid> get_CurrentThreadActivityId()
{
    return ObservableExt.Factory(() => System.Diagnostics.Tracing.EventSource.CurrentThreadActivityId);
}


public static IObservable<System.Exception> get_ConstructionException(this IObservable<System.Diagnostics.Tracing.EventSource> EventSourceValue)
{
    return Observable.Select(EventSourceValue, (EventSourceValueLambda) => EventSourceValueLambda.ConstructionException);
}

}
}