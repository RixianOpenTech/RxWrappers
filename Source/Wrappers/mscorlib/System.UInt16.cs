using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __UInt16
    {
        
        public static IObservable<System.Int32> CompareTo(this IObservable<System.UInt16> UInt16Value, IObservable<System.Object> value)
        {
            return Observable.Zip(UInt16Value, value, (UInt16ValueLambda, valueLambda) => UInt16ValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.UInt16> UInt16Value, IObservable<System.UInt16> value)
        {
            return Observable.Zip(UInt16Value, value, (UInt16ValueLambda, valueLambda) => UInt16ValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.UInt16> UInt16Value, IObservable<System.Object> obj)
        {
            return Observable.Zip(UInt16Value, obj, (UInt16ValueLambda, objLambda) => UInt16ValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.UInt16> UInt16Value, IObservable<System.UInt16> obj)
        {
            return Observable.Zip(UInt16Value, obj, (UInt16ValueLambda, objLambda) => UInt16ValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.UInt16> UInt16Value)
        {
            return Observable.Select(UInt16Value, (UInt16ValueLambda) => UInt16ValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.UInt16> UInt16Value)
        {
            return Observable.Select(UInt16Value, (UInt16ValueLambda) => UInt16ValueLambda.ToString());
        }


        public static IObservable<System.String> ToString(this IObservable<System.UInt16> UInt16Value, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(UInt16Value, provider, (UInt16ValueLambda, providerLambda) => UInt16ValueLambda.ToString(providerLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.UInt16> UInt16Value, IObservable<System.String> format)
        {
            return Observable.Zip(UInt16Value, format, (UInt16ValueLambda, formatLambda) => UInt16ValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.UInt16> UInt16Value, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(UInt16Value, format, provider, (UInt16ValueLambda, formatLambda, providerLambda) => UInt16ValueLambda.ToString(formatLambda, providerLambda));
        }


        public static IObservable<System.UInt16> Parse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => System.UInt16.Parse(sLambda));
        }


        public static IObservable<System.UInt16> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style)
        {
            return Observable.Zip(s, style, (sLambda, styleLambda) => System.UInt16.Parse(sLambda, styleLambda));
        }


        public static IObservable<System.UInt16> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, provider, (sLambda, providerLambda) => System.UInt16.Parse(sLambda, providerLambda));
        }


        public static IObservable<System.UInt16> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => System.UInt16.Parse(sLambda, styleLambda, providerLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.UInt16>> TryParse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => {
System.UInt16 resultOutput = default(System.UInt16);
var result = System.UInt16.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<Tuple<System.Boolean, System.UInt16>> TryParse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => {
System.UInt16 resultOutput = default(System.UInt16);
var result = System.UInt16.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.UInt16> UInt16Value)
        {
            return Observable.Select(UInt16Value, (UInt16ValueLambda) => UInt16ValueLambda.GetTypeCode());
        }

    }
}