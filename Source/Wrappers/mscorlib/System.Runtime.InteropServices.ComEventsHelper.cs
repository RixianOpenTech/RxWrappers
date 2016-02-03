using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _ComEventsHelper
{
    
public static IObservable<System.Reactive.Unit> Combine(IObservable<System.Object> rcw, IObservable<System.Guid> iid, IObservable<System.Int32> dispid, IObservable<System.Delegate> d)
{
    return ObservableExt.ZipExecute(rcw, iid, dispid, d, (rcwLambda, iidLambda, dispidLambda, dLambda) => System.Runtime.InteropServices.ComEventsHelper.Combine(rcwLambda, iidLambda, dispidLambda, dLambda));
}


public static IObservable<System.Delegate> Remove(IObservable<System.Object> rcw, IObservable<System.Guid> iid, IObservable<System.Int32> dispid, IObservable<System.Delegate> d)
{
    return Observable.Zip(rcw, iid, dispid, d, (rcwLambda, iidLambda, dispidLambda, dLambda) => System.Runtime.InteropServices.ComEventsHelper.Remove(rcwLambda, iidLambda, dispidLambda, dLambda));
}

}
}