using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Int16
    {
        public static IObservable<System.Int32> CompareTo(this IObservable<System.Int16> Int16Value,
            IObservable<System.Object> value)
        {
            return Observable.Zip(Int16Value, value,
                (Int16ValueLambda, valueLambda) => Int16ValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.Int16> Int16Value,
            IObservable<System.Int16> value)
        {
            return Observable.Zip(Int16Value, value,
                (Int16ValueLambda, valueLambda) => Int16ValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Int16> Int16Value,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(Int16Value, obj, (Int16ValueLambda, objLambda) => Int16ValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Int16> Int16Value,
            IObservable<System.Int16> obj)
        {
            return Observable.Zip(Int16Value, obj, (Int16ValueLambda, objLambda) => Int16ValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Int16> Int16Value)
        {
            return Observable.Select(Int16Value, (Int16ValueLambda) => Int16ValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Int16> Int16Value)
        {
            return Observable.Select(Int16Value, (Int16ValueLambda) => Int16ValueLambda.ToString());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Int16> Int16Value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(Int16Value, provider,
                (Int16ValueLambda, providerLambda) => Int16ValueLambda.ToString(providerLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Int16> Int16Value,
            IObservable<System.String> format)
        {
            return Observable.Zip(Int16Value, format,
                (Int16ValueLambda, formatLambda) => Int16ValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Int16> Int16Value,
            IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(Int16Value, format, provider,
                (Int16ValueLambda, formatLambda, providerLambda) =>
                    Int16ValueLambda.ToString(formatLambda, providerLambda));
        }


        public static IObservable<System.Int16> Parse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => System.Int16.Parse(sLambda));
        }


        public static IObservable<System.Int16> Parse(IObservable<System.String> s,
            IObservable<System.Globalization.NumberStyles> style)
        {
            return Observable.Zip(s, style, (sLambda, styleLambda) => System.Int16.Parse(sLambda, styleLambda));
        }


        public static IObservable<System.Int16> Parse(IObservable<System.String> s,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, provider, (sLambda, providerLambda) => System.Int16.Parse(sLambda, providerLambda));
        }


        public static IObservable<System.Int16> Parse(IObservable<System.String> s,
            IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider,
                (sLambda, styleLambda, providerLambda) => System.Int16.Parse(sLambda, styleLambda, providerLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Int16>> TryParse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) =>
            {
                System.Int16 resultOutput = default(System.Int16);
                var result = System.Int16.TryParse(sLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<Tuple<System.Boolean, System.Int16>> TryParse(IObservable<System.String> s,
            IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) =>
            {
                System.Int16 resultOutput = default(System.Int16);
                var result = System.Int16.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.Int16> Int16Value)
        {
            return Observable.Select(Int16Value, (Int16ValueLambda) => Int16ValueLambda.GetTypeCode());
        }
    }
}