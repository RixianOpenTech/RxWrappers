using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMIConnectionPointContainer
    {
        
        public static IObservable<Tuple<System.Guid, System.Runtime.InteropServices.UCOMIConnectionPoint>> FindConnectionPoint(this IObservable<System.Runtime.InteropServices.UCOMIConnectionPointContainer> UCOMIConnectionPointContainerValue, IObservable<System.Guid> riid)
        {
            return Observable.Zip(UCOMIConnectionPointContainerValue, riid, (UCOMIConnectionPointContainerValueLambda, riidLambda) => {
System.Runtime.InteropServices.UCOMIConnectionPoint ppCPOutput = default(System.Runtime.InteropServices.UCOMIConnectionPoint);
UCOMIConnectionPointContainerValueLambda.FindConnectionPoint(ref riidLambda, out ppCPOutput);
return Tuple.Create(riidLambda, ppCPOutput);
});
        }


        public static IObservable<System.Runtime.InteropServices.UCOMIEnumConnectionPoints> EnumConnectionPoints(this IObservable<System.Runtime.InteropServices.UCOMIConnectionPointContainer> UCOMIConnectionPointContainerValue)
        {
            return Observable.Select(UCOMIConnectionPointContainerValue, (UCOMIConnectionPointContainerValueLambda) => {
System.Runtime.InteropServices.UCOMIEnumConnectionPoints ppEnumOutput = default(System.Runtime.InteropServices.UCOMIEnumConnectionPoints);
UCOMIConnectionPointContainerValueLambda.EnumConnectionPoints(out ppEnumOutput);
return ppEnumOutput;
});
        }

    }
}