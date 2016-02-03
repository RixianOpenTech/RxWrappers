using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __HashAlgorithmName
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Security.Cryptography.HashAlgorithmName> HashAlgorithmNameValue)
        {
            return Observable.Select(HashAlgorithmNameValue, (HashAlgorithmNameValueLambda) => HashAlgorithmNameValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Cryptography.HashAlgorithmName> HashAlgorithmNameValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(HashAlgorithmNameValue, obj, (HashAlgorithmNameValueLambda, objLambda) => HashAlgorithmNameValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Cryptography.HashAlgorithmName> HashAlgorithmNameValue, IObservable<System.Security.Cryptography.HashAlgorithmName> other)
        {
            return Observable.Zip(HashAlgorithmNameValue, other, (HashAlgorithmNameValueLambda, otherLambda) => HashAlgorithmNameValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Cryptography.HashAlgorithmName> HashAlgorithmNameValue)
        {
            return Observable.Select(HashAlgorithmNameValue, (HashAlgorithmNameValueLambda) => HashAlgorithmNameValueLambda.GetHashCode());
        }


        public static IObservable<System.Security.Cryptography.HashAlgorithmName> get_MD5()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.HashAlgorithmName.MD5);
        }


        public static IObservable<System.Security.Cryptography.HashAlgorithmName> get_SHA1()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.HashAlgorithmName.SHA1);
        }


        public static IObservable<System.Security.Cryptography.HashAlgorithmName> get_SHA256()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.HashAlgorithmName.SHA256);
        }


        public static IObservable<System.Security.Cryptography.HashAlgorithmName> get_SHA384()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.HashAlgorithmName.SHA384);
        }


        public static IObservable<System.Security.Cryptography.HashAlgorithmName> get_SHA512()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.HashAlgorithmName.SHA512);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Security.Cryptography.HashAlgorithmName> HashAlgorithmNameValue)
        {
            return Observable.Select(HashAlgorithmNameValue, (HashAlgorithmNameValueLambda) => HashAlgorithmNameValueLambda.Name);
        }

    }
}