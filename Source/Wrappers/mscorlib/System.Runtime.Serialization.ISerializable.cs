using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
public static class _ISerializable
{
    
public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Runtime.Serialization.ISerializable> ISerializableValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(ISerializableValue, info, context, (ISerializableValueLambda, infoLambda, contextLambda) => ISerializableValueLambda.GetObjectData(infoLambda, contextLambda));
}

}
}