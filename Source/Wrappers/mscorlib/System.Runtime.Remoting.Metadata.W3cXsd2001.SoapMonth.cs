using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapMonth
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth> SoapMonthValue)
{
    return Observable.Select(SoapMonthValue, (SoapMonthValueLambda) => SoapMonthValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth> SoapMonthValue)
{
    return Observable.Select(SoapMonthValue, (SoapMonthValueLambda) => SoapMonthValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth.XsdType);
}


public static IObservable<System.DateTime> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth> SoapMonthValue)
{
    return Observable.Select(SoapMonthValue, (SoapMonthValueLambda) => SoapMonthValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth> SoapMonthValue, IObservable<System.DateTime> value)
{
    return ObservableExt.ZipExecute(SoapMonthValue, value, (SoapMonthValueLambda, valueLambda) => SoapMonthValueLambda.Value = valueLambda);
}

}
}