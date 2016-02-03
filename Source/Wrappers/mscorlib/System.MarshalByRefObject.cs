using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __MarshalByRefObject
    {
        
        public static IObservable<System.Object> GetLifetimeService(this IObservable<System.MarshalByRefObject> MarshalByRefObjectValue)
        {
            return Observable.Select(MarshalByRefObjectValue, (MarshalByRefObjectValueLambda) => MarshalByRefObjectValueLambda.GetLifetimeService());
        }


        public static IObservable<System.Object> InitializeLifetimeService(this IObservable<System.MarshalByRefObject> MarshalByRefObjectValue)
        {
            return Observable.Select(MarshalByRefObjectValue, (MarshalByRefObjectValueLambda) => MarshalByRefObjectValueLambda.InitializeLifetimeService());
        }


        public static IObservable<System.Runtime.Remoting.ObjRef> CreateObjRef(this IObservable<System.MarshalByRefObject> MarshalByRefObjectValue, IObservable<System.Type> requestedType)
        {
            return Observable.Zip(MarshalByRefObjectValue, requestedType, (MarshalByRefObjectValueLambda, requestedTypeLambda) => MarshalByRefObjectValueLambda.CreateObjRef(requestedTypeLambda));
        }

    }
}