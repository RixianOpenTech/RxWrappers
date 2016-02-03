using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __DeriveBytes
    {
        public static IObservable<System.Byte[]> GetBytes(
            this IObservable<System.Security.Cryptography.DeriveBytes> DeriveBytesValue, IObservable<System.Int32> cb)
        {
            return Observable.Zip(DeriveBytesValue, cb,
                (DeriveBytesValueLambda, cbLambda) => DeriveBytesValueLambda.GetBytes(cbLambda));
        }


        public static IObservable<System.Reactive.Unit> Reset(
            this IObservable<System.Security.Cryptography.DeriveBytes> DeriveBytesValue)
        {
            return Observable.Do(DeriveBytesValue, (DeriveBytesValueLambda) => DeriveBytesValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.Security.Cryptography.DeriveBytes> DeriveBytesValue)
        {
            return
                Observable.Do(DeriveBytesValue, (DeriveBytesValueLambda) => DeriveBytesValueLambda.Dispose()).ToUnit();
        }
    }
}