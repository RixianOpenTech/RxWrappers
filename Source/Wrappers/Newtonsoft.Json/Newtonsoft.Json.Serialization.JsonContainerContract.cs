using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __JsonContainerContract
    {
        
        public static IObservable<Newtonsoft.Json.JsonConverter> get_ItemConverter(this IObservable<Newtonsoft.Json.Serialization.JsonContainerContract> JsonContainerContractValue)
        {
            return Observable.Select(JsonContainerContractValue, (JsonContainerContractValueLambda) => JsonContainerContractValueLambda.ItemConverter);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_ItemIsReference(this IObservable<Newtonsoft.Json.Serialization.JsonContainerContract> JsonContainerContractValue)
        {
            return Observable.Select(JsonContainerContractValue, (JsonContainerContractValueLambda) => JsonContainerContractValueLambda.ItemIsReference);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>> get_ItemReferenceLoopHandling(this IObservable<Newtonsoft.Json.Serialization.JsonContainerContract> JsonContainerContractValue)
        {
            return Observable.Select(JsonContainerContractValue, (JsonContainerContractValueLambda) => JsonContainerContractValueLambda.ItemReferenceLoopHandling);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.TypeNameHandling>> get_ItemTypeNameHandling(this IObservable<Newtonsoft.Json.Serialization.JsonContainerContract> JsonContainerContractValue)
        {
            return Observable.Select(JsonContainerContractValue, (JsonContainerContractValueLambda) => JsonContainerContractValueLambda.ItemTypeNameHandling);
        }


        public static IObservable<System.Reactive.Unit> set_ItemConverter(this IObservable<Newtonsoft.Json.Serialization.JsonContainerContract> JsonContainerContractValue, IObservable<Newtonsoft.Json.JsonConverter> value)
        {
            return ObservableExt.ZipExecute(JsonContainerContractValue, value, (JsonContainerContractValueLambda, valueLambda) => JsonContainerContractValueLambda.ItemConverter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemIsReference(this IObservable<Newtonsoft.Json.Serialization.JsonContainerContract> JsonContainerContractValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonContainerContractValue, value, (JsonContainerContractValueLambda, valueLambda) => JsonContainerContractValueLambda.ItemIsReference = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemReferenceLoopHandling(this IObservable<Newtonsoft.Json.Serialization.JsonContainerContract> JsonContainerContractValue, IObservable<System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>> value)
        {
            return ObservableExt.ZipExecute(JsonContainerContractValue, value, (JsonContainerContractValueLambda, valueLambda) => JsonContainerContractValueLambda.ItemReferenceLoopHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemTypeNameHandling(this IObservable<Newtonsoft.Json.Serialization.JsonContainerContract> JsonContainerContractValue, IObservable<System.Nullable<Newtonsoft.Json.TypeNameHandling>> value)
        {
            return ObservableExt.ZipExecute(JsonContainerContractValue, value, (JsonContainerContractValueLambda, valueLambda) => JsonContainerContractValueLambda.ItemTypeNameHandling = valueLambda);
        }

    }
}