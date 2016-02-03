using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __FormatterConverter
    {
        
        public static IObservable<System.Object> Convert(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value, IObservable<System.Type> type)
        {
            return Observable.Zip(FormatterConverterValue, value, type, (FormatterConverterValueLambda, valueLambda, typeLambda) => FormatterConverterValueLambda.Convert(valueLambda, typeLambda));
        }


        public static IObservable<System.Object> Convert(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value, IObservable<System.TypeCode> typeCode)
        {
            return Observable.Zip(FormatterConverterValue, value, typeCode, (FormatterConverterValueLambda, valueLambda, typeCodeLambda) => FormatterConverterValueLambda.Convert(valueLambda, typeCodeLambda));
        }


        public static IObservable<System.Boolean> ToBoolean(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToBoolean(valueLambda));
        }


        public static IObservable<System.Char> ToChar(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToChar(valueLambda));
        }


        public static IObservable<System.SByte> ToSByte(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToSByte(valueLambda));
        }


        public static IObservable<System.Byte> ToByte(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToByte(valueLambda));
        }


        public static IObservable<System.Int16> ToInt16(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToInt16(valueLambda));
        }


        public static IObservable<System.UInt16> ToUInt16(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToUInt16(valueLambda));
        }


        public static IObservable<System.Int32> ToInt32(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToInt32(valueLambda));
        }


        public static IObservable<System.UInt32> ToUInt32(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToUInt32(valueLambda));
        }


        public static IObservable<System.Int64> ToInt64(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToInt64(valueLambda));
        }


        public static IObservable<System.UInt64> ToUInt64(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToUInt64(valueLambda));
        }


        public static IObservable<System.Single> ToSingle(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToSingle(valueLambda));
        }


        public static IObservable<System.Double> ToDouble(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToDouble(valueLambda));
        }


        public static IObservable<System.Decimal> ToDecimal(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToDecimal(valueLambda));
        }


        public static IObservable<System.DateTime> ToDateTime(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToDateTime(valueLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Serialization.FormatterConverter> FormatterConverterValue, IObservable<System.Object> value)
        {
            return Observable.Zip(FormatterConverterValue, value, (FormatterConverterValueLambda, valueLambda) => FormatterConverterValueLambda.ToString(valueLambda));
        }

    }
}