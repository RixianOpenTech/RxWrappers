using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Converters
{
    public static class __DateTimeConverterBase
    {
        
        public static IObservable<System.Boolean> CanConvert(this IObservable<Newtonsoft.Json.Converters.DateTimeConverterBase> DateTimeConverterBaseValue, IObservable<System.Type> objectType)
        {
            return Observable.Zip(DateTimeConverterBaseValue, objectType, (DateTimeConverterBaseValueLambda, objectTypeLambda) => DateTimeConverterBaseValueLambda.CanConvert(objectTypeLambda));
        }

    }
}