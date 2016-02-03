using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _Assembly
{
    
public static IObservable<System.String> CreateQualifiedName(IObservable<System.String> assemblyName, IObservable<System.String> typeName)
{
    return Observable.Zip(assemblyName, typeName, (assemblyNameLambda, typeNameLambda) => System.Reflection.Assembly.CreateQualifiedName(assemblyNameLambda, typeNameLambda));
}


public static IObservable<System.Reflection.Assembly> GetAssembly(IObservable<System.Type> type)
{
    return Observable.Select(type, (typeLambda) => System.Reflection.Assembly.GetAssembly(typeLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Object> o)
{
    return Observable.Zip(AssemblyValue, o, (AssemblyValueLambda, oLambda) => AssemblyValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GetHashCode());
}


public static IObservable<System.Reflection.Assembly> LoadFrom(IObservable<System.String> assemblyFile)
{
    return Observable.Select(assemblyFile, (assemblyFileLambda) => System.Reflection.Assembly.LoadFrom(assemblyFileLambda));
}


public static IObservable<System.Reflection.Assembly> ReflectionOnlyLoadFrom(IObservable<System.String> assemblyFile)
{
    return Observable.Select(assemblyFile, (assemblyFileLambda) => System.Reflection.Assembly.ReflectionOnlyLoadFrom(assemblyFileLambda));
}


public static IObservable<System.Reflection.Assembly> LoadFrom(IObservable<System.String> assemblyFile, IObservable<System.Security.Policy.Evidence> securityEvidence)
{
    return Observable.Zip(assemblyFile, securityEvidence, (assemblyFileLambda, securityEvidenceLambda) => System.Reflection.Assembly.LoadFrom(assemblyFileLambda, securityEvidenceLambda));
}


public static IObservable<System.Reflection.Assembly> LoadFrom(IObservable<System.String> assemblyFile, IObservable<System.Security.Policy.Evidence> securityEvidence, IObservable<System.Byte[]> hashValue, IObservable<System.Configuration.Assemblies.AssemblyHashAlgorithm> hashAlgorithm)
{
    return Observable.Zip(assemblyFile, securityEvidence, hashValue, hashAlgorithm, (assemblyFileLambda, securityEvidenceLambda, hashValueLambda, hashAlgorithmLambda) => System.Reflection.Assembly.LoadFrom(assemblyFileLambda, securityEvidenceLambda, hashValueLambda, hashAlgorithmLambda));
}


public static IObservable<System.Reflection.Assembly> LoadFrom(IObservable<System.String> assemblyFile, IObservable<System.Byte[]> hashValue, IObservable<System.Configuration.Assemblies.AssemblyHashAlgorithm> hashAlgorithm)
{
    return Observable.Zip(assemblyFile, hashValue, hashAlgorithm, (assemblyFileLambda, hashValueLambda, hashAlgorithmLambda) => System.Reflection.Assembly.LoadFrom(assemblyFileLambda, hashValueLambda, hashAlgorithmLambda));
}


public static IObservable<System.Reflection.Assembly> UnsafeLoadFrom(IObservable<System.String> assemblyFile)
{
    return Observable.Select(assemblyFile, (assemblyFileLambda) => System.Reflection.Assembly.UnsafeLoadFrom(assemblyFileLambda));
}


public static IObservable<System.Reflection.Assembly> Load(IObservable<System.String> assemblyString)
{
    return Observable.Select(assemblyString, (assemblyStringLambda) => System.Reflection.Assembly.Load(assemblyStringLambda));
}


public static IObservable<System.Reflection.Assembly> ReflectionOnlyLoad(IObservable<System.String> assemblyString)
{
    return Observable.Select(assemblyString, (assemblyStringLambda) => System.Reflection.Assembly.ReflectionOnlyLoad(assemblyStringLambda));
}


public static IObservable<System.Reflection.Assembly> Load(IObservable<System.String> assemblyString, IObservable<System.Security.Policy.Evidence> assemblySecurity)
{
    return Observable.Zip(assemblyString, assemblySecurity, (assemblyStringLambda, assemblySecurityLambda) => System.Reflection.Assembly.Load(assemblyStringLambda, assemblySecurityLambda));
}


public static IObservable<System.Reflection.Assembly> Load(IObservable<System.Reflection.AssemblyName> assemblyRef)
{
    return Observable.Select(assemblyRef, (assemblyRefLambda) => System.Reflection.Assembly.Load(assemblyRefLambda));
}


public static IObservable<System.Reflection.Assembly> Load(IObservable<System.Reflection.AssemblyName> assemblyRef, IObservable<System.Security.Policy.Evidence> assemblySecurity)
{
    return Observable.Zip(assemblyRef, assemblySecurity, (assemblyRefLambda, assemblySecurityLambda) => System.Reflection.Assembly.Load(assemblyRefLambda, assemblySecurityLambda));
}


public static IObservable<System.Reflection.Assembly> LoadWithPartialName(IObservable<System.String> partialName)
{
    return Observable.Select(partialName, (partialNameLambda) => System.Reflection.Assembly.LoadWithPartialName(partialNameLambda));
}


public static IObservable<System.Reflection.Assembly> LoadWithPartialName(IObservable<System.String> partialName, IObservable<System.Security.Policy.Evidence> securityEvidence)
{
    return Observable.Zip(partialName, securityEvidence, (partialNameLambda, securityEvidenceLambda) => System.Reflection.Assembly.LoadWithPartialName(partialNameLambda, securityEvidenceLambda));
}


public static IObservable<System.Reflection.Assembly> Load(IObservable<System.Byte[]> rawAssembly)
{
    return Observable.Select(rawAssembly, (rawAssemblyLambda) => System.Reflection.Assembly.Load(rawAssemblyLambda));
}


public static IObservable<System.Reflection.Assembly> ReflectionOnlyLoad(IObservable<System.Byte[]> rawAssembly)
{
    return Observable.Select(rawAssembly, (rawAssemblyLambda) => System.Reflection.Assembly.ReflectionOnlyLoad(rawAssemblyLambda));
}


public static IObservable<System.Reflection.Assembly> Load(IObservable<System.Byte[]> rawAssembly, IObservable<System.Byte[]> rawSymbolStore)
{
    return Observable.Zip(rawAssembly, rawSymbolStore, (rawAssemblyLambda, rawSymbolStoreLambda) => System.Reflection.Assembly.Load(rawAssemblyLambda, rawSymbolStoreLambda));
}


public static IObservable<System.Reflection.Assembly> Load(IObservable<System.Byte[]> rawAssembly, IObservable<System.Byte[]> rawSymbolStore, IObservable<System.Security.SecurityContextSource> securityContextSource)
{
    return Observable.Zip(rawAssembly, rawSymbolStore, securityContextSource, (rawAssemblyLambda, rawSymbolStoreLambda, securityContextSourceLambda) => System.Reflection.Assembly.Load(rawAssemblyLambda, rawSymbolStoreLambda, securityContextSourceLambda));
}


public static IObservable<System.Reflection.Assembly> Load(IObservable<System.Byte[]> rawAssembly, IObservable<System.Byte[]> rawSymbolStore, IObservable<System.Security.Policy.Evidence> securityEvidence)
{
    return Observable.Zip(rawAssembly, rawSymbolStore, securityEvidence, (rawAssemblyLambda, rawSymbolStoreLambda, securityEvidenceLambda) => System.Reflection.Assembly.Load(rawAssemblyLambda, rawSymbolStoreLambda, securityEvidenceLambda));
}


public static IObservable<System.Reflection.Assembly> LoadFile(IObservable<System.String> path)
{
    return Observable.Select(path, (pathLambda) => System.Reflection.Assembly.LoadFile(pathLambda));
}


public static IObservable<System.Reflection.Assembly> LoadFile(IObservable<System.String> path, IObservable<System.Security.Policy.Evidence> securityEvidence)
{
    return Observable.Zip(path, securityEvidence, (pathLambda, securityEvidenceLambda) => System.Reflection.Assembly.LoadFile(pathLambda, securityEvidenceLambda));
}


public static IObservable<System.Reflection.Assembly> GetExecutingAssembly()
{
    return ObservableExt.Factory(() => System.Reflection.Assembly.GetExecutingAssembly());
}


public static IObservable<System.Reflection.Assembly> GetCallingAssembly()
{
    return ObservableExt.Factory(() => System.Reflection.Assembly.GetCallingAssembly());
}


public static IObservable<System.Reflection.Assembly> GetEntryAssembly()
{
    return ObservableExt.Factory(() => System.Reflection.Assembly.GetEntryAssembly());
}


public static IObservable<System.Reflection.AssemblyName> GetName(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GetName());
}


public static IObservable<System.Reflection.AssemblyName> GetName(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Boolean> copiedName)
{
    return Observable.Zip(AssemblyValue, copiedName, (AssemblyValueLambda, copiedNameLambda) => AssemblyValueLambda.GetName(copiedNameLambda));
}


public static IObservable<System.Type> GetType(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyValue, name, (AssemblyValueLambda, nameLambda) => AssemblyValueLambda.GetType(nameLambda));
}


public static IObservable<System.Type> GetType(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> name, IObservable<System.Boolean> throwOnError)
{
    return Observable.Zip(AssemblyValue, name, throwOnError, (AssemblyValueLambda, nameLambda, throwOnErrorLambda) => AssemblyValueLambda.GetType(nameLambda, throwOnErrorLambda));
}


public static IObservable<System.Type> GetType(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> name, IObservable<System.Boolean> throwOnError, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(AssemblyValue, name, throwOnError, ignoreCase, (AssemblyValueLambda, nameLambda, throwOnErrorLambda, ignoreCaseLambda) => AssemblyValueLambda.GetType(nameLambda, throwOnErrorLambda, ignoreCaseLambda));
}


public static IObservable<System.Type[]> GetExportedTypes(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GetExportedTypes());
}


