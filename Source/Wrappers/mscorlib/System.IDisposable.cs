using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __IDisposable
    {
        
        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.IDisposable> IDisposableValue)
        {
            return Observable.Do(IDisposableValue, (IDisposableValueLambda) => IDisposableValueLambda.Dispose()).ToUnit();
        }

    }
}