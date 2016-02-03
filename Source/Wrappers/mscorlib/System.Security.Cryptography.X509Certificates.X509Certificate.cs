using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography.X509Certificates
{
public static class _X509Certificate
{
    
public static IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> CreateFromCertFile(IObservable<System.String> filename)
{
    return Observable.Select(filename, (filenameLambda) => System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromCertFile(filenameLambda));
}


public static IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> CreateFromSignedFile(IObservable<System.String> filename)
{
    return Observable.Select(filename, (filenameLambda) => System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromSignedFile(filenameLambda));
}


public static IObservable<System.String> GetName(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetName());
}


public static IObservable<System.String> GetIssuerName(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetIssuerName());
}


public static IObservable<System.Byte[]> GetSerialNumber(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetSerialNumber());
}


public static IObservable<System.String> GetSerialNumberString(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetSerialNumberString());
}


public static IObservable<System.Byte[]> GetKeyAlgorithmParameters(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetKeyAlgorithmParameters());
}


public static IObservable<System.String> GetKeyAlgorithmParametersString(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetKeyAlgorithmParametersString());
}


public static IObservable<System.String> GetKeyAlgorithm(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetKeyAlgorithm());
}


public static IObservable<System.Byte[]> GetPublicKey(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetPublicKey());
}


public static IObservable<System.String> GetPublicKeyString(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetPublicKeyString());
}


public static IObservable<System.Byte[]> GetRawCertData(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetRawCertData());
}


public static IObservable<System.String> GetRawCertDataString(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetRawCertDataString());
}


public static IObservable<System.Byte[]> GetCertHash(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetCertHash());
}


public static IObservable<System.String> GetCertHashString(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetCertHashString());
}


public static IObservable<System.String> GetEffectiveDateString(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetEffectiveDateString());
}


public static IObservable<System.String> GetExpirationDateString(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetExpirationDateString());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.Object> obj)
{
    return Observable.Zip(X509CertificateValue, obj, (X509CertificateValueLambda, objLambda) => X509CertificateValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> other)
{
    return Observable.Zip(X509CertificateValue, other, (X509CertificateValueLambda, otherLambda) => X509CertificateValueLambda.Equals(otherLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.Boolean> fVerbose)
{
    return Observable.Zip(X509CertificateValue, fVerbose, (X509CertificateValueLambda, fVerboseLambda) => X509CertificateValueLambda.ToString(fVerboseLambda));
}


public static IObservable<System.String> GetFormat(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.GetFormat());
}


public static IObservable<System.Reactive.Unit> Import(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.Byte[]> rawData)
{
    return ObservableExt.ZipExecute(X509CertificateValue, rawData, (X509CertificateValueLambda, rawDataLambda) => X509CertificateValueLambda.Import(rawDataLambda));
}


public static IObservable<System.Reactive.Unit> Import(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.Byte[]> rawData, IObservable<System.String> password, IObservable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> keyStorageFlags)
{
    return ObservableExt.ZipExecute(X509CertificateValue, rawData, password, keyStorageFlags, (X509CertificateValueLambda, rawDataLambda, passwordLambda, keyStorageFlagsLambda) => X509CertificateValueLambda.Import(rawDataLambda, passwordLambda, keyStorageFlagsLambda));
}


public static IObservable<System.Reactive.Unit> Import(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.Byte[]> rawData, IObservable<System.Security.SecureString> password, IObservable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> keyStorageFlags)
{
    return ObservableExt.ZipExecute(X509CertificateValue, rawData, password, keyStorageFlags, (X509CertificateValueLambda, rawDataLambda, passwordLambda, keyStorageFlagsLambda) => X509CertificateValueLambda.Import(rawDataLambda, passwordLambda, keyStorageFlagsLambda));
}


public static IObservable<System.Reactive.Unit> Import(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.String> fileName)
{
    return ObservableExt.ZipExecute(X509CertificateValue, fileName, (X509CertificateValueLambda, fileNameLambda) => X509CertificateValueLambda.Import(fileNameLambda));
}


public static IObservable<System.Reactive.Unit> Import(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.String> fileName, IObservable<System.String> password, IObservable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> keyStorageFlags)
{
    return ObservableExt.ZipExecute(X509CertificateValue, fileName, password, keyStorageFlags, (X509CertificateValueLambda, fileNameLambda, passwordLambda, keyStorageFlagsLambda) => X509CertificateValueLambda.Import(fileNameLambda, passwordLambda, keyStorageFlagsLambda));
}


public static IObservable<System.Reactive.Unit> Import(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.String> fileName, IObservable<System.Security.SecureString> password, IObservable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> keyStorageFlags)
{
    return ObservableExt.ZipExecute(X509CertificateValue, fileName, password, keyStorageFlags, (X509CertificateValueLambda, fileNameLambda, passwordLambda, keyStorageFlagsLambda) => X509CertificateValueLambda.Import(fileNameLambda, passwordLambda, keyStorageFlagsLambda));
}


public static IObservable<System.Byte[]> Export(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.Security.Cryptography.X509Certificates.X509ContentType> contentType)
{
    return Observable.Zip(X509CertificateValue, contentType, (X509CertificateValueLambda, contentTypeLambda) => X509CertificateValueLambda.Export(contentTypeLambda));
}


public static IObservable<System.Byte[]> Export(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.Security.Cryptography.X509Certificates.X509ContentType> contentType, IObservable<System.String> password)
{
    return Observable.Zip(X509CertificateValue, contentType, password, (X509CertificateValueLambda, contentTypeLambda, passwordLambda) => X509CertificateValueLambda.Export(contentTypeLambda, passwordLambda));
}


public static IObservable<System.Byte[]> Export(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue, IObservable<System.Security.Cryptography.X509Certificates.X509ContentType> contentType, IObservable<System.Security.SecureString> password)
{
    return Observable.Zip(X509CertificateValue, contentType, password, (X509CertificateValueLambda, contentTypeLambda, passwordLambda) => X509CertificateValueLambda.Export(contentTypeLambda, passwordLambda));
}


public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Do(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.Reset()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Do(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.IntPtr> get_Handle(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.Handle);
}


public static IObservable<System.String> get_Issuer(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.Issuer);
}


public static IObservable<System.String> get_Subject(this IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> X509CertificateValue)
{
    return Observable.Select(X509CertificateValue, (X509CertificateValueLambda) => X509CertificateValueLambda.Subject);
}

}
}