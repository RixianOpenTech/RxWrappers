using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapNonPositiveInteger
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger> SoapNonPositiveIntegerValue)
{
    return Observable.Select(SoapNonPositiveIntegerValue, (SoapNonPositiveIntegerValueLambda) => SoapNonPositiveIntegerValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger> SoapNonPositiveIntegerValue)
{
    return Observable.Select(SoapNonPositiveIntegerValue, (SoapNonPositiveIntegerValueLambda) => SoapNonPositiveIntegerValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger.XsdType);
}


public static IObservable<System.Decimal> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger> SoapNonPositiveIntegerValue)
{
    return Observable.Select(SoapNonPositiveIntegerValue, (SoapNonPositiveIntegerValueLambda) => SoapNonPositiveIntegerValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger> SoapNonPositiveIntegerValue, IObservable<System.Decimal> value)
{
    return ObservableExt.ZipExecute(SoapNonPositiveIntegerValue, value, (SoapNonPositiveIntegerValueLambda, valueLambda) => SoapNonPositiveIntegerValueLambda.Value = valueLambda);
}

}
}