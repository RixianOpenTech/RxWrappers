using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _ICspAsymmetricAlgorithm
{
    
public static IObservable<System.Byte[]> ExportCspBlob(this IObservable<System.Security.Cryptography.ICspAsymmetricAlgorithm> ICspAsymmetricAlgorithmValue, IObservable<System.Boolean> includePrivateParameters)
{
    return Observable.Zip(ICspAsymmetricAlgorithmValue, includePrivateParameters, (ICspAsymmetricAlgorithmValueLambda, includePrivateParametersLambda) => ICspAsymmetricAlgorithmValueLambda.ExportCspBlob(includePrivateParametersLambda));
}


public static IObservable<System.Reactive.Unit> ImportCspBlob(this IObservable<System.Security.Cryptography.ICspAsymmetricAlgorithm> ICspAsymmetricAlgorithmValue, IObservable<System.Byte[]> rawData)
{
    return ObservableExt.ZipExecute(ICspAsymmetricAlgorithmValue, rawData, (ICspAsymmetricAlgorithmValueLambda, rawDataLambda) => ICspAsymmetricAlgorithmValueLambda.ImportCspBlob(rawDataLambda));
}


public static IObservable<System.Security.Cryptography.CspKeyContainerInfo> get_CspKeyContainerInfo(this IObservable<System.Security.Cryptography.ICspAsymmetricAlgorithm> ICspAsymmetricAlgorithmValue)
{
    return Observable.Select(ICspAsymmetricAlgorithmValue, (ICspAsymmetricAlgorithmValueLambda) => ICspAsymmetricAlgorithmValueLambda.CspKeyContainerInfo);
}

}
}