using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __CaseInsensitiveHashCodeProvider
    {
        
        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Collections.CaseInsensitiveHashCodeProvider> CaseInsensitiveHashCodeProviderValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(CaseInsensitiveHashCodeProviderValue, obj, (CaseInsensitiveHashCodeProviderValueLambda, objLambda) => CaseInsensitiveHashCodeProviderValueLambda.GetHashCode(objLambda));
        }


        public static IObservable<System.Collections.CaseInsensitiveHashCodeProvider> get_Default()
        {
            return ObservableExt.Factory(() => System.Collections.CaseInsensitiveHashCodeProvider.Default);
        }


        public static IObservable<System.Collections.CaseInsensitiveHashCodeProvider> get_DefaultInvariant()
        {
            return ObservableExt.Factory(() => System.Collections.CaseInsensitiveHashCodeProvider.DefaultInvariant);
        }

    }
}