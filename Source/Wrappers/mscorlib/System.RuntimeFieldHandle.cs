using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __RuntimeFieldHandle
    {
        
        public static IObservable<System.Int32> GetHashCode(this IObservable<System.RuntimeFieldHandle> RuntimeFieldHandleValue)
        {
            return Observable.Select(RuntimeFieldHandleValue, (RuntimeFieldHandleValueLambda) => RuntimeFieldHandleValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.RuntimeFieldHandle> RuntimeFieldHandleValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(RuntimeFieldHandleValue, obj, (RuntimeFieldHandleValueLambda, objLambda) => RuntimeFieldHandleValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.RuntimeFieldHandle> RuntimeFieldHandleValue, IObservable<System.RuntimeFieldHandle> handle)
        {
            return Observable.Zip(RuntimeFieldHandleValue, handle, (RuntimeFieldHandleValueLambda, handleLambda) => RuntimeFieldHandleValueLambda.Equals(handleLambda));
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.RuntimeFieldHandle> RuntimeFieldHandleValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(RuntimeFieldHandleValue, info, context, (RuntimeFieldHandleValueLambda, infoLambda, contextLambda) => RuntimeFieldHandleValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.IntPtr> get_Value(this IObservable<System.RuntimeFieldHandle> RuntimeFieldHandleValue)
        {
            return Observable.Select(RuntimeFieldHandleValue, (RuntimeFieldHandleValueLambda) => RuntimeFieldHandleValueLambda.Value);
        }

    }
}