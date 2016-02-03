using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
    public static class __IEnumConnectionPoints
    {
        
        public static IObservable<int> Next(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints> IEnumConnectionPointsValue, IObservable<System.Int32> celt, IObservable<System.Runtime.InteropServices.ComTypes.IConnectionPoint[]> rgelt, IObservable<System.IntPtr> pceltFetched)
        {
            return Observable.Zip(IEnumConnectionPointsValue, celt, rgelt, pceltFetched, (IEnumConnectionPointsValueLambda, celtLambda, rgeltLambda, pceltFetchedLambda) => IEnumConnectionPointsValueLambda.Next(celtLambda, rgeltLambda, pceltFetchedLambda));
        }


        public static IObservable<System.Int32> Skip(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints> IEnumConnectionPointsValue, IObservable<System.Int32> celt)
        {
            return Observable.Zip(IEnumConnectionPointsValue, celt, (IEnumConnectionPointsValueLambda, celtLambda) => IEnumConnectionPointsValueLambda.Skip(celtLambda));
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints> IEnumConnectionPointsValue)
        {
            return Observable.Do(IEnumConnectionPointsValue, (IEnumConnectionPointsValueLambda) => IEnumConnectionPointsValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints> Clone(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints> IEnumConnectionPointsValue)
        {
            return Observable.Select(IEnumConnectionPointsValue, (IEnumConnectionPointsValueLambda) => {
System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints ppenumOutput = default(System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints);
IEnumConnectionPointsValueLambda.Clone(out ppenumOutput);
return ppenumOutput;
});
        }

    }
}