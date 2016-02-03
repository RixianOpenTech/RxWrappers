using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __KeyedHashAlgorithm
    {
        public static IObservable<System.Security.Cryptography.KeyedHashAlgorithm> Create()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.KeyedHashAlgorithm.Create());
        }


        public static IObservable<System.Security.Cryptography.KeyedHashAlgorithm> Create(
            IObservable<System.String> algName)
        {
            return Observable.Select(algName,
                (algNameLambda) => System.Security.Cryptography.KeyedHashAlgorithm.Create(algNameLambda));
        }


        public static IObservable<System.Byte[]> get_Key(
            this IObservable<System.Security.Cryptography.KeyedHashAlgorithm> KeyedHashAlgorithmValue)
        {
            return Observable.Select(KeyedHashAlgorithmValue,
                (KeyedHashAlgorithmValueLambda) => KeyedHashAlgorithmValueLambda.Key);
        }


        public static IObservable<System.Reactive.Unit> set_Key(
            this IObservable<System.Security.Cryptography.KeyedHashAlgorithm> KeyedHashAlgorithmValue,
            IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(KeyedHashAlgorithmValue, value,
                (KeyedHashAlgorithmValueLambda, valueLambda) => KeyedHashAlgorithmValueLambda.Key = valueLambda);
        }
    }
}