using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __CryptoKeySecurity
    {
        
        public static IObservable<System.Security.AccessControl.AccessRule> AccessRuleFactory(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.Principal.IdentityReference> identityReference, IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited, IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags, IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags, IObservable<System.Security.AccessControl.AccessControlType> type)
        {
            return Observable.Zip(CryptoKeySecurityValue, identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, type, (CryptoKeySecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda) => CryptoKeySecurityValueLambda.AccessRuleFactory(identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda));
        }


        public static IObservable<System.Security.AccessControl.AuditRule> AuditRuleFactory(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.Principal.IdentityReference> identityReference, IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited, IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags, IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags, IObservable<System.Security.AccessControl.AuditFlags> flags)
        {
            return Observable.Zip(CryptoKeySecurityValue, identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, flags, (CryptoKeySecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda) => CryptoKeySecurityValueLambda.AuditRuleFactory(identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAccessRule(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAccessRule> rule)
        {
            return ObservableExt.ZipExecute(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.AddAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccessRule(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAccessRule> rule)
        {
            return ObservableExt.ZipExecute(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.SetAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> ResetAccessRule(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAccessRule> rule)
        {
            return ObservableExt.ZipExecute(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.ResetAccessRule(ruleLambda));
        }


        public static IObservable<System.Boolean> RemoveAccessRule(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAccessRule> rule)
        {
            return Observable.Zip(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.RemoveAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessRuleAll(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAccessRule> rule)
        {
            return ObservableExt.ZipExecute(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.RemoveAccessRuleAll(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessRuleSpecific(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAccessRule> rule)
        {
            return ObservableExt.ZipExecute(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.RemoveAccessRuleSpecific(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAuditRule(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAuditRule> rule)
        {
            return ObservableExt.ZipExecute(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.AddAuditRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAuditRule(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAuditRule> rule)
        {
            return ObservableExt.ZipExecute(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.SetAuditRule(ruleLambda));
        }


        public static IObservable<System.Boolean> RemoveAuditRule(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAuditRule> rule)
        {
            return Observable.Zip(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.RemoveAuditRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditRuleAll(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAuditRule> rule)
        {
            return ObservableExt.ZipExecute(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.RemoveAuditRuleAll(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditRuleSpecific(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue, IObservable<System.Security.AccessControl.CryptoKeyAuditRule> rule)
        {
            return ObservableExt.ZipExecute(CryptoKeySecurityValue, rule, (CryptoKeySecurityValueLambda, ruleLambda) => CryptoKeySecurityValueLambda.RemoveAuditRuleSpecific(ruleLambda));
        }


        public static IObservable<System.Type> get_AccessRightType(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue)
        {
            return Observable.Select(CryptoKeySecurityValue, (CryptoKeySecurityValueLambda) => CryptoKeySecurityValueLambda.AccessRightType);
        }


        public static IObservable<System.Type> get_AccessRuleType(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue)
        {
            return Observable.Select(CryptoKeySecurityValue, (CryptoKeySecurityValueLambda) => CryptoKeySecurityValueLambda.AccessRuleType);
        }


        public static IObservable<System.Type> get_AuditRuleType(this IObservable<System.Security.AccessControl.CryptoKeySecurity> CryptoKeySecurityValue)
        {
            return Observable.Select(CryptoKeySecurityValue, (CryptoKeySecurityValueLambda) => CryptoKeySecurityValueLambda.AuditRuleType);
        }

    }
}