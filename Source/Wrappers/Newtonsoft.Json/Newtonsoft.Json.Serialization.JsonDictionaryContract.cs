using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __JsonDictionaryContract
    {
        
        public static IObservable<System.Func<System.String, System.String>> get_PropertyNameResolver(this IObservable<Newtonsoft.Json.Serialization.JsonDictionaryContract> JsonDictionaryContractValue)
        {
            return Observable.Select(JsonDictionaryContractValue, (JsonDictionaryContractValueLambda) => JsonDictionaryContractValueLambda.PropertyNameResolver);
        }


        public static IObservable<System.Func<System.String, System.String>> get_DictionaryKeyResolver(this IObservable<Newtonsoft.Json.Serialization.JsonDictionaryContract> JsonDictionaryContractValue)
        {
            return Observable.Select(JsonDictionaryContractValue, (JsonDictionaryContractValueLambda) => JsonDictionaryContractValueLambda.DictionaryKeyResolver);
        }


        public static IObservable<System.Type> get_DictionaryKeyType(this IObservable<Newtonsoft.Json.Serialization.JsonDictionaryContract> JsonDictionaryContractValue)
        {
            return Observable.Select(JsonDictionaryContractValue, (JsonDictionaryContractValueLambda) => JsonDictionaryContractValueLambda.DictionaryKeyType);
        }


        public static IObservable<System.Type> get_DictionaryValueType(this IObservable<Newtonsoft.Json.Serialization.JsonDictionaryContract> JsonDictionaryContractValue)
        {
            return Observable.Select(JsonDictionaryContractValue, (JsonDictionaryContractValueLambda) => JsonDictionaryContractValueLambda.DictionaryValueType);
        }


        public static IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>> get_OverrideCreator(this IObservable<Newtonsoft.Json.Serialization.JsonDictionaryContract> JsonDictionaryContractValue)
        {
            return Observable.Select(JsonDictionaryContractValue, (JsonDictionaryContractValueLambda) => JsonDictionaryContractValueLambda.OverrideCreator);
        }


        public static IObservable<System.Boolean> get_HasParameterizedCreator(this IObservable<Newtonsoft.Json.Serialization.JsonDictionaryContract> JsonDictionaryContractValue)
        {
            return Observable.Select(JsonDictionaryContractValue, (JsonDictionaryContractValueLambda) => JsonDictionaryContractValueLambda.HasParameterizedCreator);
        }


        public static IObservable<System.Reactive.Unit> set_PropertyNameResolver(this IObservable<Newtonsoft.Json.Serialization.JsonDictionaryContract> JsonDictionaryContractValue, IObservable<System.Func<System.String, System.String>> value)
        {
            return ObservableExt.ZipExecute(JsonDictionaryContractValue, value, (JsonDictionaryContractValueLambda, valueLambda) => JsonDictionaryContractValueLambda.PropertyNameResolver = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DictionaryKeyResolver(this IObservable<Newtonsoft.Json.Serialization.JsonDictionaryContract> JsonDictionaryContractValue, IObservable<System.Func<System.String, System.String>> value)
        {
            return ObservableExt.ZipExecute(JsonDictionaryContractValue, value, (JsonDictionaryContractValueLambda, valueLambda) => JsonDictionaryContractValueLambda.DictionaryKeyResolver = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_OverrideCreator(this IObservable<Newtonsoft.Json.Serialization.JsonDictionaryContract> JsonDictionaryContractValue, IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>> value)
        {
            return ObservableExt.ZipExecute(JsonDictionaryContractValue, value, (JsonDictionaryContractValueLambda, valueLambda) => JsonDictionaryContractValueLambda.OverrideCreator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_HasParameterizedCreator(this IObservable<Newtonsoft.Json.Serialization.JsonDictionaryContract> JsonDictionaryContractValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonDictionaryContractValue, value, (JsonDictionaryContractValueLambda, valueLambda) => JsonDictionaryContractValueLambda.HasParameterizedCreator = valueLambda);
        }

    }
}