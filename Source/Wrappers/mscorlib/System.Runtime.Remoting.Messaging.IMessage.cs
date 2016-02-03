using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __IMessage
    {
        
        public static IObservable<System.Collections.IDictionary> get_Properties(this IObservable<System.Runtime.Remoting.Messaging.IMessage> IMessageValue)
        {
            return Observable.Select(IMessageValue, (IMessageValueLambda) => IMessageValueLambda.Properties);
        }

    }
}