using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __KeySizes
    {
        
        public static IObservable<System.Int32> get_MinSize(this IObservable<System.Security.Cryptography.KeySizes> KeySizesValue)
        {
            return Observable.Select(KeySizesValue, (KeySizesValueLambda) => KeySizesValueLambda.MinSize);
        }


        public static IObservable<System.Int32> get_MaxSize(this IObservable<System.Security.Cryptography.KeySizes> KeySizesValue)
        {
            return Observable.Select(KeySizesValue, (KeySizesValueLambda) => KeySizesValueLambda.MaxSize);
        }


        public static IObservable<System.Int32> get_SkipSize(this IObservable<System.Security.Cryptography.KeySizes> KeySizesValue)
        {
            return Observable.Select(KeySizesValue, (KeySizesValueLambda) => KeySizesValueLambda.SkipSize);
        }

    }
}