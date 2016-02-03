using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapNormalizedString
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString> SoapNormalizedStringValue)
{
    return Observable.Select(SoapNormalizedStringValue, (SoapNormalizedStringValueLambda) => SoapNormalizedStringValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString> SoapNormalizedStringValue)
{
    return Observable.Select(SoapNormalizedStringValue, (SoapNormalizedStringValueLambda) => SoapNormalizedStringValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString.XsdType);
}


public static IObservable<System.String> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString> SoapNormalizedStringValue)
{
    return Observable.Select(SoapNormalizedStringValue, (SoapNormalizedStringValueLambda) => SoapNormalizedStringValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString> SoapNormalizedStringValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapNormalizedStringValue, value, (SoapNormalizedStringValueLambda, valueLambda) => SoapNormalizedStringValueLambda.Value = valueLambda);
}

}
}