using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Object
    {
        
        public static IObservable<System.Type> GetType(this IObservable<System.Object> ObjectValue)
        {
            return Observable.Select(ObjectValue, (ObjectValueLambda) => ObjectValueLambda.GetType());
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Object> ObjectValue)
        {
            return Observable.Select(ObjectValue, (ObjectValueLambda) => ObjectValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Object> ObjectValue)
        {
            return Observable.Select(ObjectValue, (ObjectValueLambda) => ObjectValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Object> ObjectValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(ObjectValue, obj, (ObjectValueLambda, objLambda) => ObjectValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals_Static(IObservable<System.Object> objA, IObservable<System.Object> objB)
        {
            return Observable.Zip(objA, objB, (objALambda, objBLambda) => System.Object.Equals(objALambda, objBLambda));
        }


        public static IObservable<System.Boolean> ReferenceEquals(IObservable<System.Object> objA, IObservable<System.Object> objB)
        {
            return Observable.Zip(objA, objB, (objALambda, objBLambda) => System.Object.ReferenceEquals(objALambda, objBLambda));
        }

    }
}