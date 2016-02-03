using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __IFormatterConverter
    {
        
        public static IObservable<System.Object> Convert(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value, IObservable<System.Type> type)
        {
            return Observable.Zip(IFormatterConverterValue, value, type, (IFormatterConverterValueLambda, valueLambda, typeLambda) => IFormatterConverterValueLambda.Convert(valueLambda, typeLambda));
        }


        public static IObservable<System.Object> Convert(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value, IObservable<System.TypeCode> typeCode)
        {
            return Observable.Zip(IFormatterConverterValue, value, typeCode, (IFormatterConverterValueLambda, valueLambda, typeCodeLambda) => IFormatterConverterValueLambda.Convert(valueLambda, typeCodeLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToBoolean(valueLambda));
        }


        public static IObservable<System.Char> ToChar(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToChar(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToSByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToByte(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToUInt16(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToUInt32(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToUInt64(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToSingle(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToDouble(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToDecimal(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToDateTime(valueLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Serialization.IFormatterConverter> IFormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(IFormatterConverterValue, value, (IFormatterConverterValueLambda, valueLambda) => IFormatterConverterValueLambda.ToString(valueLambda));
        }

    }
}