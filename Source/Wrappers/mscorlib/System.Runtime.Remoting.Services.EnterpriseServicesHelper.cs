using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Services
{
public static class _EnterpriseServicesHelper
{
    
public static IObservable<System.Object> WrapIUnknownWithComObject(IObservable<System.IntPtr> punk)
{
    return Observable.Select(punk, (punkLambda) => System.Runtime.Remoting.Services.EnterpriseServicesHelper.WrapIUnknownWithComObject(punkLambda));
}


public static IObservable<System.Runtime.Remoting.Activation.IConstructionReturnMessage> CreateConstructionReturnMessage(IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> ctorMsg, IObservable<System.MarshalByRefObject> retObj)
{
    return Observable.Zip(ctorMsg, retObj, (ctorMsgLambda, retObjLambda) => System.Runtime.Remoting.Services.EnterpriseServicesHelper.CreateConstructionReturnMessage(ctorMsgLambda, retObjLambda));
}


public static IObservable<System.Reactive.Unit> SwitchWrappers(IObservable<System.Runtime.Remoting.Proxies.RealProxy> oldcp, IObservable<System.Runtime.Remoting.Proxies.RealProxy> newcp)
{
    return ObservableExt.ZipExecute(oldcp, newcp, (oldcpLambda, newcpLambda) => System.Runtime.Remoting.Services.EnterpriseServicesHelper.SwitchWrappers(oldcpLambda, newcpLambda));
}

}
}