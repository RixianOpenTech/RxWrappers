using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __CspKeyContainerInfo
    {
        public static IObservable<System.Boolean> get_MachineKeyStore(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.MachineKeyStore);
        }


        public static IObservable<System.String> get_ProviderName(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.ProviderName);
        }


        public static IObservable<System.Int32> get_ProviderType(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.ProviderType);
        }


        public static IObservable<System.String> get_KeyContainerName(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.KeyContainerName);
        }


        public static IObservable<System.String> get_UniqueKeyContainerName(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.UniqueKeyContainerName);
        }


        public static IObservable<System.Security.Cryptography.KeyNumber> get_KeyNumber(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.KeyNumber);
        }


        public static IObservable<System.Boolean> get_Exportable(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.Exportable);
        }


        public static IObservable<System.Boolean> get_HardwareDevice(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.HardwareDevice);
        }


        public static IObservable<System.Boolean> get_Removable(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.Removable);
        }


        public static IObservable<System.Boolean> get_Accessible(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.Accessible);
        }


        public static IObservable<System.Boolean> get_Protected(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.Protected);
        }


        public static IObservable<System.Security.AccessControl.CryptoKeySecurity> get_CryptoKeySecurity(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.CryptoKeySecurity);
        }


        public static IObservable<System.Boolean> get_RandomlyGenerated(
            this IObservable<System.Security.Cryptography.CspKeyContainerInfo> CspKeyContainerInfoValue)
        {
            return Observable.Select(CspKeyContainerInfoValue,
                (CspKeyContainerInfoValueLambda) => CspKeyContainerInfoValueLambda.RandomlyGenerated);
        }
    }
}