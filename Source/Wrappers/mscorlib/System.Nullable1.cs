using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Nullable1
    {
        public static IObservable<T> GetValueOrDefault<T>(this IObservable<System.Nullable<T>> NullableValue)
            where T : struct
        {
            return Observable.Select(NullableValue, (NullableValueLambda) => NullableValueLambda.GetValueOrDefault());
        }


        public static IObservable<T> GetValueOrDefault<T>(this IObservable<System.Nullable<T>> NullableValue,
            IObservable<T> defaultValue) where T : struct
        {
            return Observable.Zip(NullableValue, defaultValue,
                (NullableValueLambda, defaultValueLambda) => NullableValueLambda.GetValueOrDefault(defaultValueLambda));
        }


        public static IObservable<System.Boolean> Equals<T>(this IObservable<System.Nullable<T>> NullableValue,
            IObservable<System.Object> other) where T : struct
        {
            return Observable.Zip(NullableValue, other,
                (NullableValueLambda, otherLambda) => NullableValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode<T>(this IObservable<System.Nullable<T>> NullableValue)
            where T : struct
        {
            return Observable.Select(NullableValue, (NullableValueLambda) => NullableValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString<T>(this IObservable<System.Nullable<T>> NullableValue)
            where T : struct
        {
            return Observable.Select(NullableValue, (NullableValueLambda) => NullableValueLambda.ToString());
        }


        public static IObservable<System.Boolean> get_HasValue<T>(this IObservable<System.Nullable<T>> NullableValue)
            where T : struct
        {
            return Observable.Select(NullableValue, (NullableValueLambda) => NullableValueLambda.HasValue);
        }


        public static IObservable<T> get_Value<T>(this IObservable<System.Nullable<T>> NullableValue) where T : struct
        {
            return Observable.Select(NullableValue, (NullableValueLambda) => NullableValueLambda.Value);
        }
    }
}