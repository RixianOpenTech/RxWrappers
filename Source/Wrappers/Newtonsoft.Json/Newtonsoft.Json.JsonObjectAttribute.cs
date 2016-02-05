using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonObjectAttribute
    {
        
        public static IObservable<Newtonsoft.Json.MemberSerialization> get_MemberSerialization(this IObservable<Newtonsoft.Json.JsonObjectAttribute> JsonObjectAttributeValue)
        {
            return Observable.Select(JsonObjectAttributeValue, (JsonObjectAttributeValueLambda) => JsonObjectAttributeValueLambda.MemberSerialization);
        }


        public static IObservable<Newtonsoft.Json.Required> get_ItemRequired(this IObservable<Newtonsoft.Json.JsonObjectAttribute> JsonObjectAttributeValue)
        {
            return Observable.Select(JsonObjectAttributeValue, (JsonObjectAttributeValueLambda) => JsonObjectAttributeValueLambda.ItemRequired);
        }


        public static IObservable<System.Reactive.Unit> set_MemberSerialization(this IObservable<Newtonsoft.Json.JsonObjectAttribute> JsonObjectAttributeValue, IObservable<Newtonsoft.Json.MemberSerialization> value)
        {
            return ObservableExt.ZipExecute(JsonObjectAttributeValue, value, (JsonObjectAttributeValueLambda, valueLambda) => JsonObjectAttributeValueLambda.MemberSerialization = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemRequired(this IObservable<Newtonsoft.Json.JsonObjectAttribute> JsonObjectAttributeValue, IObservable<Newtonsoft.Json.Required> value)
        {
            return ObservableExt.ZipExecute(JsonObjectAttributeValue, value, (JsonObjectAttributeValueLambda, valueLambda) => JsonObjectAttributeValueLambda.ItemRequired = valueLambda);
        }

    }
}