using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
public static class _IContextAttribute
{
    
public static IObservable<System.Boolean> IsContextOK(this IObservable<System.Runtime.Remoting.Contexts.IContextAttribute> IContextAttributeValue, IObservable<System.Runtime.Remoting.Contexts.Context> ctx, IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> msg)
{
    return Observable.Zip(IContextAttributeValue, ctx, msg, (IContextAttributeValueLambda, ctxLambda, msgLambda) => IContextAttributeValueLambda.IsContextOK(ctxLambda, msgLambda));
}


public static IObservable<System.Reactive.Unit> GetPropertiesForNewContext(this IObservable<System.Runtime.Remoting.Contexts.IContextAttribute> IContextAttributeValue, IObservable<System.Runtime.Remoting.Activation.IConstructionCallMessage> msg)
{
    return ObservableExt.ZipExecute(IContextAttributeValue, msg, (IContextAttributeValueLambda, msgLambda) => IContextAttributeValueLambda.GetPropertiesForNewContext(msgLambda));
}

}
}