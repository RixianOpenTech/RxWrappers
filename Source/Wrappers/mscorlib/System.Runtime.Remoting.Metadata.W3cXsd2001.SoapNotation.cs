using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapNotation
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation> SoapNotationValue)
{
    return Observable.Select(SoapNotationValue, (SoapNotationValueLambda) => SoapNotationValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation> SoapNotationValue)
{
    return Observable.Select(SoapNotationValue, (SoapNotationValueLambda) => SoapNotationValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation.XsdType);
}


public static IObservable<System.String> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation> SoapNotationValue)
{
    return Observable.Select(SoapNotationValue, (SoapNotationValueLambda) => SoapNotationValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation> SoapNotationValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapNotationValue, value, (SoapNotationValueLambda, valueLambda) => SoapNotationValueLambda.Value = valueLambda);
}

}
}