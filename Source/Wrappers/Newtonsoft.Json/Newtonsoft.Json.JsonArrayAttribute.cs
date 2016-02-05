using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonArrayAttribute
    {
        
        public static IObservable<System.Boolean> get_AllowNullItems(this IObservable<Newtonsoft.Json.JsonArrayAttribute> JsonArrayAttributeValue)
        {
            return Observable.Select(JsonArrayAttributeValue, (JsonArrayAttributeValueLambda) => JsonArrayAttributeValueLambda.AllowNullItems);
        }


        public static IObservable<System.Reactive.Unit> set_AllowNullItems(this IObservable<Newtonsoft.Json.JsonArrayAttribute> JsonArrayAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonArrayAttributeValue, value, (JsonArrayAttributeValueLambda, valueLambda) => JsonArrayAttributeValueLambda.AllowNullItems = valueLambda);
        }

    }
}