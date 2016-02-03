using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __ConstructionResponse
    {
        
        public static IObservable<System.Collections.IDictionary> get_Properties(this IObservable<System.Runtime.Remoting.Messaging.ConstructionResponse> ConstructionResponseValue)
        {
            return Observable.Select(ConstructionResponseValue, (ConstructionResponseValueLambda) => ConstructionResponseValueLambda.Properties);
        }

    }
}