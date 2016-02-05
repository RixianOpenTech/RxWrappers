using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __KeyValuePairConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.KeyValuePairConverter> KeyValuePairConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(KeyValuePairConverterValue, writer, value, serializer, (KeyValuePairConverterValueLambda, writerLambda, valueLambda, serializerLambda) => KeyValuePairConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.KeyValuePairConverter> KeyValuePairConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(KeyValuePairConverterValue, reader, objectType, existingValue, serializer, (KeyValuePairConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => KeyValuePairConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.KeyValuePairConverter> KeyValuePairConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(KeyValuePairConverterValue, objectType, (KeyValuePairConverterValueLambda, objectTypeLambda) => KeyValuePairConverterValueLambda.CanConvert(objectTypeLambda));
        }

    }
}