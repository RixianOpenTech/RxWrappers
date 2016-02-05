using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __JavaScriptDateTimeConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.JavaScriptDateTimeConverter> JavaScriptDateTimeConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(JavaScriptDateTimeConverterValue, writer, value, serializer, (JavaScriptDateTimeConverterValueLambda, writerLambda, valueLambda, serializerLambda) => JavaScriptDateTimeConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.JavaScriptDateTimeConverter> JavaScriptDateTimeConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(JavaScriptDateTimeConverterValue, reader, objectType, existingValue, serializer, (JavaScriptDateTimeConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => JavaScriptDateTimeConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }

    }
}