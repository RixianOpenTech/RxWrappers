using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _AssemblyBuilder
{
    
public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(IObservable<System.Reflection.AssemblyName> name, IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access)
{
    return Observable.Zip(name, access, (nameLambda, accessLambda) => System.Reflection.Emit.AssemblyBuilder.DefineDynamicAssembly(nameLambda, accessLambda));
}


public static IObservable<System.Reflection.Emit.AssemblyBuilder> DefineDynamicAssembly(IObservable<System.Reflection.AssemblyName> name, IObservable<System.Reflection.Emit.AssemblyBuilderAccess> access, IObservable<System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder>> assemblyAttributes)
{
    return Observable.Zip(name, access, assemblyAttributes, (nameLambda, accessLambda, assemblyAttributesLambda) => System.Reflection.Emit.AssemblyBuilder.DefineDynamicAssembly(nameLambda, accessLambda, assemblyAttributesLambda));
}


public static IObservable<System.Reflection.Emit.ModuleBuilder> DefineDynamicModule(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyBuilderValue, name, (AssemblyBuilderValueLambda, nameLambda) => AssemblyBuilderValueLambda.DefineDynamicModule(nameLambda));
}


public static IObservable<System.Reflection.Emit.ModuleBuilder> DefineDynamicModule(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name, IObservable<System.Boolean> emitSymbolInfo)
{
    return Observable.Zip(AssemblyBuilderValue, name, emitSymbolInfo, (AssemblyBuilderValueLambda, nameLambda, emitSymbolInfoLambda) => AssemblyBuilderValueLambda.DefineDynamicModule(nameLambda, emitSymbolInfoLambda));
}


public static IObservable<System.Reflection.Emit.ModuleBuilder> DefineDynamicModule(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name, IObservable<System.String> fileName)
{
    return Observable.Zip(AssemblyBuilderValue, name, fileName, (AssemblyBuilderValueLambda, nameLambda, fileNameLambda) => AssemblyBuilderValueLambda.DefineDynamicModule(nameLambda, fileNameLambda));
}


public static IObservable<System.Reflection.Emit.ModuleBuilder> DefineDynamicModule(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name, IObservable<System.String> fileName, IObservable<System.Boolean> emitSymbolInfo)
{
    return Observable.Zip(AssemblyBuilderValue, name, fileName, emitSymbolInfo, (AssemblyBuilderValueLambda, nameLambda, fileNameLambda, emitSymbolInfoLambda) => AssemblyBuilderValueLambda.DefineDynamicModule(nameLambda, fileNameLambda, emitSymbolInfoLambda));
}


public static IObservable<System.Resources.IResourceWriter> DefineResource(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name, IObservable<System.String> description, IObservable<System.String> fileName)
{
    return Observable.Zip(AssemblyBuilderValue, name, description, fileName, (AssemblyBuilderValueLambda, nameLambda, descriptionLambda, fileNameLambda) => AssemblyBuilderValueLambda.DefineResource(nameLambda, descriptionLambda, fileNameLambda));
}


public static IObservable<System.Resources.IResourceWriter> DefineResource(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name, IObservable<System.String> description, IObservable<System.String> fileName, IObservable<System.Reflection.ResourceAttributes> attribute)
{
    return Observable.Zip(AssemblyBuilderValue, name, description, fileName, attribute, (AssemblyBuilderValueLambda, nameLambda, descriptionLambda, fileNameLambda, attributeLambda) => AssemblyBuilderValueLambda.DefineResource(nameLambda, descriptionLambda, fileNameLambda, attributeLambda));
}


public static IObservable<System.Reactive.Unit> AddResourceFile(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name, IObservable<System.String> fileName)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, name, fileName, (AssemblyBuilderValueLambda, nameLambda, fileNameLambda) => AssemblyBuilderValueLambda.AddResourceFile(nameLambda, fileNameLambda));
}


