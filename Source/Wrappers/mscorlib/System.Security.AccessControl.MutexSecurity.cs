using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __MutexSecurity
    {
        
        public static IObservable<System.Security.AccessControl.AccessRule> AccessRuleFactory(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.Principal.IdentityReference> identityReference, IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited, IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags, IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags, IObservable<System.Security.AccessControl.AccessControlType> type)
        {
            return Observable.Zip(MutexSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, type, (MutexSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda) => MutexSecurityValueLambda.AccessRuleFactory(identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda));
        }


        public static IObservable<System.Security.AccessControl.AuditRule> AuditRuleFactory(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.Principal.IdentityReference> identityReference, IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited, IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags, IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags, IObservable<System.Security.AccessControl.AuditFlags> flags)
        {
            return Observable.Zip(MutexSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, flags, (MutexSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda) => MutexSecurityValueLambda.AuditRuleFactory(identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAccessRule(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAccessRule> rule)
        {
            return ObservableExt.ZipExecute(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.AddAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccessRule(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAccessRule> rule)
        {
            return ObservableExt.ZipExecute(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.SetAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> ResetAccessRule(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAccessRule> rule)
        {
            return ObservableExt.ZipExecute(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.ResetAccessRule(ruleLambda));
        }


        public static IObservable<System.Boolean> RemoveAccessRule(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAccessRule> rule)
        {
            return Observable.Zip(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.RemoveAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessRuleAll(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAccessRule> rule)
        {
            return ObservableExt.ZipExecute(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.RemoveAccessRuleAll(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessRuleSpecific(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAccessRule> rule)
        {
            return ObservableExt.ZipExecute(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.RemoveAccessRuleSpecific(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAuditRule(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAuditRule> rule)
        {
            return ObservableExt.ZipExecute(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.AddAuditRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAuditRule(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAuditRule> rule)
        {
            return ObservableExt.ZipExecute(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.SetAuditRule(ruleLambda));
        }


        public static IObservable<System.Boolean> RemoveAuditRule(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAuditRule> rule)
        {
            return Observable.Zip(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.RemoveAuditRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditRuleAll(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAuditRule> rule)
        {
            return ObservableExt.ZipExecute(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.RemoveAuditRuleAll(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditRuleSpecific(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue, IObservable<System.Security.AccessControl.MutexAuditRule> rule)
        {
            return ObservableExt.ZipExecute(MutexSecurityValue, rule, (MutexSecurityValueLambda, ruleLambda) => MutexSecurityValueLambda.RemoveAuditRuleSpecific(ruleLambda));
        }


        public static IObservable<System.Type> get_AccessRightType(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue)
        {
            return Observable.Select(MutexSecurityValue, (MutexSecurityValueLambda) => MutexSecurityValueLambda.AccessRightType);
        }


        public static IObservable<System.Type> get_AccessRuleType(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue)
        {
            return Observable.Select(MutexSecurityValue, (MutexSecurityValueLambda) => MutexSecurityValueLambda.AccessRuleType);
        }


        public static IObservable<System.Type> get_AuditRuleType(this IObservable<System.Security.AccessControl.MutexSecurity> MutexSecurityValue)
        {
            return Observable.Select(MutexSecurityValue, (MutexSecurityValueLambda) => MutexSecurityValueLambda.AuditRuleType);
        }

    }
}