using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _Pointer
{
    
public static IObservable<System.Object> Box(IObservable<System.Void*> ptr, IObservable<System.Type> type)
{
    return Observable.Zip(ptr, type, (ptrLambda, typeLambda) => System.Reflection.Pointer.Box(ptrLambda, typeLambda));
}


public static IObservable<System.Void*> Unbox(IObservable<System.Object> ptr)
{
    return Observable.Select(ptr, (ptrLambda) => System.Reflection.Pointer.Unbox(ptrLambda));
}

}
}