using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
public static class _SoapBase64Binary
{
    
public static IObservable<System.String> GetXsdType(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary> SoapBase64BinaryValue)
{
    return Observable.Select(SoapBase64BinaryValue, (SoapBase64BinaryValueLambda) => SoapBase64BinaryValueLambda.GetXsdType());
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary> SoapBase64BinaryValue)
{
    return Observable.Select(SoapBase64BinaryValue, (SoapBase64BinaryValueLambda) => SoapBase64BinaryValueLambda.ToString());
}


public static IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary> Parse(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary.Parse(valueLambda));
}


public static IObservable<System.String> get_XsdType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary.XsdType);
}


public static IObservable<System.Byte[]> get_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary> SoapBase64BinaryValue)
{
    return Observable.Select(SoapBase64BinaryValue, (SoapBase64BinaryValueLambda) => SoapBase64BinaryValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary> SoapBase64BinaryValue, IObservable<System.Byte[]> value)
{
    return ObservableExt.ZipExecute(SoapBase64BinaryValue, value, (SoapBase64BinaryValueLambda, valueLambda) => SoapBase64BinaryValueLambda.Value = valueLambda);
}

}
}