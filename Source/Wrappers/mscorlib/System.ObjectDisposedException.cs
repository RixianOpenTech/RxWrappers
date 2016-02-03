using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __ObjectDisposedException
    {
        
        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.ObjectDisposedException> ObjectDisposedExceptionValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(ObjectDisposedExceptionValue, info, context, (ObjectDisposedExceptionValueLambda, infoLambda, contextLambda) => ObjectDisposedExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_Message(this IObservable<System.ObjectDisposedException> ObjectDisposedExceptionValue)
        {
            return Observable.Select(ObjectDisposedExceptionValue, (ObjectDisposedExceptionValueLambda) => ObjectDisposedExceptionValueLambda.Message);
        }


        public static IObservable<System.String> get_ObjectName(this IObservable<System.ObjectDisposedException> ObjectDisposedExceptionValue)
        {
            return Observable.Select(ObjectDisposedExceptionValue, (ObjectDisposedExceptionValueLambda) => ObjectDisposedExceptionValueLambda.ObjectName);
        }

    }
}