using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
public static class _ISerializationSurrogate
{
    
public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Runtime.Serialization.ISerializationSurrogate> ISerializationSurrogateValue, IObservable<System.Object> obj, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(ISerializationSurrogateValue, obj, info, context, (ISerializationSurrogateValueLambda, objLambda, infoLambda, contextLambda) => ISerializationSurrogateValueLambda.GetObjectData(objLambda, infoLambda, contextLambda));
}


public static IObservable<System.Object> SetObjectData(this IObservable<System.Runtime.Serialization.ISerializationSurrogate> ISerializationSurrogateValue, IObservable<System.Object> obj, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context, IObservable<System.Runtime.Serialization.ISurrogateSelector> selector)
{
    return Observable.Zip(ISerializationSurrogateValue, obj, info, context, selector, (ISerializationSurrogateValueLambda, objLambda, infoLambda, contextLambda, selectorLambda) => ISerializationSurrogateValueLambda.SetObjectData(objLambda, infoLambda, contextLambda, selectorLambda));
}

}
}