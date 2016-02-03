using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __FileSystemSecurity
    {
        public static IObservable<System.Security.AccessControl.AccessRule> AccessRuleFactory(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.Principal.IdentityReference> identityReference,
            IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.AccessControlType> type)
        {
            return Observable.Zip(FileSystemSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags,
                propagationFlags, type,
                (FileSystemSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda,
                    inheritanceFlagsLambda, propagationFlagsLambda, typeLambda) =>
                    FileSystemSecurityValueLambda.AccessRuleFactory(identityReferenceLambda, accessMaskLambda,
                        isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda));
        }


        public static IObservable<System.Security.AccessControl.AuditRule> AuditRuleFactory(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.Principal.IdentityReference> identityReference,
            IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.AuditFlags> flags)
        {
            return Observable.Zip(FileSystemSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags,
                propagationFlags, flags,
                (FileSystemSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda,
                    inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda) =>
                    FileSystemSecurityValueLambda.AuditRuleFactory(identityReferenceLambda, accessMaskLambda,
                        isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAccessRule(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAccessRule> rule)
        {
            return ObservableExt.ZipExecute(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) => FileSystemSecurityValueLambda.AddAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccessRule(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAccessRule> rule)
        {
            return ObservableExt.ZipExecute(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) => FileSystemSecurityValueLambda.SetAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> ResetAccessRule(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAccessRule> rule)
        {
            return ObservableExt.ZipExecute(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) => FileSystemSecurityValueLambda.ResetAccessRule(ruleLambda));
        }


        public static IObservable<System.Boolean> RemoveAccessRule(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAccessRule> rule)
        {
            return Observable.Zip(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) =>
                    FileSystemSecurityValueLambda.RemoveAccessRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessRuleAll(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAccessRule> rule)
        {
            return ObservableExt.ZipExecute(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) =>
                    FileSystemSecurityValueLambda.RemoveAccessRuleAll(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessRuleSpecific(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAccessRule> rule)
        {
            return ObservableExt.ZipExecute(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) =>
                    FileSystemSecurityValueLambda.RemoveAccessRuleSpecific(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAuditRule(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAuditRule> rule)
        {
            return ObservableExt.ZipExecute(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) => FileSystemSecurityValueLambda.AddAuditRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAuditRule(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAuditRule> rule)
        {
            return ObservableExt.ZipExecute(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) => FileSystemSecurityValueLambda.SetAuditRule(ruleLambda));
        }


        public static IObservable<System.Boolean> RemoveAuditRule(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAuditRule> rule)
        {
            return Observable.Zip(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) => FileSystemSecurityValueLambda.RemoveAuditRule(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditRuleAll(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAuditRule> rule)
        {
            return ObservableExt.ZipExecute(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) =>
                    FileSystemSecurityValueLambda.RemoveAuditRuleAll(ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditRuleSpecific(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue,
            IObservable<System.Security.AccessControl.FileSystemAuditRule> rule)
        {
            return ObservableExt.ZipExecute(FileSystemSecurityValue, rule,
                (FileSystemSecurityValueLambda, ruleLambda) =>
                    FileSystemSecurityValueLambda.RemoveAuditRuleSpecific(ruleLambda));
        }


        public static IObservable<System.Type> get_AccessRightType(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue)
        {
            return Observable.Select(FileSystemSecurityValue,
                (FileSystemSecurityValueLambda) => FileSystemSecurityValueLambda.AccessRightType);
        }


        public static IObservable<System.Type> get_AccessRuleType(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue)
        {
            return Observable.Select(FileSystemSecurityValue,
                (FileSystemSecurityValueLambda) => FileSystemSecurityValueLambda.AccessRuleType);
        }


        public static IObservable<System.Type> get_AuditRuleType(
            this IObservable<System.Security.AccessControl.FileSystemSecurity> FileSystemSecurityValue)
        {
            return Observable.Select(FileSystemSecurityValue,
                (FileSystemSecurityValueLambda) => FileSystemSecurityValueLambda.AuditRuleType);
        }
    }
}