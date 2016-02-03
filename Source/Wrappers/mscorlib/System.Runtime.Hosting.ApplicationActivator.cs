using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Hosting
{
public static class _ApplicationActivator
{
    
public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(this IObservable<System.Runtime.Hosting.ApplicationActivator> ApplicationActivatorValue, IObservable<System.ActivationContext> activationContext)
{
    return Observable.Zip(ApplicationActivatorValue, activationContext, (ApplicationActivatorValueLambda, activationContextLambda) => ApplicationActivatorValueLambda.CreateInstance(activationContextLambda));
}


public static IObservable<System.Runtime.Remoting.ObjectHandle> CreateInstance(this IObservable<System.Runtime.Hosting.ApplicationActivator> ApplicationActivatorValue, IObservable<System.ActivationContext> activationContext, IObservable<System.String[]> activationCustomData)
{
    return Observable.Zip(ApplicationActivatorValue, activationContext, activationCustomData, (ApplicationActivatorValueLambda, activationContextLambda, activationCustomDataLambda) => ApplicationActivatorValueLambda.CreateInstance(activationContextLambda, activationCustomDataLambda));
}

}
}