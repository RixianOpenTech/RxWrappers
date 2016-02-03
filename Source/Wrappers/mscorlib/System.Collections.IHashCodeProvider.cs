using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __IHashCodeProvider
    {
        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Collections.IHashCodeProvider> IHashCodeProviderValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(IHashCodeProviderValue, obj,
                (IHashCodeProviderValueLambda, objLambda) => IHashCodeProviderValueLambda.GetHashCode(objLambda));
        }
    }
}