using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
public static class _IDynamicMessageSink
{
    
public static IObservable<System.Reactive.Unit> ProcessMessageStart(this IObservable<System.Runtime.Remoting.Contexts.IDynamicMessageSink> IDynamicMessageSinkValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> reqMsg, IObservable<System.Boolean> bCliSide, IObservable<System.Boolean> bAsync)
{
    return ObservableExt.ZipExecute(IDynamicMessageSinkValue, reqMsg, bCliSide, bAsync, (IDynamicMessageSinkValueLambda, reqMsgLambda, bCliSideLambda, bAsyncLambda) => IDynamicMessageSinkValueLambda.ProcessMessageStart(reqMsgLambda, bCliSideLambda, bAsyncLambda));
}


public static IObservable<System.Reactive.Unit> ProcessMessageFinish(this IObservable<System.Runtime.Remoting.Contexts.IDynamicMessageSink> IDynamicMessageSinkValue, IObservable<System.Runtime.Remoting.Messaging.IMessage> replyMsg, IObservable<System.Boolean> bCliSide, IObservable<System.Boolean> bAsync)
{
    return ObservableExt.ZipExecute(IDynamicMessageSinkValue, replyMsg, bCliSide, bAsync, (IDynamicMessageSinkValueLambda, replyMsgLambda, bCliSideLambda, bAsyncLambda) => IDynamicMessageSinkValueLambda.ProcessMessageFinish(replyMsgLambda, bCliSideLambda, bAsyncLambda));
}

}
}