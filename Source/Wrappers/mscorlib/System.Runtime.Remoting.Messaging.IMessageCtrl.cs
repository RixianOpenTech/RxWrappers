using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
public static class _IMessageCtrl
{
    
public static IObservable<System.Reactive.Unit> Cancel(this IObservable<System.Runtime.Remoting.Messaging.IMessageCtrl> IMessageCtrlValue, IObservable<System.Int32> msToCancel)
{
    return ObservableExt.ZipExecute(IMessageCtrlValue, msToCancel, (IMessageCtrlValueLambda, msToCancelLambda) => IMessageCtrlValueLambda.Cancel(msToCancelLambda));
}

}
}