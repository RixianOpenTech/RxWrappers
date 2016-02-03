using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __ConfiguredTaskAwaitable
    {
        public static IObservable<System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>
            GetAwaiter(
            this IObservable<System.Runtime.CompilerServices.ConfiguredTaskAwaitable> ConfiguredTaskAwaitableValue)
        {
            return Observable.Select(ConfiguredTaskAwaitableValue,
                (ConfiguredTaskAwaitableValueLambda) => ConfiguredTaskAwaitableValueLambda.GetAwaiter());
        }
    }
}