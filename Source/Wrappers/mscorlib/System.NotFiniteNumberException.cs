using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _NotFiniteNumberException
{
    
public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.NotFiniteNumberException> NotFiniteNumberExceptionValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(NotFiniteNumberExceptionValue, info, context, (NotFiniteNumberExceptionValueLambda, infoLambda, contextLambda) => NotFiniteNumberExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.Double> get_OffendingNumber(this IObservable<System.NotFiniteNumberException> NotFiniteNumberExceptionValue)
{
    return Observable.Select(NotFiniteNumberExceptionValue, (NotFiniteNumberExceptionValueLambda) => NotFiniteNumberExceptionValueLambda.OffendingNumber);
}

}
}