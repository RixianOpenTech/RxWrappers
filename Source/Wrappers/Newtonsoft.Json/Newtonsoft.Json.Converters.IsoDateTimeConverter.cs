using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __IsoDateTimeConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.IsoDateTimeConverter> IsoDateTimeConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(IsoDateTimeConverterValue, writer, value, serializer, (IsoDateTimeConverterValueLambda, writerLambda, valueLambda, serializerLambda) => IsoDateTimeConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.IsoDateTimeConverter> IsoDateTimeConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(IsoDateTimeConverterValue, reader, objectType, existingValue, serializer, (IsoDateTimeConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => IsoDateTimeConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Globalization.DateTimeStyles> get_DateTimeStyles(this IObservable<Newtonsoft.Json.Converters.IsoDateTimeConverter> IsoDateTimeConverterValue)
        {
            return Observable.Select(IsoDateTimeConverterValue, (IsoDateTimeConverterValueLambda) => IsoDateTimeConverterValueLambda.DateTimeStyles);
        }


        public static IObservable<System.String> get_DateTimeFormat(this IObservable<Newtonsoft.Json.Converters.IsoDateTimeConverter> IsoDateTimeConverterValue)
        {
            return Observable.Select(IsoDateTimeConverterValue, (IsoDateTimeConverterValueLambda) => IsoDateTimeConverterValueLambda.DateTimeFormat);
        }


        public static IObservable<System.Globalization.CultureInfo> get_Culture(this IObservable<Newtonsoft.Json.Converters.IsoDateTimeConverter> IsoDateTimeConverterValue)
        {
            return Observable.Select(IsoDateTimeConverterValue, (IsoDateTimeConverterValueLambda) => IsoDateTimeConverterValueLambda.Culture);
        }


        public static IObservable<System.Reactive.Unit> set_DateTimeStyles(this IObservable<Newtonsoft.Json.Converters.IsoDateTimeConverter> IsoDateTimeConverterValue, IObservable<System.Globalization.DateTimeStyles> value)
        {
            return ObservableExt.ZipExecute(IsoDateTimeConverterValue, value, (IsoDateTimeConverterValueLambda, valueLambda) => IsoDateTimeConverterValueLambda.DateTimeStyles = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateTimeFormat(this IObservable<Newtonsoft.Json.Converters.IsoDateTimeConverter> IsoDateTimeConverterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(IsoDateTimeConverterValue, value, (IsoDateTimeConverterValueLambda, valueLambda) => IsoDateTimeConverterValueLambda.DateTimeFormat = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Culture(this IObservable<Newtonsoft.Json.Converters.IsoDateTimeConverter> IsoDateTimeConverterValue, IObservable<System.Globalization.CultureInfo> value)
        {
            return ObservableExt.ZipExecute(IsoDateTimeConverterValue, value, (IsoDateTimeConverterValueLambda, valueLambda) => IsoDateTimeConverterValueLambda.Culture = valueLambda);
        }

    }
}