public static IObservable<System.Type[]> GetTypes(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GetTypes());
}


public static IObservable<System.IO.Stream> GetManifestResourceStream(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Type> type, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyValue, type, name, (AssemblyValueLambda, typeLambda, nameLambda) => AssemblyValueLambda.GetManifestResourceStream(typeLambda, nameLambda));
}


public static IObservable<System.IO.Stream> GetManifestResourceStream(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyValue, name, (AssemblyValueLambda, nameLambda) => AssemblyValueLambda.GetManifestResourceStream(nameLambda));
}


public static IObservable<System.Reflection.Assembly> GetSatelliteAssembly(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(AssemblyValue, culture, (AssemblyValueLambda, cultureLambda) => AssemblyValueLambda.GetSatelliteAssembly(cultureLambda));
}


public static IObservable<System.Reflection.Assembly> GetSatelliteAssembly(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Version> version)
{
    return Observable.Zip(AssemblyValue, culture, version, (AssemblyValueLambda, cultureLambda, versionLambda) => AssemblyValueLambda.GetSatelliteAssembly(cultureLambda, versionLambda));
}


public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(AssemblyValue, info, context, (AssemblyValueLambda, infoLambda, contextLambda) => AssemblyValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(AssemblyValue, inherit, (AssemblyValueLambda, inheritLambda) => AssemblyValueLambda.GetCustomAttributes(inheritLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(AssemblyValue, attributeType, inherit, (AssemblyValueLambda, attributeTypeLambda, inheritLambda) => AssemblyValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(AssemblyValue, attributeType, inherit, (AssemblyValueLambda, attributeTypeLambda, inheritLambda) => AssemblyValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>> GetCustomAttributesData(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GetCustomAttributesData());
}


public static IObservable<System.Reflection.Module> LoadModule(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> moduleName, IObservable<System.Byte[]> rawModule)
{
    return Observable.Zip(AssemblyValue, moduleName, rawModule, (AssemblyValueLambda, moduleNameLambda, rawModuleLambda) => AssemblyValueLambda.LoadModule(moduleNameLambda, rawModuleLambda));
}


public static IObservable<System.Reflection.Module> LoadModule(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> moduleName, IObservable<System.Byte[]> rawModule, IObservable<System.Byte[]> rawSymbolStore)
{
    return Observable.Zip(AssemblyValue, moduleName, rawModule, rawSymbolStore, (AssemblyValueLambda, moduleNameLambda, rawModuleLambda, rawSymbolStoreLambda) => AssemblyValueLambda.LoadModule(moduleNameLambda, rawModuleLambda, rawSymbolStoreLambda));
}


public static IObservable<System.Object> CreateInstance(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> typeName)
{
    return Observable.Zip(AssemblyValue, typeName, (AssemblyValueLambda, typeNameLambda) => AssemblyValueLambda.CreateInstance(typeNameLambda));
}


public static IObservable<System.Object> CreateInstance(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(AssemblyValue, typeName, ignoreCase, (AssemblyValueLambda, typeNameLambda, ignoreCaseLambda) => AssemblyValueLambda.CreateInstance(typeNameLambda, ignoreCaseLambda));
}


public static IObservable<System.Object> CreateInstance(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes)
{
    return Observable.Zip(AssemblyValue, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, (AssemblyValueLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda) => AssemblyValueLambda.CreateInstance(typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda));
}


public static IObservable<System.Reflection.Module[]> GetLoadedModules(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GetLoadedModules());
}


public static IObservable<System.Reflection.Module[]> GetLoadedModules(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Boolean> getResourceModules)
{
    return Observable.Zip(AssemblyValue, getResourceModules, (AssemblyValueLambda, getResourceModulesLambda) => AssemblyValueLambda.GetLoadedModules(getResourceModulesLambda));
}


public static IObservable<System.Reflection.Module[]> GetModules(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GetModules());
}


public static IObservable<System.Reflection.Module[]> GetModules(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Boolean> getResourceModules)
{
    return Observable.Zip(AssemblyValue, getResourceModules, (AssemblyValueLambda, getResourceModulesLambda) => AssemblyValueLambda.GetModules(getResourceModulesLambda));
}


public static IObservable<System.Reflection.Module> GetModule(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyValue, name, (AssemblyValueLambda, nameLambda) => AssemblyValueLambda.GetModule(nameLambda));
}


public static IObservable<System.IO.FileStream> GetFile(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyValue, name, (AssemblyValueLambda, nameLambda) => AssemblyValueLambda.GetFile(nameLambda));
}


