using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _RegistrySecurity
{
    
public static IObservable<System.Security.AccessControl.AccessRule> AccessRuleFactory(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.Principal.IdentityReference> identityReference, IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited, IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags, IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags, IObservable<System.Security.AccessControl.AccessControlType> type)
{
    return Observable.Zip(RegistrySecurityValue, identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, type, (RegistrySecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda) => RegistrySecurityValueLambda.AccessRuleFactory(identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda));
}


public static IObservable<System.Security.AccessControl.AuditRule> AuditRuleFactory(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.Principal.IdentityReference> identityReference, IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited, IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags, IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags, IObservable<System.Security.AccessControl.AuditFlags> flags)
{
    return Observable.Zip(RegistrySecurityValue, identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, flags, (RegistrySecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda) => RegistrySecurityValueLambda.AuditRuleFactory(identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda));
}


public static IObservable<System.Reactive.Unit> AddAccessRule(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAccessRule> rule)
{
    return ObservableExt.ZipExecute(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.AddAccessRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> SetAccessRule(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAccessRule> rule)
{
    return ObservableExt.ZipExecute(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.SetAccessRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> ResetAccessRule(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAccessRule> rule)
{
    return ObservableExt.ZipExecute(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.ResetAccessRule(ruleLambda));
}


public static IObservable<System.Boolean> RemoveAccessRule(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAccessRule> rule)
{
    return Observable.Zip(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.RemoveAccessRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAccessRuleAll(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAccessRule> rule)
{
    return ObservableExt.ZipExecute(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.RemoveAccessRuleAll(ruleLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAccessRuleSpecific(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAccessRule> rule)
{
    return ObservableExt.ZipExecute(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.RemoveAccessRuleSpecific(ruleLambda));
}


public static IObservable<System.Reactive.Unit> AddAuditRule(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAuditRule> rule)
{
    return ObservableExt.ZipExecute(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.AddAuditRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> SetAuditRule(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAuditRule> rule)
{
    return ObservableExt.ZipExecute(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.SetAuditRule(ruleLambda));
}


public static IObservable<System.Boolean> RemoveAuditRule(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAuditRule> rule)
{
    return Observable.Zip(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.RemoveAuditRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAuditRuleAll(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAuditRule> rule)
{
    return ObservableExt.ZipExecute(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.RemoveAuditRuleAll(ruleLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAuditRuleSpecific(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue, IObservable<System.Security.AccessControl.RegistryAuditRule> rule)
{
    return ObservableExt.ZipExecute(RegistrySecurityValue, rule, (RegistrySecurityValueLambda, ruleLambda) => RegistrySecurityValueLambda.RemoveAuditRuleSpecific(ruleLambda));
}


public static IObservable<System.Type> get_AccessRightType(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue)
{
    return Observable.Select(RegistrySecurityValue, (RegistrySecurityValueLambda) => RegistrySecurityValueLambda.AccessRightType);
}


public static IObservable<System.Type> get_AccessRuleType(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue)
{
    return Observable.Select(RegistrySecurityValue, (RegistrySecurityValueLambda) => RegistrySecurityValueLambda.AccessRuleType);
}


public static IObservable<System.Type> get_AuditRuleType(this IObservable<System.Security.AccessControl.RegistrySecurity> RegistrySecurityValue)
{
    return Observable.Select(RegistrySecurityValue, (RegistrySecurityValueLambda) => RegistrySecurityValueLambda.AuditRuleType);
}

}
}