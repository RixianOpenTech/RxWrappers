using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __JsonProperty
    {
        
        public static IObservable<System.String> ToString(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.ToString());
        }


        public static IObservable<System.String> get_PropertyName(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.PropertyName);
        }


        public static IObservable<System.Type> get_DeclaringType(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.DeclaringType);
        }


        public static IObservable<System.Nullable<System.Int32>> get_Order(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.Order);
        }


        public static IObservable<System.String> get_UnderlyingName(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.UnderlyingName);
        }


        public static IObservable<Newtonsoft.Json.Serialization.IValueProvider> get_ValueProvider(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.ValueProvider);
        }


        public static IObservable<Newtonsoft.Json.Serialization.IAttributeProvider> get_AttributeProvider(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.AttributeProvider);
        }


        public static IObservable<System.Type> get_PropertyType(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.PropertyType);
        }


        public static IObservable<Newtonsoft.Json.JsonConverter> get_Converter(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.Converter);
        }


        public static IObservable<Newtonsoft.Json.JsonConverter> get_MemberConverter(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.MemberConverter);
        }


        public static IObservable<System.Boolean> get_Ignored(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.Ignored);
        }


        public static IObservable<System.Boolean> get_Readable(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.Readable);
        }


        public static IObservable<System.Boolean> get_Writable(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.Writable);
        }


        public static IObservable<System.Boolean> get_HasMemberAttribute(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.HasMemberAttribute);
        }


        public static IObservable<System.Object> get_DefaultValue(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.DefaultValue);
        }


        public static IObservable<Newtonsoft.Json.Required> get_Required(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.Required);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_IsReference(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.IsReference);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.NullValueHandling>> get_NullValueHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.NullValueHandling);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.DefaultValueHandling>> get_DefaultValueHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.DefaultValueHandling);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>> get_ReferenceLoopHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.ReferenceLoopHandling);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.ObjectCreationHandling>> get_ObjectCreationHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.ObjectCreationHandling);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.TypeNameHandling>> get_TypeNameHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.TypeNameHandling);
        }


        public static IObservable<System.Predicate<System.Object>> get_ShouldSerialize(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.ShouldSerialize);
        }


        public static IObservable<System.Predicate<System.Object>> get_ShouldDeserialize(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.ShouldDeserialize);
        }


        public static IObservable<System.Predicate<System.Object>> get_GetIsSpecified(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.GetIsSpecified);
        }


        public static IObservable<System.Action<System.Object, System.Object>> get_SetIsSpecified(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.SetIsSpecified);
        }


        public static IObservable<Newtonsoft.Json.JsonConverter> get_ItemConverter(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.ItemConverter);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_ItemIsReference(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.ItemIsReference);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.TypeNameHandling>> get_ItemTypeNameHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.ItemTypeNameHandling);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>> get_ItemReferenceLoopHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue)
        {
            return Observable.Select(JsonPropertyValue, (JsonPropertyValueLambda) => JsonPropertyValueLambda.ItemReferenceLoopHandling);
        }


        public static IObservable<System.Reactive.Unit> set_PropertyName(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.PropertyName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DeclaringType(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Type> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.DeclaringType = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Order(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Nullable<System.Int32>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.Order = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_UnderlyingName(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.UnderlyingName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ValueProvider(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<Newtonsoft.Json.Serialization.IValueProvider> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.ValueProvider = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AttributeProvider(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<Newtonsoft.Json.Serialization.IAttributeProvider> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.AttributeProvider = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PropertyType(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Type> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.PropertyType = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Converter(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<Newtonsoft.Json.JsonConverter> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.Converter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MemberConverter(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<Newtonsoft.Json.JsonConverter> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.MemberConverter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Ignored(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.Ignored = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Readable(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.Readable = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Writable(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.Writable = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_HasMemberAttribute(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.HasMemberAttribute = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultValue(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.DefaultValue = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Required(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<Newtonsoft.Json.Required> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.Required = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IsReference(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.IsReference = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NullValueHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Nullable<Newtonsoft.Json.NullValueHandling>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.NullValueHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultValueHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Nullable<Newtonsoft.Json.DefaultValueHandling>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.DefaultValueHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReferenceLoopHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.ReferenceLoopHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ObjectCreationHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Nullable<Newtonsoft.Json.ObjectCreationHandling>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.ObjectCreationHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TypeNameHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Nullable<Newtonsoft.Json.TypeNameHandling>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.TypeNameHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ShouldSerialize(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Predicate<System.Object>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.ShouldSerialize = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ShouldDeserialize(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Predicate<System.Object>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.ShouldDeserialize = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_GetIsSpecified(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Predicate<System.Object>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.GetIsSpecified = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SetIsSpecified(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Action<System.Object, System.Object>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.SetIsSpecified = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemConverter(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<Newtonsoft.Json.JsonConverter> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.ItemConverter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemIsReference(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.ItemIsReference = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemTypeNameHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Nullable<Newtonsoft.Json.TypeNameHandling>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.ItemTypeNameHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemReferenceLoopHandling(this IObservable<Newtonsoft.Json.Serialization.JsonProperty> JsonPropertyValue, IObservable<System.Nullable<Newtonsoft.Json.ReferenceLoopHandling>> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyValue, value, (JsonPropertyValueLambda, valueLambda) => JsonPropertyValueLambda.ItemReferenceLoopHandling = valueLambda);
        }

    }
}