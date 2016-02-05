using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonContainerAttribute
    {
        
        public static IObservable<System.String> get_Id(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue)
        {
            return Observable.Select(JsonContainerAttributeValue, (JsonContainerAttributeValueLambda) => JsonContainerAttributeValueLambda.Id);
        }


        public static IObservable<System.String> get_Title(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue)
        {
            return Observable.Select(JsonContainerAttributeValue, (JsonContainerAttributeValueLambda) => JsonContainerAttributeValueLambda.Title);
        }


        public static IObservable<System.String> get_Description(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue)
        {
            return Observable.Select(JsonContainerAttributeValue, (JsonContainerAttributeValueLambda) => JsonContainerAttributeValueLambda.Description);
        }


        public static IObservable<System.Type> get_ItemConverterType(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue)
        {
            return Observable.Select(JsonContainerAttributeValue, (JsonContainerAttributeValueLambda) => JsonContainerAttributeValueLambda.ItemConverterType);
        }


        public static IObservable<System.Object[]> get_ItemConverterParameters(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue)
        {
            return Observable.Select(JsonContainerAttributeValue, (JsonContainerAttributeValueLambda) => JsonContainerAttributeValueLambda.ItemConverterParameters);
        }


        public static IObservable<System.Boolean> get_IsReference(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue)
        {
            return Observable.Select(JsonContainerAttributeValue, (JsonContainerAttributeValueLambda) => JsonContainerAttributeValueLambda.IsReference);
        }


        public static IObservable<System.Boolean> get_ItemIsReference(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue)
        {
            return Observable.Select(JsonContainerAttributeValue, (JsonContainerAttributeValueLambda) => JsonContainerAttributeValueLambda.ItemIsReference);
        }


        public static IObservable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue)
        {
            return Observable.Select(JsonContainerAttributeValue, (JsonContainerAttributeValueLambda) => JsonContainerAttributeValueLambda.ItemReferenceLoopHandling);
        }


        public static IObservable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue)
        {
            return Observable.Select(JsonContainerAttributeValue, (JsonContainerAttributeValueLambda) => JsonContainerAttributeValueLambda.ItemTypeNameHandling);
        }


        public static IObservable<System.Reactive.Unit> set_Id(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonContainerAttributeValue, value, (JsonContainerAttributeValueLambda, valueLambda) => JsonContainerAttributeValueLambda.Id = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Title(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonContainerAttributeValue, value, (JsonContainerAttributeValueLambda, valueLambda) => JsonContainerAttributeValueLambda.Title = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Description(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonContainerAttributeValue, value, (JsonContainerAttributeValueLambda, valueLambda) => JsonContainerAttributeValueLambda.Description = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemConverterType(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue, IObservable<System.Type> value)
        {
            return ObservableExt.ZipExecute(JsonContainerAttributeValue, value, (JsonContainerAttributeValueLambda, valueLambda) => JsonContainerAttributeValueLambda.ItemConverterType = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemConverterParameters(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue, IObservable<System.Object[]> value)
        {
            return ObservableExt.ZipExecute(JsonContainerAttributeValue, value, (JsonContainerAttributeValueLambda, valueLambda) => JsonContainerAttributeValueLambda.ItemConverterParameters = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IsReference(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonContainerAttributeValue, value, (JsonContainerAttributeValueLambda, valueLambda) => JsonContainerAttributeValueLambda.IsReference = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemIsReference(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonContainerAttributeValue, value, (JsonContainerAttributeValueLambda, valueLambda) => JsonContainerAttributeValueLambda.ItemIsReference = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemReferenceLoopHandling(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue, IObservable<Newtonsoft.Json.ReferenceLoopHandling> value)
        {
            return ObservableExt.ZipExecute(JsonContainerAttributeValue, value, (JsonContainerAttributeValueLambda, valueLambda) => JsonContainerAttributeValueLambda.ItemReferenceLoopHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ItemTypeNameHandling(this IObservable<Newtonsoft.Json.JsonContainerAttribute> JsonContainerAttributeValue, IObservable<Newtonsoft.Json.TypeNameHandling> value)
        {
            return ObservableExt.ZipExecute(JsonContainerAttributeValue, value, (JsonContainerAttributeValueLambda, valueLambda) => JsonContainerAttributeValueLambda.ItemTypeNameHandling = valueLambda);
        }

    }
}