using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __IRemotingFormatter
    {
        
        public static IObservable<System.Object> Deserialize(this IObservable<System.Runtime.Remoting.Messaging.IRemotingFormatter> IRemotingFormatterValue, IObservable<System.IO.Stream> serializationStream, IObservable<System.Runtime.Remoting.Messaging.HeaderHandler> handler)
        {
            return Observable.Zip(IRemotingFormatterValue, serializationStream, handler, (IRemotingFormatterValueLambda, serializationStreamLambda, handlerLambda) => IRemotingFormatterValueLambda.Deserialize(serializationStreamLambda, handlerLambda));
        }


        public static IObservable<System.Reactive.Unit> Serialize(this IObservable<System.Runtime.Remoting.Messaging.IRemotingFormatter> IRemotingFormatterValue, IObservable<System.IO.Stream> serializationStream, IObservable<System.Object> graph, IObservable<System.Runtime.Remoting.Messaging.Header[]> headers)
        {
            return ObservableExt.ZipExecute(IRemotingFormatterValue, serializationStream, graph, headers, (IRemotingFormatterValueLambda, serializationStreamLambda, graphLambda, headersLambda) => IRemotingFormatterValueLambda.Serialize(serializationStreamLambda, graphLambda, headersLambda));
        }

    }
}