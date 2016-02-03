using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __RemotingSurrogateSelector
    {
        
        public static IObservable<System.Reactive.Unit> SetRootObject(this IObservable<System.Runtime.Remoting.Messaging.RemotingSurrogateSelector> RemotingSurrogateSelectorValue, IObservable<System.Object> obj)
        {
            return ObservableExt.ZipExecute(RemotingSurrogateSelectorValue, obj, (RemotingSurrogateSelectorValueLambda, objLambda) => RemotingSurrogateSelectorValueLambda.SetRootObject(objLambda));
        }


        public static IObservable<System.Object> GetRootObject(this IObservable<System.Runtime.Remoting.Messaging.RemotingSurrogateSelector> RemotingSurrogateSelectorValue)
        {
            return Observable.Select(RemotingSurrogateSelectorValue, (RemotingSurrogateSelectorValueLambda) => RemotingSurrogateSelectorValueLambda.GetRootObject());
        }


        public static IObservable<System.Reactive.Unit> ChainSelector(this IObservable<System.Runtime.Remoting.Messaging.RemotingSurrogateSelector> RemotingSurrogateSelectorValue, IObservable<System.Runtime.Serialization.ISurrogateSelector> selector)
        {
            return ObservableExt.ZipExecute(RemotingSurrogateSelectorValue, selector, (RemotingSurrogateSelectorValueLambda, selectorLambda) => RemotingSurrogateSelectorValueLambda.ChainSelector(selectorLambda));
        }


        public static IObservable<Tuple<System.Runtime.Serialization.ISerializationSurrogate, System.Runtime.Serialization.ISurrogateSelector>> GetSurrogate(this IObservable<System.Runtime.Remoting.Messaging.RemotingSurrogateSelector> RemotingSurrogateSelectorValue, IObservable<System.Type> type, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return Observable.Zip(RemotingSurrogateSelectorValue, type, context, (RemotingSurrogateSelectorValueLambda, typeLambda, contextLambda) => {
System.Runtime.Serialization.ISurrogateSelector ssoutOutput = default(System.Runtime.Serialization.ISurrogateSelector);
var result = RemotingSurrogateSelectorValueLambda.GetSurrogate(typeLambda, contextLambda, out ssoutOutput);
return Tuple.Create(result, ssoutOutput);
});
        }


        public static IObservable<System.Runtime.Serialization.ISurrogateSelector> GetNextSelector(this IObservable<System.Runtime.Remoting.Messaging.RemotingSurrogateSelector> RemotingSurrogateSelectorValue)
        {
            return Observable.Select(RemotingSurrogateSelectorValue, (RemotingSurrogateSelectorValueLambda) => RemotingSurrogateSelectorValueLambda.GetNextSelector());
        }


        public static IObservable<System.Reactive.Unit> UseSoapFormat(this IObservable<System.Runtime.Remoting.Messaging.RemotingSurrogateSelector> RemotingSurrogateSelectorValue)
        {
            return Observable.Do(RemotingSurrogateSelectorValue, (RemotingSurrogateSelectorValueLambda) => RemotingSurrogateSelectorValueLambda.UseSoapFormat()).ToUnit();
        }


        public static IObservable<System.Runtime.Remoting.Messaging.MessageSurrogateFilter> get_Filter(this IObservable<System.Runtime.Remoting.Messaging.RemotingSurrogateSelector> RemotingSurrogateSelectorValue)
        {
            return Observable.Select(RemotingSurrogateSelectorValue, (RemotingSurrogateSelectorValueLambda) => RemotingSurrogateSelectorValueLambda.Filter);
        }


        public static IObservable<System.Reactive.Unit> set_Filter(this IObservable<System.Runtime.Remoting.Messaging.RemotingSurrogateSelector> RemotingSurrogateSelectorValue, IObservable<System.Runtime.Remoting.Messaging.MessageSurrogateFilter> value)
        {
            return ObservableExt.ZipExecute(RemotingSurrogateSelectorValue, value, (RemotingSurrogateSelectorValueLambda, valueLambda) => RemotingSurrogateSelectorValueLambda.Filter = valueLambda);
        }

    }
}