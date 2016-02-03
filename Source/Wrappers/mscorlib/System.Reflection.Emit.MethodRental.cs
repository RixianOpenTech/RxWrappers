using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
public static class _MethodRental
{
    
public static IObservable<System.Reactive.Unit> SwapMethodBody(IObservable<System.Type> cls, IObservable<System.Int32> methodtoken, IObservable<System.IntPtr> rgIL, IObservable<System.Int32> methodSize, IObservable<System.Int32> flags)
{
    return ObservableExt.ZipExecute(cls, methodtoken, rgIL, methodSize, flags, (clsLambda, methodtokenLambda, rgILLambda, methodSizeLambda, flagsLambda) => System.Reflection.Emit.MethodRental.SwapMethodBody(clsLambda, methodtokenLambda, rgILLambda, methodSizeLambda, flagsLambda));
}

}
}