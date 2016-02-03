using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _ModuleBuilder
{
    
public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Object> obj)
{
    return Observable.Zip(ModuleBuilderValue, obj, (ModuleBuilderValueLambda, objLambda) => ModuleBuilderValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.GetHashCode());
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(ModuleBuilderValue, inherit, (ModuleBuilderValueLambda, inheritLambda) => ModuleBuilderValueLambda.GetCustomAttributes(inheritLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(ModuleBuilderValue, attributeType, inherit, (ModuleBuilderValueLambda, attributeTypeLambda, inheritLambda) => ModuleBuilderValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(ModuleBuilderValue, attributeType, inherit, (ModuleBuilderValueLambda, attributeTypeLambda, inheritLambda) => ModuleBuilderValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>> GetCustomAttributesData(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.GetCustomAttributesData());
}


public static IObservable<System.Type[]> GetTypes(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.GetTypes());
}


public static IObservable<System.Type> GetType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> className)
{
    return Observable.Zip(ModuleBuilderValue, className, (ModuleBuilderValueLambda, classNameLambda) => ModuleBuilderValueLambda.GetType(classNameLambda));
}


public static IObservable<System.Type> GetType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> className, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(ModuleBuilderValue, className, ignoreCase, (ModuleBuilderValueLambda, classNameLambda, ignoreCaseLambda) => ModuleBuilderValueLambda.GetType(classNameLambda, ignoreCaseLambda));
}


public static IObservable<System.Type> GetType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> className, IObservable<System.Boolean> throwOnError, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(ModuleBuilderValue, className, throwOnError, ignoreCase, (ModuleBuilderValueLambda, classNameLambda, throwOnErrorLambda, ignoreCaseLambda) => ModuleBuilderValueLambda.GetType(classNameLambda, throwOnErrorLambda, ignoreCaseLambda));
}


public static IObservable<System.Byte[]> ResolveSignature(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Int32> metadataToken)
{
    return Observable.Zip(ModuleBuilderValue, metadataToken, (ModuleBuilderValueLambda, metadataTokenLambda) => ModuleBuilderValueLambda.ResolveSignature(metadataTokenLambda));
}


public static IObservable<System.Reflection.MethodBase> ResolveMethod(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Int32> metadataToken, IObservable<System.Type[]> genericTypeArguments, IObservable<System.Type[]> genericMethodArguments)
{
    return Observable.Zip(ModuleBuilderValue, metadataToken, genericTypeArguments, genericMethodArguments, (ModuleBuilderValueLambda, metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda) => ModuleBuilderValueLambda.ResolveMethod(metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda));
}


public static IObservable<System.Reflection.FieldInfo> ResolveField(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Int32> metadataToken, IObservable<System.Type[]> genericTypeArguments, IObservable<System.Type[]> genericMethodArguments)
{
    return Observable.Zip(ModuleBuilderValue, metadataToken, genericTypeArguments, genericMethodArguments, (ModuleBuilderValueLambda, metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda) => ModuleBuilderValueLambda.ResolveField(metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda));
}


public static IObservable<System.Type> ResolveType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Int32> metadataToken, IObservable<System.Type[]> genericTypeArguments, IObservable<System.Type[]> genericMethodArguments)
{
    return Observable.Zip(ModuleBuilderValue, metadataToken, genericTypeArguments, genericMethodArguments, (ModuleBuilderValueLambda, metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda) => ModuleBuilderValueLambda.ResolveType(metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda));
}


public static IObservable<System.Reflection.MemberInfo> ResolveMember(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Int32> metadataToken, IObservable<System.Type[]> genericTypeArguments, IObservable<System.Type[]> genericMethodArguments)
{
    return Observable.Zip(ModuleBuilderValue, metadataToken, genericTypeArguments, genericMethodArguments, (ModuleBuilderValueLambda, metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda) => ModuleBuilderValueLambda.ResolveMember(metadataTokenLambda, genericTypeArgumentsLambda, genericMethodArgumentsLambda));
}


public static IObservable<System.String> ResolveString(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Int32> metadataToken)
{
    return Observable.Zip(ModuleBuilderValue, metadataToken, (ModuleBuilderValueLambda, metadataTokenLambda) => ModuleBuilderValueLambda.ResolveString(metadataTokenLambda));
}


public static IObservable<Tuple<System.Reflection.PortableExecutableKinds, System.Reflection.ImageFileMachine>> GetPEKind(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => {
System.Reflection.PortableExecutableKinds peKindOutput = default(System.Reflection.PortableExecutableKinds);
System.Reflection.ImageFileMachine machineOutput = default(System.Reflection.ImageFileMachine);
ModuleBuilderValueLambda.GetPEKind(out peKindOutput, out machineOutput);
return Tuple.Create(peKindOutput, machineOutput);
});
}


