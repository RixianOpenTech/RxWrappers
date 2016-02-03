using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __DiscretionaryAcl
    {
        public static IObservable<System.Reactive.Unit> AddAccess(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags)
        {
            return ObservableExt.ZipExecute(DiscretionaryAclValue, accessType, sid, accessMask, inheritanceFlags,
                propagationFlags,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda) =>
                    DiscretionaryAclValueLambda.AddAccess(accessTypeLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccess(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags)
        {
            return ObservableExt.ZipExecute(DiscretionaryAclValue, accessType, sid, accessMask, inheritanceFlags,
                propagationFlags,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda) =>
                    DiscretionaryAclValueLambda.SetAccess(accessTypeLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda));
        }


        public static IObservable<System.Boolean> RemoveAccess(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags)
        {
            return Observable.Zip(DiscretionaryAclValue, accessType, sid, accessMask, inheritanceFlags, propagationFlags,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda) =>
                    DiscretionaryAclValueLambda.RemoveAccess(accessTypeLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessSpecific(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags)
        {
            return ObservableExt.ZipExecute(DiscretionaryAclValue, accessType, sid, accessMask, inheritanceFlags,
                propagationFlags,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda) =>
                    DiscretionaryAclValueLambda.RemoveAccessSpecific(accessTypeLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAccess(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid,
            IObservable<System.Security.AccessControl.ObjectAccessRule> rule)
        {
            return ObservableExt.ZipExecute(DiscretionaryAclValue, accessType, sid, rule,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, ruleLambda) =>
                    DiscretionaryAclValueLambda.AddAccess(accessTypeLambda, sidLambda, ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAccess(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.ObjectAceFlags> objectFlags, IObservable<System.Guid> objectType,
            IObservable<System.Guid> inheritedObjectType)
        {
            return ObservableExt.ZipExecute(DiscretionaryAclValue, accessType, sid, accessMask, inheritanceFlags,
                propagationFlags, objectFlags, objectType, inheritedObjectType,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda, objectFlagsLambda, objectTypeLambda, inheritedObjectTypeLambda) =>
                    DiscretionaryAclValueLambda.AddAccess(accessTypeLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda, objectFlagsLambda, objectTypeLambda,
                        inheritedObjectTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccess(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid,
            IObservable<System.Security.AccessControl.ObjectAccessRule> rule)
        {
            return ObservableExt.ZipExecute(DiscretionaryAclValue, accessType, sid, rule,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, ruleLambda) =>
                    DiscretionaryAclValueLambda.SetAccess(accessTypeLambda, sidLambda, ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetAccess(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.ObjectAceFlags> objectFlags, IObservable<System.Guid> objectType,
            IObservable<System.Guid> inheritedObjectType)
        {
            return ObservableExt.ZipExecute(DiscretionaryAclValue, accessType, sid, accessMask, inheritanceFlags,
                propagationFlags, objectFlags, objectType, inheritedObjectType,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda, objectFlagsLambda, objectTypeLambda, inheritedObjectTypeLambda) =>
                    DiscretionaryAclValueLambda.SetAccess(accessTypeLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda, objectFlagsLambda, objectTypeLambda,
                        inheritedObjectTypeLambda));
        }


        public static IObservable<System.Boolean> RemoveAccess(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid,
            IObservable<System.Security.AccessControl.ObjectAccessRule> rule)
        {
            return Observable.Zip(DiscretionaryAclValue, accessType, sid, rule,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, ruleLambda) =>
                    DiscretionaryAclValueLambda.RemoveAccess(accessTypeLambda, sidLambda, ruleLambda));
        }


        public static IObservable<System.Boolean> RemoveAccess(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.ObjectAceFlags> objectFlags, IObservable<System.Guid> objectType,
            IObservable<System.Guid> inheritedObjectType)
        {
            return Observable.Zip(DiscretionaryAclValue, accessType, sid, accessMask, inheritanceFlags, propagationFlags,
                objectFlags, objectType, inheritedObjectType,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda, objectFlagsLambda, objectTypeLambda, inheritedObjectTypeLambda) =>
                    DiscretionaryAclValueLambda.RemoveAccess(accessTypeLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda, objectFlagsLambda, objectTypeLambda,
                        inheritedObjectTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessSpecific(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid,
            IObservable<System.Security.AccessControl.ObjectAccessRule> rule)
        {
            return ObservableExt.ZipExecute(DiscretionaryAclValue, accessType, sid, rule,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, ruleLambda) =>
                    DiscretionaryAclValueLambda.RemoveAccessSpecific(accessTypeLambda, sidLambda, ruleLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAccessSpecific(
            this IObservable<System.Security.AccessControl.DiscretionaryAcl> DiscretionaryAclValue,
            IObservable<System.Security.AccessControl.AccessControlType> accessType,
            IObservable<System.Security.Principal.SecurityIdentifier> sid, IObservable<System.Int32> accessMask,
            IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags,
            IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags,
            IObservable<System.Security.AccessControl.ObjectAceFlags> objectFlags, IObservable<System.Guid> objectType,
            IObservable<System.Guid> inheritedObjectType)
        {
            return ObservableExt.ZipExecute(DiscretionaryAclValue, accessType, sid, accessMask, inheritanceFlags,
                propagationFlags, objectFlags, objectType, inheritedObjectType,
                (DiscretionaryAclValueLambda, accessTypeLambda, sidLambda, accessMaskLambda, inheritanceFlagsLambda,
                    propagationFlagsLambda, objectFlagsLambda, objectTypeLambda, inheritedObjectTypeLambda) =>
                    DiscretionaryAclValueLambda.RemoveAccessSpecific(accessTypeLambda, sidLambda, accessMaskLambda,
                        inheritanceFlagsLambda, propagationFlagsLambda, objectFlagsLambda, objectTypeLambda,
                        inheritedObjectTypeLambda));
        }
    }
}