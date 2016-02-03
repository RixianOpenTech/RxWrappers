using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __CryptoConfig
    {
        
        public static IObservable<System.Object> CreateFromName(IObservable<System.String> name, IObservable<System.Object[]> args)
        {
            return Observable.Zip(name, args, (nameLambda, argsLambda) => System.Security.Cryptography.CryptoConfig.CreateFromName(nameLambda, argsLambda));
        }


        public static IObservable<System.Reactive.Unit> AddAlgorithm(IObservable<System.Type> algorithm, IObservable<System.String[]> names)
        {
            return ObservableExt.ZipExecute(algorithm, names, (algorithmLambda, namesLambda) => System.Security.Cryptography.CryptoConfig.AddAlgorithm(algorithmLambda, namesLambda));
        }


        public static IObservable<System.Object> CreateFromName(IObservable<System.String> name)
        {
            return Observable.Select(name, (nameLambda) => System.Security.Cryptography.CryptoConfig.CreateFromName(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> AddOID(IObservable<System.String> oid, IObservable<System.String[]> names)
        {
            return ObservableExt.ZipExecute(oid, names, (oidLambda, namesLambda) => System.Security.Cryptography.CryptoConfig.AddOID(oidLambda, namesLambda));
        }


        public static IObservable<System.String> MapNameToOID(IObservable<System.String> name)
        {
            return Observable.Select(name, (nameLambda) => System.Security.Cryptography.CryptoConfig.MapNameToOID(nameLambda));
        }


        public static IObservable<System.Byte[]> EncodeOID(IObservable<System.String> str)
        {
            return Observable.Select(str, (strLambda) => System.Security.Cryptography.CryptoConfig.EncodeOID(strLambda));
        }


        public static IObservable<System.Boolean> get_AllowOnlyFipsAlgorithms()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.CryptoConfig.AllowOnlyFipsAlgorithms);
        }

    }
}