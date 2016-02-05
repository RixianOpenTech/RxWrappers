using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonReader
    {
        
        public static IObservable<System.Boolean> Read(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.Read());
        }


        public static IObservable<System.Nullable<System.Int32>> ReadAsInt32(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.ReadAsInt32());
        }


        public static IObservable<System.String> ReadAsString(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.ReadAsString());
        }


        public static IObservable<System.Byte[]> ReadAsBytes(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.ReadAsBytes());
        }


        public static IObservable<System.Nullable<System.Double>> ReadAsDouble(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.ReadAsDouble());
        }


        public static IObservable<System.Nullable<System.Boolean>> ReadAsBoolean(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.ReadAsBoolean());
        }


        public static IObservable<System.Nullable<System.Decimal>> ReadAsDecimal(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.ReadAsDecimal());
        }


        public static IObservable<System.Nullable<System.DateTime>> ReadAsDateTime(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.ReadAsDateTime());
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> ReadAsDateTimeOffset(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.ReadAsDateTimeOffset());
        }


        public static IObservable<System.Reactive.Unit> Skip(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Do(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.Skip()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Close(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Do(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Boolean> get_CloseInput(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.CloseInput);
        }


        public static IObservable<System.Boolean> get_SupportMultipleContent(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.SupportMultipleContent);
        }


        public static IObservable<System.Char> get_QuoteChar(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.QuoteChar);
        }


        public static IObservable<Newtonsoft.Json.DateTimeZoneHandling> get_DateTimeZoneHandling(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.DateTimeZoneHandling);
        }


        public static IObservable<Newtonsoft.Json.DateParseHandling> get_DateParseHandling(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.DateParseHandling);
        }


        public static IObservable<Newtonsoft.Json.FloatParseHandling> get_FloatParseHandling(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.FloatParseHandling);
        }


        public static IObservable<System.String> get_DateFormatString(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.DateFormatString);
        }


        public static IObservable<System.Nullable<System.Int32>> get_MaxDepth(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.MaxDepth);
        }


        public static IObservable<Newtonsoft.Json.JsonToken> get_TokenType(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.TokenType);
        }


        public static IObservable<System.Object> get_Value(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.Value);
        }


        public static IObservable<System.Type> get_ValueType(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.ValueType);
        }


        public static IObservable<System.Int32> get_Depth(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.Depth);
        }


        public static IObservable<System.String> get_Path(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.Path);
        }


        public static IObservable<System.Globalization.CultureInfo> get_Culture(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue)
        {
            return Observable.Select(JsonReaderValue, (JsonReaderValueLambda) => JsonReaderValueLambda.Culture);
        }


        public static IObservable<System.Reactive.Unit> set_CloseInput(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonReaderValue, value, (JsonReaderValueLambda, valueLambda) => JsonReaderValueLambda.CloseInput = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SupportMultipleContent(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonReaderValue, value, (JsonReaderValueLambda, valueLambda) => JsonReaderValueLambda.SupportMultipleContent = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateTimeZoneHandling(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue, IObservable<Newtonsoft.Json.DateTimeZoneHandling> value)
        {
            return ObservableExt.ZipExecute(JsonReaderValue, value, (JsonReaderValueLambda, valueLambda) => JsonReaderValueLambda.DateTimeZoneHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateParseHandling(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue, IObservable<Newtonsoft.Json.DateParseHandling> value)
        {
            return ObservableExt.ZipExecute(JsonReaderValue, value, (JsonReaderValueLambda, valueLambda) => JsonReaderValueLambda.DateParseHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FloatParseHandling(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue, IObservable<Newtonsoft.Json.FloatParseHandling> value)
        {
            return ObservableExt.ZipExecute(JsonReaderValue, value, (JsonReaderValueLambda, valueLambda) => JsonReaderValueLambda.FloatParseHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateFormatString(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonReaderValue, value, (JsonReaderValueLambda, valueLambda) => JsonReaderValueLambda.DateFormatString = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxDepth(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue, IObservable<System.Nullable<System.Int32>> value)
        {
            return ObservableExt.ZipExecute(JsonReaderValue, value, (JsonReaderValueLambda, valueLambda) => JsonReaderValueLambda.MaxDepth = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Culture(this IObservable<Newtonsoft.Json.JsonReader> JsonReaderValue, IObservable<System.Globalization.CultureInfo> value)
        {
            return ObservableExt.ZipExecute(JsonReaderValue, value, (JsonReaderValueLambda, valueLambda) => JsonReaderValueLambda.Culture = valueLambda);
        }

    }
}