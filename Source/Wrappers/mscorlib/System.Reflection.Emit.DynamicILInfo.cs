using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _DynamicILInfo
{
    
public static IObservable<System.Reactive.Unit> SetCode(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.Byte[]> code, IObservable<System.Int32> maxStackSize)
{
    return ObservableExt.ZipExecute(DynamicILInfoValue, code, maxStackSize, (DynamicILInfoValueLambda, codeLambda, maxStackSizeLambda) => DynamicILInfoValueLambda.SetCode(codeLambda, maxStackSizeLambda));
}


public static IObservable<System.Reactive.Unit> SetCode(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.Byte*> code, IObservable<System.Int32> codeSize, IObservable<System.Int32> maxStackSize)
{
    return ObservableExt.ZipExecute(DynamicILInfoValue, code, codeSize, maxStackSize, (DynamicILInfoValueLambda, codeLambda, codeSizeLambda, maxStackSizeLambda) => DynamicILInfoValueLambda.SetCode(codeLambda, codeSizeLambda, maxStackSizeLambda));
}


public static IObservable<System.Reactive.Unit> SetExceptions(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.Byte[]> exceptions)
{
    return ObservableExt.ZipExecute(DynamicILInfoValue, exceptions, (DynamicILInfoValueLambda, exceptionsLambda) => DynamicILInfoValueLambda.SetExceptions(exceptionsLambda));
}


public static IObservable<System.Reactive.Unit> SetExceptions(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.Byte*> exceptions, IObservable<System.Int32> exceptionsSize)
{
    return ObservableExt.ZipExecute(DynamicILInfoValue, exceptions, exceptionsSize, (DynamicILInfoValueLambda, exceptionsLambda, exceptionsSizeLambda) => DynamicILInfoValueLambda.SetExceptions(exceptionsLambda, exceptionsSizeLambda));
}


public static IObservable<System.Reactive.Unit> SetLocalSignature(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.Byte[]> localSignature)
{
    return ObservableExt.ZipExecute(DynamicILInfoValue, localSignature, (DynamicILInfoValueLambda, localSignatureLambda) => DynamicILInfoValueLambda.SetLocalSignature(localSignatureLambda));
}


public static IObservable<System.Reactive.Unit> SetLocalSignature(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.Byte*> localSignature, IObservable<System.Int32> signatureSize)
{
    return ObservableExt.ZipExecute(DynamicILInfoValue, localSignature, signatureSize, (DynamicILInfoValueLambda, localSignatureLambda, signatureSizeLambda) => DynamicILInfoValueLambda.SetLocalSignature(localSignatureLambda, signatureSizeLambda));
}


public static IObservable<System.Int32> GetTokenFor(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.RuntimeMethodHandle> method)
{
    return Observable.Zip(DynamicILInfoValue, method, (DynamicILInfoValueLambda, methodLambda) => DynamicILInfoValueLambda.GetTokenFor(methodLambda));
}


public static IObservable<System.Int32> GetTokenFor(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.Reflection.Emit.DynamicMethod> method)
{
    return Observable.Zip(DynamicILInfoValue, method, (DynamicILInfoValueLambda, methodLambda) => DynamicILInfoValueLambda.GetTokenFor(methodLambda));
}


public static IObservable<System.Int32> GetTokenFor(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.RuntimeMethodHandle> method, IObservable<System.RuntimeTypeHandle> contextType)
{
    return Observable.Zip(DynamicILInfoValue, method, contextType, (DynamicILInfoValueLambda, methodLambda, contextTypeLambda) => DynamicILInfoValueLambda.GetTokenFor(methodLambda, contextTypeLambda));
}


public static IObservable<System.Int32> GetTokenFor(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.RuntimeFieldHandle> field)
{
    return Observable.Zip(DynamicILInfoValue, field, (DynamicILInfoValueLambda, fieldLambda) => DynamicILInfoValueLambda.GetTokenFor(fieldLambda));
}


public static IObservable<System.Int32> GetTokenFor(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.RuntimeFieldHandle> field, IObservable<System.RuntimeTypeHandle> contextType)
{
    return Observable.Zip(DynamicILInfoValue, field, contextType, (DynamicILInfoValueLambda, fieldLambda, contextTypeLambda) => DynamicILInfoValueLambda.GetTokenFor(fieldLambda, contextTypeLambda));
}


public static IObservable<System.Int32> GetTokenFor(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.RuntimeTypeHandle> type)
{
    return Observable.Zip(DynamicILInfoValue, type, (DynamicILInfoValueLambda, typeLambda) => DynamicILInfoValueLambda.GetTokenFor(typeLambda));
}


public static IObservable<System.Int32> GetTokenFor(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.String> literal)
{
    return Observable.Zip(DynamicILInfoValue, literal, (DynamicILInfoValueLambda, literalLambda) => DynamicILInfoValueLambda.GetTokenFor(literalLambda));
}


public static IObservable<System.Int32> GetTokenFor(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue, IObservable<System.Byte[]> signature)
{
    return Observable.Zip(DynamicILInfoValue, signature, (DynamicILInfoValueLambda, signatureLambda) => DynamicILInfoValueLambda.GetTokenFor(signatureLambda));
}


public static IObservable<System.Reflection.Emit.DynamicMethod> get_DynamicMethod(this IObservable<System.Reflection.Emit.DynamicILInfo> DynamicILInfoValue)
{
    return Observable.Select(DynamicILInfoValue, (DynamicILInfoValueLambda) => DynamicILInfoValueLambda.DynamicMethod);
}

}
}