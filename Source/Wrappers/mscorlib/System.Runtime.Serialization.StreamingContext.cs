using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __StreamingContext
    {
        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Runtime.Serialization.StreamingContext> StreamingContextValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(StreamingContextValue, obj,
                (StreamingContextValueLambda, objLambda) => StreamingContextValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Runtime.Serialization.StreamingContext> StreamingContextValue)
        {
            return Observable.Select(StreamingContextValue,
                (StreamingContextValueLambda) => StreamingContextValueLambda.GetHashCode());
        }


        public static IObservable<System.Object> get_Context(
            this IObservable<System.Runtime.Serialization.StreamingContext> StreamingContextValue)
        {
            return Observable.Select(StreamingContextValue,
                (StreamingContextValueLambda) => StreamingContextValueLambda.Context);
        }


        public static IObservable<System.Runtime.Serialization.StreamingContextStates> get_State(
            this IObservable<System.Runtime.Serialization.StreamingContext> StreamingContextValue)
        {
            return Observable.Select(StreamingContextValue,
                (StreamingContextValueLambda) => StreamingContextValueLambda.State);
        }
    }
}