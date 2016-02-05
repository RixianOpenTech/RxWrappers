using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JProperty
    {
        
        public static IObservable<System.Reactive.Unit> WriteTo(this IObservable<Newtonsoft.Json.Linq.JProperty> JPropertyValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return ObservableExt.ZipExecute(JPropertyValue, writer, converters, (JPropertyValueLambda, writerLambda, convertersLambda) => JPropertyValueLambda.WriteTo(writerLambda, convertersLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JProperty> Load(IObservable<Newtonsoft.Json.JsonReader> reader)
        {
            return Observable.Select(reader, (readerLambda) => Newtonsoft.Json.Linq.JProperty.Load(readerLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JProperty> Load(IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> settings)
        {
            return Observable.Zip(reader, settings, (readerLambda, settingsLambda) => Newtonsoft.Json.Linq.JProperty.Load(readerLambda, settingsLambda));
        }


        public static IObservable<System.String> get_Name(this IObservable<Newtonsoft.Json.Linq.JProperty> JPropertyValue)
        {
            return Observable.Select(JPropertyValue, (JPropertyValueLambda) => JPropertyValueLambda.Name);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Value(this IObservable<Newtonsoft.Json.Linq.JProperty> JPropertyValue)
        {
            return Observable.Select(JPropertyValue, (JPropertyValueLambda) => JPropertyValueLambda.Value);
        }


        public static IObservable<Newtonsoft.Json.Linq.JTokenType> get_Type(this IObservable<Newtonsoft.Json.Linq.JProperty> JPropertyValue)
        {
            return Observable.Select(JPropertyValue, (JPropertyValueLambda) => JPropertyValueLambda.Type);
        }


        public static IObservable<System.Reactive.Unit> set_Value(this IObservable<Newtonsoft.Json.Linq.JProperty> JPropertyValue, IObservable<Newtonsoft.Json.Linq.JToken> value)
        {
            return ObservableExt.ZipExecute(JPropertyValue, value, (JPropertyValueLambda, valueLambda) => JPropertyValueLambda.Value = valueLambda);
        }

    }
}