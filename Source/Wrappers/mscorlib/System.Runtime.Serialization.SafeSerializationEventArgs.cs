using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
public static class _SafeSerializationEventArgs
{
    
public static IObservable<System.Reactive.Unit> AddSerializedState(this IObservable<System.Runtime.Serialization.SafeSerializationEventArgs> SafeSerializationEventArgsValue, IObservable<System.Runtime.Serialization.ISafeSerializationData> serializedState)
{
    return ObservableExt.ZipExecute(SafeSerializationEventArgsValue, serializedState, (SafeSerializationEventArgsValueLambda, serializedStateLambda) => SafeSerializationEventArgsValueLambda.AddSerializedState(serializedStateLambda));
}


public static IObservable<System.Runtime.Serialization.StreamingContext> get_StreamingContext(this IObservable<System.Runtime.Serialization.SafeSerializationEventArgs> SafeSerializationEventArgsValue)
{
    return Observable.Select(SafeSerializationEventArgsValue, (SafeSerializationEventArgsValueLambda) => SafeSerializationEventArgsValueLambda.StreamingContext);
}

}
}