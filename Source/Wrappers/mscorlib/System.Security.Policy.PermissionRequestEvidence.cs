using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _PermissionRequestEvidence
{
    
public static IObservable<System.Security.Policy.EvidenceBase> Clone(this IObservable<System.Security.Policy.PermissionRequestEvidence> PermissionRequestEvidenceValue)
{
    return Observable.Select(PermissionRequestEvidenceValue, (PermissionRequestEvidenceValueLambda) => PermissionRequestEvidenceValueLambda.Clone());
}


public static IObservable<System.Security.Policy.PermissionRequestEvidence> Copy(this IObservable<System.Security.Policy.PermissionRequestEvidence> PermissionRequestEvidenceValue)
{
    return Observable.Select(PermissionRequestEvidenceValue, (PermissionRequestEvidenceValueLambda) => PermissionRequestEvidenceValueLambda.Copy());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.PermissionRequestEvidence> PermissionRequestEvidenceValue)
{
    return Observable.Select(PermissionRequestEvidenceValue, (PermissionRequestEvidenceValueLambda) => PermissionRequestEvidenceValueLambda.ToString());
}


public static IObservable<System.Security.PermissionSet> get_RequestedPermissions(this IObservable<System.Security.Policy.PermissionRequestEvidence> PermissionRequestEvidenceValue)
{
    return Observable.Select(PermissionRequestEvidenceValue, (PermissionRequestEvidenceValueLambda) => PermissionRequestEvidenceValueLambda.RequestedPermissions);
}


public static IObservable<System.Security.PermissionSet> get_OptionalPermissions(this IObservable<System.Security.Policy.PermissionRequestEvidence> PermissionRequestEvidenceValue)
{
    return Observable.Select(PermissionRequestEvidenceValue, (PermissionRequestEvidenceValueLambda) => PermissionRequestEvidenceValueLambda.OptionalPermissions);
}


public static IObservable<System.Security.PermissionSet> get_DeniedPermissions(this IObservable<System.Security.Policy.PermissionRequestEvidence> PermissionRequestEvidenceValue)
{
    return Observable.Select(PermissionRequestEvidenceValue, (PermissionRequestEvidenceValueLambda) => PermissionRequestEvidenceValueLambda.DeniedPermissions);
}

}
}