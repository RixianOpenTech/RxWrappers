using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __SystemAcl
    {
        public static IObservable<System.Reactive.Unit> AddAudit(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.AccessControl.AuditFlags> auditFlags,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags)
        {
            return ObservableExt.ZipExecute(SystemAclValue, auditFlags, sid, accessMask, inheritanceFlags,
                propagationFlags,
                (SystemAclValueLambda, auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda) =>
                    SystemAclValueLambda.AddAudit(auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                        propagationFlagsLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAudit(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.AccessControl.AuditFlags> auditFlags,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags)
        {
            return ObservableExt.ZipExecute(SystemAclValue, auditFlags, sid, accessMask, inheritanceFlags,
                propagationFlags,
                (SystemAclValueLambda, auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda) =>
                    SystemAclValueLambda.SetAudit(auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                        propagationFlagsLambda));
        }


        public static IObservable<System.Boolean> RemoveAudit(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.AccessControl.AuditFlags> auditFlags,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags)
        {
            return Observable.Zip(SystemAclValue, auditFlags, sid, accessMask, inheritanceFlags, propagationFlags,
                (SystemAclValueLambda, auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda) =>
                    SystemAclValueLambda.RemoveAudit(auditFlagsLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditSpecific(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.AccessControl.AuditFlags> auditFlags,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags)
        {
            return ObservableExt.ZipExecute(SystemAclValue, auditFlags, sid, accessMask, inheritanceFlags,
                propagationFlags,
                (SystemAclValueLambda, auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda) =>
                    SystemAclValueLambda.RemoveAuditSpecific(auditFlagsLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAudit(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.Principal.SecurityIdentifier> sid,
            IObservable<System.Security.AccessControl.ObjectAuditRule> rule)
        {
            return ObservableExt.ZipExecute(SystemAclValue, sid, rule,
                (SystemAclValueLambda, sidLambda, ruleLambda) => SystemAclValueLambda.AddAudit(sidLambda, ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAudit(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.AccessControl.AuditFlags> auditFlags,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.ObjectAceFlags> objectFlags, IObservable<System.Guid> objectType,
            IObservable<System.Guid> inheritedObjectType)
        {
            return ObservableExt.ZipExecute(SystemAclValue, auditFlags, sid, accessMask, inheritanceFlags,
                propagationFlags, objectFlags, objectType, inheritedObjectType,
                (SystemAclValueLambda, auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda, objectFlagsLambda, objectTypeLambda, inheritedObjectTypeLambda) =>
                    SystemAclValueLambda.AddAudit(auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                        propagationFlagsLambda, objectFlagsLambda, objectTypeLambda, inheritedObjectTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAudit(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.Principal.SecurityIdentifier> sid,
            IObservable<System.Security.AccessControl.ObjectAuditRule> rule)
        {
            return ObservableExt.ZipExecute(SystemAclValue, sid, rule,
                (SystemAclValueLambda, sidLambda, ruleLambda) => SystemAclValueLambda.SetAudit(sidLambda, ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAudit(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.AccessControl.AuditFlags> auditFlags,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.ObjectAceFlags> objectFlags, IObservable<System.Guid> objectType,
            IObservable<System.Guid> inheritedObjectType)
        {
            return ObservableExt.ZipExecute(SystemAclValue, auditFlags, sid, accessMask, inheritanceFlags,
                propagationFlags, objectFlags, objectType, inheritedObjectType,
                (SystemAclValueLambda, auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda, objectFlagsLambda, objectTypeLambda, inheritedObjectTypeLambda) =>
                    SystemAclValueLambda.SetAudit(auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                        propagationFlagsLambda, objectFlagsLambda, objectTypeLambda, inheritedObjectTypeLambda));
        }


        public static IObservable<System.Boolean> RemoveAudit(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.Principal.SecurityIdentifier> sid,
            IObservable<System.Security.AccessControl.ObjectAuditRule> rule)
        {
            return Observable.Zip(SystemAclValue, sid, rule,
                (SystemAclValueLambda, sidLambda, ruleLambda) => SystemAclValueLambda.RemoveAudit(sidLambda, ruleLambda));
        }


        public static IObservable<System.Boolean> RemoveAudit(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.AccessControl.AuditFlags> auditFlags,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.ObjectAceFlags> objectFlags, IObservable<System.Guid> objectType,
            IObservable<System.Guid> inheritedObjectType)
        {
            return Observable.Zip(SystemAclValue, auditFlags, sid, accessMask, inheritanceFlags, propagationFlags,
                objectFlags, objectType, inheritedObjectType,
                (SystemAclValueLambda, auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda, objectFlagsLambda, objectTypeLambda, inheritedObjectTypeLambda) =>
                    SystemAclValueLambda.RemoveAudit(auditFlagsLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda, objectFlagsLambda, objectTypeLambda,
                        inheritedObjectTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditSpecific(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.Principal.SecurityIdentifier> sid,
            IObservable<System.Security.AccessControl.ObjectAuditRule> rule)
        {
            return ObservableExt.ZipExecute(SystemAclValue, sid, rule,
                (SystemAclValueLambda, sidLambda, ruleLambda) =>
                    SystemAclValueLambda.RemoveAuditSpecific(sidLambda, ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAuditSpecific(
            this IObservable<System.Security.AccessControl.SystemAcl> SystemAclValue,
            IObservable<System.Security.AccessControl.AuditFlags> auditFlags,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.ObjectAceFlags> objectFlags, IObservable<System.Guid> objectType,
            IObservable<System.Guid> inheritedObjectType)
        {
            return ObservableExt.ZipExecute(SystemAclValue, auditFlags, sid, accessMask, inheritanceFlags,
                propagationFlags, objectFlags, objectType, inheritedObjectType,
                (SystemAclValueLambda, auditFlagsLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda, objectFlagsLambda, objectTypeLambda, inheritedObjectTypeLambda) =>
                    SystemAclValueLambda.RemoveAuditSpecific(auditFlagsLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda, objectFlagsLambda, objectTypeLambda,
                        inheritedObjectTypeLambda));
        }
    }
}