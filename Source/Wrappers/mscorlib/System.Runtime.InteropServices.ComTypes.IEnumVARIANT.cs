using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
public static class _IEnumVARIANT
{
    
public static IObservable<Tuple<System.Int32, System.Object>> Next(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumVARIANT> IEnumVARIANTValue, IObservable<System.Int32> celt, IObservable<System.Object[]> rgVar, IObservable<System.IntPtr> pceltFetched)
{
    return Observable.Zip(IEnumVARIANTValue, celt, rgVar, pceltFetched, (IEnumVARIANTValueLambda, celtLambda, rgVarLambda, pceltFetchedLambda) => IEnumVARIANTValueLambda.Next(celtLambda, rgVarLambda, pceltFetchedLambda));
}


public static IObservable<System.Int32> Skip(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumVARIANT> IEnumVARIANTValue, IObservable<System.Int32> celt)
{
    return Observable.Zip(IEnumVARIANTValue, celt, (IEnumVARIANTValueLambda, celtLambda) => IEnumVARIANTValueLambda.Skip(celtLambda));
}


public static IObservable<System.Int32> Reset(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumVARIANT> IEnumVARIANTValue)
{
    return Observable.Select(IEnumVARIANTValue, (IEnumVARIANTValueLambda) => IEnumVARIANTValueLambda.Reset());
}


public static IObservable<System.Runtime.InteropServices.ComTypes.IEnumVARIANT> Clone(this IObservable<System.Runtime.InteropServices.ComTypes.IEnumVARIANT> IEnumVARIANTValue)
{
    return Observable.Select(IEnumVARIANTValue, (IEnumVARIANTValueLambda) => IEnumVARIANTValueLambda.Clone());
}

}
}