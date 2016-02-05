using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonWriter
    {
        
        public static IObservable<System.Reactive.Unit> Flush(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Do(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.Flush()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Close(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Do(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteStartObject(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Do(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.WriteStartObject()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteEndObject(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Do(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.WriteEndObject()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteStartArray(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Do(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.WriteStartArray()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteEndArray(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Do(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.WriteEndArray()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteStartConstructor(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, name, (JsonWriterValueLambda, nameLambda) => JsonWriterValueLambda.WriteStartConstructor(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteEndConstructor(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Do(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.WriteEndConstructor()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WritePropertyName(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, name, (JsonWriterValueLambda, nameLambda) => JsonWriterValueLambda.WritePropertyName(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> WritePropertyName(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.String> name, IObservable<System.Boolean> escape)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, name, escape, (JsonWriterValueLambda, nameLambda, escapeLambda) => JsonWriterValueLambda.WritePropertyName(nameLambda, escapeLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteEnd(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Do(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.WriteEnd()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteToken(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<Newtonsoft.Json.JsonReader> reader)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, reader, (JsonWriterValueLambda, readerLambda) => JsonWriterValueLambda.WriteToken(readerLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteToken(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Boolean> writeChildren)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, reader, writeChildren, (JsonWriterValueLambda, readerLambda, writeChildrenLambda) => JsonWriterValueLambda.WriteToken(readerLambda, writeChildrenLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteToken(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<Newtonsoft.Json.JsonToken> token, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, token, value, (JsonWriterValueLambda, tokenLambda, valueLambda) => JsonWriterValueLambda.WriteToken(tokenLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteToken(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<Newtonsoft.Json.JsonToken> token)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, token, (JsonWriterValueLambda, tokenLambda) => JsonWriterValueLambda.WriteToken(tokenLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteNull(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Do(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.WriteNull()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteUndefined(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Do(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.WriteUndefined()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteRaw(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.String> json)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, json, (JsonWriterValueLambda, jsonLambda) => JsonWriterValueLambda.WriteRaw(jsonLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteRawValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.String> json)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, json, (JsonWriterValueLambda, jsonLambda) => JsonWriterValueLambda.WriteRawValue(jsonLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.UInt32> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.UInt64> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Single> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Double> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Int16> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.UInt16> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Char> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.SByte> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.DateTimeOffset> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Guid> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.TimeSpan> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.Int32>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.UInt32>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.Int64>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.UInt64>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.Single>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.Double>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.Int16>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.UInt16>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.Char>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.Byte>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.SByte>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.Decimal>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.DateTime>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.DateTimeOffset>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.Guid>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Nullable<System.TimeSpan>> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Uri> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteComment(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.String> text)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, text, (JsonWriterValueLambda, textLambda) => JsonWriterValueLambda.WriteComment(textLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteWhitespace(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.String> ws)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, ws, (JsonWriterValueLambda, wsLambda) => JsonWriterValueLambda.WriteWhitespace(wsLambda));
        }


        public static IObservable<System.Boolean> get_CloseOutput(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Select(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.CloseOutput);
        }


        public static IObservable<Newtonsoft.Json.WriteState> get_WriteState(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Select(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.WriteState);
        }


        public static IObservable<System.String> get_Path(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Select(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.Path);
        }


        public static IObservable<Newtonsoft.Json.Formatting> get_Formatting(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Select(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.Formatting);
        }


        public static IObservable<Newtonsoft.Json.DateFormatHandling> get_DateFormatHandling(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Select(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.DateFormatHandling);
        }


        public static IObservable<Newtonsoft.Json.DateTimeZoneHandling> get_DateTimeZoneHandling(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Select(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.DateTimeZoneHandling);
        }


        public static IObservable<Newtonsoft.Json.StringEscapeHandling> get_StringEscapeHandling(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Select(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.StringEscapeHandling);
        }


        public static IObservable<Newtonsoft.Json.FloatFormatHandling> get_FloatFormatHandling(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Select(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.FloatFormatHandling);
        }


        public static IObservable<System.String> get_DateFormatString(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Select(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.DateFormatString);
        }


        public static IObservable<System.Globalization.CultureInfo> get_Culture(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue)
        {
            return Observable.Select(JsonWriterValue, (JsonWriterValueLambda) => JsonWriterValueLambda.Culture);
        }


        public static IObservable<System.Reactive.Unit> set_CloseOutput(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.CloseOutput = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Formatting(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<Newtonsoft.Json.Formatting> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.Formatting = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateFormatHandling(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<Newtonsoft.Json.DateFormatHandling> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.DateFormatHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateTimeZoneHandling(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<Newtonsoft.Json.DateTimeZoneHandling> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.DateTimeZoneHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_StringEscapeHandling(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<Newtonsoft.Json.StringEscapeHandling> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.StringEscapeHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FloatFormatHandling(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<Newtonsoft.Json.FloatFormatHandling> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.FloatFormatHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateFormatString(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.DateFormatString = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Culture(this IObservable<Newtonsoft.Json.JsonWriter> JsonWriterValue, IObservable<System.Globalization.CultureInfo> value)
        {
            return ObservableExt.ZipExecute(JsonWriterValue, value, (JsonWriterValueLambda, valueLambda) => JsonWriterValueLambda.Culture = valueLambda);
        }

    }
}