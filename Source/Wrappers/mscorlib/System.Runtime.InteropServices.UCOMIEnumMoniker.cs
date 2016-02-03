using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMIEnumMoniker
    {
        
        public static IObservable<Tuple<int, int>> Next(this IObservable<System.Runtime.InteropServices.UCOMIEnumMoniker> UCOMIEnumMonikerValue, IObservable<System.Int32> celt, IObservable<System.Runtime.InteropServices.UCOMIMoniker[]> rgelt)
        {
            return Observable.Zip(UCOMIEnumMonikerValue, celt, rgelt, (UCOMIEnumMonikerValueLambda, celtLambda, rgeltLambda) => {
System.Int32 pceltFetchedOutput = default(System.Int32);
var result = UCOMIEnumMonikerValueLambda.Next(celtLambda, rgeltLambda, out pceltFetchedOutput);
return Tuple.Create(result, pceltFetchedOutput);
});
        }


        public static IObservable<System.Int32> Skip(this IObservable<System.Runtime.InteropServices.UCOMIEnumMoniker> UCOMIEnumMonikerValue, IObservable<System.Int32> celt)
        {
            return Observable.Zip(UCOMIEnumMonikerValue, celt, (UCOMIEnumMonikerValueLambda, celtLambda) => UCOMIEnumMonikerValueLambda.Skip(celtLambda));
        }


        public static IObservable<System.Int32> Reset(this IObservable<System.Runtime.InteropServices.UCOMIEnumMoniker> UCOMIEnumMonikerValue)
        {
            return Observable.Select(UCOMIEnumMonikerValue, (UCOMIEnumMonikerValueLambda) => UCOMIEnumMonikerValueLambda.Reset());
        }


        public static IObservable<System.Runtime.InteropServices.UCOMIEnumMoniker> Clone(this IObservable<System.Runtime.InteropServices.UCOMIEnumMoniker> UCOMIEnumMonikerValue)
        {
            return Observable.Select(UCOMIEnumMonikerValue, (UCOMIEnumMonikerValueLambda) => {
System.Runtime.InteropServices.UCOMIEnumMoniker ppenumOutput = default(System.Runtime.InteropServices.UCOMIEnumMoniker);
UCOMIEnumMonikerValueLambda.Clone(out ppenumOutput);
return ppenumOutput;
});
        }

    }
}