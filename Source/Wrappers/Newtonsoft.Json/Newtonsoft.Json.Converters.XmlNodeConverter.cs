using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __XmlNodeConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.XmlNodeConverter> XmlNodeConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(XmlNodeConverterValue, writer, value, serializer, (XmlNodeConverterValueLambda, writerLambda, valueLambda, serializerLambda) => XmlNodeConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.XmlNodeConverter> XmlNodeConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(XmlNodeConverterValue, reader, objectType, existingValue, serializer, (XmlNodeConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => XmlNodeConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.XmlNodeConverter> XmlNodeConverterValue, IObservable<System.Type> valueType)
        {
            return Observable.Zip(XmlNodeConverterValue, valueType, (XmlNodeConverterValueLambda, valueTypeLambda) => XmlNodeConverterValueLambda.CanConvert(valueTypeLambda));
        }


        public static IObservable<System.String> get_DeserializeRootElementName(this IObservable<Newtonsoft.Json.Converters.XmlNodeConverter> XmlNodeConverterValue)
        {
            return Observable.Select(XmlNodeConverterValue, (XmlNodeConverterValueLambda) => XmlNodeConverterValueLambda.DeserializeRootElementName);
        }


        public static IObservable<System.Boolean> get_WriteArrayAttribute(this IObservable<Newtonsoft.Json.Converters.XmlNodeConverter> XmlNodeConverterValue)
        {
            return Observable.Select(XmlNodeConverterValue, (XmlNodeConverterValueLambda) => XmlNodeConverterValueLambda.WriteArrayAttribute);
        }


        public static IObservable<System.Boolean> get_OmitRootObject(this IObservable<Newtonsoft.Json.Converters.XmlNodeConverter> XmlNodeConverterValue)
        {
            return Observable.Select(XmlNodeConverterValue, (XmlNodeConverterValueLambda) => XmlNodeConverterValueLambda.OmitRootObject);
        }


        public static IObservable<System.Reactive.Unit> set_DeserializeRootElementName(this IObservable<Newtonsoft.Json.Converters.XmlNodeConverter> XmlNodeConverterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(XmlNodeConverterValue, value, (XmlNodeConverterValueLambda, valueLambda) => XmlNodeConverterValueLambda.DeserializeRootElementName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_WriteArrayAttribute(this IObservable<Newtonsoft.Json.Converters.XmlNodeConverter> XmlNodeConverterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(XmlNodeConverterValue, value, (XmlNodeConverterValueLambda, valueLambda) => XmlNodeConverterValueLambda.WriteArrayAttribute = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_OmitRootObject(this IObservable<Newtonsoft.Json.Converters.XmlNodeConverter> XmlNodeConverterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(XmlNodeConverterValue, value, (XmlNodeConverterValueLambda, valueLambda) => XmlNodeConverterValueLambda.OmitRootObject = valueLambda);
        }

    }
}