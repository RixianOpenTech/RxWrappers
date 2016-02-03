using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __ObjectSecurity
    {
        public static IObservable<System.Security.Principal.IdentityReference> GetOwner(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Type> targetType)
        {
            return Observable.Zip(ObjectSecurityValue, targetType,
                (ObjectSecurityValueLambda, targetTypeLambda) => ObjectSecurityValueLambda.GetOwner(targetTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetOwner(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Security.Principal.IdentityReference> identity)
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, identity,
                (ObjectSecurityValueLambda, identityLambda) => ObjectSecurityValueLambda.SetOwner(identityLambda));
        }


        public static IObservable<System.Security.Principal.IdentityReference> GetGroup(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Type> targetType)
        {
            return Observable.Zip(ObjectSecurityValue, targetType,
                (ObjectSecurityValueLambda, targetTypeLambda) => ObjectSecurityValueLambda.GetGroup(targetTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetGroup(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Security.Principal.IdentityReference> identity)
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, identity,
                (ObjectSecurityValueLambda, identityLambda) => ObjectSecurityValueLambda.SetGroup(identityLambda));
        }


        public static IObservable<System.Reactive.Unit> PurgeAccessRules(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Security.Principal.IdentityReference> identity)
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, identity,
                (ObjectSecurityValueLambda, identityLambda) =>
                    ObjectSecurityValueLambda.PurgeAccessRules(identityLambda));
        }


        public static IObservable<System.Reactive.Unit> PurgeAuditRules(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Security.Principal.IdentityReference> identity)
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, identity,
                (ObjectSecurityValueLambda, identityLambda) => ObjectSecurityValueLambda.PurgeAuditRules(identityLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccessRuleProtection(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Boolean> isProtected, IObservable<System.Boolean> preserveInheritance)
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, isProtected, preserveInheritance,
                (ObjectSecurityValueLambda, isProtectedLambda, preserveInheritanceLambda) =>
                    ObjectSecurityValueLambda.SetAccessRuleProtection(isProtectedLambda, preserveInheritanceLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAuditRuleProtection(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Boolean> isProtected, IObservable<System.Boolean> preserveInheritance)
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, isProtected, preserveInheritance,
                (ObjectSecurityValueLambda, isProtectedLambda, preserveInheritanceLambda) =>
                    ObjectSecurityValueLambda.SetAuditRuleProtection(isProtectedLambda, preserveInheritanceLambda));
        }


        public static IObservable<System.Boolean> IsSddlConversionSupported()
        {
            return ObservableExt.Factory(() => System.Security.AccessControl.ObjectSecurity.IsSddlConversionSupported());
        }


        public static IObservable<System.String> GetSecurityDescriptorSddlForm(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Security.AccessControl.AccessControlSections> includeSections)
        {
            return Observable.Zip(ObjectSecurityValue, includeSections,
                (ObjectSecurityValueLambda, includeSectionsLambda) =>
                    ObjectSecurityValueLambda.GetSecurityDescriptorSddlForm(includeSectionsLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSecurityDescriptorSddlForm(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.String> sddlForm)
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, sddlForm,
                (ObjectSecurityValueLambda, sddlFormLambda) =>
                    ObjectSecurityValueLambda.SetSecurityDescriptorSddlForm(sddlFormLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSecurityDescriptorSddlForm(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.String> sddlForm,
            IObservable<System.Security.AccessControl.AccessControlSections> includeSections)
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, sddlForm, includeSections,
                (ObjectSecurityValueLambda, sddlFormLambda, includeSectionsLambda) =>
                    ObjectSecurityValueLambda.SetSecurityDescriptorSddlForm(sddlFormLambda, includeSectionsLambda));
        }


        public static IObservable<System.Byte[]> GetSecurityDescriptorBinaryForm(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue)
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.GetSecurityDescriptorBinaryForm());
        }


        public static IObservable<System.Reactive.Unit> SetSecurityDescriptorBinaryForm(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Byte[]> binaryForm)
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, binaryForm,
                (ObjectSecurityValueLambda, binaryFormLambda) =>
                    ObjectSecurityValueLambda.SetSecurityDescriptorBinaryForm(binaryFormLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSecurityDescriptorBinaryForm(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Byte[]> binaryForm,
            IObservable<System.Security.AccessControl.AccessControlSections> includeSections)
        {
            return ObservableExt.ZipExecute(ObjectSecurityValue, binaryForm, includeSections,
                (ObjectSecurityValueLambda, binaryFormLambda, includeSectionsLambda) =>
                    ObjectSecurityValueLambda.SetSecurityDescriptorBinaryForm(binaryFormLambda, includeSectionsLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Boolean>> ModifyAccessRule(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Security.AccessControl.AccessControlModification> modification,
            IObservable<System.Security.AccessControl.AccessRule> rule)
        {
            return Observable.Zip(ObjectSecurityValue, modification, rule,
                (ObjectSecurityValueLambda, modificationLambda, ruleLambda) =>
                {
                    System.Boolean modifiedOutput = default(System.Boolean);
                    var result = ObjectSecurityValueLambda.ModifyAccessRule(modificationLambda, ruleLambda,
                        out modifiedOutput);
                    return Tuple.Create(result, modifiedOutput);
                });
        }


        public static IObservable<Tuple<System.Boolean, System.Boolean>> ModifyAuditRule(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Security.AccessControl.AccessControlModification> modification,
            IObservable<System.Security.AccessControl.AuditRule> rule)
        {
            return Observable.Zip(ObjectSecurityValue, modification, rule,
                (ObjectSecurityValueLambda, modificationLambda, ruleLambda) =>
                {
                    System.Boolean modifiedOutput = default(System.Boolean);
                    var result = ObjectSecurityValueLambda.ModifyAuditRule(modificationLambda, ruleLambda,
                        out modifiedOutput);
                    return Tuple.Create(result, modifiedOutput);
                });
        }


        public static IObservable<System.Security.AccessControl.AccessRule> AccessRuleFactory(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Security.Principal.IdentityReference> identityReference,
            IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.AccessControlType> type)
        {
            return Observable.Zip(ObjectSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags,
                propagationFlags, type,
                (ObjectSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda,
                    inheritanceFlagsLambda, propagationFlagsLambda, typeLambda) =>
                    ObjectSecurityValueLambda.AccessRuleFactory(identityReferenceLambda, accessMaskLambda,
                        isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda));
        }


        public static IObservable<System.Security.AccessControl.AuditRule> AuditRuleFactory(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue,
            IObservable<System.Security.Principal.IdentityReference> identityReference,
            IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.AuditFlags> flags)
        {
            return Observable.Zip(ObjectSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags,
                propagationFlags, flags,
                (ObjectSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda,
                    inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda) =>
                    ObjectSecurityValueLambda.AuditRuleFactory(identityReferenceLambda, accessMaskLambda,
                        isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda));
        }


        public static IObservable<System.Boolean> get_AreAccessRulesProtected(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue)
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.AreAccessRulesProtected);
        }


        public static IObservable<System.Boolean> get_AreAuditRulesProtected(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue)
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.AreAuditRulesProtected);
        }


        public static IObservable<System.Boolean> get_AreAccessRulesCanonical(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue)
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.AreAccessRulesCanonical);
        }


        public static IObservable<System.Boolean> get_AreAuditRulesCanonical(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue)
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.AreAuditRulesCanonical);
        }


        public static IObservable<System.Type> get_AccessRightType(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue)
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.AccessRightType);
        }


        public static IObservable<System.Type> get_AccessRuleType(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue)
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.AccessRuleType);
        }


        public static IObservable<System.Type> get_AuditRuleType(
            this IObservable<System.Security.AccessControl.ObjectSecurity> ObjectSecurityValue)
        {
            return Observable.Select(ObjectSecurityValue,
                (ObjectSecurityValueLambda) => ObjectSecurityValueLambda.AuditRuleType);
        }
    }
}