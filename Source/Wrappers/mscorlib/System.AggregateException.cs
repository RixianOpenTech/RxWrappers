using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _AggregateException
{
    
public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.AggregateException> AggregateExceptionValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(AggregateExceptionValue, info, context, (AggregateExceptionValueLambda, infoLambda, contextLambda) => AggregateExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.Exception> GetBaseException(this IObservable<System.AggregateException> AggregateExceptionValue)
{
    return Observable.Select(AggregateExceptionValue, (AggregateExceptionValueLambda) => AggregateExceptionValueLambda.GetBaseException());
}


public static IObservable<System.Reactive.Unit> Handle(this IObservable<System.AggregateException> AggregateExceptionValue, IObservable<System.Func<System.Exception, System.Boolean>> predicate)
{
    return ObservableExt.ZipExecute(AggregateExceptionValue, predicate, (AggregateExceptionValueLambda, predicateLambda) => AggregateExceptionValueLambda.Handle(predicateLambda));
}


public static IObservable<System.AggregateException> Flatten(this IObservable<System.AggregateException> AggregateExceptionValue)
{
    return Observable.Select(AggregateExceptionValue, (AggregateExceptionValueLambda) => AggregateExceptionValueLambda.Flatten());
}


public static IObservable<System.String> ToString(this IObservable<System.AggregateException> AggregateExceptionValue)
{
    return Observable.Select(AggregateExceptionValue, (AggregateExceptionValueLambda) => AggregateExceptionValueLambda.ToString());
}


public static IObservable<System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>> get_InnerExceptions(this IObservable<System.AggregateException> AggregateExceptionValue)
{
    return Observable.Select(AggregateExceptionValue, (AggregateExceptionValueLambda) => AggregateExceptionValueLambda.InnerExceptions);
}

}
}