public static IObservable<System.Boolean> IsResource(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.IsResource());
}


public static IObservable<System.Reflection.FieldInfo[]> GetFields(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.BindingFlags> bindingFlags)
{
    return Observable.Zip(ModuleBuilderValue, bindingFlags, (ModuleBuilderValueLambda, bindingFlagsLambda) => ModuleBuilderValueLambda.GetFields(bindingFlagsLambda));
}


public static IObservable<System.Reflection.FieldInfo> GetField(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.BindingFlags> bindingAttr)
{
    return Observable.Zip(ModuleBuilderValue, name, bindingAttr, (ModuleBuilderValueLambda, nameLambda, bindingAttrLambda) => ModuleBuilderValueLambda.GetField(nameLambda, bindingAttrLambda));
}


public static IObservable<System.Reflection.MethodInfo[]> GetMethods(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.BindingFlags> bindingFlags)
{
    return Observable.Zip(ModuleBuilderValue, bindingFlags, (ModuleBuilderValueLambda, bindingFlagsLambda) => ModuleBuilderValueLambda.GetMethods(bindingFlagsLambda));
}


public static IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> GetSignerCertificate(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.GetSignerCertificate());
}


public static IObservable<System.Reflection.Emit.TypeBuilder> DefineType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name)
{
    return Observable.Zip(ModuleBuilderValue, name, (ModuleBuilderValueLambda, nameLambda) => ModuleBuilderValueLambda.DefineType(nameLambda));
}


public static IObservable<System.Reflection.Emit.TypeBuilder> DefineType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr)
{
    return Observable.Zip(ModuleBuilderValue, name, attr, (ModuleBuilderValueLambda, nameLambda, attrLambda) => ModuleBuilderValueLambda.DefineType(nameLambda, attrLambda));
}


public static IObservable<System.Reflection.Emit.TypeBuilder> DefineType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr, IObservable<System.Type> parent)
{
    return Observable.Zip(ModuleBuilderValue, name, attr, parent, (ModuleBuilderValueLambda, nameLambda, attrLambda, parentLambda) => ModuleBuilderValueLambda.DefineType(nameLambda, attrLambda, parentLambda));
}


public static IObservable<System.Reflection.Emit.TypeBuilder> DefineType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr, IObservable<System.Type> parent, IObservable<System.Int32> typesize)
{
    return Observable.Zip(ModuleBuilderValue, name, attr, parent, typesize, (ModuleBuilderValueLambda, nameLambda, attrLambda, parentLambda, typesizeLambda) => ModuleBuilderValueLambda.DefineType(nameLambda, attrLambda, parentLambda, typesizeLambda));
}


public static IObservable<System.Reflection.Emit.TypeBuilder> DefineType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr, IObservable<System.Type> parent, IObservable<System.Reflection.Emit.PackingSize> packingSize, IObservable<System.Int32> typesize)
{
    return Observable.Zip(ModuleBuilderValue, name, attr, parent, packingSize, typesize, (ModuleBuilderValueLambda, nameLambda, attrLambda, parentLambda, packingSizeLambda, typesizeLambda) => ModuleBuilderValueLambda.DefineType(nameLambda, attrLambda, parentLambda, packingSizeLambda, typesizeLambda));
}


public static IObservable<System.Reflection.Emit.TypeBuilder> DefineType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr, IObservable<System.Type> parent, IObservable<System.Type[]> interfaces)
{
    return Observable.Zip(ModuleBuilderValue, name, attr, parent, interfaces, (ModuleBuilderValueLambda, nameLambda, attrLambda, parentLambda, interfacesLambda) => ModuleBuilderValueLambda.DefineType(nameLambda, attrLambda, parentLambda, interfacesLambda));
}


public static IObservable<System.Reflection.Emit.TypeBuilder> DefineType(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> attr, IObservable<System.Type> parent, IObservable<System.Reflection.Emit.PackingSize> packsize)
{
    return Observable.Zip(ModuleBuilderValue, name, attr, parent, packsize, (ModuleBuilderValueLambda, nameLambda, attrLambda, parentLambda, packsizeLambda) => ModuleBuilderValueLambda.DefineType(nameLambda, attrLambda, parentLambda, packsizeLambda));
}


public static IObservable<System.Reflection.Emit.EnumBuilder> DefineEnum(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.TypeAttributes> visibility, IObservable<System.Type> underlyingType)
{
    return Observable.Zip(ModuleBuilderValue, name, visibility, underlyingType, (ModuleBuilderValueLambda, nameLambda, visibilityLambda, underlyingTypeLambda) => ModuleBuilderValueLambda.DefineEnum(nameLambda, visibilityLambda, underlyingTypeLambda));
}


