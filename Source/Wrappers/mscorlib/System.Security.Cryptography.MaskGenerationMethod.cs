using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __MaskGenerationMethod
    {
        
        public static IObservable<System.Byte[]> GenerateMask(this IObservable<System.Security.Cryptography.MaskGenerationMethod> MaskGenerationMethodValue, IObservable<System.Byte[]> rgbSeed, IObservable<System.Int32> cbReturn)
        {
            return Observable.Zip(MaskGenerationMethodValue, rgbSeed, cbReturn, (MaskGenerationMethodValueLambda, rgbSeedLambda, cbReturnLambda) => MaskGenerationMethodValueLambda.GenerateMask(rgbSeedLambda, cbReturnLambda));
        }

    }
}