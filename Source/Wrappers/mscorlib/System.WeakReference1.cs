using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _WeakReference1
{
    
public static IObservable<Tuple<System.Boolean, T>> TryGetTarget<T>(this IObservable<System.WeakReference<T>> WeakReferenceValue)
{
    return Observable.Select(WeakReferenceValue, (WeakReferenceValueLambda) => {
T targetOutput = default(T);
var result = WeakReferenceValueLambda.TryGetTarget(out targetOutput);
return Tuple.Create(result, targetOutput);
});
}


public static IObservable<System.Reactive.Unit> SetTarget<T>(this IObservable<System.WeakReference<T>> WeakReferenceValue, IObservable<T> target)
{
    return ObservableExt.ZipExecute(WeakReferenceValue, target, (WeakReferenceValueLambda, targetLambda) => WeakReferenceValueLambda.SetTarget(targetLambda));
}


public static IObservable<System.Reactive.Unit> GetObjectData<T>(this IObservable<System.WeakReference<T>> WeakReferenceValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(WeakReferenceValue, info, context, (WeakReferenceValueLambda, infoLambda, contextLambda) => WeakReferenceValueLambda.GetObjectData(infoLambda, contextLambda));
}

}
}