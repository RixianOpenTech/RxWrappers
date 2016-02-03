using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapHexBinary
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary> SoapHexBinaryValue)
{
    return Observable.Select(SoapHexBinaryValue, (SoapHexBinaryValueLambda) => SoapHexBinaryValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary> SoapHexBinaryValue)
{
    return Observable.Select(SoapHexBinaryValue, (SoapHexBinaryValueLambda) => SoapHexBinaryValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary.XsdType);
}


public static IObservable<System.Byte[]> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary> SoapHexBinaryValue)
{
    return Observable.Select(SoapHexBinaryValue, (SoapHexBinaryValueLambda) => SoapHexBinaryValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary> SoapHexBinaryValue, IObservable<System.Byte[]> value)
{
    return ObservableExt.ZipExecute(SoapHexBinaryValue, value, (SoapHexBinaryValueLambda, valueLambda) => SoapHexBinaryValueLambda.Value = valueLambda);
}

}
}