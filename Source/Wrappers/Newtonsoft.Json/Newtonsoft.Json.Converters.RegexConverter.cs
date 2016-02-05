using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __RegexConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.RegexConverter> RegexConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(RegexConverterValue, writer, value, serializer, (RegexConverterValueLambda, writerLambda, valueLambda, serializerLambda) => RegexConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.RegexConverter> RegexConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(RegexConverterValue, reader, objectType, existingValue, serializer, (RegexConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => RegexConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.RegexConverter> RegexConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(RegexConverterValue, objectType, (RegexConverterValueLambda, objectTypeLambda) => RegexConverterValueLambda.CanConvert(objectTypeLambda));
        }

    }
}