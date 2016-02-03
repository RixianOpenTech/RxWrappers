using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _ReflectionTypeLoadException
{
    
public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Reflection.ReflectionTypeLoadException> ReflectionTypeLoadExceptionValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(ReflectionTypeLoadExceptionValue, info, context, (ReflectionTypeLoadExceptionValueLambda, infoLambda, contextLambda) => ReflectionTypeLoadExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.Type[]> get_Types(this IObservable<System.Reflection.ReflectionTypeLoadException> ReflectionTypeLoadExceptionValue)
{
    return Observable.Select(ReflectionTypeLoadExceptionValue, (ReflectionTypeLoadExceptionValueLambda) => ReflectionTypeLoadExceptionValueLambda.Types);
}


public static IObservable<System.Exception[]> get_LoaderExceptions(this IObservable<System.Reflection.ReflectionTypeLoadException> ReflectionTypeLoadExceptionValue)
{
    return Observable.Select(ReflectionTypeLoadExceptionValue, (ReflectionTypeLoadExceptionValueLambda) => ReflectionTypeLoadExceptionValueLambda.LoaderExceptions);
}

}
}