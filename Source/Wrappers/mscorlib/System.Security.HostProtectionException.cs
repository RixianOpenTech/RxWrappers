using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
public static class _HostProtectionException
{
    
public static IObservable<System.String> ToString(this IObservable<System.Security.HostProtectionException> HostProtectionExceptionValue)
{
    return Observable.Select(HostProtectionExceptionValue, (HostProtectionExceptionValueLambda) => HostProtectionExceptionValueLambda.ToString());
}


public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Security.HostProtectionException> HostProtectionExceptionValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(HostProtectionExceptionValue, info, context, (HostProtectionExceptionValueLambda, infoLambda, contextLambda) => HostProtectionExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.Security.Permissions.HostProtectionResource> get_ProtectedResources(this IObservable<System.Security.HostProtectionException> HostProtectionExceptionValue)
{
    return Observable.Select(HostProtectionExceptionValue, (HostProtectionExceptionValueLambda) => HostProtectionExceptionValueLambda.ProtectedResources);
}


public static IObservable<System.Security.Permissions.HostProtectionResource> get_DemandedResources(this IObservable<System.Security.HostProtectionException> HostProtectionExceptionValue)
{
    return Observable.Select(HostProtectionExceptionValue, (HostProtectionExceptionValueLambda) => HostProtectionExceptionValueLambda.DemandedResources);
}

}
}