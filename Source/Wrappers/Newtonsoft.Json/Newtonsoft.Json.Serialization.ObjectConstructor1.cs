using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __ObjectConstructor1
    {
        
        public static IObservable<System.Object> Invoke<T>(this IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<T>> ObjectConstructorValue, IObservable<System.Object[]> args)
        {
            return Observable.Zip(ObjectConstructorValue, args, (ObjectConstructorValueLambda, argsLambda) => ObjectConstructorValueLambda.Invoke(argsLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<T>(this IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<T>> ObjectConstructorValue, IObservable<System.Object[]> args, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ObjectConstructorValue, args, callback, @object, (ObjectConstructorValueLambda, argsLambda, callbackLambda, @objectLambda) => ObjectConstructorValueLambda.BeginInvoke(argsLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Object> EndInvoke<T>(this IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<T>> ObjectConstructorValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(ObjectConstructorValue, result, (ObjectConstructorValueLambda, resultLambda) => ObjectConstructorValueLambda.EndInvoke(resultLambda));
        }

    }
}