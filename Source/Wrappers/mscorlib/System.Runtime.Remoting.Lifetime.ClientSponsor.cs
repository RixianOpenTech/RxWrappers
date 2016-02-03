using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Lifetime
{
    public static class __ClientSponsor
    {
        
        public static IObservable<System.Boolean> Register(this IObservable<System.Runtime.Remoting.Lifetime.ClientSponsor> ClientSponsorValue, IObservable<System.MarshalByRefObject> obj)
        {
            return Observable.Zip(ClientSponsorValue, obj, (ClientSponsorValueLambda, objLambda) => ClientSponsorValueLambda.Register(objLambda));
        }


        public static IObservable<System.Reactive.Unit> Unregister(this IObservable<System.Runtime.Remoting.Lifetime.ClientSponsor> ClientSponsorValue, IObservable<System.MarshalByRefObject> obj)
        {
            return ObservableExt.ZipExecute(ClientSponsorValue, obj, (ClientSponsorValueLambda, objLambda) => ClientSponsorValueLambda.Unregister(objLambda));
        }


        public static IObservable<System.TimeSpan> Renewal(this IObservable<System.Runtime.Remoting.Lifetime.ClientSponsor> ClientSponsorValue, IObservable<System.Runtime.Remoting.Lifetime.ILease> lease)
        {
            return Observable.Zip(ClientSponsorValue, lease, (ClientSponsorValueLambda, leaseLambda) => ClientSponsorValueLambda.Renewal(leaseLambda));
        }


        public static IObservable<System.Reactive.Unit> Close(this IObservable<System.Runtime.Remoting.Lifetime.ClientSponsor> ClientSponsorValue)
        {
            return Observable.Do(ClientSponsorValue, (ClientSponsorValueLambda) => ClientSponsorValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Object> InitializeLifetimeService(this IObservable<System.Runtime.Remoting.Lifetime.ClientSponsor> ClientSponsorValue)
        {
            return Observable.Select(ClientSponsorValue, (ClientSponsorValueLambda) => ClientSponsorValueLambda.InitializeLifetimeService());
        }


        public static IObservable<System.TimeSpan> get_RenewalTime(this IObservable<System.Runtime.Remoting.Lifetime.ClientSponsor> ClientSponsorValue)
        {
            return Observable.Select(ClientSponsorValue, (ClientSponsorValueLambda) => ClientSponsorValueLambda.RenewalTime);
        }


        public static IObservable<System.Reactive.Unit> set_RenewalTime(this IObservable<System.Runtime.Remoting.Lifetime.ClientSponsor> ClientSponsorValue, IObservable<System.TimeSpan> value)
        {
            return ObservableExt.ZipExecute(ClientSponsorValue, value, (ClientSponsorValueLambda, valueLambda) => ClientSponsorValueLambda.RenewalTime = valueLambda);
        }

    }
}