using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMIEnumConnections
    {
        
        public static IObservable<Tuple<int, int>> Next(this IObservable<System.Runtime.InteropServices.UCOMIEnumConnections> UCOMIEnumConnectionsValue, IObservable<System.Int32> celt, IObservable<System.Runtime.InteropServices.CONNECTDATA[]> rgelt)
        {
            return Observable.Zip(UCOMIEnumConnectionsValue, celt, rgelt, (UCOMIEnumConnectionsValueLambda, celtLambda, rgeltLambda) => {
System.Int32 pceltFetchedOutput = default(System.Int32);
var result = UCOMIEnumConnectionsValueLambda.Next(celtLambda, rgeltLambda, out pceltFetchedOutput);
return Tuple.Create(result, pceltFetchedOutput);
});
        }


        public static IObservable<System.Int32> Skip(this IObservable<System.Runtime.InteropServices.UCOMIEnumConnections> UCOMIEnumConnectionsValue, IObservable<System.Int32> celt)
        {
            return Observable.Zip(UCOMIEnumConnectionsValue, celt, (UCOMIEnumConnectionsValueLambda, celtLambda) => UCOMIEnumConnectionsValueLambda.Skip(celtLambda));
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Runtime.InteropServices.UCOMIEnumConnections> UCOMIEnumConnectionsValue)
        {
            return Observable.Do(UCOMIEnumConnectionsValue, (UCOMIEnumConnectionsValueLambda) => UCOMIEnumConnectionsValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Runtime.InteropServices.UCOMIEnumConnections> Clone(this IObservable<System.Runtime.InteropServices.UCOMIEnumConnections> UCOMIEnumConnectionsValue)
        {
            return Observable.Select(UCOMIEnumConnectionsValue, (UCOMIEnumConnectionsValueLambda) => {
System.Runtime.InteropServices.UCOMIEnumConnections ppenumOutput = default(System.Runtime.InteropServices.UCOMIEnumConnections);
UCOMIEnumConnectionsValueLambda.Clone(out ppenumOutput);
return ppenumOutput;
});
        }

    }
}