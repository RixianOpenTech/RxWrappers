using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.JsonConverter> JsonConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(JsonConverterValue, writer, value, serializer, (JsonConverterValueLambda, writerLambda, valueLambda, serializerLambda) => JsonConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.JsonConverter> JsonConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(JsonConverterValue, reader, objectType, existingValue, serializer, (JsonConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => JsonConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.JsonConverter> JsonConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(JsonConverterValue, objectType, (JsonConverterValueLambda, objectTypeLambda) => JsonConverterValueLambda.CanConvert(objectTypeLambda));
        }


        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> GetSchema(this IObservable<Newtonsoft.Json.JsonConverter> JsonConverterValue)
        {
            return Observable.Select(JsonConverterValue, (JsonConverterValueLambda) => JsonConverterValueLambda.GetSchema());
        }


        public static IObservable<System.Boolean> get_CanRead(this IObservable<Newtonsoft.Json.JsonConverter> JsonConverterValue)
        {
            return Observable.Select(JsonConverterValue, (JsonConverterValueLambda) => JsonConverterValueLambda.CanRead);
        }


        public static IObservable<System.Boolean> get_CanWrite(this IObservable<Newtonsoft.Json.JsonConverter> JsonConverterValue)
        {
            return Observable.Select(JsonConverterValue, (JsonConverterValueLambda) => JsonConverterValueLambda.CanWrite);
        }

    }
}