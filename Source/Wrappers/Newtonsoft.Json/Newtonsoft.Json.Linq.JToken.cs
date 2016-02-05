using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JToken
    {
        
        public static IObservable<Newtonsoft.Json.JsonReader> CreateReader(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.CreateReader());
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> FromObject(IObservable<System.Object> o)
        {
            return Observable.Select(o, (oLambda) => Newtonsoft.Json.Linq.JToken.FromObject(oLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> FromObject(IObservable<System.Object> o, IObservable<Newtonsoft.Json.JsonSerializer> jsonSerializer)
        {
            return Observable.Zip(o, jsonSerializer, (oLambda, jsonSerializerLambda) => Newtonsoft.Json.Linq.JToken.FromObject(oLambda, jsonSerializerLambda));
        }


        public static IObservable<T> ToObject<T>(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue) where T : class
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.ToObject<T>());
        }


        public static IObservable<System.Object> ToObject(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(JTokenValue, objectType, (JTokenValueLambda, objectTypeLambda) => JTokenValueLambda.ToObject(objectTypeLambda));
        }


        public static IObservable<T> ToObject<T>(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<Newtonsoft.Json.JsonSerializer> jsonSerializer)
        {
            return Observable.Zip(JTokenValue, jsonSerializer, (JTokenValueLambda, jsonSerializerLambda) => JTokenValueLambda.ToObject<T>(jsonSerializerLambda));
        }


        public static IObservable<System.Object> ToObject(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Type> objectType, IObservable<Newtonsoft.Json.JsonSerializer> jsonSerializer)
        {
            return Observable.Zip(JTokenValue, objectType, jsonSerializer, (JTokenValueLambda, objectTypeLambda, jsonSerializerLambda) => JTokenValueLambda.ToObject(objectTypeLambda, jsonSerializerLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> ReadFrom(IObservable<Newtonsoft.Json.JsonReader> reader)
        {
            return Observable.Select(reader, (readerLambda) => Newtonsoft.Json.Linq.JToken.ReadFrom(readerLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> ReadFrom(IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> settings)
        {
            return Observable.Zip(reader, settings, (readerLambda, settingsLambda) => Newtonsoft.Json.Linq.JToken.ReadFrom(readerLambda, settingsLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> Parse(IObservable<System.String> json)
        {
            return Observable.Select(json, (jsonLambda) => Newtonsoft.Json.Linq.JToken.Parse(jsonLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> Parse(IObservable<System.String> json, IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> settings)
        {
            return Observable.Zip(json, settings, (jsonLambda, settingsLambda) => Newtonsoft.Json.Linq.JToken.Parse(jsonLambda, settingsLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> Load(IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> settings)
        {
            return Observable.Zip(reader, settings, (readerLambda, settingsLambda) => Newtonsoft.Json.Linq.JToken.Load(readerLambda, settingsLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> Load(IObservable<Newtonsoft.Json.JsonReader> reader)
        {
            return Observable.Select(reader, (readerLambda) => Newtonsoft.Json.Linq.JToken.Load(readerLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> SelectToken(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.String> path)
        {
            return Observable.Zip(JTokenValue, path, (JTokenValueLambda, pathLambda) => JTokenValueLambda.SelectToken(pathLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> SelectToken(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.String> path, IObservable<System.Boolean> errorWhenNoMatch)
        {
            return Observable.Zip(JTokenValue, path, errorWhenNoMatch, (JTokenValueLambda, pathLambda, errorWhenNoMatchLambda) => JTokenValueLambda.SelectToken(pathLambda, errorWhenNoMatchLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> SelectTokens(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.String> path)
        {
            return Observable.Zip(JTokenValue, path, (JTokenValueLambda, pathLambda) => JTokenValueLambda.SelectTokens(pathLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> SelectTokens(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.String> path, IObservable<System.Boolean> errorWhenNoMatch)
        {
            return Observable.Zip(JTokenValue, path, errorWhenNoMatch, (JTokenValueLambda, pathLambda, errorWhenNoMatchLambda) => JTokenValueLambda.SelectTokens(pathLambda, errorWhenNoMatchLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> DeepClone(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.DeepClone());
        }


        public static IObservable<System.Reactive.Unit> AddAnnotation(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Object> annotation)
        {
            return ObservableExt.ZipExecute(JTokenValue, annotation, (JTokenValueLambda, annotationLambda) => JTokenValueLambda.AddAnnotation(annotationLambda));
        }


        public static IObservable<T> Annotation<T>(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue) where T : class
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Annotation<T>());
        }


        public static IObservable<System.Object> Annotation(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Type> type)
        {
            return Observable.Zip(JTokenValue, type, (JTokenValueLambda, typeLambda) => JTokenValueLambda.Annotation(typeLambda));
        }


        public static IObservable<IEnumerable<T>> Annotations<T>(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue) where T : class
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Annotations<T>());
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.Object>> Annotations(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Type> type)
        {
            return Observable.Zip(JTokenValue, type, (JTokenValueLambda, typeLambda) => JTokenValueLambda.Annotations(typeLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAnnotations<T>(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue) where T : class
        {
            return Observable.Do(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.RemoveAnnotations<T>()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> RemoveAnnotations(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Type> type)
        {
            return ObservableExt.ZipExecute(JTokenValue, type, (JTokenValueLambda, typeLambda) => JTokenValueLambda.RemoveAnnotations(typeLambda));
        }


        public static IObservable<System.Boolean> DeepEquals(IObservable<Newtonsoft.Json.Linq.JToken> t1, IObservable<Newtonsoft.Json.Linq.JToken> t2)
        {
            return Observable.Zip(t1, t2, (t1Lambda, t2Lambda) => Newtonsoft.Json.Linq.JToken.DeepEquals(t1Lambda, t2Lambda));
        }


        public static IObservable<System.Reactive.Unit> AddAfterSelf(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Object> content)
        {
            return ObservableExt.ZipExecute(JTokenValue, content, (JTokenValueLambda, contentLambda) => JTokenValueLambda.AddAfterSelf(contentLambda));
        }


        public static IObservable<System.Reactive.Unit> AddBeforeSelf(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Object> content)
        {
            return ObservableExt.ZipExecute(JTokenValue, content, (JTokenValueLambda, contentLambda) => JTokenValueLambda.AddBeforeSelf(contentLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> Ancestors(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Ancestors());
        }


        public static IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> AncestorsAndSelf(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.AncestorsAndSelf());
        }


        public static IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> AfterSelf(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.AfterSelf());
        }


        public static IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> BeforeSelf(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.BeforeSelf());
        }


        public static IObservable<T> Value<T>(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Object> key)
        {
            return Observable.Zip(JTokenValue, key, (JTokenValueLambda, keyLambda) => JTokenValueLambda.Value<T>(keyLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken>> Children(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Children());
        }


        public static IObservable<JEnumerable<T>> Children<T>(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Children<T>());
        }


        public static IObservable<IEnumerable<T>> Values<T>(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Values<T>());
        }


        public static IObservable<System.Reactive.Unit> Remove(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Do(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Remove()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Replace(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<Newtonsoft.Json.Linq.JToken> value)
        {
            return ObservableExt.ZipExecute(JTokenValue, value, (JTokenValueLambda, valueLambda) => JTokenValueLambda.Replace(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteTo(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return ObservableExt.ZipExecute(JTokenValue, writer, converters, (JTokenValueLambda, writerLambda, convertersLambda) => JTokenValueLambda.WriteTo(writerLambda, convertersLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.ToString());
        }


        public static IObservable<System.String> ToString(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<Newtonsoft.Json.Formatting> formatting, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return Observable.Zip(JTokenValue, formatting, converters, (JTokenValueLambda, formattingLambda, convertersLambda) => JTokenValueLambda.ToString(formattingLambda, convertersLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JTokenEqualityComparer> get_EqualityComparer()
        {
            return ObservableExt.Factory(() => Newtonsoft.Json.Linq.JToken.EqualityComparer);
        }


        public static IObservable<Newtonsoft.Json.Linq.JContainer> get_Parent(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Parent);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Root(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Root);
        }


        public static IObservable<Newtonsoft.Json.Linq.JTokenType> get_Type(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Type);
        }


        public static IObservable<System.Boolean> get_HasValues(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.HasValues);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Next(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Next);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Previous(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Previous);
        }


        public static IObservable<System.String> get_Path(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Path);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Item(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Object> key)
        {
            return Observable.Zip(JTokenValue, key, (JTokenValueLambda, keyLambda) => JTokenValueLambda[keyLambda]);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_First(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.First);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Last(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue)
        {
            return Observable.Select(JTokenValue, (JTokenValueLambda) => JTokenValueLambda.Last);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<Newtonsoft.Json.Linq.JToken> JTokenValue, IObservable<System.Object> key, IObservable<Newtonsoft.Json.Linq.JToken> value)
        {
            return ObservableExt.ZipExecute(JTokenValue, key, value, (JTokenValueLambda, keyLambda, valueLambda) => JTokenValueLambda[keyLambda] = valueLambda);
        }

    }
}