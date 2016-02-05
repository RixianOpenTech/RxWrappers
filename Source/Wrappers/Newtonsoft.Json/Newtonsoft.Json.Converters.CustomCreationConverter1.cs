using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __CustomCreationConverter1
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson<T>(this IObservable<Newtonsoft.Json.Converters.CustomCreationConverter<T>> CustomCreationConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(CustomCreationConverterValue, writer, value, serializer, (CustomCreationConverterValueLambda, writerLambda, valueLambda, serializerLambda) => CustomCreationConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson<T>(this IObservable<Newtonsoft.Json.Converters.CustomCreationConverter<T>> CustomCreationConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(CustomCreationConverterValue, reader, objectType, existingValue, serializer, (CustomCreationConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => CustomCreationConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<T> Create<T>(this IObservable<Newtonsoft.Json.Converters.CustomCreationConverter<T>> CustomCreationConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(CustomCreationConverterValue, objectType, (CustomCreationConverterValueLambda, objectTypeLambda) => CustomCreationConverterValueLambda.Create(objectTypeLambda));
        }


        public static IObservable<System.Boolean> CanConvert<T>(this IObservable<Newtonsoft.Json.Converters.CustomCreationConverter<T>> CustomCreationConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(CustomCreationConverterValue, objectType, (CustomCreationConverterValueLambda, objectTypeLambda) => CustomCreationConverterValueLambda.CanConvert(objectTypeLambda));
        }


        public static IObservable<System.Boolean> get_CanWrite<T>(this IObservable<Newtonsoft.Json.Converters.CustomCreationConverter<T>> CustomCreationConverterValue)
        {
            return Observable.Select(CustomCreationConverterValue, (CustomCreationConverterValueLambda) => CustomCreationConverterValueLambda.CanWrite);
        }

    }
}