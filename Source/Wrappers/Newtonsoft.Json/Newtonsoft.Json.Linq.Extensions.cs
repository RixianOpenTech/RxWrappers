using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __Extensions
    {
        
        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>> Ancestors<T>(IObservable<IEnumerable<T>> source) where T : Newtonsoft.Json.Linq.JContainer
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.Ancestors<T>(sourceLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>> AncestorsAndSelf<T>(IObservable<IEnumerable<T>> source) where T : Newtonsoft.Json.Linq.JContainer
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.AncestorsAndSelf<T>(sourceLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>> Descendants<T>(IObservable<IEnumerable<T>> source) where T : Newtonsoft.Json.Linq.JContainer
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.Descendants<T>(sourceLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>> DescendantsAndSelf<T>(IObservable<IEnumerable<T>> source) where T : Newtonsoft.Json.Linq.JContainer
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.DescendantsAndSelf<T>(sourceLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JProperty>> Properties(IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JObject>> source)
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.Properties(sourceLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>> Values(IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> source, IObservable<System.Object> key)
        {
            return Observable.Zip(source, key, (sourceLambda, keyLambda) => Newtonsoft.Json.Linq.Extensions.Values(sourceLambda, keyLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>> Values(IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> source)
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.Values(sourceLambda));
        }


        public static IObservable<IEnumerable<U>> Values<U>(IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> source, IObservable<System.Object> key)
        {
            return Observable.Zip(source, key, (sourceLambda, keyLambda) => Newtonsoft.Json.Linq.Extensions.Values<U>(sourceLambda, keyLambda));
        }


        public static IObservable<IEnumerable<U>> Values<U>(IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> source)
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.Values<U>(sourceLambda));
        }


        public static IObservable<U> Value<U>(IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.Linq.Extensions.Value<U>(valueLambda));
        }


        public static IObservable<U> Value<T, U>(IObservable<IEnumerable<T>> value) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.Linq.Extensions.Value<T, U>(valueLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>> Children<T>(IObservable<IEnumerable<T>> source) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.Children<T>(sourceLambda));
        }


        public static IObservable<IEnumerable<U>> Children<T, U>(IObservable<IEnumerable<T>> source) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.Children<T, U>(sourceLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>> AsJEnumerable(IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> source)
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.AsJEnumerable(sourceLambda));
        }


        public static IObservable<IJEnumerable<T>> AsJEnumerable<T>(IObservable<IEnumerable<T>> source) where T : Newtonsoft.Json.Linq.JToken
        {
            return Observable.Select(source, (sourceLambda) => Newtonsoft.Json.Linq.Extensions.AsJEnumerable(sourceLambda));
        }

    }
}