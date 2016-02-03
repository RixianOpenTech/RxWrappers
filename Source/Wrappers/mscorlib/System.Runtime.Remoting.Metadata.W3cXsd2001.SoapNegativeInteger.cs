using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapNegativeInteger
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger> SoapNegativeIntegerValue)
{
    return Observable.Select(SoapNegativeIntegerValue, (SoapNegativeIntegerValueLambda) => SoapNegativeIntegerValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger> SoapNegativeIntegerValue)
{
    return Observable.Select(SoapNegativeIntegerValue, (SoapNegativeIntegerValueLambda) => SoapNegativeIntegerValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger.XsdType);
}


public static IObservable<System.Decimal> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger> SoapNegativeIntegerValue)
{
    return Observable.Select(SoapNegativeIntegerValue, (SoapNegativeIntegerValueLambda) => SoapNegativeIntegerValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger> SoapNegativeIntegerValue, IObservable<System.Decimal> value)
{
    return ObservableExt.ZipExecute(SoapNegativeIntegerValue, value, (SoapNegativeIntegerValueLambda, valueLambda) => SoapNegativeIntegerValueLambda.Value = valueLambda);
}

}
}