public static IObservable<System.IO.FileStream[]> GetFiles(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GetFiles());
}


public static IObservable<System.IO.FileStream[]> GetFiles(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.Boolean> getResourceModules)
{
    return Observable.Zip(AssemblyValue, getResourceModules, (AssemblyValueLambda, getResourceModulesLambda) => AssemblyValueLambda.GetFiles(getResourceModulesLambda));
}


public static IObservable<System.String[]> GetManifestResourceNames(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GetManifestResourceNames());
}


public static IObservable<System.Reflection.AssemblyName[]> GetReferencedAssemblies(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GetReferencedAssemblies());
}


public static IObservable<System.Reflection.ManifestResourceInfo> GetManifestResourceInfo(this IObservable<System.Reflection.Assembly> AssemblyValue, IObservable<System.String> resourceName)
{
    return Observable.Zip(AssemblyValue, resourceName, (AssemblyValueLambda, resourceNameLambda) => AssemblyValueLambda.GetManifestResourceInfo(resourceNameLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.ToString());
}


public static IObservable<System.String> get_CodeBase(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.CodeBase);
}


public static IObservable<System.String> get_EscapedCodeBase(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.EscapedCodeBase);
}


public static IObservable<System.String> get_FullName(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.FullName);
}


public static IObservable<System.Reflection.MethodInfo> get_EntryPoint(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.EntryPoint);
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Type>> get_ExportedTypes(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.ExportedTypes);
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo>> get_DefinedTypes(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.DefinedTypes);
}


