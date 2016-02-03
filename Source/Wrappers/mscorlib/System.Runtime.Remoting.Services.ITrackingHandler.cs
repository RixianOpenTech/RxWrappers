using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Services
{
    public static class __ITrackingHandler
    {
        public static IObservable<System.Reactive.Unit> MarshaledObject(
            this IObservable<System.Runtime.Remoting.Services.ITrackingHandler> ITrackingHandlerValue,
            IObservable<System.Object> obj, IObservable<System.Runtime.Remoting.ObjRef> or)
        {
            return ObservableExt.ZipExecute(ITrackingHandlerValue, obj, or,
                (ITrackingHandlerValueLambda, objLambda, orLambda) =>
                    ITrackingHandlerValueLambda.MarshaledObject(objLambda, orLambda));
        }


        public static IObservable<System.Reactive.Unit> UnmarshaledObject(
            this IObservable<System.Runtime.Remoting.Services.ITrackingHandler> ITrackingHandlerValue,
            IObservable<System.Object> obj, IObservable<System.Runtime.Remoting.ObjRef> or)
        {
            return ObservableExt.ZipExecute(ITrackingHandlerValue, obj, or,
                (ITrackingHandlerValueLambda, objLambda, orLambda) =>
                    ITrackingHandlerValueLambda.UnmarshaledObject(objLambda, orLambda));
        }


        public static IObservable<System.Reactive.Unit> DisconnectedObject(
            this IObservable<System.Runtime.Remoting.Services.ITrackingHandler> ITrackingHandlerValue,
            IObservable<System.Object> obj)
        {
            return ObservableExt.ZipExecute(ITrackingHandlerValue, obj,
                (ITrackingHandlerValueLambda, objLambda) => ITrackingHandlerValueLambda.DisconnectedObject(objLambda));
        }
    }
}