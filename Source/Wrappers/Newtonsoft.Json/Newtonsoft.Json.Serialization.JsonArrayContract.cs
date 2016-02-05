using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __JsonArrayContract
    {
        
        public static IObservable<System.Type> get_CollectionItemType(this IObservable<Newtonsoft.Json.Serialization.JsonArrayContract> JsonArrayContractValue)
        {
            return Observable.Select(JsonArrayContractValue, (JsonArrayContractValueLambda) => JsonArrayContractValueLambda.CollectionItemType);
        }


        public static IObservable<System.Boolean> get_IsMultidimensionalArray(this IObservable<Newtonsoft.Json.Serialization.JsonArrayContract> JsonArrayContractValue)
        {
            return Observable.Select(JsonArrayContractValue, (JsonArrayContractValueLambda) => JsonArrayContractValueLambda.IsMultidimensionalArray);
        }


        public static IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>> get_OverrideCreator(this IObservable<Newtonsoft.Json.Serialization.JsonArrayContract> JsonArrayContractValue)
        {
            return Observable.Select(JsonArrayContractValue, (JsonArrayContractValueLambda) => JsonArrayContractValueLambda.OverrideCreator);
        }


        public static IObservable<System.Boolean> get_HasParameterizedCreator(this IObservable<Newtonsoft.Json.Serialization.JsonArrayContract> JsonArrayContractValue)
        {
            return Observable.Select(JsonArrayContractValue, (JsonArrayContractValueLambda) => JsonArrayContractValueLambda.HasParameterizedCreator);
        }


        public static IObservable<System.Reactive.Unit> set_OverrideCreator(this IObservable<Newtonsoft.Json.Serialization.JsonArrayContract> JsonArrayContractValue, IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>> value)
        {
            return ObservableExt.ZipExecute(JsonArrayContractValue, value, (JsonArrayContractValueLambda, valueLambda) => JsonArrayContractValueLambda.OverrideCreator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_HasParameterizedCreator(this IObservable<Newtonsoft.Json.Serialization.JsonArrayContract> JsonArrayContractValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonArrayContractValue, value, (JsonArrayContractValueLambda, valueLambda) => JsonArrayContractValueLambda.HasParameterizedCreator = valueLambda);
        }

    }
}