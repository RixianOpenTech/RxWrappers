using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
public static class _IContributeDynamicSink
{
    
public static IObservable<System.Runtime.Remoting.Contexts.IDynamicMessageSink> GetDynamicSink(this IObservable<System.Runtime.Remoting.Contexts.IContributeDynamicSink> IContributeDynamicSinkValue)
{
    return Observable.Select(IContributeDynamicSinkValue, (IContributeDynamicSinkValueLambda) => IContributeDynamicSinkValueLambda.GetDynamicSink());
}

}
}