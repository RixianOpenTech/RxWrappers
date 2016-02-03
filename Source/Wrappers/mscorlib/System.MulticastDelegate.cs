using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __MulticastDelegate
    {
        
        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.MulticastDelegate> MulticastDelegateValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(MulticastDelegateValue, info, context, (MulticastDelegateValueLambda, infoLambda, contextLambda) => MulticastDelegateValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.MulticastDelegate> MulticastDelegateValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(MulticastDelegateValue, obj, (MulticastDelegateValueLambda, objLambda) => MulticastDelegateValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Delegate[]> GetInvocationList(this IObservable<System.MulticastDelegate> MulticastDelegateValue)
        {
            return Observable.Select(MulticastDelegateValue, (MulticastDelegateValueLambda) => MulticastDelegateValueLambda.GetInvocationList());
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.MulticastDelegate> MulticastDelegateValue)
        {
            return Observable.Select(MulticastDelegateValue, (MulticastDelegateValueLambda) => MulticastDelegateValueLambda.GetHashCode());
        }

    }
}