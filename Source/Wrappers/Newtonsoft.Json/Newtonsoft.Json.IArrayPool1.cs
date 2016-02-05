using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __IArrayPool1
    {
        
        public static IObservable<T[]> Rent<T>(this IObservable<Newtonsoft.Json.IArrayPool<T>> IArrayPoolValue, IObservable<System.Int32> minimumLength)
        {
            return Observable.Zip(IArrayPoolValue, minimumLength, (IArrayPoolValueLambda, minimumLengthLambda) => IArrayPoolValueLambda.Rent(minimumLengthLambda));
        }


        public static IObservable<System.Reactive.Unit> Return<T>(this IObservable<Newtonsoft.Json.IArrayPool<T>> IArrayPoolValue, IObservable<T[]> array)
        {
            return ObservableExt.ZipExecute(IArrayPoolValue, array, (IArrayPoolValueLambda, arrayLambda) => IArrayPoolValueLambda.Return(arrayLambda));
        }

    }
}