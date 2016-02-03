using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _TypeLoadException
{
    
public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.TypeLoadException> TypeLoadExceptionValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(TypeLoadExceptionValue, info, context, (TypeLoadExceptionValueLambda, infoLambda, contextLambda) => TypeLoadExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.String> get_Message(this IObservable<System.TypeLoadException> TypeLoadExceptionValue)
{
    return Observable.Select(TypeLoadExceptionValue, (TypeLoadExceptionValueLambda) => TypeLoadExceptionValueLambda.Message);
}


public static IObservable<System.String> get_TypeName(this IObservable<System.TypeLoadException> TypeLoadExceptionValue)
{
    return Observable.Select(TypeLoadExceptionValue, (TypeLoadExceptionValueLambda) => TypeLoadExceptionValueLambda.TypeName);
}

}
}