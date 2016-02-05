using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JContainer
    {
        
        public static IObservable<Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken>> Children(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue)
        {
            return Observable.Select(JContainerValue, (JContainerValueLambda) => JContainerValueLambda.Children());
        }


        public static IObservable<IEnumerable<T>> Values<T>(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue)
        {
            return Observable.Select(JContainerValue, (JContainerValueLambda) => JContainerValueLambda.Values<T>());
        }


        public static IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> Descendants(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue)
        {
            return Observable.Select(JContainerValue, (JContainerValueLambda) => JContainerValueLambda.Descendants());
        }


        public static IObservable<System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>> DescendantsAndSelf(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue)
        {
            return Observable.Select(JContainerValue, (JContainerValueLambda) => JContainerValueLambda.DescendantsAndSelf());
        }


        public static IObservable<System.Reactive.Unit> Add(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue, IObservable<System.Object> content)
        {
            return ObservableExt.ZipExecute(JContainerValue, content, (JContainerValueLambda, contentLambda) => JContainerValueLambda.Add(contentLambda));
        }


        public static IObservable<System.Reactive.Unit> AddFirst(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue, IObservable<System.Object> content)
        {
            return ObservableExt.ZipExecute(JContainerValue, content, (JContainerValueLambda, contentLambda) => JContainerValueLambda.AddFirst(contentLambda));
        }


        public static IObservable<Newtonsoft.Json.JsonWriter> CreateWriter(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue)
        {
            return Observable.Select(JContainerValue, (JContainerValueLambda) => JContainerValueLambda.CreateWriter());
        }


        public static IObservable<System.Reactive.Unit> ReplaceAll(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue, IObservable<System.Object> content)
        {
            return ObservableExt.ZipExecute(JContainerValue, content, (JContainerValueLambda, contentLambda) => JContainerValueLambda.ReplaceAll(contentLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAll(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue)
        {
            return Observable.Do(JContainerValue, (JContainerValueLambda) => JContainerValueLambda.RemoveAll()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Merge(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue, IObservable<System.Object> content)
        {
            return ObservableExt.ZipExecute(JContainerValue, content, (JContainerValueLambda, contentLambda) => JContainerValueLambda.Merge(contentLambda));
        }


        public static IObservable<System.Reactive.Unit> Merge(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue, IObservable<System.Object> content, IObservable<Newtonsoft.Json.Linq.JsonMergeSettings> settings)
        {
            return ObservableExt.ZipExecute(JContainerValue, content, settings, (JContainerValueLambda, contentLambda, settingsLambda) => JContainerValueLambda.Merge(contentLambda, settingsLambda));
        }


        public static IObservable<System.Boolean> get_HasValues(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue)
        {
            return Observable.Select(JContainerValue, (JContainerValueLambda) => JContainerValueLambda.HasValues);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_First(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue)
        {
            return Observable.Select(JContainerValue, (JContainerValueLambda) => JContainerValueLambda.First);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Last(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue)
        {
            return Observable.Select(JContainerValue, (JContainerValueLambda) => JContainerValueLambda.Last);
        }


        public static IObservable<System.Int32> get_Count(this IObservable<Newtonsoft.Json.Linq.JContainer> JContainerValue)
        {
            return Observable.Select(JContainerValue, (JContainerValueLambda) => JContainerValueLambda.Count);
        }

    }
}