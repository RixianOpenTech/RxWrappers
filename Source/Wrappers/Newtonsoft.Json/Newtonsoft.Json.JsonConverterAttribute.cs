using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonConverterAttribute
    {
        
        public static IObservable<System.Type> get_ConverterType(this IObservable<Newtonsoft.Json.JsonConverterAttribute> JsonConverterAttributeValue)
        {
            return Observable.Select(JsonConverterAttributeValue, (JsonConverterAttributeValueLambda) => JsonConverterAttributeValueLambda.ConverterType);
        }


        public static IObservable<System.Object[]> get_ConverterParameters(this IObservable<Newtonsoft.Json.JsonConverterAttribute> JsonConverterAttributeValue)
        {
            return Observable.Select(JsonConverterAttributeValue, (JsonConverterAttributeValueLambda) => JsonConverterAttributeValueLambda.ConverterParameters);
        }

    }
}