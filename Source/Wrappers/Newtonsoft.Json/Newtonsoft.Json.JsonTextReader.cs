using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonTextReader
    {
        
        public static IObservable<System.Boolean> Read(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.Read());
        }


        public static IObservable<System.Nullable<System.Int32>> ReadAsInt32(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.ReadAsInt32());
        }


        public static IObservable<System.Nullable<System.DateTime>> ReadAsDateTime(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.ReadAsDateTime());
        }


        public static IObservable<System.String> ReadAsString(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.ReadAsString());
        }


        public static IObservable<System.Byte[]> ReadAsBytes(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.ReadAsBytes());
        }


        public static IObservable<System.Nullable<System.Boolean>> ReadAsBoolean(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.ReadAsBoolean());
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> ReadAsDateTimeOffset(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.ReadAsDateTimeOffset());
        }


        public static IObservable<System.Nullable<System.Decimal>> ReadAsDecimal(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.ReadAsDecimal());
        }


        public static IObservable<System.Nullable<System.Double>> ReadAsDouble(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.ReadAsDouble());
        }


        public static IObservable<System.Reactive.Unit> Close(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Do(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Boolean> HasLineInfo(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.HasLineInfo());
        }


        public static IObservable<Newtonsoft.Json.IArrayPool<System.Char>> get_ArrayPool(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.ArrayPool);
        }


        public static IObservable<System.Int32> get_LineNumber(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.LineNumber);
        }


        public static IObservable<System.Int32> get_LinePosition(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue)
        {
            return Observable.Select(JsonTextReaderValue, (JsonTextReaderValueLambda) => JsonTextReaderValueLambda.LinePosition);
        }


        public static IObservable<System.Reactive.Unit> set_ArrayPool(this IObservable<Newtonsoft.Json.JsonTextReader> JsonTextReaderValue, IObservable<Newtonsoft.Json.IArrayPool<System.Char>> value)
        {
            return ObservableExt.ZipExecute(JsonTextReaderValue, value, (JsonTextReaderValueLambda, valueLambda) => JsonTextReaderValueLambda.ArrayPool = valueLambda);
        }

    }
}