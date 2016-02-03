using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __HandleRef
    {
        
        public static IObservable<System.IntPtr> ToIntPtr(IObservable<System.Runtime.InteropServices.HandleRef> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.InteropServices.HandleRef.ToIntPtr(valueLambda));
        }


        public static IObservable<System.Object> get_Wrapper(this IObservable<System.Runtime.InteropServices.HandleRef> HandleRefValue)
        {
            return Observable.Select(HandleRefValue, (HandleRefValueLambda) => HandleRefValueLambda.Wrapper);
        }


        public static IObservable<System.IntPtr> get_Handle(this IObservable<System.Runtime.InteropServices.HandleRef> HandleRefValue)
        {
            return Observable.Select(HandleRefValue, (HandleRefValueLambda) => HandleRefValueLambda.Handle);
        }

    }
}