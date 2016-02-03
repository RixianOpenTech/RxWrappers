using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Activation
{
public static class _IActivator
{
    
public static IObservable<System.Runtime.Remoting.Activation.IConstructionReturnMessage> Activate(this IObservable<System.Runtime.Remoting.Activation.IActivator> IActivatorValue, IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> msg)
{
    return Observable.Zip(IActivatorValue, msg, (IActivatorValueLambda, msgLambda) => IActivatorValueLambda.Activate(msgLambda));
}


public static IObservable<System.Runtime.Remoting.Activation.IActivator> get_NextActivator(this IObservable<System.Runtime.Remoting.Activation.IActivator> IActivatorValue)
{
    return Observable.Select(IActivatorValue, (IActivatorValueLambda) => IActivatorValueLambda.NextActivator);
}


public static IObservable<System.Runtime.Remoting.Activation.ActivatorLevel> get_Level(this IObservable<System.Runtime.Remoting.Activation.IActivator> IActivatorValue)
{
    return Observable.Select(IActivatorValue, (IActivatorValueLambda) => IActivatorValueLambda.Level);
}


public static IObservable<System.Reactive.Unit> set_NextActivator(this IObservable<System.Runtime.Remoting.Activation.IActivator> IActivatorValue, IObservable<System.Runtime.Remoting.Activation.IActivator> value)
{
    return ObservableExt.ZipExecute(IActivatorValue, value, (IActivatorValueLambda, valueLambda) => IActivatorValueLambda.NextActivator = valueLambda);
}

}
}