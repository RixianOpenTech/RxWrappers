using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __Hash
    {
        
        public static IObservable<System.Security.Policy.Hash> CreateSHA1(IObservable<System.Byte[]> sha1)
        {
            return Observable.Select(sha1, (sha1Lambda) => System.Security.Policy.Hash.CreateSHA1(sha1Lambda));
        }


        public static IObservable<System.Security.Policy.Hash> CreateSHA256(IObservable<System.Byte[]> sha256)
        {
            return Observable.Select(sha256, (sha256Lambda) => System.Security.Policy.Hash.CreateSHA256(sha256Lambda));
        }


        public static IObservable<System.Security.Policy.Hash> CreateMD5(IObservable<System.Byte[]> md5)
        {
            return Observable.Select(md5, (md5Lambda) => System.Security.Policy.Hash.CreateMD5(md5Lambda));
        }


        public static IObservable<System.Security.Policy.EvidenceBase> Clone(this IObservable<System.Security.Policy.Hash> HashValue)
        {
            return Observable.Select(HashValue, (HashValueLambda) => HashValueLambda.Clone());
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Security.Policy.Hash> HashValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(HashValue, info, context, (HashValueLambda, infoLambda, contextLambda) => HashValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Byte[]> GenerateHash(this IObservable<System.Security.Policy.Hash> HashValue, IObservable<System.Security.Cryptography.HashAlgorithm> hashAlg)
        {
            return Observable.Zip(HashValue, hashAlg, (HashValueLambda, hashAlgLambda) => HashValueLambda.GenerateHash(hashAlgLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.Hash> HashValue)
        {
            return Observable.Select(HashValue, (HashValueLambda) => HashValueLambda.ToString());
        }


        public static IObservable<System.Byte[]> get_SHA1(this IObservable<System.Security.Policy.Hash> HashValue)
        {
            return Observable.Select(HashValue, (HashValueLambda) => HashValueLambda.SHA1);
        }


        public static IObservable<System.Byte[]> get_SHA256(this IObservable<System.Security.Policy.Hash> HashValue)
        {
            return Observable.Select(HashValue, (HashValueLambda) => HashValueLambda.SHA256);
        }


        public static IObservable<System.Byte[]> get_MD5(this IObservable<System.Security.Policy.Hash> HashValue)
        {
            return Observable.Select(HashValue, (HashValueLambda) => HashValueLambda.MD5);
        }

    }
}