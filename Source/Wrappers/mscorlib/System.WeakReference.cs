using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __WeakReference
    {
        
        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.WeakReference> WeakReferenceValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(WeakReferenceValue, info, context, (WeakReferenceValueLambda, infoLambda, contextLambda) => WeakReferenceValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Boolean> get_IsAlive(this IObservable<System.WeakReference> WeakReferenceValue)
        {
            return Observable.Select(WeakReferenceValue, (WeakReferenceValueLambda) => WeakReferenceValueLambda.IsAlive);
        }


        public static IObservable<System.Boolean> get_TrackResurrection(this IObservable<System.WeakReference> WeakReferenceValue)
        {
            return Observable.Select(WeakReferenceValue, (WeakReferenceValueLambda) => WeakReferenceValueLambda.TrackResurrection);
        }


        public static IObservable<System.Object> get_Target(this IObservable<System.WeakReference> WeakReferenceValue)
        {
            return Observable.Select(WeakReferenceValue, (WeakReferenceValueLambda) => WeakReferenceValueLambda.Target);
        }


        public static IObservable<System.Reactive.Unit> set_Target(this IObservable<System.WeakReference> WeakReferenceValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(WeakReferenceValue, value, (WeakReferenceValueLambda, valueLambda) => WeakReferenceValueLambda.Target = valueLambda);
        }

    }
}