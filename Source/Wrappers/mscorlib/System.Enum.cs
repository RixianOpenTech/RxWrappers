using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Enum
    {
        public static IObservable<Tuple<System.Boolean, TEnum>> TryParse<TEnum>(IObservable<System.String> value)
            where TEnum : struct
        {
            return Observable.Select(value, (valueLambda) =>
            {
                TEnum resultOutput = default(TEnum);
                var result = System.Enum.TryParse(valueLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<Tuple<System.Boolean, TEnum>> TryParse<TEnum>(IObservable<System.String> value,
            IObservable<System.Boolean> ignoreCase) where TEnum : struct
        {
            return Observable.Zip(value, ignoreCase, (valueLambda, ignoreCaseLambda) =>
            {
                TEnum resultOutput = default(TEnum);
                var result = System.Enum.TryParse(valueLambda, ignoreCaseLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<System.Object> Parse(IObservable<System.Type> enumType,
            IObservable<System.String> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.Parse(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.Object> Parse(IObservable<System.Type> enumType,
            IObservable<System.String> value, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(enumType, value, ignoreCase,
                (enumTypeLambda, valueLambda, ignoreCaseLambda) =>
                    System.Enum.Parse(enumTypeLambda, valueLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Type> GetUnderlyingType(IObservable<System.Type> enumType)
        {
            return Observable.Select(enumType, (enumTypeLambda) => System.Enum.GetUnderlyingType(enumTypeLambda));
        }


        public static IObservable<System.Array> GetValues(IObservable<System.Type> enumType)
        {
            return Observable.Select(enumType, (enumTypeLambda) => System.Enum.GetValues(enumTypeLambda));
        }


        public static IObservable<System.String> GetName(IObservable<System.Type> enumType,
            IObservable<System.Object> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.GetName(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.String[]> GetNames(IObservable<System.Type> enumType)
        {
            return Observable.Select(enumType, (enumTypeLambda) => System.Enum.GetNames(enumTypeLambda));
        }


        public static IObservable<System.Object> ToObject(IObservable<System.Type> enumType,
            IObservable<System.Object> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.ToObject(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.Boolean> IsDefined(IObservable<System.Type> enumType,
            IObservable<System.Object> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.IsDefined(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.String> Format(IObservable<System.Type> enumType,
            IObservable<System.Object> value, IObservable<System.String> format)
        {
            return Observable.Zip(enumType, value, format,
                (enumTypeLambda, valueLambda, formatLambda) =>
                    System.Enum.Format(enumTypeLambda, valueLambda, formatLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Enum> EnumValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(EnumValue, obj, (EnumValueLambda, objLambda) => EnumValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Enum> EnumValue)
        {
            return Observable.Select(EnumValue, (EnumValueLambda) => EnumValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Enum> EnumValue)
        {
            return Observable.Select(EnumValue, (EnumValueLambda) => EnumValueLambda.ToString());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Enum> EnumValue,
            IObservable<System.String> format, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(EnumValue, format, provider,
                (EnumValueLambda, formatLambda, providerLambda) =>
                    EnumValueLambda.ToString(formatLambda, providerLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<System.Enum> EnumValue,
            IObservable<System.Object> target)
        {
            return Observable.Zip(EnumValue, target,
                (EnumValueLambda, targetLambda) => EnumValueLambda.CompareTo(targetLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Enum> EnumValue,
            IObservable<System.String> format)
        {
            return Observable.Zip(EnumValue, format,
                (EnumValueLambda, formatLambda) => EnumValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Enum> EnumValue,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(EnumValue, provider,
                (EnumValueLambda, providerLambda) => EnumValueLambda.ToString(providerLambda));
        }


        public static IObservable<System.Boolean> HasFlag(this IObservable<System.Enum> EnumValue,
            IObservable<System.Enum> flag)
        {
            return Observable.Zip(EnumValue, flag, (EnumValueLambda, flagLambda) => EnumValueLambda.HasFlag(flagLambda));
        }


        public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.Enum> EnumValue)
        {
            return Observable.Select(EnumValue, (EnumValueLambda) => EnumValueLambda.GetTypeCode());
        }


        public static IObservable<System.Object> ToObject(IObservable<System.Type> enumType,
            IObservable<System.SByte> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.ToObject(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.Object> ToObject(IObservable<System.Type> enumType,
            IObservable<System.Int16> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.ToObject(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.Object> ToObject(IObservable<System.Type> enumType,
            IObservable<System.Int32> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.ToObject(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.Object> ToObject(IObservable<System.Type> enumType,
            IObservable<System.Byte> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.ToObject(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.Object> ToObject(IObservable<System.Type> enumType,
            IObservable<System.UInt16> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.ToObject(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.Object> ToObject(IObservable<System.Type> enumType,
            IObservable<System.UInt32> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.ToObject(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.Object> ToObject(IObservable<System.Type> enumType,
            IObservable<System.Int64> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.ToObject(enumTypeLambda, valueLambda));
        }


        public static IObservable<System.Object> ToObject(IObservable<System.Type> enumType,
            IObservable<System.UInt64> value)
        {
            return Observable.Zip(enumType, value,
                (enumTypeLambda, valueLambda) => System.Enum.ToObject(enumTypeLambda, valueLambda));
        }
    }
}