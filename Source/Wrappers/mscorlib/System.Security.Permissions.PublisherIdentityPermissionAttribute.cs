using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __PublisherIdentityPermissionAttribute
    {
        public static IObservable<System.Security.IPermission> CreatePermission(
            this IObservable<System.Security.Permissions.PublisherIdentityPermissionAttribute>
                PublisherIdentityPermissionAttributeValue)
        {
            return Observable.Select(PublisherIdentityPermissionAttributeValue,
                (PublisherIdentityPermissionAttributeValueLambda) =>
                    PublisherIdentityPermissionAttributeValueLambda.CreatePermission());
        }


        public static IObservable<System.String> get_X509Certificate(
            this IObservable<System.Security.Permissions.PublisherIdentityPermissionAttribute>
                PublisherIdentityPermissionAttributeValue)
        {
            return Observable.Select(PublisherIdentityPermissionAttributeValue,
                (PublisherIdentityPermissionAttributeValueLambda) =>
                    PublisherIdentityPermissionAttributeValueLambda.X509Certificate);
        }


        public static IObservable<System.String> get_CertFile(
            this IObservable<System.Security.Permissions.PublisherIdentityPermissionAttribute>
                PublisherIdentityPermissionAttributeValue)
        {
            return Observable.Select(PublisherIdentityPermissionAttributeValue,
                (PublisherIdentityPermissionAttributeValueLambda) =>
                    PublisherIdentityPermissionAttributeValueLambda.CertFile);
        }


        public static IObservable<System.String> get_SignedFile(
            this IObservable<System.Security.Permissions.PublisherIdentityPermissionAttribute>
                PublisherIdentityPermissionAttributeValue)
        {
            return Observable.Select(PublisherIdentityPermissionAttributeValue,
                (PublisherIdentityPermissionAttributeValueLambda) =>
                    PublisherIdentityPermissionAttributeValueLambda.SignedFile);
        }


        public static IObservable<System.Reactive.Unit> set_X509Certificate(
            this IObservable<System.Security.Permissions.PublisherIdentityPermissionAttribute>
                PublisherIdentityPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(PublisherIdentityPermissionAttributeValue, value,
                (PublisherIdentityPermissionAttributeValueLambda, valueLambda) =>
                    PublisherIdentityPermissionAttributeValueLambda.X509Certificate = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CertFile(
            this IObservable<System.Security.Permissions.PublisherIdentityPermissionAttribute>
                PublisherIdentityPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(PublisherIdentityPermissionAttributeValue, value,
                (PublisherIdentityPermissionAttributeValueLambda, valueLambda) =>
                    PublisherIdentityPermissionAttributeValueLambda.CertFile = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SignedFile(
            this IObservable<System.Security.Permissions.PublisherIdentityPermissionAttribute>
                PublisherIdentityPermissionAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(PublisherIdentityPermissionAttributeValue, value,
                (PublisherIdentityPermissionAttributeValueLambda, valueLambda) =>
                    PublisherIdentityPermissionAttributeValueLambda.SignedFile = valueLambda);
        }
    }
}