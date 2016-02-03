using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Tuple5
    {
        
        public static IObservable<System.Boolean> Equals<T1, T2, T3, T4, T5>(this IObservable<System.Tuple<T1, T2, T3, T4, T5>> TupleValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(TupleValue, obj, (TupleValueLambda, objLambda) => TupleValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode<T1, T2, T3, T4, T5>(this IObservable<System.Tuple<T1, T2, T3, T4, T5>> TupleValue)
        {
            return Observable.Select(TupleValue, (TupleValueLambda) => TupleValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString<T1, T2, T3, T4, T5>(this IObservable<System.Tuple<T1, T2, T3, T4, T5>> TupleValue)
        {
            return Observable.Select(TupleValue, (TupleValueLambda) => TupleValueLambda.ToString());
        }


        public static IObservable<T1> get_Item1<T1, T2, T3, T4, T5>(this IObservable<System.Tuple<T1, T2, T3, T4, T5>> TupleValue)
        {
            return Observable.Select(TupleValue, (TupleValueLambda) => TupleValueLambda.Item1);
        }


        public static IObservable<T2> get_Item2<T1, T2, T3, T4, T5>(this IObservable<System.Tuple<T1, T2, T3, T4, T5>> TupleValue)
        {
            return Observable.Select(TupleValue, (TupleValueLambda) => TupleValueLambda.Item2);
        }


        public static IObservable<T3> get_Item3<T1, T2, T3, T4, T5>(this IObservable<System.Tuple<T1, T2, T3, T4, T5>> TupleValue)
        {
            return Observable.Select(TupleValue, (TupleValueLambda) => TupleValueLambda.Item3);
        }


        public static IObservable<T4> get_Item4<T1, T2, T3, T4, T5>(this IObservable<System.Tuple<T1, T2, T3, T4, T5>> TupleValue)
        {
            return Observable.Select(TupleValue, (TupleValueLambda) => TupleValueLambda.Item4);
        }


        public static IObservable<T5> get_Item5<T1, T2, T3, T4, T5>(this IObservable<System.Tuple<T1, T2, T3, T4, T5>> TupleValue)
        {
            return Observable.Select(TupleValue, (TupleValueLambda) => TupleValueLambda.Item5);
        }

    }
}