using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonValidatingReader
    {
        
        public static IObservable<System.Nullable<System.Int32>> ReadAsInt32(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.ReadAsInt32());
        }


        public static IObservable<System.Byte[]> ReadAsBytes(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.ReadAsBytes());
        }


        public static IObservable<System.Nullable<System.Decimal>> ReadAsDecimal(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.ReadAsDecimal());
        }


        public static IObservable<System.Nullable<System.Double>> ReadAsDouble(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.ReadAsDouble());
        }


        public static IObservable<System.Nullable<System.Boolean>> ReadAsBoolean(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.ReadAsBoolean());
        }


        public static IObservable<System.String> ReadAsString(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.ReadAsString());
        }


        public static IObservable<System.Nullable<System.DateTime>> ReadAsDateTime(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.ReadAsDateTime());
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> ReadAsDateTimeOffset(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.ReadAsDateTimeOffset());
        }


        public static IObservable<System.Boolean> Read(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.Read());
        }


        public static IObservable<System.Object> get_Value(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.Value);
        }


        public static IObservable<System.Int32> get_Depth(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.Depth);
        }


        public static IObservable<System.String> get_Path(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.Path);
        }


        public static IObservable<System.Char> get_QuoteChar(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.QuoteChar);
        }


        public static IObservable<Newtonsoft.Json.JsonToken> get_TokenType(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.TokenType);
        }


        public static IObservable<System.Type> get_ValueType(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.ValueType);
        }


        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> get_Schema(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.Schema);
        }


        public static IObservable<Newtonsoft.Json.JsonReader> get_Reader(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue)
        {
            return Observable.Select(JsonValidatingReaderValue, (JsonValidatingReaderValueLambda) => JsonValidatingReaderValueLambda.Reader);
        }


        public static IObservable<System.Reactive.Unit> set_Schema(this IObservable<Newtonsoft.Json.JsonValidatingReader> JsonValidatingReaderValue, IObservable<Newtonsoft.Json.Schema.JsonSchema> value)
        {
            return ObservableExt.ZipExecute(JsonValidatingReaderValue, value, (JsonValidatingReaderValueLambda, valueLambda) => JsonValidatingReaderValueLambda.Schema = valueLambda);
        }

    }
}