using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _AssemblyName
{
    
public static IObservable<System.Object> Clone(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.Clone());
}


public static IObservable<System.Reflection.AssemblyName> GetAssemblyName(IObservable<System.String> assemblyFile)
{
    return Observable.Select(assemblyFile, (assemblyFileLambda) => System.Reflection.AssemblyName.GetAssemblyName(assemblyFileLambda));
}


public static IObservable<System.Byte[]> GetPublicKey(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.GetPublicKey());
}


public static IObservable<System.Reactive.Unit> SetPublicKey(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Byte[]> publicKey)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, publicKey, (AssemblyNameValueLambda, publicKeyLambda) => AssemblyNameValueLambda.SetPublicKey(publicKeyLambda));
}


public static IObservable<System.Byte[]> GetPublicKeyToken(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.GetPublicKeyToken());
}


public static IObservable<System.Reactive.Unit> SetPublicKeyToken(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Byte[]> publicKeyToken)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, publicKeyToken, (AssemblyNameValueLambda, publicKeyTokenLambda) => AssemblyNameValueLambda.SetPublicKeyToken(publicKeyTokenLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.ToString());
}


public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, info, context, (AssemblyNameValueLambda, infoLambda, contextLambda) => AssemblyNameValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.Reactive.Unit> OnDeserialization(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Object> sender)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, sender, (AssemblyNameValueLambda, senderLambda) => AssemblyNameValueLambda.OnDeserialization(senderLambda));
}


public static IObservable<System.Boolean> ReferenceMatchesDefinition(IObservable<System.Reflection.AssemblyName> reference, IObservable<System.Reflection.AssemblyName> definition)
{
    return Observable.Zip(reference, definition, (referenceLambda, definitionLambda) => System.Reflection.AssemblyName.ReferenceMatchesDefinition(referenceLambda, definitionLambda));
}


public static IObservable<System.String> get_Name(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.Name);
}


public static IObservable<System.Version> get_Version(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.Version);
}


public static IObservable<System.Globalization.CultureInfo> get_CultureInfo(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.CultureInfo);
}


public static IObservable<System.String> get_CultureName(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.CultureName);
}


public static IObservable<System.String> get_CodeBase(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.CodeBase);
}


public static IObservable<System.String> get_EscapedCodeBase(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.EscapedCodeBase);
}


public static IObservable<System.Reflection.ProcessorArchitecture> get_ProcessorArchitecture(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.ProcessorArchitecture);
}


public static IObservable<System.Reflection.AssemblyContentType> get_ContentType(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.ContentType);
}


public static IObservable<System.Reflection.AssemblyNameFlags> get_Flags(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.Flags);
}


public static IObservable<System.Configuration.Assemblies.AssemblyHashAlgorithm> get_HashAlgorithm(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.HashAlgorithm);
}


public static IObservable<System.Configuration.Assemblies.AssemblyVersionCompatibility> get_VersionCompatibility(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.VersionCompatibility);
}


public static IObservable<System.Reflection.StrongNameKeyPair> get_KeyPair(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.KeyPair);
}


public static IObservable<System.String> get_FullName(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue)
{
    return Observable.Select(AssemblyNameValue, (AssemblyNameValueLambda) => AssemblyNameValueLambda.FullName);
}


public static IObservable<System.Reactive.Unit> set_Name(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.Name = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Version(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Version> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.Version = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_CultureInfo(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Globalization.CultureInfo> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.CultureInfo = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_CultureName(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.CultureName = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_CodeBase(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.CodeBase = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ProcessorArchitecture(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Reflection.ProcessorArchitecture> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.ProcessorArchitecture = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ContentType(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Reflection.AssemblyContentType> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.ContentType = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Flags(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Reflection.AssemblyNameFlags> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.Flags = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_HashAlgorithm(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Configuration.Assemblies.AssemblyHashAlgorithm> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.HashAlgorithm = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_VersionCompatibility(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Configuration.Assemblies.AssemblyVersionCompatibility> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.VersionCompatibility = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_KeyPair(this IObservable<System.Reflection.AssemblyName> AssemblyNameValue, IObservable<System.Reflection.StrongNameKeyPair> value)
{
    return ObservableExt.ZipExecute(AssemblyNameValue, value, (AssemblyNameValueLambda, valueLambda) => AssemblyNameValueLambda.KeyPair = valueLambda);
}

}
}