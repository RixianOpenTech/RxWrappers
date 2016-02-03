using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Double
    {
        
        public static IObservable<System.Boolean> IsInfinity(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Double.IsInfinity(dLambda));
        }


        public static IObservable<System.Boolean> IsPositiveInfinity(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Double.IsPositiveInfinity(dLambda));
        }


        public static IObservable<System.Boolean> IsNegativeInfinity(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Double.IsNegativeInfinity(dLambda));
        }


        public static IObservable<System.Boolean> IsNaN(IObservable<System.Double> d)
        {
            return Observable.Select(d, (dLambda) => System.Double.IsNaN(dLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.Double> DoubleValue, IObservable<System.Object> value)
        {
            return Observable.Zip(DoubleValue, value, (DoubleValueLambda, valueLambda) => DoubleValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.Double> DoubleValue, IObservable<System.Double> value)
        {
            return Observable.Zip(DoubleValue, value, (DoubleValueLambda, valueLambda) => DoubleValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Double> DoubleValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(DoubleValue, obj, (DoubleValueLambda, objLambda) => DoubleValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Double> DoubleValue, IObservable<System.Double> obj)
        {
            return Observable.Zip(DoubleValue, obj, (DoubleValueLambda, objLambda) => DoubleValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Double> DoubleValue)
        {
            return Observable.Select(DoubleValue, (DoubleValueLambda) => DoubleValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Double> DoubleValue)
        {
            return Observable.Select(DoubleValue, (DoubleValueLambda) => DoubleValueLambda.ToString());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Double> DoubleValue, IObservable<System.String> format)
        {
            return Observable.Zip(DoubleValue, format, (DoubleValueLambda, formatLambda) => DoubleValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Double> DoubleValue, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(DoubleValue, provider, (DoubleValueLambda, providerLambda) => DoubleValueLambda.ToString(providerLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Double> DoubleValue, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(DoubleValue, format, provider, (DoubleValueLambda, formatLambda, providerLambda) => DoubleValueLambda.ToString(formatLambda, providerLambda));
        }


        public static IObservable<System.Double> Parse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => System.Double.Parse(sLambda));
        }


        public static IObservable<System.Double> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style)
        {
            return Observable.Zip(s, style, (sLambda, styleLambda) => System.Double.Parse(sLambda, styleLambda));
        }


        public static IObservable<System.Double> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, provider, (sLambda, providerLambda) => System.Double.Parse(sLambda, providerLambda));
        }


        public static IObservable<System.Double> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => System.Double.Parse(sLambda, styleLambda, providerLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Double>> TryParse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => {
System.Double resultOutput = default(System.Double);
var result = System.Double.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<Tuple<System.Boolean, System.Double>> TryParse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => {
System.Double resultOutput = default(System.Double);
var result = System.Double.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.Double> DoubleValue)
        {
            return Observable.Select(DoubleValue, (DoubleValueLambda) => DoubleValueLambda.GetTypeCode());
        }

    }
}