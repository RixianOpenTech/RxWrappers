using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _IIdentityPermissionFactory
{
    
public static IObservable<System.Security.IPermission> CreateIdentityPermission(this IObservable<System.Security.Policy.IIdentityPermissionFactory> IIdentityPermissionFactoryValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(IIdentityPermissionFactoryValue, evidence, (IIdentityPermissionFactoryValueLambda, evidenceLambda) => IIdentityPermissionFactoryValueLambda.CreateIdentityPermission(evidenceLambda));
}

}
}