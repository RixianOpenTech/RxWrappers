using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __DiscriminatedUnionConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.DiscriminatedUnionConverter> DiscriminatedUnionConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(DiscriminatedUnionConverterValue, writer, value, serializer, (DiscriminatedUnionConverterValueLambda, writerLambda, valueLambda, serializerLambda) => DiscriminatedUnionConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.DiscriminatedUnionConverter> DiscriminatedUnionConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(DiscriminatedUnionConverterValue, reader, objectType, existingValue, serializer, (DiscriminatedUnionConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => DiscriminatedUnionConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.DiscriminatedUnionConverter> DiscriminatedUnionConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(DiscriminatedUnionConverterValue, objectType, (DiscriminatedUnionConverterValueLambda, objectTypeLambda) => DiscriminatedUnionConverterValueLambda.CanConvert(objectTypeLambda));
        }

    }
}