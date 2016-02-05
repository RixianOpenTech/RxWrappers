using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __BinaryConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.BinaryConverter> BinaryConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(BinaryConverterValue, writer, value, serializer, (BinaryConverterValueLambda, writerLambda, valueLambda, serializerLambda) => BinaryConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.BinaryConverter> BinaryConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(BinaryConverterValue, reader, objectType, existingValue, serializer, (BinaryConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => BinaryConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.BinaryConverter> BinaryConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(BinaryConverterValue, objectType, (BinaryConverterValueLambda, objectTypeLambda) => BinaryConverterValueLambda.CanConvert(objectTypeLambda));
        }

    }
}