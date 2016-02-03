using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapId
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId> SoapIdValue)
{
    return Observable.Select(SoapIdValue, (SoapIdValueLambda) => SoapIdValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId> SoapIdValue)
{
    return Observable.Select(SoapIdValue, (SoapIdValueLambda) => SoapIdValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId.XsdType);
}


public static IObservable<System.String> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId> SoapIdValue)
{
    return Observable.Select(SoapIdValue, (SoapIdValueLambda) => SoapIdValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId> SoapIdValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapIdValue, value, (SoapIdValueLambda, valueLambda) => SoapIdValueLambda.Value = valueLambda);
}

}
}