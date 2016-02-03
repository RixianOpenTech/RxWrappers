using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _IServiceProvider
{
    
public static IObservable<System.Object> GetService(this IObservable<System.IServiceProvider> IServiceProviderValue, IObservable<System.Type> serviceType)
{
    return Observable.Zip(IServiceProviderValue, serviceType, (IServiceProviderValueLambda, serviceTypeLambda) => IServiceProviderValueLambda.GetService(serviceTypeLambda));
}

}
}