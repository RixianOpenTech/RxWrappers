using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
    public static class __IEnumMoniker
    {
        
        public static IObservable<int> Next(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumMoniker> IEnumMonikerValue, IObservable<System.Int32> celt, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker[]> rgelt, IObservable<System.IntPtr> pceltFetched)
        {
            return Observable.Zip(IEnumMonikerValue, celt, rgelt, pceltFetched, (IEnumMonikerValueLambda, celtLambda, rgeltLambda, pceltFetchedLambda) => IEnumMonikerValueLambda.Next(celtLambda, rgeltLambda, pceltFetchedLambda));
        }


        public static IObservable<System.Int32> Skip(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumMoniker> IEnumMonikerValue, IObservable<System.Int32> celt)
        {
            return Observable.Zip(IEnumMonikerValue, celt, (IEnumMonikerValueLambda, celtLambda) => IEnumMonikerValueLambda.Skip(celtLambda));
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumMoniker> IEnumMonikerValue)
        {
            return Observable.Do(IEnumMonikerValue, (IEnumMonikerValueLambda) => IEnumMonikerValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.IEnumMoniker> Clone(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumMoniker> IEnumMonikerValue)
        {
            return Observable.Select(IEnumMonikerValue, (IEnumMonikerValueLambda) => {
System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenumOutput = default(System.Runtime.InteropServices.ComTypes.IEnumMoniker);
IEnumMonikerValueLambda.Clone(out ppenumOutput);
return ppenumOutput;
});
        }

    }
}