using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __IntPtr
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.IntPtr> IntPtrValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(IntPtrValue, obj, (IntPtrValueLambda, objLambda) => IntPtrValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.IntPtr> IntPtrValue)
        {
            return Observable.Select(IntPtrValue, (IntPtrValueLambda) => IntPtrValueLambda.GetHashCode());
        }


        public static IObservable<System.Int32> ToInt32(this IObservable<System.IntPtr> IntPtrValue)
        {
            return Observable.Select(IntPtrValue, (IntPtrValueLambda) => IntPtrValueLambda.ToInt32());
        }


        public static IObservable<System.Int64> ToInt64(this IObservable<System.IntPtr> IntPtrValue)
        {
            return Observable.Select(IntPtrValue, (IntPtrValueLambda) => IntPtrValueLambda.ToInt64());
        }


        public static IObservable<System.String> ToString(this IObservable<System.IntPtr> IntPtrValue)
        {
            return Observable.Select(IntPtrValue, (IntPtrValueLambda) => IntPtrValueLambda.ToString());
        }


        public static IObservable<System.String> ToString(this IObservable<System.IntPtr> IntPtrValue, IObservable<System.String> format)
        {
            return Observable.Zip(IntPtrValue, format, (IntPtrValueLambda, formatLambda) => IntPtrValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.IntPtr> Add(IObservable<System.IntPtr> pointer, IObservable<System.Int32> offset)
        {
            return Observable.Zip(pointer, offset, (pointerLambda, offsetLambda) => System.IntPtr.Add(pointerLambda, offsetLambda));
        }


        public static IObservable<System.IntPtr> Subtract(IObservable<System.IntPtr> pointer, IObservable<System.Int32> offset)
        {
            return Observable.Zip(pointer, offset, (pointerLambda, offsetLambda) => System.IntPtr.Subtract(pointerLambda, offsetLambda));
        }


        public static IObservable<System.Int32> get_Size()
        {
            return ObservableExt.Factory(() => System.IntPtr.Size);
        }

    }
}