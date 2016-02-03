using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
    public static class __IObjectHandle
    {
        
        public static IObservable<System.Object> Unwrap(this IObservable<System.Runtime.Remoting.IObjectHandle> IObjectHandleValue)
        {
            return Observable.Select(IObjectHandleValue, (IObjectHandleValueLambda) => IObjectHandleValueLambda.Unwrap());
        }

    }
}