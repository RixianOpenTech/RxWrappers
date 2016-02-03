using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _PolicyLevel
{
    
public static IObservable<System.Security.NamedPermissionSet> GetNamedPermissionSet(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.String> name)
{
    return Observable.Zip(PolicyLevelValue, name, (PolicyLevelValueLambda, nameLambda) => PolicyLevelValueLambda.GetNamedPermissionSet(nameLambda));
}


public static IObservable<System.Security.Policy.PolicyStatement> Resolve(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(PolicyLevelValue, evidence, (PolicyLevelValueLambda, evidenceLambda) => PolicyLevelValueLambda.Resolve(evidenceLambda));
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.Security.SecurityElement> e)
{
    return ObservableExt.ZipExecute(PolicyLevelValue, e, (PolicyLevelValueLambda, eLambda) => PolicyLevelValueLambda.FromXml(eLambda));
}


public static IObservable<System.Security.Policy.PolicyLevel> CreateAppDomainLevel()
{
    return ObservableExt.Factory(() => System.Security.Policy.PolicyLevel.CreateAppDomainLevel());
}


public static IObservable<System.Security.Policy.CodeGroup> ResolveMatchingCodeGroups(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(PolicyLevelValue, evidence, (PolicyLevelValueLambda, evidenceLambda) => PolicyLevelValueLambda.ResolveMatchingCodeGroups(evidenceLambda));
}


public static IObservable<System.Reactive.Unit> AddFullTrustAssembly(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.Security.Policy.StrongName> sn)
{
    return ObservableExt.ZipExecute(PolicyLevelValue, sn, (PolicyLevelValueLambda, snLambda) => PolicyLevelValueLambda.AddFullTrustAssembly(snLambda));
}


public static IObservable<System.Reactive.Unit> AddFullTrustAssembly(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.Security.Policy.StrongNameMembershipCondition> snMC)
{
    return ObservableExt.ZipExecute(PolicyLevelValue, snMC, (PolicyLevelValueLambda, snMCLambda) => PolicyLevelValueLambda.AddFullTrustAssembly(snMCLambda));
}


public static IObservable<System.Reactive.Unit> RemoveFullTrustAssembly(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.Security.Policy.StrongName> sn)
{
    return ObservableExt.ZipExecute(PolicyLevelValue, sn, (PolicyLevelValueLambda, snLambda) => PolicyLevelValueLambda.RemoveFullTrustAssembly(snLambda));
}


public static IObservable<System.Reactive.Unit> RemoveFullTrustAssembly(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.Security.Policy.StrongNameMembershipCondition> snMC)
{
    return ObservableExt.ZipExecute(PolicyLevelValue, snMC, (PolicyLevelValueLambda, snMCLambda) => PolicyLevelValueLambda.RemoveFullTrustAssembly(snMCLambda));
}


public static IObservable<System.Reactive.Unit> AddNamedPermissionSet(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.Security.NamedPermissionSet> permSet)
{
    return ObservableExt.ZipExecute(PolicyLevelValue, permSet, (PolicyLevelValueLambda, permSetLambda) => PolicyLevelValueLambda.AddNamedPermissionSet(permSetLambda));
}


public static IObservable<System.Security.NamedPermissionSet> RemoveNamedPermissionSet(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.Security.NamedPermissionSet> permSet)
{
    return Observable.Zip(PolicyLevelValue, permSet, (PolicyLevelValueLambda, permSetLambda) => PolicyLevelValueLambda.RemoveNamedPermissionSet(permSetLambda));
}


public static IObservable<System.Security.NamedPermissionSet> RemoveNamedPermissionSet(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.String> name)
{
    return Observable.Zip(PolicyLevelValue, name, (PolicyLevelValueLambda, nameLambda) => PolicyLevelValueLambda.RemoveNamedPermissionSet(nameLambda));
}


public static IObservable<System.Security.NamedPermissionSet> ChangeNamedPermissionSet(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.String> name, IObservable<System.Security.PermissionSet> pSet)
{
    return Observable.Zip(PolicyLevelValue, name, pSet, (PolicyLevelValueLambda, nameLambda, pSetLambda) => PolicyLevelValueLambda.ChangeNamedPermissionSet(nameLambda, pSetLambda));
}


public static IObservable<System.Reactive.Unit> Recover(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue)
{
    return Observable.Do(PolicyLevelValue, (PolicyLevelValueLambda) => PolicyLevelValueLambda.Recover()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue)
{
    return Observable.Do(PolicyLevelValue, (PolicyLevelValueLambda) => PolicyLevelValueLambda.Reset()).ToUnit();
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue)
{
    return Observable.Select(PolicyLevelValue, (PolicyLevelValueLambda) => PolicyLevelValueLambda.ToXml());
}


public static IObservable<System.String> get_Label(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue)
{
    return Observable.Select(PolicyLevelValue, (PolicyLevelValueLambda) => PolicyLevelValueLambda.Label);
}


public static IObservable<System.Security.PolicyLevelType> get_Type(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue)
{
    return Observable.Select(PolicyLevelValue, (PolicyLevelValueLambda) => PolicyLevelValueLambda.Type);
}


public static IObservable<System.String> get_StoreLocation(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue)
{
    return Observable.Select(PolicyLevelValue, (PolicyLevelValueLambda) => PolicyLevelValueLambda.StoreLocation);
}


public static IObservable<System.Security.Policy.CodeGroup> get_RootCodeGroup(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue)
{
    return Observable.Select(PolicyLevelValue, (PolicyLevelValueLambda) => PolicyLevelValueLambda.RootCodeGroup);
}


public static IObservable<System.Collections.IList> get_NamedPermissionSets(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue)
{
    return Observable.Select(PolicyLevelValue, (PolicyLevelValueLambda) => PolicyLevelValueLambda.NamedPermissionSets);
}


public static IObservable<System.Collections.IList> get_FullTrustAssemblies(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue)
{
    return Observable.Select(PolicyLevelValue, (PolicyLevelValueLambda) => PolicyLevelValueLambda.FullTrustAssemblies);
}


public static IObservable<System.Reactive.Unit> set_RootCodeGroup(this IObservable<System.Security.Policy.PolicyLevel> PolicyLevelValue, IObservable<System.Security.Policy.CodeGroup> value)
{
    return ObservableExt.ZipExecute(PolicyLevelValue, value, (PolicyLevelValueLambda, valueLambda) => PolicyLevelValueLambda.RootCodeGroup = valueLambda);
}

}
}