using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _DynamicMethod
{
    
public static IObservable<System.Delegate> CreateDelegate(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue, IObservable<System.Type> delegateType)
{
    return Observable.Zip(DynamicMethodValue, delegateType, (DynamicMethodValueLambda, delegateTypeLambda) => DynamicMethodValueLambda.CreateDelegate(delegateTypeLambda));
}


public static IObservable<System.Delegate> CreateDelegate(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue, IObservable<System.Type> delegateType, IObservable<System.Object> target)
{
    return Observable.Zip(DynamicMethodValue, delegateType, target, (DynamicMethodValueLambda, delegateTypeLambda, targetLambda) => DynamicMethodValueLambda.CreateDelegate(delegateTypeLambda, targetLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.ToString());
}


public static IObservable<System.Reflection.MethodInfo> GetBaseDefinition(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.GetBaseDefinition());
}


public static IObservable<System.Reflection.ParameterInfo[]> GetParameters(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.GetParameters());
}


public static IObservable<System.Reflection.MethodImplAttributes> GetMethodImplementationFlags(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.GetMethodImplementationFlags());
}


public static IObservable<System.Object> Invoke(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue, IObservable<System.Object> obj, IObservable<System.Reflection.BindingFlags> invokeAttr, IObservable<System.Reflection.Binder> binder, IObservable<System.Object[]> parameters, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(DynamicMethodValue, obj, invokeAttr, binder, parameters, culture, (DynamicMethodValueLambda, objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda) => DynamicMethodValueLambda.Invoke(objLambda, invokeAttrLambda, binderLambda, parametersLambda, cultureLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(DynamicMethodValue, attributeType, inherit, (DynamicMethodValueLambda, attributeTypeLambda, inheritLambda) => DynamicMethodValueLambda.GetCustomAttributes(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Object[]> GetCustomAttributes(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(DynamicMethodValue, inherit, (DynamicMethodValueLambda, inheritLambda) => DynamicMethodValueLambda.GetCustomAttributes(inheritLambda));
}


public static IObservable<System.Boolean> IsDefined(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue, IObservable<System.Type> attributeType, IObservable<System.Boolean> inherit)
{
    return Observable.Zip(DynamicMethodValue, attributeType, inherit, (DynamicMethodValueLambda, attributeTypeLambda, inheritLambda) => DynamicMethodValueLambda.IsDefined(attributeTypeLambda, inheritLambda));
}


public static IObservable<System.Reflection.Emit.ParameterBuilder> DefineParameter(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue, IObservable<System.Int32> position, IObservable<System.Reflection.ParameterAttributes> attributes, IObservable<System.String> parameterName)
{
    return Observable.Zip(DynamicMethodValue, position, attributes, parameterName, (DynamicMethodValueLambda, positionLambda, attributesLambda, parameterNameLambda) => DynamicMethodValueLambda.DefineParameter(positionLambda, attributesLambda, parameterNameLambda));
}


public static IObservable<System.Reflection.Emit.DynamicILInfo> GetDynamicILInfo(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.GetDynamicILInfo());
}


public static IObservable<System.Reflection.Emit.ILGenerator> GetILGenerator(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.GetILGenerator());
}


public static IObservable<System.Reflection.Emit.ILGenerator> GetILGenerator(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue, IObservable<System.Int32> streamSize)
{
    return Observable.Zip(DynamicMethodValue, streamSize, (DynamicMethodValueLambda, streamSizeLambda) => DynamicMethodValueLambda.GetILGenerator(streamSizeLambda));
}


public static IObservable<System.String> get_Name(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.Name);
}


public static IObservable<System.Type> get_DeclaringType(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.DeclaringType);
}


public static IObservable<System.Type> get_ReflectedType(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.ReflectedType);
}


public static IObservable<System.Reflection.Module> get_Module(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.Module);
}


public static IObservable<System.RuntimeMethodHandle> get_MethodHandle(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.MethodHandle);
}


public static IObservable<System.Reflection.MethodAttributes> get_Attributes(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.Attributes);
}


public static IObservable<System.Reflection.CallingConventions> get_CallingConvention(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.CallingConvention);
}


public static IObservable<System.Boolean> get_IsSecurityCritical(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.IsSecurityCritical);
}


public static IObservable<System.Boolean> get_IsSecuritySafeCritical(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.IsSecuritySafeCritical);
}


public static IObservable<System.Boolean> get_IsSecurityTransparent(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.IsSecurityTransparent);
}


public static IObservable<System.Type> get_ReturnType(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.ReturnType);
}


public static IObservable<System.Reflection.ParameterInfo> get_ReturnParameter(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.ReturnParameter);
}


public static IObservable<System.Reflection.ICustomAttributeProvider> get_ReturnTypeCustomAttributes(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.ReturnTypeCustomAttributes);
}


public static IObservable<System.Boolean> get_InitLocals(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue)
{
    return Observable.Select(DynamicMethodValue, (DynamicMethodValueLambda) => DynamicMethodValueLambda.InitLocals);
}


public static IObservable<System.Reactive.Unit> set_InitLocals(this IObservable<System.Reflection.Emit.DynamicMethod> DynamicMethodValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(DynamicMethodValue, value, (DynamicMethodValueLambda, valueLambda) => DynamicMethodValueLambda.InitLocals = valueLambda);
}

}
}