using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _TypedReference
{
    
public static IObservable<System.TypedReference> MakeTypedReference(IObservable<System.Object> target, IObservable<System.Reflection.FieldInfo[]> flds)
{
    return Observable.Zip(target, flds, (targetLambda, fldsLambda) => System.TypedReference.MakeTypedReference(targetLambda, fldsLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.TypedReference> TypedReferenceValue)
{
    return Observable.Select(TypedReferenceValue, (TypedReferenceValueLambda) => TypedReferenceValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.TypedReference> TypedReferenceValue, IObservable<System.Object> o)
{
    return Observable.Zip(TypedReferenceValue, o, (TypedReferenceValueLambda, oLambda) => TypedReferenceValueLambda.Equals(oLambda));
}


public static IObservable<System.Object> ToObject(IObservable<System.TypedReference> value)
{
    return Observable.Select(value, (valueLambda) => System.TypedReference.ToObject(valueLambda));
}


public static IObservable<System.Type> GetTargetType(IObservable<System.TypedReference> value)
{
    return Observable.Select(value, (valueLambda) => System.TypedReference.GetTargetType(valueLambda));
}


public static IObservable<System.RuntimeTypeHandle> TargetTypeToken(IObservable<System.TypedReference> value)
{
    return Observable.Select(value, (valueLambda) => System.TypedReference.TargetTypeToken(valueLambda));
}


public static IObservable<System.Reactive.Unit> SetTypedReference(IObservable<System.TypedReference> target, IObservable<System.Object> value)
{
    return ObservableExt.ZipExecute(target, value, (targetLambda, valueLambda) => System.TypedReference.SetTypedReference(targetLambda, valueLambda));
}

}
}