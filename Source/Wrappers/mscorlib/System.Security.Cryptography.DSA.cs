using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __DSA
    {
        public static IObservable<System.Security.Cryptography.DSA> Create()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.DSA.Create());
        }


        public static IObservable<System.Security.Cryptography.DSA> Create(IObservable<System.String> algName)
        {
            return Observable.Select(algName, (algNameLambda) => System.Security.Cryptography.DSA.Create(algNameLambda));
        }


        public static IObservable<System.Byte[]> CreateSignature(
            this IObservable<System.Security.Cryptography.DSA> DSAValue, IObservable<System.Byte[]> rgbHash)
        {
            return Observable.Zip(DSAValue, rgbHash,
                (DSAValueLambda, rgbHashLambda) => DSAValueLambda.CreateSignature(rgbHashLambda));
        }


        public static IObservable<System.Boolean> VerifySignature(
            this IObservable<System.Security.Cryptography.DSA> DSAValue, IObservable<System.Byte[]> rgbHash,
            IObservable<System.Byte[]> rgbSignature)
        {
            return Observable.Zip(DSAValue, rgbHash, rgbSignature,
                (DSAValueLambda, rgbHashLambda, rgbSignatureLambda) =>
                    DSAValueLambda.VerifySignature(rgbHashLambda, rgbSignatureLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXmlString(
            this IObservable<System.Security.Cryptography.DSA> DSAValue, IObservable<System.String> xmlString)
        {
            return ObservableExt.ZipExecute(DSAValue, xmlString,
                (DSAValueLambda, xmlStringLambda) => DSAValueLambda.FromXmlString(xmlStringLambda));
        }


        public static IObservable<System.String> ToXmlString(
            this IObservable<System.Security.Cryptography.DSA> DSAValue,
            IObservable<System.Boolean> includePrivateParameters)
        {
            return Observable.Zip(DSAValue, includePrivateParameters,
                (DSAValueLambda, includePrivateParametersLambda) =>
                    DSAValueLambda.ToXmlString(includePrivateParametersLambda));
        }


        public static IObservable<System.Security.Cryptography.DSAParameters> ExportParameters(
            this IObservable<System.Security.Cryptography.DSA> DSAValue,
            IObservable<System.Boolean> includePrivateParameters)
        {
            return Observable.Zip(DSAValue, includePrivateParameters,
                (DSAValueLambda, includePrivateParametersLambda) =>
                    DSAValueLambda.ExportParameters(includePrivateParametersLambda));
        }


        public static IObservable<System.Reactive.Unit> ImportParameters(
            this IObservable<System.Security.Cryptography.DSA> DSAValue,
            IObservable<System.Security.Cryptography.DSAParameters> parameters)
        {
            return ObservableExt.ZipExecute(DSAValue, parameters,
                (DSAValueLambda, parametersLambda) => DSAValueLambda.ImportParameters(parametersLambda));
        }
    }
}