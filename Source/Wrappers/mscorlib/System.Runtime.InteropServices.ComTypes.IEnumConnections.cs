using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
    public static class __IEnumConnections
    {
        
        public static IObservable<int> Next(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnections> IEnumConnectionsValue, IObservable<System.Int32> celt, IObservable<System.Runtime.InteropServices.ComTypes.CONNECTDATA[]> rgelt, IObservable<System.IntPtr> pceltFetched)
        {
            return Observable.Zip(IEnumConnectionsValue, celt, rgelt, pceltFetched, (IEnumConnectionsValueLambda, celtLambda, rgeltLambda, pceltFetchedLambda) => IEnumConnectionsValueLambda.Next(celtLambda, rgeltLambda, pceltFetchedLambda));
        }


        public static IObservable<System.Int32> Skip(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnections> IEnumConnectionsValue, IObservable<System.Int32> celt)
        {
            return Observable.Zip(IEnumConnectionsValue, celt, (IEnumConnectionsValueLambda, celtLambda) => IEnumConnectionsValueLambda.Skip(celtLambda));
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnections> IEnumConnectionsValue)
        {
            return Observable.Do(IEnumConnectionsValue, (IEnumConnectionsValueLambda) => IEnumConnectionsValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnections> Clone(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnections> IEnumConnectionsValue)
        {
            return Observable.Select(IEnumConnectionsValue, (IEnumConnectionsValueLambda) => {
System.Runtime.InteropServices.ComTypes.IEnumConnections ppenumOutput = default(System.Runtime.InteropServices.ComTypes.IEnumConnections);
IEnumConnectionsValueLambda.Clone(out ppenumOutput);
return ppenumOutput;
});
        }

    }
}