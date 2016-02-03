using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Metadata
{
public static class _SoapTypeAttribute
{
    
public static IObservable<System.Runtime.Remoting.Metadata.SoapOption> get_SoapOptions(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue)
{
    return Observable.Select(SoapTypeAttributeValue, (SoapTypeAttributeValueLambda) => SoapTypeAttributeValueLambda.SoapOptions);
}


public static IObservable<System.String> get_XmlElementName(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue)
{
    return Observable.Select(SoapTypeAttributeValue, (SoapTypeAttributeValueLambda) => SoapTypeAttributeValueLambda.XmlElementName);
}


public static IObservable<System.String> get_XmlNamespace(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue)
{
    return Observable.Select(SoapTypeAttributeValue, (SoapTypeAttributeValueLambda) => SoapTypeAttributeValueLambda.XmlNamespace);
}


public static IObservable<System.String> get_XmlTypeName(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue)
{
    return Observable.Select(SoapTypeAttributeValue, (SoapTypeAttributeValueLambda) => SoapTypeAttributeValueLambda.XmlTypeName);
}


public static IObservable<System.String> get_XmlTypeNamespace(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue)
{
    return Observable.Select(SoapTypeAttributeValue, (SoapTypeAttributeValueLambda) => SoapTypeAttributeValueLambda.XmlTypeNamespace);
}


public static IObservable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> get_XmlFieldOrder(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue)
{
    return Observable.Select(SoapTypeAttributeValue, (SoapTypeAttributeValueLambda) => SoapTypeAttributeValueLambda.XmlFieldOrder);
}


public static IObservable<System.Boolean> get_UseAttribute(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue)
{
    return Observable.Select(SoapTypeAttributeValue, (SoapTypeAttributeValueLambda) => SoapTypeAttributeValueLambda.UseAttribute);
}


public static IObservable<System.Reactive.Unit> set_SoapOptions(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue, IObservable<System.Runtime.Remoting.Metadata.SoapOption> value)
{
    return ObservableExt.ZipExecute(SoapTypeAttributeValue, value, (SoapTypeAttributeValueLambda, valueLambda) => SoapTypeAttributeValueLambda.SoapOptions = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_XmlElementName(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapTypeAttributeValue, value, (SoapTypeAttributeValueLambda, valueLambda) => SoapTypeAttributeValueLambda.XmlElementName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_XmlNamespace(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapTypeAttributeValue, value, (SoapTypeAttributeValueLambda, valueLambda) => SoapTypeAttributeValueLambda.XmlNamespace = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_XmlTypeName(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapTypeAttributeValue, value, (SoapTypeAttributeValueLambda, valueLambda) => SoapTypeAttributeValueLambda.XmlTypeName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_XmlTypeNamespace(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SoapTypeAttributeValue, value, (SoapTypeAttributeValueLambda, valueLambda) => SoapTypeAttributeValueLambda.XmlTypeNamespace = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_XmlFieldOrder(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue, IObservable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> value)
{
    return ObservableExt.ZipExecute(SoapTypeAttributeValue, value, (SoapTypeAttributeValueLambda, valueLambda) => SoapTypeAttributeValueLambda.XmlFieldOrder = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_UseAttribute(this IObservable<System.Runtime.Remoting.Metadata.SoapTypeAttribute> SoapTypeAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(SoapTypeAttributeValue, value, (SoapTypeAttributeValueLambda, valueLambda) => SoapTypeAttributeValueLambda.UseAttribute = valueLambda);
}

}
}