public static IObservable<System.Resources.IResourceWriter> DefineResource(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.String> description)
{
    return Observable.Zip(ModuleBuilderValue, name, description, (ModuleBuilderValueLambda, nameLambda, descriptionLambda) => ModuleBuilderValueLambda.DefineResource(nameLambda, descriptionLambda));
}


public static IObservable<System.Resources.IResourceWriter> DefineResource(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.String> description, IObservable<System.Reflection.ResourceAttributes> attribute)
{
    return Observable.Zip(ModuleBuilderValue, name, description, attribute, (ModuleBuilderValueLambda, nameLambda, descriptionLambda, attributeLambda) => ModuleBuilderValueLambda.DefineResource(nameLambda, descriptionLambda, attributeLambda));
}


public static IObservable<System.Reactive.Unit> DefineManifestResource(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.IO.Stream> stream, IObservable<System.Reflection.ResourceAttributes> attribute)
{
    return ObservableExt.ZipExecute(ModuleBuilderValue, name, stream, attribute, (ModuleBuilderValueLambda, nameLambda, streamLambda, attributeLambda) => ModuleBuilderValueLambda.DefineManifestResource(nameLambda, streamLambda, attributeLambda));
}


public static IObservable<System.Reactive.Unit> DefineUnmanagedResource(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Byte[]> resource)
{
    return ObservableExt.ZipExecute(ModuleBuilderValue, resource, (ModuleBuilderValueLambda, resourceLambda) => ModuleBuilderValueLambda.DefineUnmanagedResource(resourceLambda));
}


public static IObservable<System.Reactive.Unit> DefineUnmanagedResource(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> resourceFileName)
{
    return ObservableExt.ZipExecute(ModuleBuilderValue, resourceFileName, (ModuleBuilderValueLambda, resourceFileNameLambda) => ModuleBuilderValueLambda.DefineUnmanagedResource(resourceFileNameLambda));
}


