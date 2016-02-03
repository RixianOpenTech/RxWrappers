using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
public static class _SoapServices
{
    
public static IObservable<System.Reactive.Unit> RegisterInteropXmlElement(IObservable<System.String> xmlElement, IObservable<System.String> xmlNamespace, IObservable<System.Type> type)
{
    return ObservableExt.ZipExecute(xmlElement, xmlNamespace, type, (xmlElementLambda, xmlNamespaceLambda, typeLambda) => System.Runtime.Remoting.SoapServices.RegisterInteropXmlElement(xmlElementLambda, xmlNamespaceLambda, typeLambda));
}


public static IObservable<System.Reactive.Unit> RegisterInteropXmlType(IObservable<System.String> xmlType, IObservable<System.String> xmlTypeNamespace, IObservable<System.Type> type)
{
    return ObservableExt.ZipExecute(xmlType, xmlTypeNamespace, type, (xmlTypeLambda, xmlTypeNamespaceLambda, typeLambda) => System.Runtime.Remoting.SoapServices.RegisterInteropXmlType(xmlTypeLambda, xmlTypeNamespaceLambda, typeLambda));
}


public static IObservable<System.Reactive.Unit> PreLoad(IObservable<System.Type> type)
{
    return Observable.Do(type, (typeLambda) => System.Runtime.Remoting.SoapServices.PreLoad(typeLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> PreLoad(IObservable<System.Reflection.Assembly> assembly)
{
    return Observable.Do(assembly, (assemblyLambda) => System.Runtime.Remoting.SoapServices.PreLoad(assemblyLambda)).ToUnit();
}


public static IObservable<System.Type> GetInteropTypeFromXmlElement(IObservable<System.String> xmlElement, IObservable<System.String> xmlNamespace)
{
    return Observable.Zip(xmlElement, xmlNamespace, (xmlElementLambda, xmlNamespaceLambda) => System.Runtime.Remoting.SoapServices.GetInteropTypeFromXmlElement(xmlElementLambda, xmlNamespaceLambda));
}


public static IObservable<System.Type> GetInteropTypeFromXmlType(IObservable<System.String> xmlType, IObservable<System.String> xmlTypeNamespace)
{
    return Observable.Zip(xmlType, xmlTypeNamespace, (xmlTypeLambda, xmlTypeNamespaceLambda) => System.Runtime.Remoting.SoapServices.GetInteropTypeFromXmlType(xmlTypeLambda, xmlTypeNamespaceLambda));
}


public static IObservable<Tuple<System.Type, System.String>> GetInteropFieldTypeAndNameFromXmlElement(IObservable<System.Type> containingType, IObservable<System.String> xmlElement, IObservable<System.String> xmlNamespace)
{
    return Observable.Zip(containingType, xmlElement, xmlNamespace, (containingTypeLambda, xmlElementLambda, xmlNamespaceLambda) => {
System.Type typeOutput = default(System.Type);
System.String nameOutput = default(System.String);
System.Runtime.Remoting.SoapServices.GetInteropFieldTypeAndNameFromXmlElement(containingTypeLambda, xmlElementLambda, xmlNamespaceLambda, out typeOutput, out nameOutput);
return Tuple.Create(typeOutput, nameOutput);
});
}


public static IObservable<Tuple<System.Type, System.String>> GetInteropFieldTypeAndNameFromXmlAttribute(IObservable<System.Type> containingType, IObservable<System.String> xmlAttribute, IObservable<System.String> xmlNamespace)
{
    return Observable.Zip(containingType, xmlAttribute, xmlNamespace, (containingTypeLambda, xmlAttributeLambda, xmlNamespaceLambda) => {
System.Type typeOutput = default(System.Type);
System.String nameOutput = default(System.String);
System.Runtime.Remoting.SoapServices.GetInteropFieldTypeAndNameFromXmlAttribute(containingTypeLambda, xmlAttributeLambda, xmlNamespaceLambda, out typeOutput, out nameOutput);
return Tuple.Create(typeOutput, nameOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.String, System.String>> GetXmlElementForInteropType(IObservable<System.Type> type)
{
    return Observable.Select(type, (typeLambda) => {
System.String xmlElementOutput = default(System.String);
System.String xmlNamespaceOutput = default(System.String);
var result = System.Runtime.Remoting.SoapServices.GetXmlElementForInteropType(typeLambda, out xmlElementOutput, out xmlNamespaceOutput);
return Tuple.Create(result, xmlElementOutput, xmlNamespaceOutput);
});
}


public static IObservable<Tuple<System.Boolean, System.String, System.String>> GetXmlTypeForInteropType(IObservable<System.Type> type)
{
    return Observable.Select(type, (typeLambda) => {
System.String xmlTypeOutput = default(System.String);
System.String xmlTypeNamespaceOutput = default(System.String);
var result = System.Runtime.Remoting.SoapServices.GetXmlTypeForInteropType(typeLambda, out xmlTypeOutput, out xmlTypeNamespaceOutput);
return Tuple.Create(result, xmlTypeOutput, xmlTypeNamespaceOutput);
});
}


public static IObservable<System.String> GetXmlNamespaceForMethodCall(IObservable<System.Reflection.MethodBase> mb)
{
    return Observable.Select(mb, (mbLambda) => System.Runtime.Remoting.SoapServices.GetXmlNamespaceForMethodCall(mbLambda));
}


public static IObservable<System.String> GetXmlNamespaceForMethodResponse(IObservable<System.Reflection.MethodBase> mb)
{
    return Observable.Select(mb, (mbLambda) => System.Runtime.Remoting.SoapServices.GetXmlNamespaceForMethodResponse(mbLambda));
}


public static IObservable<System.Reactive.Unit> RegisterSoapActionForMethodBase(IObservable<System.Reflection.MethodBase> mb)
{
    return Observable.Do(mb, (mbLambda) => System.Runtime.Remoting.SoapServices.RegisterSoapActionForMethodBase(mbLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> RegisterSoapActionForMethodBase(IObservable<System.Reflection.MethodBase> mb, IObservable<System.String> soapAction)
{
    return ObservableExt.ZipExecute(mb, soapAction, (mbLambda, soapActionLambda) => System.Runtime.Remoting.SoapServices.RegisterSoapActionForMethodBase(mbLambda, soapActionLambda));
}


public static IObservable<System.String> GetSoapActionFromMethodBase(IObservable<System.Reflection.MethodBase> mb)
{
    return Observable.Select(mb, (mbLambda) => System.Runtime.Remoting.SoapServices.GetSoapActionFromMethodBase(mbLambda));
}


public static IObservable<System.Boolean> IsSoapActionValidForMethodBase(IObservable<System.String> soapAction, IObservable<System.Reflection.MethodBase> mb)
{
    return Observable.Zip(soapAction, mb, (soapActionLambda, mbLambda) => System.Runtime.Remoting.SoapServices.IsSoapActionValidForMethodBase(soapActionLambda, mbLambda));
}


public static IObservable<Tuple<System.Boolean, System.String, System.String>> GetTypeAndMethodNameFromSoapAction(IObservable<System.String> soapAction)
{
    return Observable.Select(soapAction, (soapActionLambda) => {
System.String typeNameOutput = default(System.String);
System.String methodNameOutput = default(System.String);
var result = System.Runtime.Remoting.SoapServices.GetTypeAndMethodNameFromSoapAction(soapActionLambda, out typeNameOutput, out methodNameOutput);
return Tuple.Create(result, typeNameOutput, methodNameOutput);
});
}


public static IObservable<System.Boolean> IsClrTypeNamespace(IObservable<System.String> namespaceString)
{
    return Observable.Select(namespaceString, (namespaceStringLambda) => System.Runtime.Remoting.SoapServices.IsClrTypeNamespace(namespaceStringLambda));
}


public static IObservable<System.String> CodeXmlNamespaceForClrTypeNamespace(IObservable<System.String> typeNamespace, IObservable<System.String> assemblyName)
{
    return Observable.Zip(typeNamespace, assemblyName, (typeNamespaceLambda, assemblyNameLambda) => System.Runtime.Remoting.SoapServices.CodeXmlNamespaceForClrTypeNamespace(typeNamespaceLambda, assemblyNameLambda));
}


public static IObservable<Tuple<System.Boolean, System.String, System.String>> DecodeXmlNamespaceForClrTypeNamespace(IObservable<System.String> inNamespace)
{
    return Observable.Select(inNamespace, (inNamespaceLambda) => {
System.String typeNamespaceOutput = default(System.String);
System.String assemblyNameOutput = default(System.String);
var result = System.Runtime.Remoting.SoapServices.DecodeXmlNamespaceForClrTypeNamespace(inNamespaceLambda, out typeNamespaceOutput, out assemblyNameOutput);
return Tuple.Create(result, typeNamespaceOutput, assemblyNameOutput);
});
}


public static IObservable<System.String> get_XmlNsForClrType()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.SoapServices.XmlNsForClrType);
}


public static IObservable<System.String> get_XmlNsForClrTypeWithAssembly()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.SoapServices.XmlNsForClrTypeWithAssembly);
}


public static IObservable<System.String> get_XmlNsForClrTypeWithNs()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.SoapServices.XmlNsForClrTypeWithNs);
}


public static IObservable<System.String> get_XmlNsForClrTypeWithNsAndAssembly()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.SoapServices.XmlNsForClrTypeWithNsAndAssembly);
}

}
}