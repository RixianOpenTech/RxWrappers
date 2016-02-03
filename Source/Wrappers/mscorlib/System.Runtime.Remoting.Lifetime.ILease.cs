using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Lifetime
{
public static class _ILease
{
    
public static IObservable<System.Reactive.Unit> Register(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue, IObservable<System.Runtime.Remoting.Lifetime.ISponsor> obj, IObservable<System.TimeSpan> renewalTime)
{
    return ObservableExt.ZipExecute(ILeaseValue, obj, renewalTime, (ILeaseValueLambda, objLambda, renewalTimeLambda) => ILeaseValueLambda.Register(objLambda, renewalTimeLambda));
}


public static IObservable<System.Reactive.Unit> Register(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue, IObservable<System.Runtime.Remoting.Lifetime.ISponsor> obj)
{
    return ObservableExt.ZipExecute(ILeaseValue, obj, (ILeaseValueLambda, objLambda) => ILeaseValueLambda.Register(objLambda));
}


public static IObservable<System.Reactive.Unit> Unregister(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue, IObservable<System.Runtime.Remoting.Lifetime.ISponsor> obj)
{
    return ObservableExt.ZipExecute(ILeaseValue, obj, (ILeaseValueLambda, objLambda) => ILeaseValueLambda.Unregister(objLambda));
}


public static IObservable<System.TimeSpan> Renew(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue, IObservable<System.TimeSpan> renewalTime)
{
    return Observable.Zip(ILeaseValue, renewalTime, (ILeaseValueLambda, renewalTimeLambda) => ILeaseValueLambda.Renew(renewalTimeLambda));
}


public static IObservable<System.TimeSpan> get_RenewOnCallTime(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue)
{
    return Observable.Select(ILeaseValue, (ILeaseValueLambda) => ILeaseValueLambda.RenewOnCallTime);
}


public static IObservable<System.TimeSpan> get_SponsorshipTimeout(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue)
{
    return Observable.Select(ILeaseValue, (ILeaseValueLambda) => ILeaseValueLambda.SponsorshipTimeout);
}


public static IObservable<System.TimeSpan> get_InitialLeaseTime(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue)
{
    return Observable.Select(ILeaseValue, (ILeaseValueLambda) => ILeaseValueLambda.InitialLeaseTime);
}


public static IObservable<System.TimeSpan> get_CurrentLeaseTime(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue)
{
    return Observable.Select(ILeaseValue, (ILeaseValueLambda) => ILeaseValueLambda.CurrentLeaseTime);
}


public static IObservable<System.Runtime.Remoting.Lifetime.LeaseState> get_CurrentState(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue)
{
    return Observable.Select(ILeaseValue, (ILeaseValueLambda) => ILeaseValueLambda.CurrentState);
}


public static IObservable<System.Reactive.Unit> set_RenewOnCallTime(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue, IObservable<System.TimeSpan> value)
{
    return ObservableExt.ZipExecute(ILeaseValue, value, (ILeaseValueLambda, valueLambda) => ILeaseValueLambda.RenewOnCallTime = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_SponsorshipTimeout(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue, IObservable<System.TimeSpan> value)
{
    return ObservableExt.ZipExecute(ILeaseValue, value, (ILeaseValueLambda, valueLambda) => ILeaseValueLambda.SponsorshipTimeout = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_InitialLeaseTime(this IObservable<System.Runtime.Remoting.Lifetime.ILease> ILeaseValue, IObservable<System.TimeSpan> value)
{
    return ObservableExt.ZipExecute(ILeaseValue, value, (ILeaseValueLambda, valueLambda) => ILeaseValueLambda.InitialLeaseTime = valueLambda);
}

}
}