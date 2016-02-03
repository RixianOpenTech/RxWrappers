using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata
{
public static class _SoapFieldAttribute
{
    
public static IObservable<System.Boolean> IsInteropXmlElement(this IObservable<System.Runtime.Remoting.Metadata.SoapFieldAttribute> SoapFieldAttributeValue)
{
    return Observable.Select(SoapFieldAttributeValue, (SoapFieldAttributeValueLambda) => SoapFieldAttributeValueLambda.IsInteropXmlElement());
}


public static IObservable<System.String> get_XmlElementName(this IObservable<System.Runtime.Remoting.Metadata.SoapFieldAttribute> SoapFieldAttributeValue)
{
    return Observable.Select(SoapFieldAttributeValue, (SoapFieldAttributeValueLambda) => SoapFieldAttributeValueLambda.XmlElementName);
}


public static IObservable<System.Int32> get_Order(this IObservable<System.Runtime.Remoting.Metadata.SoapFieldAttribute> SoapFieldAttributeValue)
{
    return Observable.Select(SoapFieldAttributeValue, (SoapFieldAttributeValueLambda) => SoapFieldAttributeValueLambda.Order);
}


public static IObservable<System.Reactive.Unit> set_XmlElementName(this IObservable<System.Runtime.Remoting.Metadata.SoapFieldAttribute> SoapFieldAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapFieldAttributeValue, value, (SoapFieldAttributeValueLambda, valueLambda) => SoapFieldAttributeValueLambda.XmlElementName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Order(this IObservable<System.Runtime.Remoting.Metadata.SoapFieldAttribute> SoapFieldAttributeValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(SoapFieldAttributeValue, value, (SoapFieldAttributeValueLambda, valueLambda) => SoapFieldAttributeValueLambda.Order = valueLambda);
}

}
}