using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _ModuleHandle
{
    
public static IObservable<System.Int32> GetHashCode(this IObservable<System.ModuleHandle> ModuleHandleValue)
{
    return Observable.Select(ModuleHandleValue, (ModuleHandleValueLambda) => ModuleHandleValueLambda.GetHashCode());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.Object> obj)
{
    return Observable.Zip(ModuleHandleValue, obj, (ModuleHandleValueLambda, objLambda) => ModuleHandleValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.ModuleHandle> handle)
{
    return Observable.Zip(ModuleHandleValue, handle, (ModuleHandleValueLambda, handleLambda) => ModuleHandleValueLambda.Equals(handleLambda));
}


public static IObservable<System.RuntimeTypeHandle> GetRuntimeTypeHandleFromMetadataToken(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.Int32> typeToken)
{
    return Observable.Zip(ModuleHandleValue, typeToken, (ModuleHandleValueLambda, typeTokenLambda) => ModuleHandleValueLambda.GetRuntimeTypeHandleFromMetadataToken(typeTokenLambda));
}


public static IObservable<System.RuntimeTypeHandle> ResolveTypeHandle(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.Int32> typeToken)
{
    return Observable.Zip(ModuleHandleValue, typeToken, (ModuleHandleValueLambda, typeTokenLambda) => ModuleHandleValueLambda.ResolveTypeHandle(typeTokenLambda));
}


public static IObservable<System.RuntimeTypeHandle> ResolveTypeHandle(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.Int32> typeToken, IObservable<System.RuntimeTypeHandle[]> typeInstantiationContext, IObservable<System.RuntimeTypeHandle[]> methodInstantiationContext)
{
    return Observable.Zip(ModuleHandleValue, typeToken, typeInstantiationContext, methodInstantiationContext, (ModuleHandleValueLambda, typeTokenLambda, typeInstantiationContextLambda, methodInstantiationContextLambda) => ModuleHandleValueLambda.ResolveTypeHandle(typeTokenLambda, typeInstantiationContextLambda, methodInstantiationContextLambda));
}


public static IObservable<System.RuntimeMethodHandle> GetRuntimeMethodHandleFromMetadataToken(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.Int32> methodToken)
{
    return Observable.Zip(ModuleHandleValue, methodToken, (ModuleHandleValueLambda, methodTokenLambda) => ModuleHandleValueLambda.GetRuntimeMethodHandleFromMetadataToken(methodTokenLambda));
}


public static IObservable<System.RuntimeMethodHandle> ResolveMethodHandle(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.Int32> methodToken)
{
    return Observable.Zip(ModuleHandleValue, methodToken, (ModuleHandleValueLambda, methodTokenLambda) => ModuleHandleValueLambda.ResolveMethodHandle(methodTokenLambda));
}


public static IObservable<System.RuntimeMethodHandle> ResolveMethodHandle(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.Int32> methodToken, IObservable<System.RuntimeTypeHandle[]> typeInstantiationContext, IObservable<System.RuntimeTypeHandle[]> methodInstantiationContext)
{
    return Observable.Zip(ModuleHandleValue, methodToken, typeInstantiationContext, methodInstantiationContext, (ModuleHandleValueLambda, methodTokenLambda, typeInstantiationContextLambda, methodInstantiationContextLambda) => ModuleHandleValueLambda.ResolveMethodHandle(methodTokenLambda, typeInstantiationContextLambda, methodInstantiationContextLambda));
}


public static IObservable<System.RuntimeFieldHandle> GetRuntimeFieldHandleFromMetadataToken(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.Int32> fieldToken)
{
    return Observable.Zip(ModuleHandleValue, fieldToken, (ModuleHandleValueLambda, fieldTokenLambda) => ModuleHandleValueLambda.GetRuntimeFieldHandleFromMetadataToken(fieldTokenLambda));
}


public static IObservable<System.RuntimeFieldHandle> ResolveFieldHandle(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.Int32> fieldToken)
{
    return Observable.Zip(ModuleHandleValue, fieldToken, (ModuleHandleValueLambda, fieldTokenLambda) => ModuleHandleValueLambda.ResolveFieldHandle(fieldTokenLambda));
}


public static IObservable<System.RuntimeFieldHandle> ResolveFieldHandle(this IObservable<System.ModuleHandle> ModuleHandleValue, IObservable<System.Int32> fieldToken, IObservable<System.RuntimeTypeHandle[]> typeInstantiationContext, IObservable<System.RuntimeTypeHandle[]> methodInstantiationContext)
{
    return Observable.Zip(ModuleHandleValue, fieldToken, typeInstantiationContext, methodInstantiationContext, (ModuleHandleValueLambda, fieldTokenLambda, typeInstantiationContextLambda, methodInstantiationContextLambda) => ModuleHandleValueLambda.ResolveFieldHandle(fieldTokenLambda, typeInstantiationContextLambda, methodInstantiationContextLambda));
}


public static IObservable<System.Int32> get_MDStreamVersion(this IObservable<System.ModuleHandle> ModuleHandleValue)
{
    return Observable.Select(ModuleHandleValue, (ModuleHandleValueLambda) => ModuleHandleValueLambda.MDStreamVersion);
}

}
}