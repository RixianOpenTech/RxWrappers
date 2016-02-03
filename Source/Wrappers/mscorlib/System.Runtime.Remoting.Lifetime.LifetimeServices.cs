using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Lifetime
{
    public static class __LifetimeServices
    {
        public static IObservable<System.TimeSpan> get_LeaseTime()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseTime);
        }


        public static IObservable<System.TimeSpan> get_RenewOnCallTime()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Lifetime.LifetimeServices.RenewOnCallTime);
        }


        public static IObservable<System.TimeSpan> get_SponsorshipTimeout()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Lifetime.LifetimeServices.SponsorshipTimeout);
        }


        public static IObservable<System.TimeSpan> get_LeaseManagerPollTime()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime);
        }


        public static IObservable<System.Reactive.Unit> set_LeaseTime(IObservable<System.TimeSpan> value)
        {
            return
                Observable.Do(value,
                    (valueLambda) => System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseTime = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_RenewOnCallTime(IObservable<System.TimeSpan> value)
        {
            return
                Observable.Do(value,
                    (valueLambda) => System.Runtime.Remoting.Lifetime.LifetimeServices.RenewOnCallTime = valueLambda)
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_SponsorshipTimeout(IObservable<System.TimeSpan> value)
        {
            return
                Observable.Do(value,
                    (valueLambda) => System.Runtime.Remoting.Lifetime.LifetimeServices.SponsorshipTimeout = valueLambda)
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_LeaseManagerPollTime(IObservable<System.TimeSpan> value)
        {
            return
                Observable.Do(value,
                    (valueLambda) =>
                        System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime = valueLambda).ToUnit();
        }
    }
}