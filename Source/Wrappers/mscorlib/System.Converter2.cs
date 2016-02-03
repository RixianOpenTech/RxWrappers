using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Converter2
    {
        
        public static IObservable<TOutput> Invoke<TInput, TOutput>(this IObservable<System.Converter<TInput, TOutput>> ConverterValue, IObservable<TInput> input)
        {
            return Observable.Zip(ConverterValue, input, (ConverterValueLambda, inputLambda) => ConverterValueLambda.Invoke(inputLambda));
        }


        public static IObservable<System.IAsyncResult> BeginInvoke<TInput, TOutput>(this IObservable<System.Converter<TInput, TOutput>> ConverterValue, IObservable<TInput> input, IObservable<System.AsyncCallback> callback, IObservable<System.Object> @object)
        {
            return Observable.Zip(ConverterValue, input, callback, @object, (ConverterValueLambda, inputLambda, callbackLambda, @objectLambda) => ConverterValueLambda.BeginInvoke(inputLambda, callbackLambda, @objectLambda));
        }


        public static IObservable<TOutput> EndInvoke<TInput, TOutput>(this IObservable<System.Converter<TInput, TOutput>> ConverterValue, IObservable<System.IAsyncResult> result)
        {
            return Observable.Zip(ConverterValue, result, (ConverterValueLambda, resultLambda) => ConverterValueLambda.EndInvoke(resultLambda));
        }

    }
}