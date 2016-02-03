using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __LoaderOptimizationAttribute
    {
        
        public static IObservable<System.LoaderOptimization> get_Value(this IObservable<System.LoaderOptimizationAttribute> LoaderOptimizationAttributeValue)
        {
            return Observable.Select(LoaderOptimizationAttributeValue, (LoaderOptimizationAttributeValueLambda) => LoaderOptimizationAttributeValueLambda.Value);
        }

    }
}