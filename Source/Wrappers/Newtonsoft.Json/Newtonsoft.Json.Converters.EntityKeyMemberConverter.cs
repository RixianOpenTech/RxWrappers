using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __EntityKeyMemberConverter
    {
        
        public static IObservable<System.Reactive.Unit> WriteJson(this IObservable<Newtonsoft.Json.Converters.EntityKeyMemberConverter> EntityKeyMemberConverterValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<System.Object> value, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return ObservableExt.ZipExecute(EntityKeyMemberConverterValue, writer, value, serializer, (EntityKeyMemberConverterValueLambda, writerLambda, valueLambda, serializerLambda) => EntityKeyMemberConverterValueLambda.WriteJson(writerLambda, valueLambda, serializerLambda));
        }


        public static IObservable<System.Object> ReadJson(this IObservable<Newtonsoft.Json.Converters.EntityKeyMemberConverter> EntityKeyMemberConverterValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType, IObservable<System.Object> existingValue, IObservable<Newtonsoft.Json.JsonSerializer> serializer)
        {
            return Observable.Zip(EntityKeyMemberConverterValue, reader, objectType, existingValue, serializer, (EntityKeyMemberConverterValueLambda, readerLambda, objectTypeLambda, existingValueLambda, serializerLambda) => EntityKeyMemberConverterValueLambda.ReadJson(readerLambda, objectTypeLambda, existingValueLambda, serializerLambda));
        }


        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.EntityKeyMemberConverter> EntityKeyMemberConverterValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(EntityKeyMemberConverterValue, objectType, (EntityKeyMemberConverterValueLambda, objectTypeLambda) => EntityKeyMemberConverterValueLambda.CanConvert(objectTypeLambda));
        }

    }
}