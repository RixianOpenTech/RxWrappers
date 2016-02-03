using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __PKCS1MaskGenerationMethod
    {
        
        public static IObservable<System.Byte[]> GenerateMask(this IObservable<System.Security.Cryptography.PKCS1MaskGenerationMethod> PKCS1MaskGenerationMethodValue, IObservable<System.Byte[]> rgbSeed, IObservable<System.Int32> cbReturn)
        {
            return Observable.Zip(PKCS1MaskGenerationMethodValue, rgbSeed, cbReturn, (PKCS1MaskGenerationMethodValueLambda, rgbSeedLambda, cbReturnLambda) => PKCS1MaskGenerationMethodValueLambda.GenerateMask(rgbSeedLambda, cbReturnLambda));
        }


        public static IObservable<System.String> get_HashName(this IObservable<System.Security.Cryptography.PKCS1MaskGenerationMethod> PKCS1MaskGenerationMethodValue)
        {
            return Observable.Select(PKCS1MaskGenerationMethodValue, (PKCS1MaskGenerationMethodValueLambda) => PKCS1MaskGenerationMethodValueLambda.HashName);
        }


        public static IObservable<System.Reactive.Unit> set_HashName(this IObservable<System.Security.Cryptography.PKCS1MaskGenerationMethod> PKCS1MaskGenerationMethodValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(PKCS1MaskGenerationMethodValue, value, (PKCS1MaskGenerationMethodValueLambda, valueLambda) => PKCS1MaskGenerationMethodValueLambda.HashName = valueLambda);
        }

    }
}