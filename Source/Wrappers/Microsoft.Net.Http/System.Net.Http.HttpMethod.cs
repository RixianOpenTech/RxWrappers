using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __HttpMethod
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.HttpMethod> HttpMethodValue, IObservable<System.Net.Http.HttpMethod> other)
        {
            return Observable.Zip(HttpMethodValue, other, (HttpMethodValueLambda, otherLambda) => HttpMethodValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.HttpMethod> HttpMethodValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(HttpMethodValue, obj, (HttpMethodValueLambda, objLambda) => HttpMethodValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.HttpMethod> HttpMethodValue)
        {
            return Observable.Select(HttpMethodValue, (HttpMethodValueLambda) => HttpMethodValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.HttpMethod> HttpMethodValue)
        {
            return Observable.Select(HttpMethodValue, (HttpMethodValueLambda) => HttpMethodValueLambda.ToString());
        }


        public static IObservable<System.Net.Http.HttpMethod> get_Get()
        {
            return ObservableExt.Factory(() => System.Net.Http.HttpMethod.Get);
        }


        public static IObservable<System.Net.Http.HttpMethod> get_Put()
        {
            return ObservableExt.Factory(() => System.Net.Http.HttpMethod.Put);
        }


        public static IObservable<System.Net.Http.HttpMethod> get_Post()
        {
            return ObservableExt.Factory(() => System.Net.Http.HttpMethod.Post);
        }


        public static IObservable<System.Net.Http.HttpMethod> get_Delete()
        {
            return ObservableExt.Factory(() => System.Net.Http.HttpMethod.Delete);
        }


        public static IObservable<System.Net.Http.HttpMethod> get_Head()
        {
            return ObservableExt.Factory(() => System.Net.Http.HttpMethod.Head);
        }


        public static IObservable<System.Net.Http.HttpMethod> get_Options()
        {
            return ObservableExt.Factory(() => System.Net.Http.HttpMethod.Options);
        }


        public static IObservable<System.Net.Http.HttpMethod> get_Trace()
        {
            return ObservableExt.Factory(() => System.Net.Http.HttpMethod.Trace);
        }


        public static IObservable<System.String> get_Method(this IObservable<System.Net.Http.HttpMethod> HttpMethodValue)
        {
            return Observable.Select(HttpMethodValue, (HttpMethodValueLambda) => HttpMethodValueLambda.Method);
        }

    }
}