using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __IValueProvider
    {
        
        public static IObservable<System.Reactive.Unit> SetValue(this IObservable<Newtonsoft.Json.Serialization.IValueProvider> IValueProviderValue, IObservable<System.Object> target, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(IValueProviderValue, target, value, (IValueProviderValueLambda, targetLambda, valueLambda) => IValueProviderValueLambda.SetValue(targetLambda, valueLambda));
        }


        public static IObservable<System.Object> GetValue(this IObservable<Newtonsoft.Json.Serialization.IValueProvider> IValueProviderValue, IObservable<System.Object> target)
        {
            return Observable.Zip(IValueProviderValue, target, (IValueProviderValueLambda, targetLambda) => IValueProviderValueLambda.GetValue(targetLambda));
        }

    }
}