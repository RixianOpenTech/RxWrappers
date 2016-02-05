using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __DataSetConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.DataSetConverter> DataSetConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(DataSetConverterValue, writer, value, serializer, (DataSetConverterValueLambda, writerLambda, valueLambda, serializerLambda) => DataSetConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.DataSetConverter> DataSetConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(DataSetConverterValue, reader, objectType, existingValue, serializer, (DataSetConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => DataSetConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.DataSetConverter> DataSetConverterValue, IObservable<System.Type> valueType)
        {
            return Observable.Zip(DataSetConverterValue, valueType, (DataSetConverterValueLambda, valueTypeLambda) => DataSetConverterValueLambda.CanConvert(valueTypeLambda));
        }

    }
}