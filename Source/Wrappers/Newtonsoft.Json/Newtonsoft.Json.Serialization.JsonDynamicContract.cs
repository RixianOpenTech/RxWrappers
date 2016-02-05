using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __JsonDynamicContract
    {
        
        public static IObservable<Newtonsoft.Json.Serialization.JsonPropertyCollection> get_Properties(this IObservable<Newtonsoft.Json.Serialization.JsonDynamicContract> JsonDynamicContractValue)
        {
            return Observable.Select(JsonDynamicContractValue, (JsonDynamicContractValueLambda) => JsonDynamicContractValueLambda.Properties);
        }


        public static IObservable<System.Func<System.String, System.String>> get_PropertyNameResolver(this IObservable<Newtonsoft.Json.Serialization.JsonDynamicContract> JsonDynamicContractValue)
        {
            return Observable.Select(JsonDynamicContractValue, (JsonDynamicContractValueLambda) => JsonDynamicContractValueLambda.PropertyNameResolver);
        }


        public static IObservable<System.Reactive.Unit> set_PropertyNameResolver(this IObservable<Newtonsoft.Json.Serialization.JsonDynamicContract> JsonDynamicContractValue, IObservable<System.Func<System.String, System.String>> value)
        {
            return ObservableExt.ZipExecute(JsonDynamicContractValue, value, (JsonDynamicContractValueLambda, valueLambda) => JsonDynamicContractValueLambda.PropertyNameResolver = valueLambda);
        }

    }
}