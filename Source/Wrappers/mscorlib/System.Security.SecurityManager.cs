using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
public static class _SecurityManager
{
    
public static IObservable<System.Security.PermissionSet> GetStandardSandbox(IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Select(evidence, (evidenceLambda) => System.Security.SecurityManager.GetStandardSandbox(evidenceLambda));
}


public static IObservable<System.Security.Policy.PolicyLevel> LoadPolicyLevelFromString(IObservable<System.String> str, IObservable<System.Security.PolicyLevelType> type)
{
    return Observable.Zip(str, type, (strLambda, typeLambda) => System.Security.SecurityManager.LoadPolicyLevelFromString(strLambda, typeLambda));
}


public static IObservable<System.Boolean> IsGranted(IObservable<System.Security.IPermission> perm)
{
    return Observable.Select(perm, (permLambda) => System.Security.SecurityManager.IsGranted(permLambda));
}


public static IObservable<Tuple<System.Collections.ArrayList, System.Collections.ArrayList>> GetZoneAndOrigin()
{
    return ObservableExt.Factory(() => {
System.Collections.ArrayList zoneOutput = default(System.Collections.ArrayList);
System.Collections.ArrayList originOutput = default(System.Collections.ArrayList);
System.Security.SecurityManager.GetZoneAndOrigin(out zoneOutput, out originOutput);
return Tuple.Create(zoneOutput, originOutput);
});
}


public static IObservable<System.Security.Policy.PolicyLevel> LoadPolicyLevelFromFile(IObservable<System.String> path, IObservable<System.Security.PolicyLevelType> type)
{
    return Observable.Zip(path, type, (pathLambda, typeLambda) => System.Security.SecurityManager.LoadPolicyLevelFromFile(pathLambda, typeLambda));
}


public static IObservable<System.Reactive.Unit> SavePolicyLevel(IObservable<System.Security.Policy.PolicyLevel> level)
{
    return Observable.Do(level, (levelLambda) => System.Security.SecurityManager.SavePolicyLevel(levelLambda)).ToUnit();
}


public static IObservable<Tuple<System.Security.PermissionSet, System.Security.PermissionSet>> ResolvePolicy(IObservable<System.Security.Policy.Evidence> evidence, IObservable<System.Security.PermissionSet> reqdPset, IObservable<System.Security.PermissionSet> optPset, IObservable<System.Security.PermissionSet> denyPset)
{
    return Observable.Zip(evidence, reqdPset, optPset, denyPset, (evidenceLambda, reqdPsetLambda, optPsetLambda, denyPsetLambda) => {
System.Security.PermissionSet deniedOutput = default(System.Security.PermissionSet);
var result = System.Security.SecurityManager.ResolvePolicy(evidenceLambda, reqdPsetLambda, optPsetLambda, denyPsetLambda, out deniedOutput);
return Tuple.Create(result, deniedOutput);
});
}


public static IObservable<System.Security.PermissionSet> ResolvePolicy(IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Select(evidence, (evidenceLambda) => System.Security.SecurityManager.ResolvePolicy(evidenceLambda));
}


public static IObservable<System.Security.PermissionSet> ResolvePolicy(IObservable<System.Security.Policy.Evidence[]> evidences)
{
    return Observable.Select(evidences, (evidencesLambda) => System.Security.SecurityManager.ResolvePolicy(evidencesLambda));
}


public static IObservable<System.Boolean> CurrentThreadRequiresSecurityContextCapture()
{
    return ObservableExt.Factory(() => System.Security.SecurityManager.CurrentThreadRequiresSecurityContextCapture());
}


public static IObservable<System.Security.PermissionSet> ResolveSystemPolicy(IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Select(evidence, (evidenceLambda) => System.Security.SecurityManager.ResolveSystemPolicy(evidenceLambda));
}


public static IObservable<System.Collections.IEnumerator> ResolvePolicyGroups(IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Select(evidence, (evidenceLambda) => System.Security.SecurityManager.ResolvePolicyGroups(evidenceLambda));
}


public static IObservable<System.Collections.IEnumerator> PolicyHierarchy()
{
    return ObservableExt.Factory(() => System.Security.SecurityManager.PolicyHierarchy());
}


public static IObservable<System.Reactive.Unit> SavePolicy()
{
    return ObservableExt.Factory(() => System.Security.SecurityManager.SavePolicy());
}


public static IObservable<System.Boolean> get_CheckExecutionRights()
{
    return ObservableExt.Factory(() => System.Security.SecurityManager.CheckExecutionRights);
}


public static IObservable<System.Boolean> get_SecurityEnabled()
{
    return ObservableExt.Factory(() => System.Security.SecurityManager.SecurityEnabled);
}


public static IObservable<System.Reactive.Unit> set_CheckExecutionRights(IObservable<System.Boolean> value)
{
    return Observable.Do(value, (valueLambda) => System.Security.SecurityManager.CheckExecutionRights = valueLambda).ToUnit();
}


public static IObservable<System.Reactive.Unit> set_SecurityEnabled(IObservable<System.Boolean> value)
{
    return Observable.Do(value, (valueLambda) => System.Security.SecurityManager.SecurityEnabled = valueLambda).ToUnit();
}

}
}