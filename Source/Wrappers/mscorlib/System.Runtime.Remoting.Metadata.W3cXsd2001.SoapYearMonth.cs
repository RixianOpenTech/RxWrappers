using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapYearMonth
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth> SoapYearMonthValue)
{
    return Observable.Select(SoapYearMonthValue, (SoapYearMonthValueLambda) => SoapYearMonthValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth> SoapYearMonthValue)
{
    return Observable.Select(SoapYearMonthValue, (SoapYearMonthValueLambda) => SoapYearMonthValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth.XsdType);
}


public static IObservable<System.DateTime> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth> SoapYearMonthValue)
{
    return Observable.Select(SoapYearMonthValue, (SoapYearMonthValueLambda) => SoapYearMonthValueLambda.Value);
}


public static IObservable<System.Int32> get_Sign(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth> SoapYearMonthValue)
{
    return Observable.Select(SoapYearMonthValue, (SoapYearMonthValueLambda) => SoapYearMonthValueLambda.Sign);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth> SoapYearMonthValue, IObservable<System.DateTime> value)
{
    return ObservableExt.ZipExecute(SoapYearMonthValue, value, (SoapYearMonthValueLambda, valueLambda) => SoapYearMonthValueLambda.Value = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Sign(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth> SoapYearMonthValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(SoapYearMonthValue, value, (SoapYearMonthValueLambda, valueLambda) => SoapYearMonthValueLambda.Sign = valueLambda);
}

}
}