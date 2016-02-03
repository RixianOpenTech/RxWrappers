using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
public static class _IConnectionPointContainer
{
    
public static IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints> EnumConnectionPoints(this IObservable<System.Runtime.InteropServices.ComTypes.IConnectionPointContainer> IConnectionPointContainerValue)
{
    return Observable.Select(IConnectionPointContainerValue, (IConnectionPointContainerValueLambda) => {
System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints ppEnumOutput = default(System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints);
IConnectionPointContainerValueLambda.EnumConnectionPoints(out ppEnumOutput);
return ppEnumOutput;
});
}


public static IObservable<Tuple<System.Guid, System.Runtime.InteropServices.ComTypes.IConnectionPoint>> FindConnectionPoint(this IObservable<System.Runtime.InteropServices.ComTypes.IConnectionPointContainer> IConnectionPointContainerValue, IObservable<System.Guid> riid)
{
    return Observable.Zip(IConnectionPointContainerValue, riid, (IConnectionPointContainerValueLambda, riidLambda) => {
System.Runtime.InteropServices.ComTypes.IConnectionPoint ppCPOutput = default(System.Runtime.InteropServices.ComTypes.IConnectionPoint);
IConnectionPointContainerValueLambda.FindConnectionPoint(ref riidLambda, out ppCPOutput);
return Tuple.Create(riidLambda, ppCPOutput);
});
}

}
}