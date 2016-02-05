using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __JsonObjectContract
    {
        
        public static IObservable<Newtonsoft.Json.MemberSerialization> get_MemberSerialization(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.MemberSerialization);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.Required>> get_ItemRequired(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.ItemRequired);
        }


        public static IObservable<Newtonsoft.Json.Serialization.JsonPropertyCollection> get_Properties(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.Properties);
        }


        public static IObservable<Newtonsoft.Json.Serialization.JsonPropertyCollection> get_ConstructorParameters(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.ConstructorParameters);
        }


        public static IObservable<Newtonsoft.Json.Serialization.JsonPropertyCollection> get_CreatorParameters(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.CreatorParameters);
        }


        public static IObservable<System.Reflection.ConstructorInfo> get_OverrideConstructor(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.OverrideConstructor);
        }


        public static IObservable<System.Reflection.ConstructorInfo> get_ParametrizedConstructor(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.ParametrizedConstructor);
        }


        public static IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>> get_OverrideCreator(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.OverrideCreator);
        }


        public static IObservable<Newtonsoft.Json.Serialization.ExtensionDataSetter> get_ExtensionDataSetter(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.ExtensionDataSetter);
        }


        public static IObservable<Newtonsoft.Json.Serialization.ExtensionDataGetter> get_ExtensionDataGetter(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.ExtensionDataGetter);
        }


        public static IObservable<System.Type> get_ExtensionDataValueType(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue)
        {
            return Observable.Select(JsonObjectContractValue, (JsonObjectContractValueLambda) => JsonObjectContractValueLambda.ExtensionDataValueType);
        }


        public static IObservable<System.Reactive.Unit> set_MemberSerialization(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue, IObservable<Newtonsoft.Json.MemberSerialization> value)
        {
            return ObservableExt.ZipExecute(JsonObjectContractValue, value, (JsonObjectContractValueLambda, valueLambda) => JsonObjectContractValueLambda.MemberSerialization = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemRequired(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue, IObservable<System.Nullable<Newtonsoft.Json.Required>> value)
        {
            return ObservableExt.ZipExecute(JsonObjectContractValue, value, (JsonObjectContractValueLambda, valueLambda) => JsonObjectContractValueLambda.ItemRequired = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_OverrideConstructor(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue, IObservable<System.Reflection.ConstructorInfo> value)
        {
            return ObservableExt.ZipExecute(JsonObjectContractValue, value, (JsonObjectContractValueLambda, valueLambda) => JsonObjectContractValueLambda.OverrideConstructor = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ParametrizedConstructor(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue, IObservable<System.Reflection.ConstructorInfo> value)
        {
            return ObservableExt.ZipExecute(JsonObjectContractValue, value, (JsonObjectContractValueLambda, valueLambda) => JsonObjectContractValueLambda.ParametrizedConstructor = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_OverrideCreator(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue, IObservable<Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>> value)
        {
            return ObservableExt.ZipExecute(JsonObjectContractValue, value, (JsonObjectContractValueLambda, valueLambda) => JsonObjectContractValueLambda.OverrideCreator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ExtensionDataSetter(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue, IObservable<Newtonsoft.Json.Serialization.ExtensionDataSetter> value)
        {
            return ObservableExt.ZipExecute(JsonObjectContractValue, value, (JsonObjectContractValueLambda, valueLambda) => JsonObjectContractValueLambda.ExtensionDataSetter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ExtensionDataGetter(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue, IObservable<Newtonsoft.Json.Serialization.ExtensionDataGetter> value)
        {
            return ObservableExt.ZipExecute(JsonObjectContractValue, value, (JsonObjectContractValueLambda, valueLambda) => JsonObjectContractValueLambda.ExtensionDataGetter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ExtensionDataValueType(this IObservable<Newtonsoft.Json.Serialization.JsonObjectContract> JsonObjectContractValue, IObservable<System.Type> value)
        {
            return ObservableExt.ZipExecute(JsonObjectContractValue, value, (JsonObjectContractValueLambda, valueLambda) => JsonObjectContractValueLambda.ExtensionDataValueType = valueLambda);
        }

    }
}