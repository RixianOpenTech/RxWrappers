using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapIdref
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref> SoapIdrefValue)
{
    return Observable.Select(SoapIdrefValue, (SoapIdrefValueLambda) => SoapIdrefValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref> SoapIdrefValue)
{
    return Observable.Select(SoapIdrefValue, (SoapIdrefValueLambda) => SoapIdrefValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref.XsdType);
}


public static IObservable<System.String> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref> SoapIdrefValue)
{
    return Observable.Select(SoapIdrefValue, (SoapIdrefValueLambda) => SoapIdrefValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref> SoapIdrefValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapIdrefValue, value, (SoapIdrefValueLambda, valueLambda) => SoapIdrefValueLambda.Value = valueLambda);
}

}
}