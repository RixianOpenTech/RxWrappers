using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RSASignaturePadding
    {
        
        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Cryptography.RSASignaturePadding> RSASignaturePaddingValue)
        {
            return Observable.Select(RSASignaturePaddingValue, (RSASignaturePaddingValueLambda) => RSASignaturePaddingValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Cryptography.RSASignaturePadding> RSASignaturePaddingValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(RSASignaturePaddingValue, obj, (RSASignaturePaddingValueLambda, objLambda) => RSASignaturePaddingValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Cryptography.RSASignaturePadding> RSASignaturePaddingValue, IObservable<System.Security.Cryptography.RSASignaturePadding> other)
        {
            return Observable.Zip(RSASignaturePaddingValue, other, (RSASignaturePaddingValueLambda, otherLambda) => RSASignaturePaddingValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.Cryptography.RSASignaturePadding> RSASignaturePaddingValue)
        {
            return Observable.Select(RSASignaturePaddingValue, (RSASignaturePaddingValueLambda) => RSASignaturePaddingValueLambda.ToString());
        }


        public static IObservable<System.Security.Cryptography.RSASignaturePadding> get_Pkcs1()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RSASignaturePadding.Pkcs1);
        }


        public static IObservable<System.Security.Cryptography.RSASignaturePadding> get_Pss()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RSASignaturePadding.Pss);
        }


        public static IObservable<System.Security.Cryptography.RSASignaturePaddingMode> get_Mode(this IObservable<System.Security.Cryptography.RSASignaturePadding> RSASignaturePaddingValue)
        {
            return Observable.Select(RSASignaturePaddingValue, (RSASignaturePaddingValueLambda) => RSASignaturePaddingValueLambda.Mode);
        }

    }
}