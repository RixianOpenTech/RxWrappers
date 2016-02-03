using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __CommonSecurityDescriptor
    {
        public static IObservable<System.Reactive.Unit> SetSystemAclProtection(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue,
            IObservable<System.Boolean> isProtected, IObservable<System.Boolean> preserveInheritance)
        {
            return ObservableExt.ZipExecute(CommonSecurityDescriptorValue, isProtected, preserveInheritance,
                (CommonSecurityDescriptorValueLambda, isProtectedLambda, preserveInheritanceLambda) =>
                    CommonSecurityDescriptorValueLambda.SetSystemAclProtection(isProtectedLambda,
                        preserveInheritanceLambda));
        }


        public static IObservable<System.Reactive.Unit> SetDiscretionaryAclProtection(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue,
            IObservable<System.Boolean> isProtected, IObservable<System.Boolean> preserveInheritance)
        {
            return ObservableExt.ZipExecute(CommonSecurityDescriptorValue, isProtected, preserveInheritance,
                (CommonSecurityDescriptorValueLambda, isProtectedLambda, preserveInheritanceLambda) =>
                    CommonSecurityDescriptorValueLambda.SetDiscretionaryAclProtection(isProtectedLambda,
                        preserveInheritanceLambda));
        }


        public static IObservable<System.Reactive.Unit> PurgeAccessControl(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue,
            IObservable<System.Security.Principal.SecurityIdentifier> sid)
        {
            return ObservableExt.ZipExecute(CommonSecurityDescriptorValue, sid,
                (CommonSecurityDescriptorValueLambda, sidLambda) =>
                    CommonSecurityDescriptorValueLambda.PurgeAccessControl(sidLambda));
        }


        public static IObservable<System.Reactive.Unit> PurgeAudit(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue,
            IObservable<System.Security.Principal.SecurityIdentifier> sid)
        {
            return ObservableExt.ZipExecute(CommonSecurityDescriptorValue, sid,
                (CommonSecurityDescriptorValueLambda, sidLambda) =>
                    CommonSecurityDescriptorValueLambda.PurgeAudit(sidLambda));
        }


        public static IObservable<System.Reactive.Unit> AddDiscretionaryAcl(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue,
            IObservable<System.Byte> revision, IObservable<System.Int32> trusted)
        {
            return ObservableExt.ZipExecute(CommonSecurityDescriptorValue, revision, trusted,
                (CommonSecurityDescriptorValueLambda, revisionLambda, trustedLambda) =>
                    CommonSecurityDescriptorValueLambda.AddDiscretionaryAcl(revisionLambda, trustedLambda));
        }


        public static IObservable<System.Reactive.Unit> AddSystemAcl(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue,
            IObservable<System.Byte> revision, IObservable<System.Int32> trusted)
        {
            return ObservableExt.ZipExecute(CommonSecurityDescriptorValue, revision, trusted,
                (CommonSecurityDescriptorValueLambda, revisionLambda, trustedLambda) =>
                    CommonSecurityDescriptorValueLambda.AddSystemAcl(revisionLambda, trustedLambda));
        }


        public static IObservable<System.Boolean> get_IsContainer(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue)
        {
            return Observable.Select(CommonSecurityDescriptorValue,
                (CommonSecurityDescriptorValueLambda) => CommonSecurityDescriptorValueLambda.IsContainer);
        }


        public static IObservable<System.Boolean> get_IsDS(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue)
        {
            return Observable.Select(CommonSecurityDescriptorValue,
                (CommonSecurityDescriptorValueLambda) => CommonSecurityDescriptorValueLambda.IsDS);
        }


        public static IObservable<System.Security.AccessControl.ControlFlags> get_ControlFlags(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue)
        {
            return Observable.Select(CommonSecurityDescriptorValue,
                (CommonSecurityDescriptorValueLambda) => CommonSecurityDescriptorValueLambda.ControlFlags);
        }


        public static IObservable<System.Security.Principal.SecurityIdentifier> get_Owner(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue)
        {
            return Observable.Select(CommonSecurityDescriptorValue,
                (CommonSecurityDescriptorValueLambda) => CommonSecurityDescriptorValueLambda.Owner);
        }


        public static IObservable<System.Security.Principal.SecurityIdentifier> get_Group(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue)
        {
            return Observable.Select(CommonSecurityDescriptorValue,
                (CommonSecurityDescriptorValueLambda) => CommonSecurityDescriptorValueLambda.Group);
        }


        public static IObservable<System.Security.AccessControl.SystemAcl> get_SystemAcl(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue)
        {
            return Observable.Select(CommonSecurityDescriptorValue,
                (CommonSecurityDescriptorValueLambda) => CommonSecurityDescriptorValueLambda.SystemAcl);
        }


        public static IObservable<System.Security.AccessControl.DiscretionaryAcl> get_DiscretionaryAcl(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue)
        {
            return Observable.Select(CommonSecurityDescriptorValue,
                (CommonSecurityDescriptorValueLambda) => CommonSecurityDescriptorValueLambda.DiscretionaryAcl);
        }


        public static IObservable<System.Boolean> get_IsSystemAclCanonical(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue)
        {
            return Observable.Select(CommonSecurityDescriptorValue,
                (CommonSecurityDescriptorValueLambda) => CommonSecurityDescriptorValueLambda.IsSystemAclCanonical);
        }


        public static IObservable<System.Boolean> get_IsDiscretionaryAclCanonical(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue)
        {
            return Observable.Select(CommonSecurityDescriptorValue,
                (CommonSecurityDescriptorValueLambda) => CommonSecurityDescriptorValueLambda.IsDiscretionaryAclCanonical);
        }


        public static IObservable<System.Reactive.Unit> set_Owner(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue,
            IObservable<System.Security.Principal.SecurityIdentifier> value)
        {
            return ObservableExt.ZipExecute(CommonSecurityDescriptorValue, value,
                (CommonSecurityDescriptorValueLambda, valueLambda) =>
                    CommonSecurityDescriptorValueLambda.Owner = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Group(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue,
            IObservable<System.Security.Principal.SecurityIdentifier> value)
        {
            return ObservableExt.ZipExecute(CommonSecurityDescriptorValue, value,
                (CommonSecurityDescriptorValueLambda, valueLambda) =>
                    CommonSecurityDescriptorValueLambda.Group = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SystemAcl(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue,
            IObservable<System.Security.AccessControl.SystemAcl> value)
        {
            return ObservableExt.ZipExecute(CommonSecurityDescriptorValue, value,
                (CommonSecurityDescriptorValueLambda, valueLambda) =>
                    CommonSecurityDescriptorValueLambda.SystemAcl = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DiscretionaryAcl(
            this IObservable<System.Security.AccessControl.CommonSecurityDescriptor> CommonSecurityDescriptorValue,
            IObservable<System.Security.AccessControl.DiscretionaryAcl> value)
        {
            return ObservableExt.ZipExecute(CommonSecurityDescriptorValue, value,
                (CommonSecurityDescriptorValueLambda, valueLambda) =>
                    CommonSecurityDescriptorValueLambda.DiscretionaryAcl = valueLambda);
        }
    }
}