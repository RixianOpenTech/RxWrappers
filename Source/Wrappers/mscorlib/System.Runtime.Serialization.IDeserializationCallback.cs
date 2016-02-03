using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __IDeserializationCallback
    {
        
        public static IObservable<System.Reactive.Unit> OnDeserialization(this IObservable<System.Runtime.Serialization.IDeserializationCallback> IDeserializationCallbackValue, IObservable<System.Object> sender)
        {
            return ObservableExt.ZipExecute(IDeserializationCallbackValue, sender, (IDeserializationCallbackValueLambda, senderLambda) => IDeserializationCallbackValueLambda.OnDeserialization(senderLambda));
        }

    }
}