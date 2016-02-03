using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __SurrogateSelector
    {
        
        public static IObservable<System.Reactive.Unit> AddSurrogate(this IObservable<System.Runtime.Serialization.SurrogateSelector> SurrogateSelectorValue, IObservable<System.Type> type, IObservable<System.Runtime.Serialization.StreamingContext> context, IObservable<System.Runtime.Serialization.ISerializationSurrogate> surrogate)
        {
            return ObservableExt.ZipExecute(SurrogateSelectorValue, type, context, surrogate, (SurrogateSelectorValueLambda, typeLambda, contextLambda, surrogateLambda) => SurrogateSelectorValueLambda.AddSurrogate(typeLambda, contextLambda, surrogateLambda));
        }


        public static IObservable<System.Reactive.Unit> ChainSelector(this IObservable<System.Runtime.Serialization.SurrogateSelector> SurrogateSelectorValue, IObservable<System.Runtime.Serialization.ISurrogateSelector> selector)
        {
            return ObservableExt.ZipExecute(SurrogateSelectorValue, selector, (SurrogateSelectorValueLambda, selectorLambda) => SurrogateSelectorValueLambda.ChainSelector(selectorLambda));
        }


        public static IObservable<System.Runtime.Serialization.ISurrogateSelector> GetNextSelector(this IObservable<System.Runtime.Serialization.SurrogateSelector> SurrogateSelectorValue)
        {
            return Observable.Select(SurrogateSelectorValue, (SurrogateSelectorValueLambda) => SurrogateSelectorValueLambda.GetNextSelector());
        }


        public static IObservable<Tuple<System.Runtime.Serialization.ISerializationSurrogate, System.Runtime.Serialization.ISurrogateSelector>> GetSurrogate(this IObservable<System.Runtime.Serialization.SurrogateSelector> SurrogateSelectorValue, IObservable<System.Type> type, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return Observable.Zip(SurrogateSelectorValue, type, context, (SurrogateSelectorValueLambda, typeLambda, contextLambda) => {
System.Runtime.Serialization.ISurrogateSelector selectorOutput = default(System.Runtime.Serialization.ISurrogateSelector);
var result = SurrogateSelectorValueLambda.GetSurrogate(typeLambda, contextLambda, out selectorOutput);
return Tuple.Create(result, selectorOutput);
});
        }


        public static IObservable<System.Reactive.Unit> RemoveSurrogate(this IObservable<System.Runtime.Serialization.SurrogateSelector> SurrogateSelectorValue, IObservable<System.Type> type, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(SurrogateSelectorValue, type, context, (SurrogateSelectorValueLambda, typeLambda, contextLambda) => SurrogateSelectorValueLambda.RemoveSurrogate(typeLambda, contextLambda));
        }

    }
}