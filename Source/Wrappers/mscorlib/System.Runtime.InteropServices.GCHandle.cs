using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __GCHandle
    {
        
        public static IObservable<System.Runtime.InteropServices.GCHandle> Alloc(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.InteropServices.GCHandle.Alloc(valueLambda));
        }


        public static IObservable<System.Runtime.InteropServices.GCHandle> Alloc(IObservable<System.Object> value, IObservable<System.Runtime.InteropServices.GCHandleType> type)
        {
            return Observable.Zip(value, type, (valueLambda, typeLambda) => System.Runtime.InteropServices.GCHandle.Alloc(valueLambda, typeLambda));
        }


        public static IObservable<System.Reactive.Unit> Free(this IObservable<System.Runtime.InteropServices.GCHandle> GCHandleValue)
        {
            return Observable.Do(GCHandleValue, (GCHandleValueLambda) => GCHandleValueLambda.Free()).ToUnit();
        }


        public static IObservable<System.IntPtr> AddrOfPinnedObject(this IObservable<System.Runtime.InteropServices.GCHandle> GCHandleValue)
        {
            return Observable.Select(GCHandleValue, (GCHandleValueLambda) => GCHandleValueLambda.AddrOfPinnedObject());
        }


        public static IObservable<System.Runtime.InteropServices.GCHandle> FromIntPtr(IObservable<System.IntPtr> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.InteropServices.GCHandle.FromIntPtr(valueLambda));
        }


        public static IObservable<System.IntPtr> ToIntPtr(IObservable<System.Runtime.InteropServices.GCHandle> value)
        {
            return Observable.Select(value, (valueLambda) => System.Runtime.InteropServices.GCHandle.ToIntPtr(valueLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Runtime.InteropServices.GCHandle> GCHandleValue)
        {
            return Observable.Select(GCHandleValue, (GCHandleValueLambda) => GCHandleValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Runtime.InteropServices.GCHandle> GCHandleValue, IObservable<System.Object> o)
        {
            return Observable.Zip(GCHandleValue, o, (GCHandleValueLambda, oLambda) => GCHandleValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Object> get_Target(this IObservable<System.Runtime.InteropServices.GCHandle> GCHandleValue)
        {
            return Observable.Select(GCHandleValue, (GCHandleValueLambda) => GCHandleValueLambda.Target);
        }


        public static IObservable<System.Boolean> get_IsAllocated(this IObservable<System.Runtime.InteropServices.GCHandle> GCHandleValue)
        {
            return Observable.Select(GCHandleValue, (GCHandleValueLambda) => GCHandleValueLambda.IsAllocated);
        }


        public static IObservable<System.Reactive.Unit> set_Target(this IObservable<System.Runtime.InteropServices.GCHandle> GCHandleValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(GCHandleValue, value, (GCHandleValueLambda, valueLambda) => GCHandleValueLambda.Target = valueLambda);
        }

    }
}