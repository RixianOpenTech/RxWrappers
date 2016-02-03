using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _DBNull
{
    
public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.DBNull> DBNullValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(DBNullValue, info, context, (DBNullValueLambda, infoLambda, contextLambda) => DBNullValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.DBNull> DBNullValue)
{
    return Observable.Select(DBNullValue, (DBNullValueLambda) => DBNullValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.DBNull> DBNullValue, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(DBNullValue, provider, (DBNullValueLambda, providerLambda) => DBNullValueLambda.ToString(providerLambda));
}


public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.DBNull> DBNullValue)
{
    return Observable.Select(DBNullValue, (DBNullValueLambda) => DBNullValueLambda.GetTypeCode());
}

}
}