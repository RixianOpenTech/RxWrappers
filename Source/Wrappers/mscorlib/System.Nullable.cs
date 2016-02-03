using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Nullable
    {
        public static IObservable<System.Int32> Compare<T>(IObservable<Nullable<T>> n1, IObservable<Nullable<T>> n2)
            where T : struct
        {
            return Observable.Zip(n1, n2, (n1Lambda, n2Lambda) => System.Nullable.Compare(n1Lambda, n2Lambda));
        }


        public static IObservable<System.Boolean> Equals<T>(IObservable<Nullable<T>> n1, IObservable<Nullable<T>> n2)
            where T : struct
        {
            return Observable.Zip(n1, n2, (n1Lambda, n2Lambda) => System.Nullable.Equals(n1Lambda, n2Lambda));
        }


        public static IObservable<System.Type> GetUnderlyingType(IObservable<System.Type> nullableType)
        {
            return Observable.Select(nullableType,
                (nullableTypeLambda) => System.Nullable.GetUnderlyingType(nullableTypeLambda));
        }
    }
}