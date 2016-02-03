using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __UInt32
    {
        
        public static IObservable<System.Int32> CompareTo(this IObservable<System.UInt32> UInt32Value, IObservable<System.Object> value)
        {
            return Observable.Zip(UInt32Value, value, (UInt32ValueLambda, valueLambda) => UInt32ValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.UInt32> UInt32Value, IObservable<System.UInt32> value)
        {
            return Observable.Zip(UInt32Value, value, (UInt32ValueLambda, valueLambda) => UInt32ValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.UInt32> UInt32Value, IObservable<System.Object> obj)
        {
            return Observable.Zip(UInt32Value, obj, (UInt32ValueLambda, objLambda) => UInt32ValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.UInt32> UInt32Value, IObservable<System.UInt32> obj)
        {
            return Observable.Zip(UInt32Value, obj, (UInt32ValueLambda, objLambda) => UInt32ValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.UInt32> UInt32Value)
        {
            return Observable.Select(UInt32Value, (UInt32ValueLambda) => UInt32ValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.UInt32> UInt32Value)
        {
            return Observable.Select(UInt32Value, (UInt32ValueLambda) => UInt32ValueLambda.ToString());
        }


        public static IObservable<System.String> ToString(this IObservable<System.UInt32> UInt32Value, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(UInt32Value, provider, (UInt32ValueLambda, providerLambda) => UInt32ValueLambda.ToString(providerLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.UInt32> UInt32Value, IObservable<System.String> format)
        {
            return Observable.Zip(UInt32Value, format, (UInt32ValueLambda, formatLambda) => UInt32ValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.UInt32> UInt32Value, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(UInt32Value, format, provider, (UInt32ValueLambda, formatLambda, providerLambda) => UInt32ValueLambda.ToString(formatLambda, providerLambda));
        }


        public static IObservable<System.UInt32> Parse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => System.UInt32.Parse(sLambda));
        }


        public static IObservable<System.UInt32> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style)
        {
            return Observable.Zip(s, style, (sLambda, styleLambda) => System.UInt32.Parse(sLambda, styleLambda));
        }


        public static IObservable<System.UInt32> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, provider, (sLambda, providerLambda) => System.UInt32.Parse(sLambda, providerLambda));
        }


        public static IObservable<System.UInt32> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => System.UInt32.Parse(sLambda, styleLambda, providerLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.UInt32>> TryParse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => {
System.UInt32 resultOutput = default(System.UInt32);
var result = System.UInt32.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<Tuple<System.Boolean, System.UInt32>> TryParse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => {
System.UInt32 resultOutput = default(System.UInt32);
var result = System.UInt32.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.UInt32> UInt32Value)
        {
            return Observable.Select(UInt32Value, (UInt32ValueLambda) => UInt32ValueLambda.GetTypeCode());
        }

    }
}