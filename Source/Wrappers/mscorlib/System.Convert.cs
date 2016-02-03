using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Convert
    {
        public static IObservable<System.TypeCode> GetTypeCode(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.GetTypeCode(valueLambda));
        }


        public static IObservable<System.Boolean> IsDBNull(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.IsDBNull(valueLambda));
        }


        public static IObservable<System.Object> ChangeType(IObservable<System.Object> value,
            IObservable<System.TypeCode> typeCode)
        {
            return Observable.Zip(value, typeCode,
                (valueLambda, typeCodeLambda) => System.Convert.ChangeType(valueLambda, typeCodeLambda));
        }


        public static IObservable<System.Object> ChangeType(IObservable<System.Object> value,
            IObservable<System.TypeCode> typeCode, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, typeCode, provider,
                (valueLambda, typeCodeLambda, providerLambda) =>
                    System.Convert.ChangeType(valueLambda, typeCodeLambda, providerLambda));
        }


        public static IObservable<System.Object> ChangeType(IObservable<System.Object> value,
            IObservable<System.Type> conversionType)
        {
            return Observable.Zip(value, conversionType,
                (valueLambda, conversionTypeLambda) => System.Convert.ChangeType(valueLambda, conversionTypeLambda));
        }


        public static IObservable<System.Object> ChangeType(IObservable<System.Object> value,
            IObservable<System.Type> conversionType, IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, conversionType, provider,
                (valueLambda, conversionTypeLambda, providerLambda) =>
                    System.Convert.ChangeType(valueLambda, conversionTypeLambda, providerLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToBoolean(valueLambda, providerLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToBoolean(valueLambda, providerLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToBoolean(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToChar(valueLambda, providerLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToChar(valueLambda, providerLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.Char> ToChar(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToChar(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToSByte(valueLambda, providerLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToSByte(valueLambda, providerLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToByte(valueLambda, providerLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToByte(valueLambda, providerLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToByte(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToInt16(valueLambda, providerLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToInt16(valueLambda, providerLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToUInt16(valueLambda, providerLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToUInt16(valueLambda, providerLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt16(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToInt32(valueLambda, providerLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToInt32(valueLambda, providerLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToUInt32(valueLambda, providerLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToUInt32(valueLambda, providerLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt32(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToInt64(valueLambda, providerLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToInt64(valueLambda, providerLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToUInt64(valueLambda, providerLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToUInt64(valueLambda, providerLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToUInt64(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToSingle(valueLambda, providerLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToSingle(valueLambda, providerLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToSingle(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToDouble(valueLambda, providerLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToDouble(valueLambda, providerLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDouble(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToDecimal(valueLambda, providerLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToDecimal(valueLambda, providerLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDecimal(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToDateTime(valueLambda, providerLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToDateTime(valueLambda, providerLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToDateTime(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Object> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Object> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Boolean> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Boolean> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Char> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Char> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.SByte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.SByte> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Byte> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Byte> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int16> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.UInt16> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.UInt16> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int32> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.UInt32> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.UInt32> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int64> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.UInt64> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.UInt64> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Single> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Single> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Double> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Double> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Decimal> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Decimal> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.DateTime> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.DateTime> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => System.Convert.ToString(valueLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.String> value,
            IObservable<System.IFormatProvider> provider)
        {
            return Observable.Zip(value, provider,
                (valueLambda, providerLambda) => System.Convert.ToString(valueLambda, providerLambda));
        }


        public static IObservable<System.Byte> ToByte(IObservable<System.String> value,
            IObservable<System.Int32> fromBase)
        {
            return Observable.Zip(value, fromBase,
                (valueLambda, fromBaseLambda) => System.Convert.ToByte(valueLambda, fromBaseLambda));
        }


        public static IObservable<System.SByte> ToSByte(IObservable<System.String> value,
            IObservable<System.Int32> fromBase)
        {
            return Observable.Zip(value, fromBase,
                (valueLambda, fromBaseLambda) => System.Convert.ToSByte(valueLambda, fromBaseLambda));
        }


        public static IObservable<System.Int16> ToInt16(IObservable<System.String> value,
            IObservable<System.Int32> fromBase)
        {
            return Observable.Zip(value, fromBase,
                (valueLambda, fromBaseLambda) => System.Convert.ToInt16(valueLambda, fromBaseLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(IObservable<System.String> value,
            IObservable<System.Int32> fromBase)
        {
            return Observable.Zip(value, fromBase,
                (valueLambda, fromBaseLambda) => System.Convert.ToUInt16(valueLambda, fromBaseLambda));
        }


        public static IObservable<System.Int32> ToInt32(IObservable<System.String> value,
            IObservable<System.Int32> fromBase)
        {
            return Observable.Zip(value, fromBase,
                (valueLambda, fromBaseLambda) => System.Convert.ToInt32(valueLambda, fromBaseLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(IObservable<System.String> value,
            IObservable<System.Int32> fromBase)
        {
            return Observable.Zip(value, fromBase,
                (valueLambda, fromBaseLambda) => System.Convert.ToUInt32(valueLambda, fromBaseLambda));
        }


        public static IObservable<System.Int64> ToInt64(IObservable<System.String> value,
            IObservable<System.Int32> fromBase)
        {
            return Observable.Zip(value, fromBase,
                (valueLambda, fromBaseLambda) => System.Convert.ToInt64(valueLambda, fromBaseLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(IObservable<System.String> value,
            IObservable<System.Int32> fromBase)
        {
            return Observable.Zip(value, fromBase,
                (valueLambda, fromBaseLambda) => System.Convert.ToUInt64(valueLambda, fromBaseLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Byte> value,
            IObservable<System.Int32> toBase)
        {
            return Observable.Zip(value, toBase,
                (valueLambda, toBaseLambda) => System.Convert.ToString(valueLambda, toBaseLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int16> value,
            IObservable<System.Int32> toBase)
        {
            return Observable.Zip(value, toBase,
                (valueLambda, toBaseLambda) => System.Convert.ToString(valueLambda, toBaseLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int32> value,
            IObservable<System.Int32> toBase)
        {
            return Observable.Zip(value, toBase,
                (valueLambda, toBaseLambda) => System.Convert.ToString(valueLambda, toBaseLambda));
        }


        public static IObservable<System.String> ToString(IObservable<System.Int64> value,
            IObservable<System.Int32> toBase)
        {
            return Observable.Zip(value, toBase,
                (valueLambda, toBaseLambda) => System.Convert.ToString(valueLambda, toBaseLambda));
        }


        public static IObservable<System.String> ToBase64String(IObservable<System.Byte[]> inArray)
        {
            return Observable.Select(inArray, (inArrayLambda) => System.Convert.ToBase64String(inArrayLambda));
        }


        public static IObservable<System.String> ToBase64String(IObservable<System.Byte[]> inArray,
            IObservable<System.Base64FormattingOptions> options)
        {
            return Observable.Zip(inArray, options,
                (inArrayLambda, optionsLambda) => System.Convert.ToBase64String(inArrayLambda, optionsLambda));
        }


        public static IObservable<System.String> ToBase64String(IObservable<System.Byte[]> inArray,
            IObservable<System.Int32> offset, IObservable<System.Int32> length)
        {
            return Observable.Zip(inArray, offset, length,
                (inArrayLambda, offsetLambda, lengthLambda) =>
                    System.Convert.ToBase64String(inArrayLambda, offsetLambda, lengthLambda));
        }


        public static IObservable<System.String> ToBase64String(IObservable<System.Byte[]> inArray,
            IObservable<System.Int32> offset, IObservable<System.Int32> length,
            IObservable<System.Base64FormattingOptions> options)
        {
            return Observable.Zip(inArray, offset, length, options,
                (inArrayLambda, offsetLambda, lengthLambda, optionsLambda) =>
                    System.Convert.ToBase64String(inArrayLambda, offsetLambda, lengthLambda, optionsLambda));
        }


        public static IObservable<System.Int32> ToBase64CharArray(IObservable<System.Byte[]> inArray,
            IObservable<System.Int32> offsetIn, IObservable<System.Int32> length, IObservable<System.Char[]> outArray,
            IObservable<System.Int32> offsetOut)
        {
            return Observable.Zip(inArray, offsetIn, length, outArray, offsetOut,
                (inArrayLambda, offsetInLambda, lengthLambda, outArrayLambda, offsetOutLambda) =>
                    System.Convert.ToBase64CharArray(inArrayLambda, offsetInLambda, lengthLambda, outArrayLambda,
                        offsetOutLambda));
        }


        public static IObservable<System.Int32> ToBase64CharArray(IObservable<System.Byte[]> inArray,
            IObservable<System.Int32> offsetIn, IObservable<System.Int32> length, IObservable<System.Char[]> outArray,
            IObservable<System.Int32> offsetOut, IObservable<System.Base64FormattingOptions> options)
        {
            return Observable.Zip(inArray, offsetIn, length, outArray, offsetOut, options,
                (inArrayLambda, offsetInLambda, lengthLambda, outArrayLambda, offsetOutLambda, optionsLambda) =>
                    System.Convert.ToBase64CharArray(inArrayLambda, offsetInLambda, lengthLambda, outArrayLambda,
                        offsetOutLambda, optionsLambda));
        }


        public static IObservable<System.Byte[]> FromBase64String(IObservable<System.String> s)
        {
            return Observable.Select(s, (sLambda) => System.Convert.FromBase64String(sLambda));
        }


        public static IObservable<System.Byte[]> FromBase64CharArray(IObservable<System.Char[]> inArray,
            IObservable<System.Int32> offset, IObservable<System.Int32> length)
        {
            return Observable.Zip(inArray, offset, length,
                (inArrayLambda, offsetLambda, lengthLambda) =>
                    System.Convert.FromBase64CharArray(inArrayLambda, offsetLambda, lengthLambda));
        }
    }
}