using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class __Assembly
{
    
public static IObservable<System.String> ToString(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.ToString());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Object> other)
{
    return Observable.Zip(_AssemblyValue, other, (_AssemblyValueLambda, otherLambda) => _AssemblyValueLambda.Equals(otherLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GetHashCode());
}


public static IObservable<System.Type> GetType(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GetType());
}


public static IObservable<System.Reflection.AssemblyName> GetName(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GetName());
}


public static IObservable<System.Reflection.AssemblyName> GetName(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Boolean> copiedName)
{
    return Observable.Zip(_AssemblyValue, copiedName, (_AssemblyValueLambda, copiedNameLambda) => _AssemblyValueLambda.GetName(copiedNameLambda));
}


public static IObservable<System.Type> GetType(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> name)
{
    return Observable.Zip(_AssemblyValue, name, (_AssemblyValueLambda, nameLambda) => _AssemblyValueLambda.GetType(nameLambda));
}


public static IObservable<System.Type> GetType(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> name, IObservable<System.Boolean> throwOnError)
{
    return Observable.Zip(_AssemblyValue, name, throwOnError, (_AssemblyValueLambda, nameLambda, throwOnErrorLambda) => _AssemblyValueLambda.GetType(nameLambda, throwOnErrorLambda));
}


public static IObservable<System.Type[]> GetExportedTypes(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GetExportedTypes());
}


public static IObservable<System.Type[]> GetTypes(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GetTypes());
}


public static IObservable<System.IO.Stream> GetManifestResourceStream(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Type> type, IObservable<System.String> name)
{
    return Observable.Zip(_AssemblyValue, type, name, (_AssemblyValueLambda, typeLambda, nameLambda) => _AssemblyValueLambda.GetManifestResourceStream(typeLambda, nameLambda));
}


public static IObservable<System.IO.Stream> GetManifestResourceStream(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> name)
{
    return Observable.Zip(_AssemblyValue, name, (_AssemblyValueLambda, nameLambda) => _AssemblyValueLambda.GetManifestResourceStream(nameLambda));
}


public static IObservable<System.IO.FileStream> GetFile(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> name)
{
    return Observable.Zip(_AssemblyValue, name, (_AssemblyValueLambda, nameLambda) => _AssemblyValueLambda.GetFile(nameLambda));
}


public static IObservable<System.IO.FileStream[]> GetFiles(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GetFiles());
}


public static IObservable<System.IO.FileStream[]> GetFiles(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Boolean> getResourceModules)
{
    return Observable.Zip(_AssemblyValue, getResourceModules, (_AssemblyValueLambda, getResourceModulesLambda) => _AssemblyValueLambda.GetFiles(getResourceModulesLambda));
}


public static IObservable<System.String[]> GetManifestResourceNames(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GetManifestResourceNames());
}


