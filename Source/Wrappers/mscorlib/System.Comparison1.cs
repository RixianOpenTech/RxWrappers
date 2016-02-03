using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Comparison1
    {
        
        public static IObservable<System.Int32> Invoke<T>(this IObservable<System.Comparison<T>> ComparisonValue, IObservable<T> x, IObservable<T> y)
        {
            return Observable.Zip(ComparisonValue, x, y, (ComparisonValueLambda, xLambda, yLambda) => ComparisonValueLambda.Invoke(xLambda, yLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<T>(this IObservable<System.Comparison<T>> ComparisonValue, IObservable<T> x, IObservable<T> y, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ComparisonValue, x, y, callback, @object, (ComparisonValueLambda, xLambda, yLambda, callbackLambda, @objectLambda) => ComparisonValueLambda.BeginInvoke(xLambda, yLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<System.Int32> EndInvoke<T>(this IObservable<System.Comparison<T>> ComparisonValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(ComparisonValue, result, (ComparisonValueLambda, resultLambda) => ComparisonValueLambda.EndInvoke(resultLambda));
        }

    }
}