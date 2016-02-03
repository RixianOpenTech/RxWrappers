using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __PublisherIdentityPermission
    {
        public static IObservable<System.Security.IPermission> Copy(
            this IObservable<System.Security.Permissions.PublisherIdentityPermission> PublisherIdentityPermissionValue)
        {
            return Observable.Select(PublisherIdentityPermissionValue,
                (PublisherIdentityPermissionValueLambda) => PublisherIdentityPermissionValueLambda.Copy());
        }


        public static IObservable<System.Boolean> IsSubsetOf(
            this IObservable<System.Security.Permissions.PublisherIdentityPermission> PublisherIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(PublisherIdentityPermissionValue, target,
                (PublisherIdentityPermissionValueLambda, targetLambda) =>
                    PublisherIdentityPermissionValueLambda.IsSubsetOf(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Intersect(
            this IObservable<System.Security.Permissions.PublisherIdentityPermission> PublisherIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(PublisherIdentityPermissionValue, target,
                (PublisherIdentityPermissionValueLambda, targetLambda) =>
                    PublisherIdentityPermissionValueLambda.Intersect(targetLambda));
        }


        public static IObservable<System.Security.IPermission> Union(
            this IObservable<System.Security.Permissions.PublisherIdentityPermission> PublisherIdentityPermissionValue,
            IObservable<System.Security.IPermission> target)
        {
            return Observable.Zip(PublisherIdentityPermissionValue, target,
                (PublisherIdentityPermissionValueLambda, targetLambda) =>
                    PublisherIdentityPermissionValueLambda.Union(targetLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Permissions.PublisherIdentityPermission> PublisherIdentityPermissionValue,
            IObservable<System.Security.SecurityElement> esd)
        {
            return ObservableExt.ZipExecute(PublisherIdentityPermissionValue, esd,
                (PublisherIdentityPermissionValueLambda, esdLambda) =>
                    PublisherIdentityPermissionValueLambda.FromXml(esdLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Permissions.PublisherIdentityPermission> PublisherIdentityPermissionValue)
        {
            return Observable.Select(PublisherIdentityPermissionValue,
                (PublisherIdentityPermissionValueLambda) => PublisherIdentityPermissionValueLambda.ToXml());
        }


        public static IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> get_Certificate(
            this IObservable<System.Security.Permissions.PublisherIdentityPermission> PublisherIdentityPermissionValue)
        {
            return Observable.Select(PublisherIdentityPermissionValue,
                (PublisherIdentityPermissionValueLambda) => PublisherIdentityPermissionValueLambda.Certificate);
        }


        public static IObservable<System.Reactive.Unit> set_Certificate(
            this IObservable<System.Security.Permissions.PublisherIdentityPermission> PublisherIdentityPermissionValue,
            IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> value)
        {
            return ObservableExt.ZipExecute(PublisherIdentityPermissionValue, value,
                (PublisherIdentityPermissionValueLambda, valueLambda) =>
                    PublisherIdentityPermissionValueLambda.Certificate = valueLambda);
        }
    }
}