using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Services
{
    public static class __TrackingServices
    {
        
        public static IObservable<System.Reactive.Unit> RegisterTrackingHandler(IObservable<System.Runtime.Remoting.Services.ITrackingHandler> handler)
        {
            return Observable.Do(handler, (handlerLambda) => System.Runtime.Remoting.Services.TrackingServices.RegisterTrackingHandler(handlerLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> UnregisterTrackingHandler(IObservable<System.Runtime.Remoting.Services.ITrackingHandler> handler)
        {
            return Observable.Do(handler, (handlerLambda) => System.Runtime.Remoting.Services.TrackingServices.UnregisterTrackingHandler(handlerLambda)).ToUnit();
        }


        public static IObservable<System.Runtime.Remoting.Services.ITrackingHandler[]> get_RegisteredHandlers()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Services.TrackingServices.RegisteredHandlers);
        }

    }
}