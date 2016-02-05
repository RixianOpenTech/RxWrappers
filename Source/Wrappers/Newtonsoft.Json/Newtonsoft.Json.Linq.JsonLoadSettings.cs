using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JsonLoadSettings
    {
        
        public static IObservable<Newtonsoft.Json.Linq.CommentHandling> get_CommentHandling(this IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> JsonLoadSettingsValue)
        {
            return Observable.Select(JsonLoadSettingsValue, (JsonLoadSettingsValueLambda) => JsonLoadSettingsValueLambda.CommentHandling);
        }


        public static IObservable<Newtonsoft.Json.Linq.LineInfoHandling> get_LineInfoHandling(this IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> JsonLoadSettingsValue)
        {
            return Observable.Select(JsonLoadSettingsValue, (JsonLoadSettingsValueLambda) => JsonLoadSettingsValueLambda.LineInfoHandling);
        }


        public static IObservable<System.Reactive.Unit> set_CommentHandling(this IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> JsonLoadSettingsValue, IObservable<Newtonsoft.Json.Linq.CommentHandling> value)
        {
            return ObservableExt.ZipExecute(JsonLoadSettingsValue, value, (JsonLoadSettingsValueLambda, valueLambda) => JsonLoadSettingsValueLambda.CommentHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_LineInfoHandling(this IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> JsonLoadSettingsValue, IObservable<Newtonsoft.Json.Linq.LineInfoHandling> value)
        {
            return ObservableExt.ZipExecute(JsonLoadSettingsValue, value, (JsonLoadSettingsValueLambda, valueLambda) => JsonLoadSettingsValueLambda.LineInfoHandling = valueLambda);
        }

    }
}