public static IObservable<System.Security.Policy.Evidence> get_Evidence(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.Evidence);
}


public static IObservable<System.Security.PermissionSet> get_PermissionSet(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.PermissionSet);
}


public static IObservable<System.Boolean> get_IsFullyTrusted(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.IsFullyTrusted);
}


public static IObservable<System.Security.SecurityRuleSet> get_SecurityRuleSet(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.SecurityRuleSet);
}


public static IObservable<System.Reflection.Module> get_ManifestModule(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.ManifestModule);
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>> get_CustomAttributes(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.CustomAttributes);
}


public static IObservable<System.Boolean> get_ReflectionOnly(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.ReflectionOnly);
}


public static IObservable<System.Collections.Generic.IEnumerable<System.Reflection.Module>> get_Modules(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.Modules);
}


public static IObservable<System.String> get_Location(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.Location);
}


public static IObservable<System.String> get_ImageRuntimeVersion(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.ImageRuntimeVersion);
}


public static IObservable<System.Boolean> get_GlobalAssemblyCache(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.GlobalAssemblyCache);
}


public static IObservable<System.Int64> get_HostContext(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.HostContext);
}


public static IObservable<System.Boolean> get_IsDynamic(this IObservable<System.Reflection.Assembly> AssemblyValue)
{
    return Observable.Select(AssemblyValue, (AssemblyValueLambda) => AssemblyValueLambda.IsDynamic);
}

}
}