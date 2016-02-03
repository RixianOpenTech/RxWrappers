using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _EventWaitHandleSecurity
{
    
public static IObservable<System.Security.AccessControl.AccessRule> AccessRuleFactory(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.Principal.IdentityReference> identityReference, IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited, IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags, IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags, IObservable<System.Security.AccessControl.AccessControlType> type)
{
    return Observable.Zip(EventWaitHandleSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, type, (EventWaitHandleSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda) => EventWaitHandleSecurityValueLambda.AccessRuleFactory(identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda));
}


public static IObservable<System.Security.AccessControl.AuditRule> AuditRuleFactory(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.Principal.IdentityReference> identityReference, IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited, IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags, IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags, IObservable<System.Security.AccessControl.AuditFlags> flags)
{
    return Observable.Zip(EventWaitHandleSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, flags, (EventWaitHandleSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda) => EventWaitHandleSecurityValueLambda.AuditRuleFactory(identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda));
}


public static IObservable<System.Reactive.Unit> AddAccessRule(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAccessRule> rule)
{
    return ObservableExt.ZipExecute(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.AddAccessRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> SetAccessRule(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAccessRule> rule)
{
    return ObservableExt.ZipExecute(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.SetAccessRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> ResetAccessRule(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAccessRule> rule)
{
    return ObservableExt.ZipExecute(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.ResetAccessRule(ruleLambda));
}


public static IObservable<System.Boolean> RemoveAccessRule(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAccessRule> rule)
{
    return Observable.Zip(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.RemoveAccessRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAccessRuleAll(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAccessRule> rule)
{
    return ObservableExt.ZipExecute(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.RemoveAccessRuleAll(ruleLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAccessRuleSpecific(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAccessRule> rule)
{
    return ObservableExt.ZipExecute(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.RemoveAccessRuleSpecific(ruleLambda));
}


public static IObservable<System.Reactive.Unit> AddAuditRule(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAuditRule> rule)
{
    return ObservableExt.ZipExecute(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.AddAuditRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> SetAuditRule(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAuditRule> rule)
{
    return ObservableExt.ZipExecute(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.SetAuditRule(ruleLambda));
}


public static IObservable<System.Boolean> RemoveAuditRule(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAuditRule> rule)
{
    return Observable.Zip(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.RemoveAuditRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAuditRuleAll(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAuditRule> rule)
{
    return ObservableExt.ZipExecute(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.RemoveAuditRuleAll(ruleLambda));
}


public static IObservable<System.Reactive.Unit> RemoveAuditRuleSpecific(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue, IObservable<System.Security.AccessControl.EventWaitHandleAuditRule> rule)
{
    return ObservableExt.ZipExecute(EventWaitHandleSecurityValue, rule, (EventWaitHandleSecurityValueLambda, ruleLambda) => EventWaitHandleSecurityValueLambda.RemoveAuditRuleSpecific(ruleLambda));
}


public static IObservable<System.Type> get_AccessRightType(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue)
{
    return Observable.Select(EventWaitHandleSecurityValue, (EventWaitHandleSecurityValueLambda) => EventWaitHandleSecurityValueLambda.AccessRightType);
}


public static IObservable<System.Type> get_AccessRuleType(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue)
{
    return Observable.Select(EventWaitHandleSecurityValue, (EventWaitHandleSecurityValueLambda) => EventWaitHandleSecurityValueLambda.AccessRuleType);
}


public static IObservable<System.Type> get_AuditRuleType(this IObservable<System.Security.AccessControl.EventWaitHandleSecurity> EventWaitHandleSecurityValue)
{
    return Observable.Select(EventWaitHandleSecurityValue, (EventWaitHandleSecurityValueLambda) => EventWaitHandleSecurityValueLambda.AuditRuleType);
}

}
}