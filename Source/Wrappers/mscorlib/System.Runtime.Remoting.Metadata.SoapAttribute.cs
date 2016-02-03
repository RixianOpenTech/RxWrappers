using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata
{
public static class _SoapAttribute
{
    
public static IObservable<System.String> get_XmlNamespace(this IObservable<System.Runtime.Remoting.Metadata.SoapAttribute> SoapAttributeValue)
{
    return Observable.Select(SoapAttributeValue, (SoapAttributeValueLambda) => SoapAttributeValueLambda.XmlNamespace);
}


public static IObservable<System.Boolean> get_UseAttribute(this IObservable<System.Runtime.Remoting.Metadata.SoapAttribute> SoapAttributeValue)
{
    return Observable.Select(SoapAttributeValue, (SoapAttributeValueLambda) => SoapAttributeValueLambda.UseAttribute);
}


public static IObservable<System.Boolean> get_Embedded(this IObservable<System.Runtime.Remoting.Metadata.SoapAttribute> SoapAttributeValue)
{
    return Observable.Select(SoapAttributeValue, (SoapAttributeValueLambda) => SoapAttributeValueLambda.Embedded);
}


public static IObservable<System.Reactive.Unit> set_XmlNamespace(this IObservable<System.Runtime.Remoting.Metadata.SoapAttribute> SoapAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapAttributeValue, value, (SoapAttributeValueLambda, valueLambda) => SoapAttributeValueLambda.XmlNamespace = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_UseAttribute(this IObservable<System.Runtime.Remoting.Metadata.SoapAttribute> SoapAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(SoapAttributeValue, value, (SoapAttributeValueLambda, valueLambda) => SoapAttributeValueLambda.UseAttribute = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Embedded(this IObservable<System.Runtime.Remoting.Metadata.SoapAttribute> SoapAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(SoapAttributeValue, value, (SoapAttributeValueLambda, valueLambda) => SoapAttributeValueLambda.Embedded = valueLambda);
}

}
}