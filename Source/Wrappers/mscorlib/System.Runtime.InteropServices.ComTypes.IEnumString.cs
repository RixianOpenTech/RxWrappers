using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
    public static class __IEnumString
    {
        
        public static IObservable<int> Next(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumString> IEnumStringValue, IObservable<System.Int32> celt, IObservable<System.String[]> rgelt, IObservable<System.IntPtr> pceltFetched)
        {
            return Observable.Zip(IEnumStringValue, celt, rgelt, pceltFetched, (IEnumStringValueLambda, celtLambda, rgeltLambda, pceltFetchedLambda) => IEnumStringValueLambda.Next(celtLambda, rgeltLambda, pceltFetchedLambda));
        }


        public static IObservable<System.Int32> Skip(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumString> IEnumStringValue, IObservable<System.Int32> celt)
        {
            return Observable.Zip(IEnumStringValue, celt, (IEnumStringValueLambda, celtLambda) => IEnumStringValueLambda.Skip(celtLambda));
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumString> IEnumStringValue)
        {
            return Observable.Do(IEnumStringValue, (IEnumStringValueLambda) => IEnumStringValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.IEnumString> Clone(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumString> IEnumStringValue)
        {
            return Observable.Select(IEnumStringValue, (IEnumStringValueLambda) => {
System.Runtime.InteropServices.ComTypes.IEnumString ppenumOutput = default(System.Runtime.InteropServices.ComTypes.IEnumString);
IEnumStringValueLambda.Clone(out ppenumOutput);
return ppenumOutput;
});
        }

    }
}