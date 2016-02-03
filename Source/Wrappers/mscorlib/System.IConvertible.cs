using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __IConvertible
    {
        public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.IConvertible> IConvertibleValue)
        {
            return Observable.Select(IConvertibleValue,
                (IConvertibleValueLambda) => IConvertibleValueLambda.GetTypeCode());
        }


        public static IObservable<System.Boolean> ToBoolean(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToBoolean(providerLambda));
        }


        public static IObservable<System.Char> ToChar(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToChar(providerLambda));
        }


        public static IObservable<System.SByte> ToSByte(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToSByte(providerLambda));
        }


        public static IObservable<System.Byte> ToByte(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToByte(providerLambda));
        }


        public static IObservable<System.Int16> ToInt16(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToInt16(providerLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToUInt16(providerLambda));
        }


        public static IObservable<System.Int32> ToInt32(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToInt32(providerLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToUInt32(providerLambda));
        }


        public static IObservable<System.Int64> ToInt64(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToInt64(providerLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToUInt64(providerLambda));
        }


        public static IObservable<System.Single> ToSingle(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToSingle(providerLambda));
        }


        public static IObservable<System.Double> ToDouble(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToDouble(providerLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToDecimal(providerLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToDateTime(providerLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, provider,
                (IConvertibleValueLambda, providerLambda) => IConvertibleValueLambda.ToString(providerLambda));
        }


        public static IObservable<System.Object> ToType(this IObservable<System.IConvertible> IConvertibleValue,
            IObservable<System.Type> conversionType, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(IConvertibleValue, conversionType, provider,
                (IConvertibleValueLambda, conversionTypeLambda, providerLambda) =>
                    IConvertibleValueLambda.ToType(conversionTypeLambda, providerLambda));
        }
    }
}