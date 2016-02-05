using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JObject
    {
        
        public static IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty>> Properties(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue)
        {
            return Observable.Select(JObjectValue, (JObjectValueLambda) => JObjectValueLambda.Properties());
        }


        public static IObservable<Newtonsoft.Json.Linq.JProperty> Property(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.String> name)
        {
            return Observable.Zip(JObjectValue, name, (JObjectValueLambda, nameLambda) => JObjectValueLambda.Property(nameLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken>> PropertyValues(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue)
        {
            return Observable.Select(JObjectValue, (JObjectValueLambda) => JObjectValueLambda.PropertyValues());
        }


        public static IObservable<Newtonsoft.Json.Linq.JObject> Load(IObservable<Newtonsoft.Json.JsonReader> reader)
        {
            return Observable.Select(reader, (readerLambda) => Newtonsoft.Json.Linq.JObject.Load(readerLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JObject> Load(IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> settings)
        {
            return Observable.Zip(reader, settings, (readerLambda, settingsLambda) => Newtonsoft.Json.Linq.JObject.Load(readerLambda, settingsLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JObject> Parse(IObservable<System.String> json)
        {
            return Observable.Select(json, (jsonLambda) => Newtonsoft.Json.Linq.JObject.Parse(jsonLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JObject> Parse(IObservable<System.String> json, IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> settings)
        {
            return Observable.Zip(json, settings, (jsonLambda, settingsLambda) => Newtonsoft.Json.Linq.JObject.Parse(jsonLambda, settingsLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JObject> FromObject(IObservable<System.Object> o)
        {
            return Observable.Select(o, (oLambda) => Newtonsoft.Json.Linq.JObject.FromObject(oLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JObject> FromObject(IObservable<System.Object> o, IObservable<Newtonsoft.Json.JsonSerializer> jsonSerializer)
        {
            return Observable.Zip(o, jsonSerializer, (oLambda, jsonSerializerLambda) => Newtonsoft.Json.Linq.JObject.FromObject(oLambda, jsonSerializerLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteTo(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return ObservableExt.ZipExecute(JObjectValue, writer, converters, (JObjectValueLambda, writerLambda, convertersLambda) => JObjectValueLambda.WriteTo(writerLambda, convertersLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> GetValue(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.String> propertyName)
        {
            return Observable.Zip(JObjectValue, propertyName, (JObjectValueLambda, propertyNameLambda) => JObjectValueLambda.GetValue(propertyNameLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> GetValue(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.String> propertyName, IObservable<System.StringComparison> comparison)
        {
            return Observable.Zip(JObjectValue, propertyName, comparison, (JObjectValueLambda, propertyNameLambda, comparisonLambda) => JObjectValueLambda.GetValue(propertyNameLambda, comparisonLambda));
        }


        public static IObservable<Tuple<System.Boolean, Newtonsoft.Json.Linq.JToken>> TryGetValue(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.String> propertyName, IObservable<System.StringComparison> comparison)
        {
            return Observable.Zip(JObjectValue, propertyName, comparison, (JObjectValueLambda, propertyNameLambda, comparisonLambda) => {
Newtonsoft.Json.Linq.JToken valueOutput = default(Newtonsoft.Json.Linq.JToken);
var result = JObjectValueLambda.TryGetValue(propertyNameLambda, comparisonLambda, out valueOutput);
return Tuple.Create(result, valueOutput);
});
        }


        public static IObservable<System.Reactive.Unit> Add(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.String> propertyName, IObservable<Newtonsoft.Json.Linq.JToken> value)
        {
            return ObservableExt.ZipExecute(JObjectValue, propertyName, value, (JObjectValueLambda, propertyNameLambda, valueLambda) => JObjectValueLambda.Add(propertyNameLambda, valueLambda));
        }


        public static IObservable<System.Boolean> Remove(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.String> propertyName)
        {
            return Observable.Zip(JObjectValue, propertyName, (JObjectValueLambda, propertyNameLambda) => JObjectValueLambda.Remove(propertyNameLambda));
        }


        public static IObservable<Tuple<System.Boolean, Newtonsoft.Json.Linq.JToken>> TryGetValue(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.String> propertyName)
        {
            return Observable.Zip(JObjectValue, propertyName, (JObjectValueLambda, propertyNameLambda) => {
Newtonsoft.Json.Linq.JToken valueOutput = default(Newtonsoft.Json.Linq.JToken);
var result = JObjectValueLambda.TryGetValue(propertyNameLambda, out valueOutput);
return Tuple.Create(result, valueOutput);
});
        }


        public static IObservable<IEnumerator<KeyValuePair<string, JToken>>> GetEnumerator(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue)
        {
            return Observable.Select(JObjectValue, (JObjectValueLambda) => JObjectValueLambda.GetEnumerator());
        }


        public static IObservable<Newtonsoft.Json.Linq.JTokenType> get_Type(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue)
        {
            return Observable.Select(JObjectValue, (JObjectValueLambda) => JObjectValueLambda.Type);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Item(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.Object> key)
        {
            return Observable.Zip(JObjectValue, key, (JObjectValueLambda, keyLambda) => JObjectValueLambda[keyLambda]);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Item(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.String> propertyName)
        {
            return Observable.Zip(JObjectValue, propertyName, (JObjectValueLambda, propertyNameLambda) => JObjectValueLambda[propertyName]);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.Object> key, IObservable<Newtonsoft.Json.Linq.JToken> value)
        {
            return ObservableExt.ZipExecute(JObjectValue, key, value, (JObjectValueLambda, keyLambda, valueLambda) => JObjectValueLambda[keyLambda] = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<Newtonsoft.Json.Linq.JObject> JObjectValue, IObservable<System.String> propertyName, IObservable<Newtonsoft.Json.Linq.JToken> value)
        {
            return ObservableExt.ZipExecute(JObjectValue, propertyName, value, (JObjectValueLambda, propertyNameLambda, valueLambda) => JObjectValueLambda[propertyName] = valueLambda);
        }

    }
}