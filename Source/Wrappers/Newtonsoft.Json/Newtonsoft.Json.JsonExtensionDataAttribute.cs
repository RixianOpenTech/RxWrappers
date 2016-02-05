using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonExtensionDataAttribute
    {
        
        public static IObservable<System.Boolean> get_WriteData(this IObservable<Newtonsoft.Json.JsonExtensionDataAttribute> JsonExtensionDataAttributeValue)
        {
            return Observable.Select(JsonExtensionDataAttributeValue, (JsonExtensionDataAttributeValueLambda) => JsonExtensionDataAttributeValueLambda.WriteData);
        }


        public static IObservable<System.Boolean> get_ReadData(this IObservable<Newtonsoft.Json.JsonExtensionDataAttribute> JsonExtensionDataAttributeValue)
        {
            return Observable.Select(JsonExtensionDataAttributeValue, (JsonExtensionDataAttributeValueLambda) => JsonExtensionDataAttributeValueLambda.ReadData);
        }


        public static IObservable<System.Reactive.Unit> set_WriteData(this IObservable<Newtonsoft.Json.JsonExtensionDataAttribute> JsonExtensionDataAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonExtensionDataAttributeValue, value, (JsonExtensionDataAttributeValueLambda, valueLambda) => JsonExtensionDataAttributeValueLambda.WriteData = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReadData(this IObservable<Newtonsoft.Json.JsonExtensionDataAttribute> JsonExtensionDataAttributeValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonExtensionDataAttributeValue, value, (JsonExtensionDataAttributeValueLambda, valueLambda) => JsonExtensionDataAttributeValueLambda.ReadData = valueLambda);
        }

    }
}