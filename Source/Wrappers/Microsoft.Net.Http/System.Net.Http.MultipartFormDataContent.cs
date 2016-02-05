using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http
{
    public static class __MultipartFormDataContent
    {
        
        public static IObservable<System.Reactive.Unit> Add(this IObservable<System.Net.Http.MultipartFormDataContent> MultipartFormDataContentValue, IObservable<System.Net.Http.HttpContent> content)
        {
            return ObservableExt.ZipExecute(MultipartFormDataContentValue, content, (MultipartFormDataContentValueLambda, contentLambda) => MultipartFormDataContentValueLambda.Add(contentLambda));
        }


        public static IObservable<System.Reactive.Unit> Add(this IObservable<System.Net.Http.MultipartFormDataContent> MultipartFormDataContentValue, IObservable<System.Net.Http.HttpContent> content, IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(MultipartFormDataContentValue, content, name, (MultipartFormDataContentValueLambda, contentLambda, nameLambda) => MultipartFormDataContentValueLambda.Add(contentLambda, nameLambda));
        }


        public static IObservable<System.Reactive.Unit> Add(this IObservable<System.Net.Http.MultipartFormDataContent> MultipartFormDataContentValue, IObservable<System.Net.Http.HttpContent> content, IObservable<System.String> name, IObservable<System.String> fileName)
        {
            return ObservableExt.ZipExecute(MultipartFormDataContentValue, content, name, fileName, (MultipartFormDataContentValueLambda, contentLambda, nameLambda, fileNameLambda) => MultipartFormDataContentValueLambda.Add(contentLambda, nameLambda, fileNameLambda));
        }

    }
}