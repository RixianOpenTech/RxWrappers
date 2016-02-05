using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Bson
{
    public static class __BsonWriter
    {
        
        public static IObservable<System.Reactive.Unit> Flush(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue)
        {
            return Observable.Do(BsonWriterValue, (BsonWriterValueLambda) => BsonWriterValueLambda.Flush()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteComment(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.String> text)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, text, (BsonWriterValueLambda, textLambda) => BsonWriterValueLambda.WriteComment(textLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteStartConstructor(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, name, (BsonWriterValueLambda, nameLambda) => BsonWriterValueLambda.WriteStartConstructor(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteRaw(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.String> json)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, json, (BsonWriterValueLambda, jsonLambda) => BsonWriterValueLambda.WriteRaw(jsonLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteRawValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.String> json)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, json, (BsonWriterValueLambda, jsonLambda) => BsonWriterValueLambda.WriteRawValue(jsonLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteStartArray(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue)
        {
            return Observable.Do(BsonWriterValue, (BsonWriterValueLambda) => BsonWriterValueLambda.WriteStartArray()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteStartObject(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue)
        {
            return Observable.Do(BsonWriterValue, (BsonWriterValueLambda) => BsonWriterValueLambda.WriteStartObject()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WritePropertyName(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, name, (BsonWriterValueLambda, nameLambda) => BsonWriterValueLambda.WritePropertyName(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> Close(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue)
        {
            return Observable.Do(BsonWriterValue, (BsonWriterValueLambda) => BsonWriterValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteNull(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue)
        {
            return Observable.Do(BsonWriterValue, (BsonWriterValueLambda) => BsonWriterValueLambda.WriteNull()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteUndefined(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue)
        {
            return Observable.Do(BsonWriterValue, (BsonWriterValueLambda) => BsonWriterValueLambda.WriteUndefined()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.UInt32> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.UInt64> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Single> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Double> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Int16> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.UInt16> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Char> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.SByte> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.DateTimeOffset> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Guid> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.TimeSpan> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Uri> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteObjectId(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.WriteObjectId(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteRegex(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.String> pattern, IObservable<System.String> options)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, pattern, options, (BsonWriterValueLambda, patternLambda, optionsLambda) => BsonWriterValueLambda.WriteRegex(patternLambda, optionsLambda));
        }


        public static IObservable<System.DateTimeKind> get_DateTimeKindHandling(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue)
        {
            return Observable.Select(BsonWriterValue, (BsonWriterValueLambda) => BsonWriterValueLambda.DateTimeKindHandling);
        }


        public static IObservable<System.Reactive.Unit> set_DateTimeKindHandling(this IObservable<Newtonsoft.Json.Bson.BsonWriter> BsonWriterValue, IObservable<System.DateTimeKind> value)
        {
            return ObservableExt.ZipExecute(BsonWriterValue, value, (BsonWriterValueLambda, valueLambda) => BsonWriterValueLambda.DateTimeKindHandling = valueLambda);
        }

    }
}