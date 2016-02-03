using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapDate
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate> SoapDateValue)
{
    return Observable.Select(SoapDateValue, (SoapDateValueLambda) => SoapDateValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate> SoapDateValue)
{
    return Observable.Select(SoapDateValue, (SoapDateValueLambda) => SoapDateValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate.XsdType);
}


public static IObservable<System.DateTime> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate> SoapDateValue)
{
    return Observable.Select(SoapDateValue, (SoapDateValueLambda) => SoapDateValueLambda.Value);
}


public static IObservable<System.Int32> get_Sign(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate> SoapDateValue)
{
    return Observable.Select(SoapDateValue, (SoapDateValueLambda) => SoapDateValueLambda.Sign);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate> SoapDateValue, IObservable<System.DateTime> value)
{
    return ObservableExt.ZipExecute(SoapDateValue, value, (SoapDateValueLambda, valueLambda) => SoapDateValueLambda.Value = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Sign(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate> SoapDateValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(SoapDateValue, value, (SoapDateValueLambda, valueLambda) => SoapDateValueLambda.Sign = valueLambda);
}

}
}