using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __DynamicValueProvider
    {
        
        public static IObservable<System.Reactive.Unit> SetValue(this IObservable<Newtonsoft.Json.Serialization.DynamicValueProvider> DynamicValueProviderValue, IObservable<System.Object> target, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(DynamicValueProviderValue, target, value, (DynamicValueProviderValueLambda, targetLambda, valueLambda) => DynamicValueProviderValueLambda.SetValue(targetLambda, valueLambda));
        }


        public static IObservable<System.Object> GetValue(this IObservable<Newtonsoft.Json.Serialization.DynamicValueProvider> DynamicValueProviderValue, IObservable<System.Object> target)
        {
            return Observable.Zip(DynamicValueProviderValue, target, (DynamicValueProviderValueLambda, targetLambda) => DynamicValueProviderValueLambda.GetValue(targetLambda));
        }

    }
}