using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonTextWriter
    {
        
        public static IObservable<System.Reactive.Unit> Flush(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Do(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.Flush()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Close(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Do(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteStartObject(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Do(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.WriteStartObject()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteStartArray(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Do(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.WriteStartArray()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteStartConstructor(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, name, (JsonTextWriterValueLambda, nameLambda) => JsonTextWriterValueLambda.WriteStartConstructor(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> WritePropertyName(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, name, (JsonTextWriterValueLambda, nameLambda) => JsonTextWriterValueLambda.WritePropertyName(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> WritePropertyName(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.String> name, IObservable<System.Boolean> escape)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, name, escape, (JsonTextWriterValueLambda, nameLambda, escapeLambda) => JsonTextWriterValueLambda.WritePropertyName(nameLambda, escapeLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteNull(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Do(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.WriteNull()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteUndefined(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Do(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.WriteUndefined()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteRaw(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.String> json)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, json, (JsonTextWriterValueLambda, jsonLambda) => JsonTextWriterValueLambda.WriteRaw(jsonLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.UInt32> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.UInt64> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Single> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Nullable<System.Single>> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Double> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Nullable<System.Double>> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Int16> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.UInt16> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Char> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.SByte> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.DateTimeOffset> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Guid> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.TimeSpan> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Uri> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteComment(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.String> text)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, text, (JsonTextWriterValueLambda, textLambda) => JsonTextWriterValueLambda.WriteComment(textLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteWhitespace(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.String> ws)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, ws, (JsonTextWriterValueLambda, wsLambda) => JsonTextWriterValueLambda.WriteWhitespace(wsLambda));
        }


        public static IObservable<Newtonsoft.Json.IArrayPool<System.Char>> get_ArrayPool(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Select(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.ArrayPool);
        }


        public static IObservable<System.Int32> get_Indentation(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Select(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.Indentation);
        }


        public static IObservable<System.Char> get_QuoteChar(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Select(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.QuoteChar);
        }


        public static IObservable<System.Char> get_IndentChar(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Select(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.IndentChar);
        }


        public static IObservable<System.Boolean> get_QuoteName(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue)
        {
            return Observable.Select(JsonTextWriterValue, (JsonTextWriterValueLambda) => JsonTextWriterValueLambda.QuoteName);
        }


        public static IObservable<System.Reactive.Unit> set_ArrayPool(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<Newtonsoft.Json.IArrayPool<System.Char>> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.ArrayPool = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Indentation(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.Indentation = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_QuoteChar(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Char> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.QuoteChar = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IndentChar(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Char> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.IndentChar = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_QuoteName(this IObservable<Newtonsoft.Json.JsonTextWriter> JsonTextWriterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonTextWriterValue, value, (JsonTextWriterValueLambda, valueLambda) => JsonTextWriterValueLambda.QuoteName = valueLambda);
        }

    }
}