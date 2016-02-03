using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO.IsolatedStorage
{
    public static class __INormalizeForIsolatedStorage
    {
        public static IObservable<System.Object> Normalize(
            this IObservable<System.IO.IsolatedStorage.INormalizeForIsolatedStorage> INormalizeForIsolatedStorageValue)
        {
            return Observable.Select(INormalizeForIsolatedStorageValue,
                (INormalizeForIsolatedStorageValueLambda) => INormalizeForIsolatedStorageValueLambda.Normalize());
        }
    }
}