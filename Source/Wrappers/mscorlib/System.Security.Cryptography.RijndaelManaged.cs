using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RijndaelManaged
    {
        public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateEncryptor(
            this IObservable<System.Security.Cryptography.RijndaelManaged> RijndaelManagedValue,
            IObservable<System.Byte[]> rgbKey, IObservable<System.Byte[]> rgbIV)
        {
            return Observable.Zip(RijndaelManagedValue, rgbKey, rgbIV,
                (RijndaelManagedValueLambda, rgbKeyLambda, rgbIVLambda) =>
                    RijndaelManagedValueLambda.CreateEncryptor(rgbKeyLambda, rgbIVLambda));
        }


        public static IObservable<System.Security.Cryptography.ICryptoTransform> CreateDecryptor(
            this IObservable<System.Security.Cryptography.RijndaelManaged> RijndaelManagedValue,
            IObservable<System.Byte[]> rgbKey, IObservable<System.Byte[]> rgbIV)
        {
            return Observable.Zip(RijndaelManagedValue, rgbKey, rgbIV,
                (RijndaelManagedValueLambda, rgbKeyLambda, rgbIVLambda) =>
                    RijndaelManagedValueLambda.CreateDecryptor(rgbKeyLambda, rgbIVLambda));
        }


        public static IObservable<System.Reactive.Unit> GenerateKey(
            this IObservable<System.Security.Cryptography.RijndaelManaged> RijndaelManagedValue)
        {
            return
                Observable.Do(RijndaelManagedValue,
                    (RijndaelManagedValueLambda) => RijndaelManagedValueLambda.GenerateKey()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> GenerateIV(
            this IObservable<System.Security.Cryptography.RijndaelManaged> RijndaelManagedValue)
        {
            return
                Observable.Do(RijndaelManagedValue,
                    (RijndaelManagedValueLambda) => RijndaelManagedValueLambda.GenerateIV()).ToUnit();
        }
    }
}