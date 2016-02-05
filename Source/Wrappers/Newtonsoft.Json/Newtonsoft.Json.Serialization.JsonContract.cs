using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __JsonContract
    {
        
        public static IObservable<System.Type> get_UnderlyingType(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.UnderlyingType);
        }


        public static IObservable<System.Type> get_CreatedType(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.CreatedType);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_IsReference(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.IsReference);
        }


        public static IObservable<Newtonsoft.Json.JsonConverter> get_Converter(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.Converter);
        }


        public static IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback>> get_OnDeserializedCallbacks(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.OnDeserializedCallbacks);
        }


        public static IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback>> get_OnDeserializingCallbacks(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.OnDeserializingCallbacks);
        }


        public static IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback>> get_OnSerializedCallbacks(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.OnSerializedCallbacks);
        }


        public static IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback>> get_OnSerializingCallbacks(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.OnSerializingCallbacks);
        }


        public static IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback>> get_OnErrorCallbacks(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.OnErrorCallbacks);
        }


        public static IObservable<System.Reflection.MethodInfo> get_OnDeserialized(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.OnDeserialized);
        }


        public static IObservable<System.Reflection.MethodInfo> get_OnDeserializing(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.OnDeserializing);
        }


        public static IObservable<System.Reflection.MethodInfo> get_OnSerialized(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.OnSerialized);
        }


        public static IObservable<System.Reflection.MethodInfo> get_OnSerializing(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.OnSerializing);
        }


        public static IObservable<System.Reflection.MethodInfo> get_OnError(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.OnError);
        }


        public static IObservable<System.Func<System.Object>> get_DefaultCreator(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.DefaultCreator);
        }


        public static IObservable<System.Boolean> get_DefaultCreatorNonPublic(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue)
        {
            return Observable.Select(JsonContractValue, (JsonContractValueLambda) => JsonContractValueLambda.DefaultCreatorNonPublic);
        }


        public static IObservable<System.Reactive.Unit> set_CreatedType(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue, IObservable<System.Type> value)
        {
            return ObservableExt.ZipExecute(JsonContractValue, value, (JsonContractValueLambda, valueLambda) => JsonContractValueLambda.CreatedType = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IsReference(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonContractValue, value, (JsonContractValueLambda, valueLambda) => JsonContractValueLambda.IsReference = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Converter(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue, IObservable<Newtonsoft.Json.JsonConverter> value)
        {
            return ObservableExt.ZipExecute(JsonContractValue, value, (JsonContractValueLambda, valueLambda) => JsonContractValueLambda.Converter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_OnDeserialized(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue, IObservable<System.Reflection.MethodInfo> value)
        {
            return ObservableExt.ZipExecute(JsonContractValue, value, (JsonContractValueLambda, valueLambda) => JsonContractValueLambda.OnDeserialized = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_OnDeserializing(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue, IObservable<System.Reflection.MethodInfo> value)
        {
            return ObservableExt.ZipExecute(JsonContractValue, value, (JsonContractValueLambda, valueLambda) => JsonContractValueLambda.OnDeserializing = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_OnSerialized(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue, IObservable<System.Reflection.MethodInfo> value)
        {
            return ObservableExt.ZipExecute(JsonContractValue, value, (JsonContractValueLambda, valueLambda) => JsonContractValueLambda.OnSerialized = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_OnSerializing(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue, IObservable<System.Reflection.MethodInfo> value)
        {
            return ObservableExt.ZipExecute(JsonContractValue, value, (JsonContractValueLambda, valueLambda) => JsonContractValueLambda.OnSerializing = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_OnError(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue, IObservable<System.Reflection.MethodInfo> value)
        {
            return ObservableExt.ZipExecute(JsonContractValue, value, (JsonContractValueLambda, valueLambda) => JsonContractValueLambda.OnError = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultCreator(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue, IObservable<System.Func<System.Object>> value)
        {
            return ObservableExt.ZipExecute(JsonContractValue, value, (JsonContractValueLambda, valueLambda) => JsonContractValueLambda.DefaultCreator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultCreatorNonPublic(this IObservable<Newtonsoft.Json.Serialization.JsonContract> JsonContractValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonContractValue, value, (JsonContractValueLambda, valueLambda) => JsonContractValueLambda.DefaultCreatorNonPublic = valueLambda);
        }

    }
}