public static IObservable<System.Reflection.Emit.MethodBuilder> DefineGlobalMethod(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
{
    return Observable.Zip(ModuleBuilderValue, name, attributes, returnType, parameterTypes, (ModuleBuilderValueLambda, nameLambda, attributesLambda, returnTypeLambda, parameterTypesLambda) => ModuleBuilderValueLambda.DefineGlobalMethod(nameLambda, attributesLambda, returnTypeLambda, parameterTypesLambda));
}


public static IObservable<System.Reflection.Emit.MethodBuilder> DefineGlobalMethod(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
{
    return Observable.Zip(ModuleBuilderValue, name, attributes, callingConvention, returnType, parameterTypes, (ModuleBuilderValueLambda, nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda) => ModuleBuilderValueLambda.DefineGlobalMethod(nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda));
}


public static IObservable<System.Reflection.Emit.MethodBuilder> DefineGlobalMethod(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> requiredReturnTypeCustomModifiers, IObservable<System.Type[]> optionalReturnTypeCustomModifiers, IObservable<System.Type[]> parameterTypes, IObservable<System.Type[][]> requiredParameterTypeCustomModifiers, IObservable<System.Type[][]> optionalParameterTypeCustomModifiers)
{
    return Observable.Zip(ModuleBuilderValue, name, attributes, callingConvention, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers, (ModuleBuilderValueLambda, nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, requiredReturnTypeCustomModifiersLambda, optionalReturnTypeCustomModifiersLambda, parameterTypesLambda, requiredParameterTypeCustomModifiersLambda, optionalParameterTypeCustomModifiersLambda) => ModuleBuilderValueLambda.DefineGlobalMethod(nameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, requiredReturnTypeCustomModifiersLambda, optionalReturnTypeCustomModifiersLambda, parameterTypesLambda, requiredParameterTypeCustomModifiersLambda, optionalParameterTypeCustomModifiersLambda));
}


public static IObservable<System.Reflection.Emit.MethodBuilder> DefinePInvokeMethod(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.String> dllName, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes, IObservable<System.Runtime.InteropServices.CallingConvention> nativeCallConv, IObservable<System.Runtime.InteropServices.CharSet> nativeCharSet)
{
    return Observable.Zip(ModuleBuilderValue, name, dllName, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet, (ModuleBuilderValueLambda, nameLambda, dllNameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda, nativeCallConvLambda, nativeCharSetLambda) => ModuleBuilderValueLambda.DefinePInvokeMethod(nameLambda, dllNameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda, nativeCallConvLambda, nativeCharSetLambda));
}


public static IObservable<System.Reflection.Emit.MethodBuilder> DefinePInvokeMethod(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.String> dllName, IObservable<System.String> entryName, IObservable<System.Reflection.MethodAttributes> attributes, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes, IObservable<System.Runtime.InteropServices.CallingConvention> nativeCallConv, IObservable<System.Runtime.InteropServices.CharSet> nativeCharSet)
{
    return Observable.Zip(ModuleBuilderValue, name, dllName, entryName, attributes, callingConvention, returnType, parameterTypes, nativeCallConv, nativeCharSet, (ModuleBuilderValueLambda, nameLambda, dllNameLambda, entryNameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda, nativeCallConvLambda, nativeCharSetLambda) => ModuleBuilderValueLambda.DefinePInvokeMethod(nameLambda, dllNameLambda, entryNameLambda, attributesLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda, nativeCallConvLambda, nativeCharSetLambda));
}


public static IObservable<System.Reactive.Unit> CreateGlobalFunctions(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Do(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.CreateGlobalFunctions()).ToUnit();
}


public static IObservable<System.Reflection.Emit.FieldBuilder> DefineInitializedData(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Byte[]> data, IObservable<System.Reflection.FieldAttributes> attributes)
{
    return Observable.Zip(ModuleBuilderValue, name, data, attributes, (ModuleBuilderValueLambda, nameLambda, dataLambda, attributesLambda) => ModuleBuilderValueLambda.DefineInitializedData(nameLambda, dataLambda, attributesLambda));
}


public static IObservable<System.Reflection.Emit.FieldBuilder> DefineUninitializedData(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Int32> size, IObservable<System.Reflection.FieldAttributes> attributes)
{
    return Observable.Zip(ModuleBuilderValue, name, size, attributes, (ModuleBuilderValueLambda, nameLambda, sizeLambda, attributesLambda) => ModuleBuilderValueLambda.DefineUninitializedData(nameLambda, sizeLambda, attributesLambda));
}


public static IObservable<System.Reflection.Emit.TypeToken> GetTypeToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Type> type)
{
    return Observable.Zip(ModuleBuilderValue, type, (ModuleBuilderValueLambda, typeLambda) => ModuleBuilderValueLambda.GetTypeToken(typeLambda));
}


public static IObservable<System.Reflection.Emit.TypeToken> GetTypeToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name)
{
    return Observable.Zip(ModuleBuilderValue, name, (ModuleBuilderValueLambda, nameLambda) => ModuleBuilderValueLambda.GetTypeToken(nameLambda));
}


public static IObservable<System.Reflection.Emit.MethodToken> GetMethodToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.MethodInfo> method)
{
    return Observable.Zip(ModuleBuilderValue, method, (ModuleBuilderValueLambda, methodLambda) => ModuleBuilderValueLambda.GetMethodToken(methodLambda));
}


public static IObservable<System.Reflection.Emit.MethodToken> GetConstructorToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.ConstructorInfo> constructor, IObservable<System.Collections.Generic.IEnumerable<System.Type>> optionalParameterTypes)
{
    return Observable.Zip(ModuleBuilderValue, constructor, optionalParameterTypes, (ModuleBuilderValueLambda, constructorLambda, optionalParameterTypesLambda) => ModuleBuilderValueLambda.GetConstructorToken(constructorLambda, optionalParameterTypesLambda));
}


public static IObservable<System.Reflection.Emit.MethodToken> GetMethodToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.MethodInfo> method, IObservable<System.Collections.Generic.IEnumerable<System.Type>> optionalParameterTypes)
{
    return Observable.Zip(ModuleBuilderValue, method, optionalParameterTypes, (ModuleBuilderValueLambda, methodLambda, optionalParameterTypesLambda) => ModuleBuilderValueLambda.GetMethodToken(methodLambda, optionalParameterTypesLambda));
}


public static IObservable<System.Reflection.Emit.MethodToken> GetArrayMethodToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Type> arrayClass, IObservable<System.String> methodName, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
{
    return Observable.Zip(ModuleBuilderValue, arrayClass, methodName, callingConvention, returnType, parameterTypes, (ModuleBuilderValueLambda, arrayClassLambda, methodNameLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda) => ModuleBuilderValueLambda.GetArrayMethodToken(arrayClassLambda, methodNameLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda));
}


