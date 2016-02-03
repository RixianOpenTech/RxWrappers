using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapTime
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapTime> SoapTimeValue)
{
    return Observable.Select(SoapTimeValue, (SoapTimeValueLambda) => SoapTimeValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapTime> SoapTimeValue)
{
    return Observable.Select(SoapTimeValue, (SoapTimeValueLambda) => SoapTimeValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapTime> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapTime.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapTime.XsdType);
}


public static IObservable<System.DateTime> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapTime> SoapTimeValue)
{
    return Observable.Select(SoapTimeValue, (SoapTimeValueLambda) => SoapTimeValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapTime> SoapTimeValue, IObservable<System.DateTime> value)
{
    return ObservableExt.ZipExecute(SoapTimeValue, value, (SoapTimeValueLambda, valueLambda) => SoapTimeValueLambda.Value = valueLambda);
}

}
}