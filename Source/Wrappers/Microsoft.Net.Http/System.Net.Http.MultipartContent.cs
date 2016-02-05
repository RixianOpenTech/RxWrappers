using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __MultipartContent
    {
        
        public static IObservable<System.Reactive.Unit> Add(this IObservable<System.Net.Http.MultipartContent> MultipartContentValue, IObservable<System.Net.Http.HttpContent> content)
        {
            return ObservableExt.ZipExecute(MultipartContentValue, content, (MultipartContentValueLambda, contentLambda) => MultipartContentValueLambda.Add(contentLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerator<System.Net.Http.HttpContent>> GetEnumerator(this IObservable<System.Net.Http.MultipartContent> MultipartContentValue)
        {
            return Observable.Select(MultipartContentValue, (MultipartContentValueLambda) => MultipartContentValueLambda.GetEnumerator());
        }

    }
}