public static IObservable<System.Reflection.MethodInfo> GetArrayMethod(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Type> arrayClass, IObservable<System.String> methodName, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
{
    return Observable.Zip(ModuleBuilderValue, arrayClass, methodName, callingConvention, returnType, parameterTypes, (ModuleBuilderValueLambda, arrayClassLambda, methodNameLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda) => ModuleBuilderValueLambda.GetArrayMethod(arrayClassLambda, methodNameLambda, callingConventionLambda, returnTypeLambda, parameterTypesLambda));
}


public static IObservable<System.Reflection.Emit.MethodToken> GetConstructorToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.ConstructorInfo> con)
{
    return Observable.Zip(ModuleBuilderValue, con, (ModuleBuilderValueLambda, conLambda) => ModuleBuilderValueLambda.GetConstructorToken(conLambda));
}


public static IObservable<System.Reflection.Emit.FieldToken> GetFieldToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.FieldInfo> field)
{
    return Observable.Zip(ModuleBuilderValue, field, (ModuleBuilderValueLambda, fieldLambda) => ModuleBuilderValueLambda.GetFieldToken(fieldLambda));
}


public static IObservable<System.Reflection.Emit.StringToken> GetStringConstant(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> str)
{
    return Observable.Zip(ModuleBuilderValue, str, (ModuleBuilderValueLambda, strLambda) => ModuleBuilderValueLambda.GetStringConstant(strLambda));
}


public static IObservable<System.Reflection.Emit.SignatureToken> GetSignatureToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.Emit.SignatureHelper> sigHelper)
{
    return Observable.Zip(ModuleBuilderValue, sigHelper, (ModuleBuilderValueLambda, sigHelperLambda) => ModuleBuilderValueLambda.GetSignatureToken(sigHelperLambda));
}


public static IObservable<System.Reflection.Emit.SignatureToken> GetSignatureToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Byte[]> sigBytes, IObservable<System.Int32> sigLength)
{
    return Observable.Zip(ModuleBuilderValue, sigBytes, sigLength, (ModuleBuilderValueLambda, sigBytesLambda, sigLengthLambda) => ModuleBuilderValueLambda.GetSignatureToken(sigBytesLambda, sigLengthLambda));
}


public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
{
    return ObservableExt.ZipExecute(ModuleBuilderValue, con, binaryAttribute, (ModuleBuilderValueLambda, conLambda, binaryAttributeLambda) => ModuleBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
}


public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
{
    return ObservableExt.ZipExecute(ModuleBuilderValue, customBuilder, (ModuleBuilderValueLambda, customBuilderLambda) => ModuleBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolWriter> GetSymWriter(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.GetSymWriter());
}


public static IObservable<System.Diagnostics.SymbolStore.ISymbolDocumentWriter> DefineDocument(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> url, IObservable<System.Guid> language, IObservable<System.Guid> languageVendor, IObservable<System.Guid> documentType)
{
    return Observable.Zip(ModuleBuilderValue, url, language, languageVendor, documentType, (ModuleBuilderValueLambda, urlLambda, languageLambda, languageVendorLambda, documentTypeLambda) => ModuleBuilderValueLambda.DefineDocument(urlLambda, languageLambda, languageVendorLambda, documentTypeLambda));
}


public static IObservable<System.Reactive.Unit> SetUserEntryPoint(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.Reflection.MethodInfo> entryPoint)
{
    return ObservableExt.ZipExecute(ModuleBuilderValue, entryPoint, (ModuleBuilderValueLambda, entryPointLambda) => ModuleBuilderValueLambda.SetUserEntryPoint(entryPointLambda));
}


public static IObservable<System.Reactive.Unit> SetSymCustomAttribute(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue, IObservable<System.String> name, IObservable<System.Byte[]> data)
{
    return ObservableExt.ZipExecute(ModuleBuilderValue, name, data, (ModuleBuilderValueLambda, nameLambda, dataLambda) => ModuleBuilderValueLambda.SetSymCustomAttribute(nameLambda, dataLambda));
}


public static IObservable<System.Boolean> IsTransient(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.IsTransient());
}


public static IObservable<System.String> get_FullyQualifiedName(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.FullyQualifiedName);
}


public static IObservable<System.Int32> get_MDStreamVersion(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.MDStreamVersion);
}


public static IObservable<System.Guid> get_ModuleVersionId(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.ModuleVersionId);
}


public static IObservable<System.Int32> get_MetadataToken(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.MetadataToken);
}


public static IObservable<System.String> get_ScopeName(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.ScopeName);
}


public static IObservable<System.String> get_Name(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.Name);
}


public static IObservable<System.Reflection.Assembly> get_Assembly(this IObservable<System.Reflection.Emit.ModuleBuilder> ModuleBuilderValue)
{
    return Observable.Select(ModuleBuilderValue, (ModuleBuilderValueLambda) => ModuleBuilderValueLambda.Assembly);
}

}
}