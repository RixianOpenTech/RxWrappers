using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __UIntPtr
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.UIntPtr> UIntPtrValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(UIntPtrValue, obj, (UIntPtrValueLambda, objLambda) => UIntPtrValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.UIntPtr> UIntPtrValue)
        {
            return Observable.Select(UIntPtrValue, (UIntPtrValueLambda) => UIntPtrValueLambda.GetHashCode());
        }


        public static IObservable<System.UInt32> ToUInt32(this IObservable<System.UIntPtr> UIntPtrValue)
        {
            return Observable.Select(UIntPtrValue, (UIntPtrValueLambda) => UIntPtrValueLambda.ToUInt32());
        }


        public static IObservable<System.UInt64> ToUInt64(this IObservable<System.UIntPtr> UIntPtrValue)
        {
            return Observable.Select(UIntPtrValue, (UIntPtrValueLambda) => UIntPtrValueLambda.ToUInt64());
        }


        public static IObservable<System.String> ToString(this IObservable<System.UIntPtr> UIntPtrValue)
        {
            return Observable.Select(UIntPtrValue, (UIntPtrValueLambda) => UIntPtrValueLambda.ToString());
        }


        public static IObservable<System.UIntPtr> Add(IObservable<System.UIntPtr> pointer, IObservable<System.Int32> offset)
        {
            return Observable.Zip(pointer, offset, (pointerLambda, offsetLambda) => System.UIntPtr.Add(pointerLambda, offsetLambda));
        }


        public static IObservable<System.UIntPtr> Subtract(IObservable<System.UIntPtr> pointer, IObservable<System.Int32> offset)
        {
            return Observable.Zip(pointer, offset, (pointerLambda, offsetLambda) => System.UIntPtr.Subtract(pointerLambda, offsetLambda));
        }


        public static IObservable<System.Int32> get_Size()
        {
            return ObservableExt.Factory(() => System.UIntPtr.Size);
        }

    }
}