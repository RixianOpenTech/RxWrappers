using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
public static class _ISafeSerializationData
{
    
public static IObservable<System.Reactive.Unit> CompleteDeserialization(this IObservable<System.Runtime.Serialization.ISafeSerializationData> ISafeSerializationDataValue, IObservable<System.Object> deserialized)
{
    return ObservableExt.ZipExecute(ISafeSerializationDataValue, deserialized, (ISafeSerializationDataValueLambda, deserializedLambda) => ISafeSerializationDataValueLambda.CompleteDeserialization(deserializedLambda));
}

}
}