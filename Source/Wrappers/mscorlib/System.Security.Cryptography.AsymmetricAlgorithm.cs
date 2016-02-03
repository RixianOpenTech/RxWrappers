using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __AsymmetricAlgorithm
    {
        
        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.Cryptography.AsymmetricAlgorithm> AsymmetricAlgorithmValue)
        {
            return Observable.Do(AsymmetricAlgorithmValue, (AsymmetricAlgorithmValueLambda) => AsymmetricAlgorithmValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Security.Cryptography.AsymmetricAlgorithm> AsymmetricAlgorithmValue)
        {
            return Observable.Do(AsymmetricAlgorithmValue, (AsymmetricAlgorithmValueLambda) => AsymmetricAlgorithmValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Security.Cryptography.AsymmetricAlgorithm> Create()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.AsymmetricAlgorithm.Create());
        }


        public static IObservable<System.Security.Cryptography.AsymmetricAlgorithm> Create(IObservable<System.String> algName)
        {
            return Observable.Select(algName, (algNameLambda) => System.Security.Cryptography.AsymmetricAlgorithm.Create(algNameLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXmlString(this IObservable<System.Security.Cryptography.AsymmetricAlgorithm> AsymmetricAlgorithmValue, IObservable<System.String> xmlString)
        {
            return ObservableExt.ZipExecute(AsymmetricAlgorithmValue, xmlString, (AsymmetricAlgorithmValueLambda, xmlStringLambda) => AsymmetricAlgorithmValueLambda.FromXmlString(xmlStringLambda));
        }


        public static IObservable<System.String> ToXmlString(this IObservable<System.Security.Cryptography.AsymmetricAlgorithm> AsymmetricAlgorithmValue, IObservable<System.Boolean> includePrivateParameters)
        {
            return Observable.Zip(AsymmetricAlgorithmValue, includePrivateParameters, (AsymmetricAlgorithmValueLambda, includePrivateParametersLambda) => AsymmetricAlgorithmValueLambda.ToXmlString(includePrivateParametersLambda));
        }


        public static IObservable<System.Int32> get_KeySize(this IObservable<System.Security.Cryptography.AsymmetricAlgorithm> AsymmetricAlgorithmValue)
        {
            return Observable.Select(AsymmetricAlgorithmValue, (AsymmetricAlgorithmValueLambda) => AsymmetricAlgorithmValueLambda.KeySize);
        }


        public static IObservable<System.Security.Cryptography.KeySizes[]> get_LegalKeySizes(this IObservable<System.Security.Cryptography.AsymmetricAlgorithm> AsymmetricAlgorithmValue)
        {
            return Observable.Select(AsymmetricAlgorithmValue, (AsymmetricAlgorithmValueLambda) => AsymmetricAlgorithmValueLambda.LegalKeySizes);
        }


        public static IObservable<System.String> get_SignatureAlgorithm(this IObservable<System.Security.Cryptography.AsymmetricAlgorithm> AsymmetricAlgorithmValue)
        {
            return Observable.Select(AsymmetricAlgorithmValue, (AsymmetricAlgorithmValueLambda) => AsymmetricAlgorithmValueLambda.SignatureAlgorithm);
        }


        public static IObservable<System.String> get_KeyExchangeAlgorithm(this IObservable<System.Security.Cryptography.AsymmetricAlgorithm> AsymmetricAlgorithmValue)
        {
            return Observable.Select(AsymmetricAlgorithmValue, (AsymmetricAlgorithmValueLambda) => AsymmetricAlgorithmValueLambda.KeyExchangeAlgorithm);
        }


        public static IObservable<System.Reactive.Unit> set_KeySize(this IObservable<System.Security.Cryptography.AsymmetricAlgorithm> AsymmetricAlgorithmValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(AsymmetricAlgorithmValue, value, (AsymmetricAlgorithmValueLambda, valueLambda) => AsymmetricAlgorithmValueLambda.KeySize = valueLambda);
        }

    }
}