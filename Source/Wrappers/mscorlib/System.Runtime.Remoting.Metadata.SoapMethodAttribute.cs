using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata
{
public static class _SoapMethodAttribute
{
    
public static IObservable<System.String> get_SoapAction(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue)
{
    return Observable.Select(SoapMethodAttributeValue, (SoapMethodAttributeValueLambda) => SoapMethodAttributeValueLambda.SoapAction);
}


public static IObservable<System.Boolean> get_UseAttribute(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue)
{
    return Observable.Select(SoapMethodAttributeValue, (SoapMethodAttributeValueLambda) => SoapMethodAttributeValueLambda.UseAttribute);
}


public static IObservable<System.String> get_XmlNamespace(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue)
{
    return Observable.Select(SoapMethodAttributeValue, (SoapMethodAttributeValueLambda) => SoapMethodAttributeValueLambda.XmlNamespace);
}


public static IObservable<System.String> get_ResponseXmlElementName(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue)
{
    return Observable.Select(SoapMethodAttributeValue, (SoapMethodAttributeValueLambda) => SoapMethodAttributeValueLambda.ResponseXmlElementName);
}


public static IObservable<System.String> get_ResponseXmlNamespace(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue)
{
    return Observable.Select(SoapMethodAttributeValue, (SoapMethodAttributeValueLambda) => SoapMethodAttributeValueLambda.ResponseXmlNamespace);
}


public static IObservable<System.String> get_ReturnXmlElementName(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue)
{
    return Observable.Select(SoapMethodAttributeValue, (SoapMethodAttributeValueLambda) => SoapMethodAttributeValueLambda.ReturnXmlElementName);
}


public static IObservable<System.Reactive.Unit> set_SoapAction(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapMethodAttributeValue, value, (SoapMethodAttributeValueLambda, valueLambda) => SoapMethodAttributeValueLambda.SoapAction = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_UseAttribute(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(SoapMethodAttributeValue, value, (SoapMethodAttributeValueLambda, valueLambda) => SoapMethodAttributeValueLambda.UseAttribute = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_XmlNamespace(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapMethodAttributeValue, value, (SoapMethodAttributeValueLambda, valueLambda) => SoapMethodAttributeValueLambda.XmlNamespace = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ResponseXmlElementName(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapMethodAttributeValue, value, (SoapMethodAttributeValueLambda, valueLambda) => SoapMethodAttributeValueLambda.ResponseXmlElementName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ResponseXmlNamespace(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapMethodAttributeValue, value, (SoapMethodAttributeValueLambda, valueLambda) => SoapMethodAttributeValueLambda.ResponseXmlNamespace = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ReturnXmlElementName(this IObservable<System.Runtime.Remoting.Metadata.SoapMethodAttribute> SoapMethodAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapMethodAttributeValue, value, (SoapMethodAttributeValueLambda, valueLambda) => SoapMethodAttributeValueLambda.ReturnXmlElementName = valueLambda);
}

}
}