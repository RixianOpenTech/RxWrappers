using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonPropertyAttribute
    {
        
        public static IObservable<System.Type> get_ItemConverterType(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.ItemConverterType);
        }


        public static IObservable<System.Object[]> get_ItemConverterParameters(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.ItemConverterParameters);
        }


        public static IObservable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.NullValueHandling);
        }


        public static IObservable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.DefaultValueHandling);
        }


        public static IObservable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.ReferenceLoopHandling);
        }


        public static IObservable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.ObjectCreationHandling);
        }


        public static IObservable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.TypeNameHandling);
        }


        public static IObservable<System.Boolean> get_IsReference(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.IsReference);
        }


        public static IObservable<System.Int32> get_Order(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.Order);
        }


        public static IObservable<Newtonsoft.Json.Required> get_Required(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.Required);
        }


        public static IObservable<System.String> get_PropertyName(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.PropertyName);
        }


        public static IObservable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.ItemReferenceLoopHandling);
        }


        public static IObservable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.ItemTypeNameHandling);
        }


        public static IObservable<System.Boolean> get_ItemIsReference(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue)
        {
            return Observable.Select(JsonPropertyAttributeValue, (JsonPropertyAttributeValueLambda) => JsonPropertyAttributeValueLambda.ItemIsReference);
        }


        public static IObservable<System.Reactive.Unit> set_ItemConverterType(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<System.Type> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.ItemConverterType = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemConverterParameters(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<System.Object[]> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.ItemConverterParameters = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NullValueHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<Newtonsoft.Json.NullValueHandling> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.NullValueHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultValueHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<Newtonsoft.Json.DefaultValueHandling> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.DefaultValueHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReferenceLoopHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<Newtonsoft.Json.ReferenceLoopHandling> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.ReferenceLoopHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ObjectCreationHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<Newtonsoft.Json.ObjectCreationHandling> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.ObjectCreationHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TypeNameHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<Newtonsoft.Json.TypeNameHandling> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.TypeNameHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IsReference(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.IsReference = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Order(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.Order = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Required(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<Newtonsoft.Json.Required> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.Required = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PropertyName(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.PropertyName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemReferenceLoopHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<Newtonsoft.Json.ReferenceLoopHandling> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.ItemReferenceLoopHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemTypeNameHandling(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<Newtonsoft.Json.TypeNameHandling> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.ItemTypeNameHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemIsReference(this IObservable<Newtonsoft.Json.JsonPropertyAttribute> JsonPropertyAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonPropertyAttributeValue, value, (JsonPropertyAttributeValueLambda, valueLambda) => JsonPropertyAttributeValueLambda.ItemIsReference = valueLambda);
        }

    }
}