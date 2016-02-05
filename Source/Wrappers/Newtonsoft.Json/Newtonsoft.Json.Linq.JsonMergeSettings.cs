using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JsonMergeSettings
    {
        
        public static IObservable<Newtonsoft.Json.Linq.MergeArrayHandling> get_MergeArrayHandling(this IObservable<Newtonsoft.Json.Linq.JsonMergeSettings> JsonMergeSettingsValue)
        {
            return Observable.Select(JsonMergeSettingsValue, (JsonMergeSettingsValueLambda) => JsonMergeSettingsValueLambda.MergeArrayHandling);
        }


        public static IObservable<System.Reactive.Unit> set_MergeArrayHandling(this IObservable<Newtonsoft.Json.Linq.JsonMergeSettings> JsonMergeSettingsValue, IObservable<Newtonsoft.Json.Linq.MergeArrayHandling> value)
        {
            return ObservableExt.ZipExecute(JsonMergeSettingsValue, value, (JsonMergeSettingsValueLambda, valueLambda) => JsonMergeSettingsValueLambda.MergeArrayHandling = valueLambda);
        }

    }
}