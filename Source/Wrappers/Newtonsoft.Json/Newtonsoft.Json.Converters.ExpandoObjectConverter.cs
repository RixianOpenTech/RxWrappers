using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __ExpandoObjectConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.ExpandoObjectConverter> ExpandoObjectConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(ExpandoObjectConverterValue, writer, value, serializer, (ExpandoObjectConverterValueLambda, writerLambda, valueLambda, serializerLambda) => ExpandoObjectConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.ExpandoObjectConverter> ExpandoObjectConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(ExpandoObjectConverterValue, reader, objectType, existingValue, serializer, (ExpandoObjectConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => ExpandoObjectConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.ExpandoObjectConverter> ExpandoObjectConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(ExpandoObjectConverterValue, objectType, (ExpandoObjectConverterValueLambda, objectTypeLambda) => ExpandoObjectConverterValueLambda.CanConvert(objectTypeLambda));
        }


        public static IObservable<System.Boolean> get_CanWrite(this IObservable<Newtonsoft.Json.Converters.ExpandoObjectConverter> ExpandoObjectConverterValue)
        {
            return Observable.Select(ExpandoObjectConverterValue, (ExpandoObjectConverterValueLambda) => ExpandoObjectConverterValueLambda.CanWrite);
        }

    }
}