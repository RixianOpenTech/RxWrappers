using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __ISurrogateSelector
    {
        public static IObservable<System.Reactive.Unit> ChainSelector(
            this IObservable<System.Runtime.Serialization.ISurrogateSelector> ISurrogateSelectorValue,
            IObservable<System.Runtime.Serialization.ISurrogateSelector> selector)
        {
            return ObservableExt.ZipExecute(ISurrogateSelectorValue, selector,
                (ISurrogateSelectorValueLambda, selectorLambda) =>
                    ISurrogateSelectorValueLambda.ChainSelector(selectorLambda));
        }


        public static
            IObservable
                <
                    Tuple
                        <System.Runtime.Serialization.ISerializationSurrogate,
                            System.Runtime.Serialization.ISurrogateSelector>> GetSurrogate(
            this IObservable<System.Runtime.Serialization.ISurrogateSelector> ISurrogateSelectorValue,
            IObservable<System.Type> type, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return Observable.Zip(ISurrogateSelectorValue, type, context,
                (ISurrogateSelectorValueLambda, typeLambda, contextLambda) =>
                {
                    System.Runtime.Serialization.ISurrogateSelector selectorOutput =
                        default(System.Runtime.Serialization.ISurrogateSelector);
                    var result = ISurrogateSelectorValueLambda.GetSurrogate(typeLambda, contextLambda,
                        out selectorOutput);
                    return Tuple.Create(result, selectorOutput);
                });
        }


        public static IObservable<System.Runtime.Serialization.ISurrogateSelector> GetNextSelector(
            this IObservable<System.Runtime.Serialization.ISurrogateSelector> ISurrogateSelectorValue)
        {
            return Observable.Select(ISurrogateSelectorValue,
                (ISurrogateSelectorValueLambda) => ISurrogateSelectorValueLambda.GetNextSelector());
        }
    }
}