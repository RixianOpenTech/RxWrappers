using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __StringEnumConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.StringEnumConverter> StringEnumConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(StringEnumConverterValue, writer, value, serializer, (StringEnumConverterValueLambda, writerLambda, valueLambda, serializerLambda) => StringEnumConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.StringEnumConverter> StringEnumConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(StringEnumConverterValue, reader, objectType, existingValue, serializer, (StringEnumConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => StringEnumConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.StringEnumConverter> StringEnumConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(StringEnumConverterValue, objectType, (StringEnumConverterValueLambda, objectTypeLambda) => StringEnumConverterValueLambda.CanConvert(objectTypeLambda));
        }


        public static IObservable<System.Boolean> get_CamelCaseText(this IObservable<Newtonsoft.Json.Converters.StringEnumConverter> StringEnumConverterValue)
        {
            return Observable.Select(StringEnumConverterValue, (StringEnumConverterValueLambda) => StringEnumConverterValueLambda.CamelCaseText);
        }


        public static IObservable<System.Boolean> get_AllowIntegerValues(this IObservable<Newtonsoft.Json.Converters.StringEnumConverter> StringEnumConverterValue)
        {
            return Observable.Select(StringEnumConverterValue, (StringEnumConverterValueLambda) => StringEnumConverterValueLambda.AllowIntegerValues);
        }


        public static IObservable<System.Reactive.Unit> set_CamelCaseText(this IObservable<Newtonsoft.Json.Converters.StringEnumConverter> StringEnumConverterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(StringEnumConverterValue, value, (StringEnumConverterValueLambda, valueLambda) => StringEnumConverterValueLambda.CamelCaseText = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AllowIntegerValues(this IObservable<Newtonsoft.Json.Converters.StringEnumConverter> StringEnumConverterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(StringEnumConverterValue, value, (StringEnumConverterValueLambda, valueLambda) => StringEnumConverterValueLambda.AllowIntegerValues = valueLambda);
        }

    }
}