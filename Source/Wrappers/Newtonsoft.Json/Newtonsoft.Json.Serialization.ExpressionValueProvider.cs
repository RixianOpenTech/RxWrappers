using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __ExpressionValueProvider
    {
        
        public static IObservable<System.Reactive.Unit> SetValue(this IObservable<Newtonsoft.Json.Serialization.ExpressionValueProvider> ExpressionValueProviderValue, IObservable<System.Object> target, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(ExpressionValueProviderValue, target, value, (ExpressionValueProviderValueLambda, targetLambda, valueLambda) => ExpressionValueProviderValueLambda.SetValue(targetLambda, valueLambda));
        }


        public static IObservable<System.Object> GetValue(this IObservable<Newtonsoft.Json.Serialization.ExpressionValueProvider> ExpressionValueProviderValue, IObservable<System.Object> target)
        {
            return Observable.Zip(ExpressionValueProviderValue, target, (ExpressionValueProviderValueLambda, targetLambda) => ExpressionValueProviderValueLambda.GetValue(targetLambda));
        }

    }
}