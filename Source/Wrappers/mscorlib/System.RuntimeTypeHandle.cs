using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __RuntimeTypeHandle
    {
        
        public static IObservable<System.Int32> GetHashCode(this IObservable<System.RuntimeTypeHandle> RuntimeTypeHandleValue)
        {
            return Observable.Select(RuntimeTypeHandleValue, (RuntimeTypeHandleValueLambda) => RuntimeTypeHandleValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.RuntimeTypeHandle> RuntimeTypeHandleValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(RuntimeTypeHandleValue, obj, (RuntimeTypeHandleValueLambda, objLambda) => RuntimeTypeHandleValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.RuntimeTypeHandle> RuntimeTypeHandleValue, IObservable<System.RuntimeTypeHandle> handle)
        {
            return Observable.Zip(RuntimeTypeHandleValue, handle, (RuntimeTypeHandleValueLambda, handleLambda) => RuntimeTypeHandleValueLambda.Equals(handleLambda));
        }


        public static IObservable<System.ModuleHandle> GetModuleHandle(this IObservable<System.RuntimeTypeHandle> RuntimeTypeHandleValue)
        {
            return Observable.Select(RuntimeTypeHandleValue, (RuntimeTypeHandleValueLambda) => RuntimeTypeHandleValueLambda.GetModuleHandle());
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.RuntimeTypeHandle> RuntimeTypeHandleValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(RuntimeTypeHandleValue, info, context, (RuntimeTypeHandleValueLambda, infoLambda, contextLambda) => RuntimeTypeHandleValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.IntPtr> get_Value(this IObservable<System.RuntimeTypeHandle> RuntimeTypeHandleValue)
        {
            return Observable.Select(RuntimeTypeHandleValue, (RuntimeTypeHandleValueLambda) => RuntimeTypeHandleValueLambda.Value);
        }

    }
}