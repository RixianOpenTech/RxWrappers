using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __VersionConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.VersionConverter> VersionConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(VersionConverterValue, writer, value, serializer, (VersionConverterValueLambda, writerLambda, valueLambda, serializerLambda) => VersionConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.VersionConverter> VersionConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(VersionConverterValue, reader, objectType, existingValue, serializer, (VersionConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => VersionConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.VersionConverter> VersionConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(VersionConverterValue, objectType, (VersionConverterValueLambda, objectTypeLambda) => VersionConverterValueLambda.CanConvert(objectTypeLambda));
        }

    }
}