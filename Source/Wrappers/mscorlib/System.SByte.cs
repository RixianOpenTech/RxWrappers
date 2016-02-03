using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __SByte
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.SByte> SByteValue)
        {
            return Observable.Select(SByteValue, (SByteValueLambda) => SByteValueLambda.ToString());
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.SByte> SByteValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(SByteValue, obj, (SByteValueLambda, objLambda) => SByteValueLambda.CompareTo(objLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.SByte> SByteValue, IObservable<System.SByte> value)
        {
            return Observable.Zip(SByteValue, value, (SByteValueLambda, valueLambda) => SByteValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.SByte> SByteValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(SByteValue, obj, (SByteValueLambda, objLambda) => SByteValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.SByte> SByteValue, IObservable<System.SByte> obj)
        {
            return Observable.Zip(SByteValue, obj, (SByteValueLambda, objLambda) => SByteValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.SByte> SByteValue)
        {
            return Observable.Select(SByteValue, (SByteValueLambda) => SByteValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.SByte> SByteValue, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(SByteValue, provider, (SByteValueLambda, providerLambda) => SByteValueLambda.ToString(providerLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.SByte> SByteValue, IObservable<System.String> format)
        {
            return Observable.Zip(SByteValue, format, (SByteValueLambda, formatLambda) => SByteValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.SByte> SByteValue, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(SByteValue, format, provider, (SByteValueLambda, formatLambda, providerLambda) => SByteValueLambda.ToString(formatLambda, providerLambda));
        }


        public static IObservable<System.SByte> Parse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => System.SByte.Parse(sLambda));
        }


        public static IObservable<System.SByte> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style)
        {
            return Observable.Zip(s, style, (sLambda, styleLambda) => System.SByte.Parse(sLambda, styleLambda));
        }


        public static IObservable<System.SByte> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, provider, (sLambda, providerLambda) => System.SByte.Parse(sLambda, providerLambda));
        }


        public static IObservable<System.SByte> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => System.SByte.Parse(sLambda, styleLambda, providerLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.SByte>> TryParse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => {
System.SByte resultOutput = default(System.SByte);
var result = System.SByte.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<Tuple<System.Boolean, System.SByte>> TryParse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => {
System.SByte resultOutput = default(System.SByte);
var result = System.SByte.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.SByte> SByteValue)
        {
            return Observable.Select(SByteValue, (SByteValueLambda) => SByteValueLambda.GetTypeCode());
        }

    }
}