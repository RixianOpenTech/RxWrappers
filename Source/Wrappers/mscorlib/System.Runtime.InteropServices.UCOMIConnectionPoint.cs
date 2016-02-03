using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _UCOMIConnectionPoint
{
    
public static IObservable<System.Int32> Advise(this IObservable<System.Runtime.InteropServices.UCOMIConnectionPoint> UCOMIConnectionPointValue, IObservable<System.Object> pUnkSink)
{
    return Observable.Zip(UCOMIConnectionPointValue, pUnkSink, (UCOMIConnectionPointValueLambda, pUnkSinkLambda) => {
System.Int32 pdwCookieOutput = default(System.Int32);
UCOMIConnectionPointValueLambda.Advise(pUnkSinkLambda, out pdwCookieOutput);
return pdwCookieOutput;
});
}


public static IObservable<System.Reactive.Unit> Unadvise(this IObservable<System.Runtime.InteropServices.UCOMIConnectionPoint> UCOMIConnectionPointValue, IObservable<System.Int32> dwCookie)
{
    return ObservableExt.ZipExecute(UCOMIConnectionPointValue, dwCookie, (UCOMIConnectionPointValueLambda, dwCookieLambda) => UCOMIConnectionPointValueLambda.Unadvise(dwCookieLambda));
}


public static IObservable<System.Guid> GetConnectionInterface(this IObservable<System.Runtime.InteropServices.UCOMIConnectionPoint> UCOMIConnectionPointValue)
{
    return Observable.Select(UCOMIConnectionPointValue, (UCOMIConnectionPointValueLambda) => {
System.Guid pIIDOutput = default(System.Guid);
UCOMIConnectionPointValueLambda.GetConnectionInterface(out pIIDOutput);
return pIIDOutput;
});
}


public static IObservable<System.Runtime.InteropServices.UCOMIConnectionPointContainer> GetConnectionPointContainer(this IObservable<System.Runtime.InteropServices.UCOMIConnectionPoint> UCOMIConnectionPointValue)
{
    return Observable.Select(UCOMIConnectionPointValue, (UCOMIConnectionPointValueLambda) => {
System.Runtime.InteropServices.UCOMIConnectionPointContainer ppCPCOutput = default(System.Runtime.InteropServices.UCOMIConnectionPointContainer);
UCOMIConnectionPointValueLambda.GetConnectionPointContainer(out ppCPCOutput);
return ppCPCOutput;
});
}


public static IObservable<System.Runtime.InteropServices.UCOMIEnumConnections> EnumConnections(this IObservable<System.Runtime.InteropServices.UCOMIConnectionPoint> UCOMIConnectionPointValue)
{
    return Observable.Select(UCOMIConnectionPointValue, (UCOMIConnectionPointValueLambda) => {
System.Runtime.InteropServices.UCOMIEnumConnections ppEnumOutput = default(System.Runtime.InteropServices.UCOMIEnumConnections);
UCOMIConnectionPointValueLambda.EnumConnections(out ppEnumOutput);
return ppEnumOutput;
});
}

}
}