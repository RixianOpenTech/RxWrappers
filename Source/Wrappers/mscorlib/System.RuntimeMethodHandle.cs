using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __RuntimeMethodHandle
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.RuntimeMethodHandle> RuntimeMethodHandleValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(RuntimeMethodHandleValue, info, context,
                (RuntimeMethodHandleValueLambda, infoLambda, contextLambda) =>
                    RuntimeMethodHandleValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.RuntimeMethodHandle> RuntimeMethodHandleValue)
        {
            return Observable.Select(RuntimeMethodHandleValue,
                (RuntimeMethodHandleValueLambda) => RuntimeMethodHandleValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.RuntimeMethodHandle> RuntimeMethodHandleValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(RuntimeMethodHandleValue, obj,
                (RuntimeMethodHandleValueLambda, objLambda) => RuntimeMethodHandleValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.RuntimeMethodHandle> RuntimeMethodHandleValue,
            IObservable<System.RuntimeMethodHandle> handle)
        {
            return Observable.Zip(RuntimeMethodHandleValue, handle,
                (RuntimeMethodHandleValueLambda, handleLambda) => RuntimeMethodHandleValueLambda.Equals(handleLambda));
        }


        public static IObservable<System.IntPtr> GetFunctionPointer(
            this IObservable<System.RuntimeMethodHandle> RuntimeMethodHandleValue)
        {
            return Observable.Select(RuntimeMethodHandleValue,
                (RuntimeMethodHandleValueLambda) => RuntimeMethodHandleValueLambda.GetFunctionPointer());
        }


        public static IObservable<System.IntPtr> get_Value(
            this IObservable<System.RuntimeMethodHandle> RuntimeMethodHandleValue)
        {
            return Observable.Select(RuntimeMethodHandleValue,
                (RuntimeMethodHandleValueLambda) => RuntimeMethodHandleValueLambda.Value);
        }
    }
}