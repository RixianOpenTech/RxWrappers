using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __ObjectIDGenerator
    {
        public static IObservable<Tuple<System.Int64, System.Boolean>> GetId(
            this IObservable<System.Runtime.Serialization.ObjectIDGenerator> ObjectIDGeneratorValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(ObjectIDGeneratorValue, obj, (ObjectIDGeneratorValueLambda, objLambda) =>
            {
                System.Boolean firstTimeOutput = default(System.Boolean);
                var result = ObjectIDGeneratorValueLambda.GetId(objLambda, out firstTimeOutput);
                return Tuple.Create(result, firstTimeOutput);
            });
        }


        public static IObservable<Tuple<System.Int64, System.Boolean>> HasId(
            this IObservable<System.Runtime.Serialization.ObjectIDGenerator> ObjectIDGeneratorValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(ObjectIDGeneratorValue, obj, (ObjectIDGeneratorValueLambda, objLambda) =>
            {
                System.Boolean firstTimeOutput = default(System.Boolean);
                var result = ObjectIDGeneratorValueLambda.HasId(objLambda, out firstTimeOutput);
                return Tuple.Create(result, firstTimeOutput);
            });
        }
    }
}