using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Tuple1
    {
        public static IObservable<System.Boolean> Equals<T1>(this IObservable<System.Tuple<T1>> TupleValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(TupleValue, obj, (TupleValueLambda, objLambda) => TupleValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode<T1>(this IObservable<System.Tuple<T1>> TupleValue)
        {
            return Observable.Select(TupleValue, (TupleValueLambda) => TupleValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString<T1>(this IObservable<System.Tuple<T1>> TupleValue)
        {
            return Observable.Select(TupleValue, (TupleValueLambda) => TupleValueLambda.ToString());
        }


        public static IObservable<T1> get_Item1<T1>(this IObservable<System.Tuple<T1>> TupleValue)
        {
            return Observable.Select(TupleValue, (TupleValueLambda) => TupleValueLambda.Item1);
        }
    }
}