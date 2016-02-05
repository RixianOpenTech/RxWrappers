using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __DataTableConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.DataTableConverter> DataTableConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(DataTableConverterValue, writer, value, serializer, (DataTableConverterValueLambda, writerLambda, valueLambda, serializerLambda) => DataTableConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.DataTableConverter> DataTableConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(DataTableConverterValue, reader, objectType, existingValue, serializer, (DataTableConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => DataTableConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.DataTableConverter> DataTableConverterValue, IObservable<System.Type> valueType)
        {
            return Observable.Zip(DataTableConverterValue, valueType, (DataTableConverterValueLambda, valueTypeLambda) => DataTableConverterValueLambda.CanConvert(valueTypeLambda));
        }

    }
}