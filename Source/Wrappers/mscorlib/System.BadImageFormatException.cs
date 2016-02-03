using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _BadImageFormatException
{
    
public static IObservable<System.String> ToString(this IObservable<System.BadImageFormatException> BadImageFormatExceptionValue)
{
    return Observable.Select(BadImageFormatExceptionValue, (BadImageFormatExceptionValueLambda) => BadImageFormatExceptionValueLambda.ToString());
}


public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.BadImageFormatException> BadImageFormatExceptionValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(BadImageFormatExceptionValue, info, context, (BadImageFormatExceptionValueLambda, infoLambda, contextLambda) => BadImageFormatExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.String> get_Message(this IObservable<System.BadImageFormatException> BadImageFormatExceptionValue)
{
    return Observable.Select(BadImageFormatExceptionValue, (BadImageFormatExceptionValueLambda) => BadImageFormatExceptionValueLambda.Message);
}


public static IObservable<System.String> get_FileName(this IObservable<System.BadImageFormatException> BadImageFormatExceptionValue)
{
    return Observable.Select(BadImageFormatExceptionValue, (BadImageFormatExceptionValueLambda) => BadImageFormatExceptionValueLambda.FileName);
}


public static IObservable<System.String> get_FusionLog(this IObservable<System.BadImageFormatException> BadImageFormatExceptionValue)
{
    return Observable.Select(BadImageFormatExceptionValue, (BadImageFormatExceptionValueLambda) => BadImageFormatExceptionValueLambda.FusionLog);
}

}
}