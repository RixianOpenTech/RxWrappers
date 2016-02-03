using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __KeyContainerPermissionAccessEntry
    {
        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue, IObservable<System.Object> o)
        {
            return Observable.Zip(KeyContainerPermissionAccessEntryValue, o,
                (KeyContainerPermissionAccessEntryValueLambda, oLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue)
        {
            return Observable.Select(KeyContainerPermissionAccessEntryValue,
                (KeyContainerPermissionAccessEntryValueLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.GetHashCode());
        }


        public static IObservable<System.String> get_KeyStore(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue)
        {
            return Observable.Select(KeyContainerPermissionAccessEntryValue,
                (KeyContainerPermissionAccessEntryValueLambda) => KeyContainerPermissionAccessEntryValueLambda.KeyStore);
        }


        public static IObservable<System.String> get_ProviderName(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue)
        {
            return Observable.Select(KeyContainerPermissionAccessEntryValue,
                (KeyContainerPermissionAccessEntryValueLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.ProviderName);
        }


        public static IObservable<System.Int32> get_ProviderType(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue)
        {
            return Observable.Select(KeyContainerPermissionAccessEntryValue,
                (KeyContainerPermissionAccessEntryValueLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.ProviderType);
        }


        public static IObservable<System.String> get_KeyContainerName(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue)
        {
            return Observable.Select(KeyContainerPermissionAccessEntryValue,
                (KeyContainerPermissionAccessEntryValueLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.KeyContainerName);
        }


        public static IObservable<System.Int32> get_KeySpec(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue)
        {
            return Observable.Select(KeyContainerPermissionAccessEntryValue,
                (KeyContainerPermissionAccessEntryValueLambda) => KeyContainerPermissionAccessEntryValueLambda.KeySpec);
        }


        public static IObservable<System.Security.Permissions.KeyContainerPermissionFlags> get_Flags(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue)
        {
            return Observable.Select(KeyContainerPermissionAccessEntryValue,
                (KeyContainerPermissionAccessEntryValueLambda) => KeyContainerPermissionAccessEntryValueLambda.Flags);
        }


        public static IObservable<System.Reactive.Unit> set_KeyStore(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(KeyContainerPermissionAccessEntryValue, value,
                (KeyContainerPermissionAccessEntryValueLambda, valueLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.KeyStore = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ProviderName(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(KeyContainerPermissionAccessEntryValue, value,
                (KeyContainerPermissionAccessEntryValueLambda, valueLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.ProviderName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ProviderType(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(KeyContainerPermissionAccessEntryValue, value,
                (KeyContainerPermissionAccessEntryValueLambda, valueLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.ProviderType = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_KeyContainerName(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(KeyContainerPermissionAccessEntryValue, value,
                (KeyContainerPermissionAccessEntryValueLambda, valueLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.KeyContainerName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_KeySpec(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(KeyContainerPermissionAccessEntryValue, value,
                (KeyContainerPermissionAccessEntryValueLambda, valueLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.KeySpec = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Flags(
            this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry>
                KeyContainerPermissionAccessEntryValue,
            IObservable<System.Security.Permissions.KeyContainerPermissionFlags> value)
        {
            return ObservableExt.ZipExecute(KeyContainerPermissionAccessEntryValue, value,
                (KeyContainerPermissionAccessEntryValueLambda, valueLambda) =>
                    KeyContainerPermissionAccessEntryValueLambda.Flags = valueLambda);
        }
    }
}