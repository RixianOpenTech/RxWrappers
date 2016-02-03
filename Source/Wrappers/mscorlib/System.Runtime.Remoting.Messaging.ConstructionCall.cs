using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
public static class _ConstructionCall
{
    
public static IObservable<System.Object[]> get_CallSiteActivationAttributes(this IObservable<System.Runtime.Remoting.Messaging.ConstructionCall> ConstructionCallValue)
{
    return Observable.Select(ConstructionCallValue, (ConstructionCallValueLambda) => ConstructionCallValueLambda.CallSiteActivationAttributes);
}


public static IObservable<System.Type> get_ActivationType(this IObservable<System.Runtime.Remoting.Messaging.ConstructionCall> ConstructionCallValue)
{
    return Observable.Select(ConstructionCallValue, (ConstructionCallValueLambda) => ConstructionCallValueLambda.ActivationType);
}


public static IObservable<System.String> get_ActivationTypeName(this IObservable<System.Runtime.Remoting.Messaging.ConstructionCall> ConstructionCallValue)
{
    return Observable.Select(ConstructionCallValue, (ConstructionCallValueLambda) => ConstructionCallValueLambda.ActivationTypeName);
}


public static IObservable<System.Collections.IList> get_ContextProperties(this IObservable<System.Runtime.Remoting.Messaging.ConstructionCall> ConstructionCallValue)
{
    return Observable.Select(ConstructionCallValue, (ConstructionCallValueLambda) => ConstructionCallValueLambda.ContextProperties);
}


public static IObservable<System.Collections.IDictionary> get_Properties(this IObservable<System.Runtime.Remoting.Messaging.ConstructionCall> ConstructionCallValue)
{
    return Observable.Select(ConstructionCallValue, (ConstructionCallValueLambda) => ConstructionCallValueLambda.Properties);
}


public static IObservable<System.Runtime.Remoting.Activation.IActivator> get_Activator(this IObservable<System.Runtime.Remoting.Messaging.ConstructionCall> ConstructionCallValue)
{
    return Observable.Select(ConstructionCallValue, (ConstructionCallValueLambda) => ConstructionCallValueLambda.Activator);
}


public static IObservable<System.Reactive.Unit> set_Activator(this IObservable<System.Runtime.Remoting.Messaging.ConstructionCall> ConstructionCallValue, IObservable<System.Runtime.Remoting.Activation.IActivator> value)
{
    return ObservableExt.ZipExecute(ConstructionCallValue, value, (ConstructionCallValueLambda, valueLambda) => ConstructionCallValueLambda.Activator = valueLambda);
}

}
}