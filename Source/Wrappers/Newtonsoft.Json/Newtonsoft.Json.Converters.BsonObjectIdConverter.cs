using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __BsonObjectIdConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.BsonObjectIdConverter> BsonObjectIdConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(BsonObjectIdConverterValue, writer, value, serializer, (BsonObjectIdConverterValueLambda, writerLambda, valueLambda, serializerLambda) => BsonObjectIdConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.BsonObjectIdConverter> BsonObjectIdConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(BsonObjectIdConverterValue, reader, objectType, existingValue, serializer, (BsonObjectIdConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => BsonObjectIdConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.BsonObjectIdConverter> BsonObjectIdConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(BsonObjectIdConverterValue, objectType, (BsonObjectIdConverterValueLambda, objectTypeLambda) => BsonObjectIdConverterValueLambda.CanConvert(objectTypeLambda));
        }

    }
}