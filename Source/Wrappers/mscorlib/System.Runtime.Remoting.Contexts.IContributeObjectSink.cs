using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
public static class _IContributeObjectSink
{
    
public static IObservable<System.Runtime.Remoting.Messaging.IMessageSink> GetObjectSink(this IObservable<System.Runtime.Remoting.Contexts.IContributeObjectSink> IContributeObjectSinkValue, IObservable<System.MarshalByRefObject> obj, IObservable<System.Runtime.Remoting.Messaging.IMessageSink> nextSink)
{
    return Observable.Zip(IContributeObjectSinkValue, obj, nextSink, (IContributeObjectSinkValueLambda, objLambda, nextSinkLambda) => IContributeObjectSinkValueLambda.GetObjectSink(objLambda, nextSinkLambda));
}

}
}