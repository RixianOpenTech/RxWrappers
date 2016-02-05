using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __HttpHeaderValueCollection1
    {
        
        public static IObservable<System.Reactive.Unit> Add<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue, IObservable<T> item) where T : class
        {
            return ObservableExt.ZipExecute(HttpHeaderValueCollectionValue, item, (HttpHeaderValueCollectionValueLambda, itemLambda) => HttpHeaderValueCollectionValueLambda.Add(itemLambda));
        }


        public static IObservable<System.Reactive.Unit> ParseAdd<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue, IObservable<System.String> input) where T : class
        {
            return ObservableExt.ZipExecute(HttpHeaderValueCollectionValue, input, (HttpHeaderValueCollectionValueLambda, inputLambda) => HttpHeaderValueCollectionValueLambda.ParseAdd(inputLambda));
        }


        public static IObservable<System.Boolean> TryParseAdd<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue, IObservable<System.String> input) where T : class
        {
            return Observable.Zip(HttpHeaderValueCollectionValue, input, (HttpHeaderValueCollectionValueLambda, inputLambda) => HttpHeaderValueCollectionValueLambda.TryParseAdd(inputLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue) where T : class
        {
            return Observable.Do(HttpHeaderValueCollectionValue, (HttpHeaderValueCollectionValueLambda) => HttpHeaderValueCollectionValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Boolean> Contains<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue, IObservable<T> item) where T : class
        {
            return Observable.Zip(HttpHeaderValueCollectionValue, item, (HttpHeaderValueCollectionValueLambda, itemLambda) => HttpHeaderValueCollectionValueLambda.Contains(itemLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyTo<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue, IObservable<T[]> array, IObservable<System.Int32> arrayIndex) where T : class
        {
            return ObservableExt.ZipExecute(HttpHeaderValueCollectionValue, array, arrayIndex, (HttpHeaderValueCollectionValueLambda, arrayLambda, arrayIndexLambda) => HttpHeaderValueCollectionValueLambda.CopyTo(arrayLambda, arrayIndexLambda));
        }


        public static IObservable<System.Boolean> Remove<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue, IObservable<T> item) where T : class
        {
            return Observable.Zip(HttpHeaderValueCollectionValue, item, (HttpHeaderValueCollectionValueLambda, itemLambda) => HttpHeaderValueCollectionValueLambda.Remove(itemLambda));
        }


        public static IObservable<IEnumerator<T>> GetEnumerator<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue) where T : class
        {
            return Observable.Select(HttpHeaderValueCollectionValue, (HttpHeaderValueCollectionValueLambda) => HttpHeaderValueCollectionValueLambda.GetEnumerator());
        }


        public static IObservable<System.String> ToString<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue) where T : class
        {
            return Observable.Select(HttpHeaderValueCollectionValue, (HttpHeaderValueCollectionValueLambda) => HttpHeaderValueCollectionValueLambda.ToString());
        }


        public static IObservable<System.Int32> get_Count<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue) where T : class
        {
            return Observable.Select(HttpHeaderValueCollectionValue, (HttpHeaderValueCollectionValueLambda) => HttpHeaderValueCollectionValueLambda.Count);
        }


        public static IObservable<System.Boolean> get_IsReadOnly<T>(this IObservable<System.Net.Http.Headers.HttpHeaderValueCollection<T>> HttpHeaderValueCollectionValue) where T : class
        {
            return Observable.Select(HttpHeaderValueCollectionValue, (HttpHeaderValueCollectionValueLambda) => HttpHeaderValueCollectionValueLambda.IsReadOnly);
        }

    }
}