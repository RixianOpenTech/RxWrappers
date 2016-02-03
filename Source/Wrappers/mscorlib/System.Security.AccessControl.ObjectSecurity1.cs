using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __ObjectSecurity1
    {
        public static IObservable<System.Security.AccessControl.AccessRule> AccessRuleFactory<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<System.Security.Principal.IdentityReference> identityReference,
            IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.AccessControlType> type) where T : struct
        {
            return Observable.Zip(ObjectSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags,
                propagationFlags, type,
                (ObjectSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda,
                    inheritanceFlagsLambda, propagationFlagsLambda, typeLambda) =>
                    ObjectSecurityValueLambda.AccessRuleFactory(identityReferenceLambda, accessMaskLambda,
                        isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda));
        }


        public static IObservable<System.Security.AccessControl.AuditRule> AuditRuleFactory<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<System.Security.Principal.IdentityReference> identityReference,
            IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.AuditFlags> flags) where T : struct
        {
            return Observable.Zip(ObjectSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags,
                propagationFlags, flags,
                (ObjectSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda,
                    inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda) =>
                    ObjectSecurityValueLambda.AuditRuleFactory(identityReferenceLambda, accessMaskLambda,
                        isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAccessRule<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AccessRule<T>> rule) where T : struct
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) => ObjectSecurityValueLambda.AddAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccessRule<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AccessRule<T>> rule) where T : struct
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) => ObjectSecurityValueLambda.SetAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> ResetAccessRule<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AccessRule<T>> rule) where T : struct
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) => ObjectSecurityValueLambda.ResetAccessRule(ruleLambda));
        }


        public static IObservable<System.Boolean> RemoveAccessRule<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AccessRule<T>> rule) where T : struct
        {
            return Observable.Zip(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) => ObjectSecurityValueLambda.RemoveAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessRuleAll<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AccessRule<T>> rule) where T : struct
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) => ObjectSecurityValueLambda.RemoveAccessRuleAll(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessRuleSpecific<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AccessRule<T>> rule) where T : struct
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) =>
                    ObjectSecurityValueLambda.RemoveAccessRuleSpecific(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAuditRule<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AuditRule<T>> rule) where T : struct
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) => ObjectSecurityValueLambda.AddAuditRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAuditRule<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AuditRule<T>> rule) where T : struct
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) => ObjectSecurityValueLambda.SetAuditRule(ruleLambda));
        }


        public static IObservable<System.Boolean> RemoveAuditRule<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AuditRule<T>> rule) where T : struct
        {
            return Observable.Zip(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) => ObjectSecurityValueLambda.RemoveAuditRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditRuleAll<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AuditRule<T>> rule) where T : struct
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) => ObjectSecurityValueLambda.RemoveAuditRuleAll(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditRuleSpecific<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue,
            IObservable<AuditRule<T>> rule) where T : struct
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, rule,
                (ObjectSecurityValueLambda, ruleLambda) => ObjectSecurityValueLambda.RemoveAuditRuleSpecific(ruleLambda));
        }


        public static IObservable<System.Type> get_AccessRightType<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue) where T : struct
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.AccessRightType);
        }


        public static IObservable<System.Type> get_AccessRuleType<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue) where T : struct
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.AccessRuleType);
        }


        public static IObservable<System.Type> get_AuditRuleType<T>(
            this IObservable<System.Security.AccessControl.ObjectSecurity<T>> ObjectSecurityValue) where T : struct
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.AuditRuleType);
        }
    }
}