using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JArray
    {
        
        public static IObservable<Newtonsoft.Json.Linq.JArray> Load(IObservable<Newtonsoft.Json.JsonReader> reader)
        {
            return Observable.Select(reader, (readerLambda) => Newtonsoft.Json.Linq.JArray.Load(readerLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JArray> Load(IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> settings)
        {
            return Observable.Zip(reader, settings, (readerLambda, settingsLambda) => Newtonsoft.Json.Linq.JArray.Load(readerLambda, settingsLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JArray> Parse(IObservable<System.String> json)
        {
            return Observable.Select(json, (jsonLambda) => Newtonsoft.Json.Linq.JArray.Parse(jsonLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JArray> Parse(IObservable<System.String> json, IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> settings)
        {
            return Observable.Zip(json, settings, (jsonLambda, settingsLambda) => Newtonsoft.Json.Linq.JArray.Parse(jsonLambda, settingsLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JArray> FromObject(IObservable<System.Object> o)
        {
            return Observable.Select(o, (oLambda) => Newtonsoft.Json.Linq.JArray.FromObject(oLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JArray> FromObject(IObservable<System.Object> o, IObservable<Newtonsoft.Json.JsonSerializer> jsonSerializer)
        {
            return Observable.Zip(o, jsonSerializer, (oLambda, jsonSerializerLambda) => Newtonsoft.Json.Linq.JArray.FromObject(oLambda, jsonSerializerLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteTo(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return ObservableExt.ZipExecute(JArrayValue, writer, converters, (JArrayValueLambda, writerLambda, convertersLambda) => JArrayValueLambda.WriteTo(writerLambda, convertersLambda));
        }


        public static IObservable<System.Int32> IndexOf(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<Newtonsoft.Json.Linq.JToken> item)
        {
            return Observable.Zip(JArrayValue, item, (JArrayValueLambda, itemLambda) => JArrayValueLambda.IndexOf(itemLambda));
        }


        public static IObservable<System.Reactive.Unit> Insert(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<System.Int32> index, IObservable<Newtonsoft.Json.Linq.JToken> item)
        {
            return ObservableExt.ZipExecute(JArrayValue, index, item, (JArrayValueLambda, indexLambda, itemLambda) => JArrayValueLambda.Insert(indexLambda, itemLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAt(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(JArrayValue, index, (JArrayValueLambda, indexLambda) => JArrayValueLambda.RemoveAt(indexLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>> GetEnumerator(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue)
        {
            return Observable.Select(JArrayValue, (JArrayValueLambda) => JArrayValueLambda.GetEnumerator());
        }


        public static IObservable<System.Reactive.Unit> Add(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<Newtonsoft.Json.Linq.JToken> item)
        {
            return ObservableExt.ZipExecute(JArrayValue, item, (JArrayValueLambda, itemLambda) => JArrayValueLambda.Add(itemLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue)
        {
            return Observable.Do(JArrayValue, (JArrayValueLambda) => JArrayValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Boolean> Contains(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<Newtonsoft.Json.Linq.JToken> item)
        {
            return Observable.Zip(JArrayValue, item, (JArrayValueLambda, itemLambda) => JArrayValueLambda.Contains(itemLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<Newtonsoft.Json.Linq.JToken[]> array, IObservable<System.Int32> arrayIndex)
        {
            return ObservableExt.ZipExecute(JArrayValue, array, arrayIndex, (JArrayValueLambda, arrayLambda, arrayIndexLambda) => JArrayValueLambda.CopyTo(arrayLambda, arrayIndexLambda));
        }


        public static IObservable<System.Boolean> Remove(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<Newtonsoft.Json.Linq.JToken> item)
        {
            return Observable.Zip(JArrayValue, item, (JArrayValueLambda, itemLambda) => JArrayValueLambda.Remove(itemLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JTokenType> get_Type(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue)
        {
            return Observable.Select(JArrayValue, (JArrayValueLambda) => JArrayValueLambda.Type);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Item(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<System.Object> key)
        {
            return Observable.Zip(JArrayValue, key, (JArrayValueLambda, keyLambda) => JArrayValueLambda[keyLambda]);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Item(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(JArrayValue, index, (JArrayValueLambda, indexLambda) => JArrayValueLambda[indexLambda]);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue)
        {
            return Observable.Select(JArrayValue, (JArrayValueLambda) => JArrayValueLambda.IsReadOnly);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<System.Object> key, IObservable<Newtonsoft.Json.Linq.JToken> value)
        {
            return ObservableExt.ZipExecute(JArrayValue, key, value, (JArrayValueLambda, keyLambda, valueLambda) => JArrayValueLambda[valueLambda] = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<Newtonsoft.Json.Linq.JArray> JArrayValue, IObservable<System.Int32> index, IObservable<Newtonsoft.Json.Linq.JToken> value)
        {
            return ObservableExt.ZipExecute(JArrayValue, index, value, (JArrayValueLambda, indexLambda, valueLambda) => JArrayValueLambda[indexLambda] = valueLambda);
        }

    }
}