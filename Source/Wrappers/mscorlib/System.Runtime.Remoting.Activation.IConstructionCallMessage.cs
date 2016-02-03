using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Activation
{
public static class _IConstructionCallMessage
{
    
public static IObservable<System.Runtime.Remoting.Activation.IActivator> get_Activator(this IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> IConstructionCallMessageValue)
{
    return Observable.Select(IConstructionCallMessageValue, (IConstructionCallMessageValueLambda) => IConstructionCallMessageValueLambda.Activator);
}


public static IObservable<System.Object[]> get_CallSiteActivationAttributes(this IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> IConstructionCallMessageValue)
{
    return Observable.Select(IConstructionCallMessageValue, (IConstructionCallMessageValueLambda) => IConstructionCallMessageValueLambda.CallSiteActivationAttributes);
}


public static IObservable<System.String> get_ActivationTypeName(this IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> IConstructionCallMessageValue)
{
    return Observable.Select(IConstructionCallMessageValue, (IConstructionCallMessageValueLambda) => IConstructionCallMessageValueLambda.ActivationTypeName);
}


public static IObservable<System.Type> get_ActivationType(this IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> IConstructionCallMessageValue)
{
    return Observable.Select(IConstructionCallMessageValue, (IConstructionCallMessageValueLambda) => IConstructionCallMessageValueLambda.ActivationType);
}


public static IObservable<System.Collections.IList> get_ContextProperties(this IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> IConstructionCallMessageValue)
{
    return Observable.Select(IConstructionCallMessageValue, (IConstructionCallMessageValueLambda) => IConstructionCallMessageValueLambda.ContextProperties);
}


public static IObservable<System.Reactive.Unit> set_Activator(this IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> IConstructionCallMessageValue, IObservable<System.Runtime.Remoting.Activation.IActivator> value)
{
    return ObservableExt.ZipExecute(IConstructionCallMessageValue, value, (IConstructionCallMessageValueLambda, valueLambda) => IConstructionCallMessageValueLambda.Activator = valueLambda);
}

}
}