public static IObservable<System.Reflection.ManifestResourceInfo> GetManifestResourceInfo(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> resourceName)
{
    return Observable.Zip(_AssemblyValue, resourceName, (_AssemblyValueLambda, resourceNameLambda) => _AssemblyValueLambda.GetManifestResourceInfo(resourceNameLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(_AssemblyValue, attributeType, inherit, (_AssemblyValueLambda, attributeTypeLambda, inheritLambda) => _AssemblyValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(_AssemblyValue, inherit, (_AssemblyValueLambda, inheritLambda) => _AssemblyValueLambda.GetCustomAttributes(inheritLambda));
}


public static IObservable<System.Boolean> IsDefined(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(_AssemblyValue, attributeType, inherit, (_AssemblyValueLambda, attributeTypeLambda, inheritLambda) => _AssemblyValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(_AssemblyValue, info, context, (_AssemblyValueLambda, infoLambda, contextLambda) => _AssemblyValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.Type> GetType(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> name, IObservable<System.Boolean> throwOnError, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(_AssemblyValue, name, throwOnError, ignoreCase, (_AssemblyValueLambda, nameLambda, throwOnErrorLambda, ignoreCaseLambda) => _AssemblyValueLambda.GetType(nameLambda, throwOnErrorLambda, ignoreCaseLambda));
}


public static IObservable<System.Reflection.Assembly> GetSatelliteAssembly(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(_AssemblyValue, culture, (_AssemblyValueLambda, cultureLambda) => _AssemblyValueLambda.GetSatelliteAssembly(cultureLambda));
}


public static IObservable<System.Reflection.Assembly> GetSatelliteAssembly(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Version> version)
{
    return Observable.Zip(_AssemblyValue, culture, version, (_AssemblyValueLambda, cultureLambda, versionLambda) => _AssemblyValueLambda.GetSatelliteAssembly(cultureLambda, versionLambda));
}


public static IObservable<System.Reflection.Module> LoadModule(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> moduleName, IObservable<System.Byte[]> rawModule)
{
    return Observable.Zip(_AssemblyValue, moduleName, rawModule, (_AssemblyValueLambda, moduleNameLambda, rawModuleLambda) => _AssemblyValueLambda.LoadModule(moduleNameLambda, rawModuleLambda));
}


public static IObservable<System.Reflection.Module> LoadModule(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> moduleName, IObservable<System.Byte[]> rawModule, IObservable<System.Byte[]> rawSymbolStore)
{
    return Observable.Zip(_AssemblyValue, moduleName, rawModule, rawSymbolStore, (_AssemblyValueLambda, moduleNameLambda, rawModuleLambda, rawSymbolStoreLambda) => _AssemblyValueLambda.LoadModule(moduleNameLambda, rawModuleLambda, rawSymbolStoreLambda));
}


public static IObservable<System.Object> CreateInstance(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> typeName)
{
    return Observable.Zip(_AssemblyValue, typeName, (_AssemblyValueLambda, typeNameLambda) => _AssemblyValueLambda.CreateInstance(typeNameLambda));
}


public static IObservable<System.Object> CreateInstance(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(_AssemblyValue, typeName, ignoreCase, (_AssemblyValueLambda, typeNameLambda, ignoreCaseLambda) => _AssemblyValueLambda.CreateInstance(typeNameLambda, ignoreCaseLambda));
}


public static IObservable<System.Object> CreateInstance(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> typeName, IObservable<System.Boolean> ignoreCase, IObservable<System.Reflection.BindingFlags> bindingAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> args, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Object[]> activationAttributes)
{
    return Observable.Zip(_AssemblyValue, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, (_AssemblyValueLambda, typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda) => _AssemblyValueLambda.CreateInstance(typeNameLambda, ignoreCaseLambda, bindingAttrLambda, binderLambda, argsLambda, cultureLambda, activationAttributesLambda));
}


public static IObservable<System.Reflection.Module[]> GetLoadedModules(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GetLoadedModules());
}


public static IObservable<System.Reflection.Module[]> GetLoadedModules(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Boolean> getResourceModules)
{
    return Observable.Zip(_AssemblyValue, getResourceModules, (_AssemblyValueLambda, getResourceModulesLambda) => _AssemblyValueLambda.GetLoadedModules(getResourceModulesLambda));
}


public static IObservable<System.Reflection.Module[]> GetModules(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GetModules());
}


public static IObservable<System.Reflection.Module[]> GetModules(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.Boolean> getResourceModules)
{
    return Observable.Zip(_AssemblyValue, getResourceModules, (_AssemblyValueLambda, getResourceModulesLambda) => _AssemblyValueLambda.GetModules(getResourceModulesLambda));
}


public static IObservable<System.Reflection.Module> GetModule(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue, IObservable<System.String> name)
{
    return Observable.Zip(_AssemblyValue, name, (_AssemblyValueLambda, nameLambda) => _AssemblyValueLambda.GetModule(nameLambda));
}


public static IObservable<System.Reflection.AssemblyName[]> GetReferencedAssemblies(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GetReferencedAssemblies());
}


public static IObservable<System.String> get_CodeBase(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.CodeBase);
}


public static IObservable<System.String> get_EscapedCodeBase(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.EscapedCodeBase);
}


public static IObservable<System.String> get_FullName(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.FullName);
}


public static IObservable<System.Reflection.MethodInfo> get_EntryPoint(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.EntryPoint);
}


public static IObservable<System.String> get_Location(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.Location);
}


public static IObservable<System.Security.Policy.Evidence> get_Evidence(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.Evidence);
}


public static IObservable<System.Boolean> get_GlobalAssemblyCache(this IObservable<System.Runtime.InteropServices._Assembly> _AssemblyValue)
{
    return Observable.Select(_AssemblyValue, (_AssemblyValueLambda) => _AssemblyValueLambda.GlobalAssemblyCache);
}

}
}