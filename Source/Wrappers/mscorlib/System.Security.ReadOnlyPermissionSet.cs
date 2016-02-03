using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __ReadOnlyPermissionSet
    {
        public static IObservable<System.Security.PermissionSet> Copy(
            this IObservable<System.Security.ReadOnlyPermissionSet> ReadOnlyPermissionSetValue)
        {
            return Observable.Select(ReadOnlyPermissionSetValue,
                (ReadOnlyPermissionSetValueLambda) => ReadOnlyPermissionSetValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.ReadOnlyPermissionSet> ReadOnlyPermissionSetValue)
        {
            return Observable.Select(ReadOnlyPermissionSetValue,
                (ReadOnlyPermissionSetValueLambda) => ReadOnlyPermissionSetValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.ReadOnlyPermissionSet> ReadOnlyPermissionSetValue,
            IObservable<System.Security.SecurityElement> et)
        {
            return ObservableExt.ZipExecute(ReadOnlyPermissionSetValue, et,
                (ReadOnlyPermissionSetValueLambda, etLambda) => ReadOnlyPermissionSetValueLambda.FromXml(etLambda));
        }


        public static IObservable<System.Boolean> get_IsReadOnly(
            this IObservable<System.Security.ReadOnlyPermissionSet> ReadOnlyPermissionSetValue)
        {
            return Observable.Select(ReadOnlyPermissionSetValue,
                (ReadOnlyPermissionSetValueLambda) => ReadOnlyPermissionSetValueLambda.IsReadOnly);
        }
    }
}