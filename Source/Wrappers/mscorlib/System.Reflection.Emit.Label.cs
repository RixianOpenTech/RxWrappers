using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __Label
    {
        
        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.Label> LabelValue)
        {
            return Observable.Select(LabelValue, (LabelValueLambda) => LabelValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.Label> LabelValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(LabelValue, obj, (LabelValueLambda, objLambda) => LabelValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.Label> LabelValue, IObservable<System.Reflection.Emit.Label> obj)
        {
            return Observable.Zip(LabelValue, obj, (LabelValueLambda, objLambda) => LabelValueLambda.Equals(objLambda));
        }

    }
}