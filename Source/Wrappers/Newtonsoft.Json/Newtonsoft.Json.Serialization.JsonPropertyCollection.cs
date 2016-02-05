using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __JsonPropertyCollection
    {
        
        public static IObservable<System.Reactive.Unit> AddProperty(this IObservable<Newtonsoft.Json.Serialization.JsonPropertyCollection> JsonPropertyCollectionValue, IObservable<Newtonsoft.Json.Serialization.JsonProperty> property)
        {
            return ObservableExt.ZipExecute(JsonPropertyCollectionValue, property, (JsonPropertyCollectionValueLambda, propertyLambda) => JsonPropertyCollectionValueLambda.AddProperty(propertyLambda));
        }


        public static IObservable<Newtonsoft.Json.Serialization.JsonProperty> GetClosestMatchProperty(this IObservable<Newtonsoft.Json.Serialization.JsonPropertyCollection> JsonPropertyCollectionValue, IObservable<System.String> propertyName)
        {
            return Observable.Zip(JsonPropertyCollectionValue, propertyName, (JsonPropertyCollectionValueLambda, propertyNameLambda) => JsonPropertyCollectionValueLambda.GetClosestMatchProperty(propertyNameLambda));
        }


        public static IObservable<Newtonsoft.Json.Serialization.JsonProperty> GetProperty(this IObservable<Newtonsoft.Json.Serialization.JsonPropertyCollection> JsonPropertyCollectionValue, IObservable<System.String> propertyName, IObservable<System.StringComparison> comparisonType)
        {
            return Observable.Zip(JsonPropertyCollectionValue, propertyName, comparisonType, (JsonPropertyCollectionValueLambda, propertyNameLambda, comparisonTypeLambda) => JsonPropertyCollectionValueLambda.GetProperty(propertyNameLambda, comparisonTypeLambda));
        }

    }
}