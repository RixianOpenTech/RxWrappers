using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Decimal
    {
        
        public static IObservable<System.Int64> ToOACurrency(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Decimal.ToOACurrency(valueLambda));
        }


        public static IObservable<System.Decimal> FromOACurrency(IObservable<System.Int64> cy)
        {
            return Observable.Select(cy, (cyLambda) => System.Decimal.FromOACurrency(cyLambda));
        }


        public static IObservable<System.Decimal> Add(IObservable<System.Decimal> d1, IObservable<System.Decimal> d2)
        {
            return Observable.Zip(d1, d2, (d1Lambda, d2Lambda) => System.Decimal.Add(d1Lambda, d2Lambda));
        }


        public static IObservable<System.Decimal> Ceiling(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.Ceiling(dLambda));
        }


        public static IObservable<System.Int32> Compare(IObservable<System.Decimal> d1, IObservable<System.Decimal> d2)
        {
            return Observable.Zip(d1, d2, (d1Lambda, d2Lambda) => System.Decimal.Compare(d1Lambda, d2Lambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.Decimal> DecimalValue, IObservable<System.Object> value)
        {
            return Observable.Zip(DecimalValue, value, (DecimalValueLambda, valueLambda) => DecimalValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.Decimal> DecimalValue, IObservable<System.Decimal> value)
        {
            return Observable.Zip(DecimalValue, value, (DecimalValueLambda, valueLambda) => DecimalValueLambda.CompareTo(valueLambda));
        }


        public static IObservable<System.Decimal> Divide(IObservable<System.Decimal> d1, IObservable<System.Decimal> d2)
        {
            return Observable.Zip(d1, d2, (d1Lambda, d2Lambda) => System.Decimal.Divide(d1Lambda, d2Lambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Decimal> DecimalValue, IObservable<System.Object> value)
        {
            return Observable.Zip(DecimalValue, value, (DecimalValueLambda, valueLambda) => DecimalValueLambda.Equals(valueLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Decimal> DecimalValue, IObservable<System.Decimal> value)
        {
            return Observable.Zip(DecimalValue, value, (DecimalValueLambda, valueLambda) => DecimalValueLambda.Equals(valueLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Decimal> DecimalValue)
        {
            return Observable.Select(DecimalValue, (DecimalValueLambda) => DecimalValueLambda.GetHashCode());
        }
        

        public static IObservable<System.Decimal> Floor(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.Floor(dLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Decimal> DecimalValue)
        {
            return Observable.Select(DecimalValue, (DecimalValueLambda) => DecimalValueLambda.ToString());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Decimal> DecimalValue, IObservable<System.String> format)
        {
            return Observable.Zip(DecimalValue, format, (DecimalValueLambda, formatLambda) => DecimalValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Decimal> DecimalValue, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(DecimalValue, provider, (DecimalValueLambda, providerLambda) => DecimalValueLambda.ToString(providerLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Decimal> DecimalValue, IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(DecimalValue, format, provider, (DecimalValueLambda, formatLambda, providerLambda) => DecimalValueLambda.ToString(formatLambda, providerLambda));
        }


        public static IObservable<System.Decimal> Parse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => System.Decimal.Parse(sLambda));
        }


        public static IObservable<System.Decimal> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style)
        {
            return Observable.Zip(s, style, (sLambda, styleLambda) => System.Decimal.Parse(sLambda, styleLambda));
        }


        public static IObservable<System.Decimal> Parse(IObservable<System.String> s, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, provider, (sLambda, providerLambda) => System.Decimal.Parse(sLambda, providerLambda));
        }


        public static IObservable<System.Decimal> Parse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => System.Decimal.Parse(sLambda, styleLambda, providerLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Decimal>> TryParse(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => {
System.Decimal resultOutput = default(System.Decimal);
var result = System.Decimal.TryParse(sLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<Tuple<System.Boolean, System.Decimal>> TryParse(IObservable<System.String> s, IObservable<System.Globalization.NumberStyles> style, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(s, style, provider, (sLambda, styleLambda, providerLambda) => {
System.Decimal resultOutput = default(System.Decimal);
var result = System.Decimal.TryParse(sLambda, styleLambda, providerLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<System.Int32[]> GetBits(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.GetBits(dLambda));
        }


        public static IObservable<System.Decimal> Remainder(IObservable<System.Decimal> d1, IObservable<System.Decimal> d2)
        {
            return Observable.Zip(d1, d2, (d1Lambda, d2Lambda) => System.Decimal.Remainder(d1Lambda, d2Lambda));
        }


        public static IObservable<System.Decimal> Multiply(IObservable<System.Decimal> d1, IObservable<System.Decimal> d2)
        {
            return Observable.Zip(d1, d2, (d1Lambda, d2Lambda) => System.Decimal.Multiply(d1Lambda, d2Lambda));
        }


        public static IObservable<System.Decimal> Negate(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.Negate(dLambda));
        }


        public static IObservable<System.Decimal> Round(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.Round(dLambda));
        }


        public static IObservable<System.Decimal> Round(IObservable<System.Decimal> d, IObservable<System.Int32> decimals)
        {
            return Observable.Zip(d, decimals, (dLambda, decimalsLambda) => System.Decimal.Round(dLambda, decimalsLambda));
        }


        public static IObservable<System.Decimal> Round(IObservable<System.Decimal> d, IObservable<System.MidpointRounding> mode)
        {
            return Observable.Zip(d, mode, (dLambda, modeLambda) => System.Decimal.Round(dLambda, modeLambda));
        }


        public static IObservable<System.Decimal> Round(IObservable<System.Decimal> d, IObservable<System.Int32> decimals, IObservable<System.MidpointRounding> mode)
        {
            return Observable.Zip(d, decimals, mode, (dLambda, decimalsLambda, modeLambda) => System.Decimal.Round(dLambda, decimalsLambda, modeLambda));
        }


        public static IObservable<System.Decimal> Subtract(IObservable<System.Decimal> d1, IObservable<System.Decimal> d2)
        {
            return Observable.Zip(d1, d2, (d1Lambda, d2Lambda) => System.Decimal.Subtract(d1Lambda, d2Lambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Decimal.ToByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Decimal.ToSByte(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Decimal.ToInt16(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.ToDouble(dLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.ToInt32(dLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.ToInt64(dLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Decimal.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.ToUInt32(dLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.ToUInt64(dLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.ToSingle(dLambda));
        }


        public static IObservable<System.Decimal> Truncate(IObservable<System.Decimal> d)
        {
            return Observable.Select(d, (dLambda) => System.Decimal.Truncate(dLambda));
        }


        public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.Decimal> DecimalValue)
        {
            return Observable.Select(DecimalValue, (DecimalValueLambda) => DecimalValueLambda.GetTypeCode());
        }

    }
}