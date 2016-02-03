using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    public static class __IActivationFactory
    {
        public static IObservable<System.Object> ActivateInstance(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.IActivationFactory> IActivationFactoryValue)
        {
            return Observable.Select(IActivationFactoryValue,
                (IActivationFactoryValueLambda) => IActivationFactoryValueLambda.ActivateInstance());
        }
    }
}