public static IObservable<System.Reactive.Unit> AddResourceFile(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name, IObservable<System.String> fileName, IObservable<System.Reflection.ResourceAttributes> attribute)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, name, fileName, attribute, (AssemblyBuilderValueLambda, nameLambda, fileNameLambda, attributeLambda) => AssemblyBuilderValueLambda.AddResourceFile(nameLambda, fileNameLambda, attributeLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Object> obj)
{
    return Observable.Zip(AssemblyBuilderValue, obj, (AssemblyBuilderValueLambda, objLambda) => AssemblyBuilderValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.GetHashCode());
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(AssemblyBuilderValue, inherit, (AssemblyBuilderValueLambda, inheritLambda) => AssemblyBuilderValueLambda.GetCustomAttributes(inheritLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(AssemblyBuilderValue, attributeType, inherit, (AssemblyBuilderValueLambda, attributeTypeLambda, inheritLambda) => AssemblyBuilderValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(AssemblyBuilderValue, attributeType, inherit, (AssemblyBuilderValueLambda, attributeTypeLambda, inheritLambda) => AssemblyBuilderValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>> GetCustomAttributesData(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.GetCustomAttributesData());
}


public static IObservable<System.String[]> GetManifestResourceNames(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.GetManifestResourceNames());
}


public static IObservable<System.IO.FileStream> GetFile(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyBuilderValue, name, (AssemblyBuilderValueLambda, nameLambda) => AssemblyBuilderValueLambda.GetFile(nameLambda));
}


public static IObservable<System.IO.FileStream[]> GetFiles(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Boolean> getResourceModules)
{
    return Observable.Zip(AssemblyBuilderValue, getResourceModules, (AssemblyBuilderValueLambda, getResourceModulesLambda) => AssemblyBuilderValueLambda.GetFiles(getResourceModulesLambda));
}


public static IObservable<System.IO.Stream> GetManifestResourceStream(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Type> type, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyBuilderValue, type, name, (AssemblyBuilderValueLambda, typeLambda, nameLambda) => AssemblyBuilderValueLambda.GetManifestResourceStream(typeLambda, nameLambda));
}


public static IObservable<System.IO.Stream> GetManifestResourceStream(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyBuilderValue, name, (AssemblyBuilderValueLambda, nameLambda) => AssemblyBuilderValueLambda.GetManifestResourceStream(nameLambda));
}


public static IObservable<System.Reflection.ManifestResourceInfo> GetManifestResourceInfo(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> resourceName)
{
    return Observable.Zip(AssemblyBuilderValue, resourceName, (AssemblyBuilderValueLambda, resourceNameLambda) => AssemblyBuilderValueLambda.GetManifestResourceInfo(resourceNameLambda));
}


public static IObservable<System.Type[]> GetExportedTypes(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.GetExportedTypes());
}


public static IObservable<System.Reflection.AssemblyName> GetName(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Boolean> copiedName)
{
    return Observable.Zip(AssemblyBuilderValue, copiedName, (AssemblyBuilderValueLambda, copiedNameLambda) => AssemblyBuilderValueLambda.GetName(copiedNameLambda));
}


public static IObservable<System.Type> GetType(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name, IObservable<System.Boolean> throwOnError, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(AssemblyBuilderValue, name, throwOnError, ignoreCase, (AssemblyBuilderValueLambda, nameLambda, throwOnErrorLambda, ignoreCaseLambda) => AssemblyBuilderValueLambda.GetType(nameLambda, throwOnErrorLambda, ignoreCaseLambda));
}


public static IObservable<System.Reflection.Module> GetModule(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyBuilderValue, name, (AssemblyBuilderValueLambda, nameLambda) => AssemblyBuilderValueLambda.GetModule(nameLambda));
}


public static IObservable<System.Reflection.AssemblyName[]> GetReferencedAssemblies(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.GetReferencedAssemblies());
}


public static IObservable<System.Reflection.Module[]> GetModules(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Boolean> getResourceModules)
{
    return Observable.Zip(AssemblyBuilderValue, getResourceModules, (AssemblyBuilderValueLambda, getResourceModulesLambda) => AssemblyBuilderValueLambda.GetModules(getResourceModulesLambda));
}


public static IObservable<System.Reflection.Module[]> GetLoadedModules(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Boolean> getResourceModules)
{
    return Observable.Zip(AssemblyBuilderValue, getResourceModules, (AssemblyBuilderValueLambda, getResourceModulesLambda) => AssemblyBuilderValueLambda.GetLoadedModules(getResourceModulesLambda));
}


public static IObservable<System.Reflection.Assembly> GetSatelliteAssembly(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(AssemblyBuilderValue, culture, (AssemblyBuilderValueLambda, cultureLambda) => AssemblyBuilderValueLambda.GetSatelliteAssembly(cultureLambda));
}


public static IObservable<System.Reflection.Assembly> GetSatelliteAssembly(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Version> version)
{
    return Observable.Zip(AssemblyBuilderValue, culture, version, (AssemblyBuilderValueLambda, cultureLambda, versionLambda) => AssemblyBuilderValueLambda.GetSatelliteAssembly(cultureLambda, versionLambda));
}


