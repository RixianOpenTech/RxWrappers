using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __ReflectionValueProvider
    {
        
        public static IObservable<System.Reactive.Unit> SetValue(this IObservable<Newtonsoft.Json.Serialization.ReflectionValueProvider> ReflectionValueProviderValue, IObservable<System.Object> target, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(ReflectionValueProviderValue, target, value, (ReflectionValueProviderValueLambda, targetLambda, valueLambda) => ReflectionValueProviderValueLambda.SetValue(targetLambda, valueLambda));
        }


        public static IObservable<System.Object> GetValue(this IObservable<Newtonsoft.Json.Serialization.ReflectionValueProvider> ReflectionValueProviderValue, IObservable<System.Object> target)
        {
            return Observable.Zip(ReflectionValueProviderValue, target, (ReflectionValueProviderValueLambda, targetLambda) => ReflectionValueProviderValueLambda.GetValue(targetLambda));
        }

    }
}