public static IObservable<System.Reactive.Unit> DefineVersionInfoResource(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> product, IObservable<System.String> productVersion, IObservable<System.String> company, IObservable<System.String> copyright, IObservable<System.String> trademark)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, product, productVersion, company, copyright, trademark, (AssemblyBuilderValueLambda, productLambda, productVersionLambda, companyLambda, copyrightLambda, trademarkLambda) => AssemblyBuilderValueLambda.DefineVersionInfoResource(productLambda, productVersionLambda, companyLambda, copyrightLambda, trademarkLambda));
}


public static IObservable<System.Reactive.Unit> DefineVersionInfoResource(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Do(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.DefineVersionInfoResource()).ToUnit();
}


public static IObservable<System.Reactive.Unit> DefineUnmanagedResource(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Byte[]> resource)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, resource, (AssemblyBuilderValueLambda, resourceLambda) => AssemblyBuilderValueLambda.DefineUnmanagedResource(resourceLambda));
}


public static IObservable<System.Reactive.Unit> DefineUnmanagedResource(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> resourceFileName)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, resourceFileName, (AssemblyBuilderValueLambda, resourceFileNameLambda) => AssemblyBuilderValueLambda.DefineUnmanagedResource(resourceFileNameLambda));
}


public static IObservable<System.Reflection.Emit.ModuleBuilder> GetDynamicModule(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> name)
{
    return Observable.Zip(AssemblyBuilderValue, name, (AssemblyBuilderValueLambda, nameLambda) => AssemblyBuilderValueLambda.GetDynamicModule(nameLambda));
}


public static IObservable<System.Reactive.Unit> SetEntryPoint(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Reflection.MethodInfo> entryMethod)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, entryMethod, (AssemblyBuilderValueLambda, entryMethodLambda) => AssemblyBuilderValueLambda.SetEntryPoint(entryMethodLambda));
}


public static IObservable<System.Reactive.Unit> SetEntryPoint(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Reflection.MethodInfo> entryMethod, IObservable<System.Reflection.Emit.PEFileKinds> fileKind)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, entryMethod, fileKind, (AssemblyBuilderValueLambda, entryMethodLambda, fileKindLambda) => AssemblyBuilderValueLambda.SetEntryPoint(entryMethodLambda, fileKindLambda));
}


public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, con, binaryAttribute, (AssemblyBuilderValueLambda, conLambda, binaryAttributeLambda) => AssemblyBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
}


public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, customBuilder, (AssemblyBuilderValueLambda, customBuilderLambda) => AssemblyBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
}


public static IObservable<System.Reactive.Unit> Save(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> assemblyFileName)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, assemblyFileName, (AssemblyBuilderValueLambda, assemblyFileNameLambda) => AssemblyBuilderValueLambda.Save(assemblyFileNameLambda));
}


public static IObservable<System.Reactive.Unit> Save(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue, IObservable<System.String> assemblyFileName, IObservable<System.Reflection.PortableExecutableKinds> portableExecutableKind, IObservable<System.Reflection.ImageFileMachine> imageFileMachine)
{
    return ObservableExt.ZipExecute(AssemblyBuilderValue, assemblyFileName, portableExecutableKind, imageFileMachine, (AssemblyBuilderValueLambda, assemblyFileNameLambda, portableExecutableKindLambda, imageFileMachineLambda) => AssemblyBuilderValueLambda.Save(assemblyFileNameLambda, portableExecutableKindLambda, imageFileMachineLambda));
}


public static IObservable<System.String> get_Location(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.Location);
}


public static IObservable<System.String> get_ImageRuntimeVersion(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.ImageRuntimeVersion);
}


public static IObservable<System.String> get_CodeBase(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.CodeBase);
}


public static IObservable<System.Reflection.MethodInfo> get_EntryPoint(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.EntryPoint);
}


public static IObservable<System.String> get_FullName(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.FullName);
}


public static IObservable<System.Security.Policy.Evidence> get_Evidence(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.Evidence);
}


public static IObservable<System.Security.PermissionSet> get_PermissionSet(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.PermissionSet);
}


public static IObservable<System.Security.SecurityRuleSet> get_SecurityRuleSet(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.SecurityRuleSet);
}


public static IObservable<System.Reflection.Module> get_ManifestModule(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.ManifestModule);
}


public static IObservable<System.Boolean> get_ReflectionOnly(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.ReflectionOnly);
}


public static IObservable<System.Boolean> get_GlobalAssemblyCache(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.GlobalAssemblyCache);
}


public static IObservable<System.Int64> get_HostContext(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.HostContext);
}


public static IObservable<System.Boolean> get_IsDynamic(this IObservable<System.Reflection.Emit.AssemblyBuilder> AssemblyBuilderValue)
{
    return Observable.Select(AssemblyBuilderValue, (AssemblyBuilderValueLambda) => AssemblyBuilderValueLambda.IsDynamic);
}

}
}