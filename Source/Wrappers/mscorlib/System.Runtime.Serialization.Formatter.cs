using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __Formatter
    {
        
        public static IObservable<System.Object> Deserialize(this IObservable<System.Runtime.Serialization.Formatter> FormatterValue, IObservable<System.IO.Stream> serializationStream)
        {
            return Observable.Zip(FormatterValue, serializationStream, (FormatterValueLambda, serializationStreamLambda) => FormatterValueLambda.Deserialize(serializationStreamLambda));
        }


        public static IObservable<System.Reactive.Unit> Serialize(this IObservable<System.Runtime.Serialization.Formatter> FormatterValue, IObservable<System.IO.Stream> serializationStream, IObservable<System.Object> graph)
        {
            return ObservableExt.ZipExecute(FormatterValue, serializationStream, graph, (FormatterValueLambda, serializationStreamLambda, graphLambda) => FormatterValueLambda.Serialize(serializationStreamLambda, graphLambda));
        }


        public static IObservable<System.Runtime.Serialization.ISurrogateSelector> get_SurrogateSelector(this IObservable<System.Runtime.Serialization.Formatter> FormatterValue)
        {
            return Observable.Select(FormatterValue, (FormatterValueLambda) => FormatterValueLambda.SurrogateSelector);
        }


        public static IObservable<System.Runtime.Serialization.SerializationBinder> get_Binder(this IObservable<System.Runtime.Serialization.Formatter> FormatterValue)
        {
            return Observable.Select(FormatterValue, (FormatterValueLambda) => FormatterValueLambda.Binder);
        }


        public static IObservable<System.Runtime.Serialization.StreamingContext> get_Context(this IObservable<System.Runtime.Serialization.Formatter> FormatterValue)
        {
            return Observable.Select(FormatterValue, (FormatterValueLambda) => FormatterValueLambda.Context);
        }


        public static IObservable<System.Reactive.Unit> set_SurrogateSelector(this IObservable<System.Runtime.Serialization.Formatter> FormatterValue, IObservable<System.Runtime.Serialization.ISurrogateSelector> value)
        {
            return ObservableExt.ZipExecute(FormatterValue, value, (FormatterValueLambda, valueLambda) => FormatterValueLambda.SurrogateSelector = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Binder(this IObservable<System.Runtime.Serialization.Formatter> FormatterValue, IObservable<System.Runtime.Serialization.SerializationBinder> value)
        {
            return ObservableExt.ZipExecute(FormatterValue, value, (FormatterValueLambda, valueLambda) => FormatterValueLambda.Binder = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Context(this IObservable<System.Runtime.Serialization.Formatter> FormatterValue, IObservable<System.Runtime.Serialization.StreamingContext> value)
        {
            return ObservableExt.ZipExecute(FormatterValue, value, (FormatterValueLambda, valueLambda) => FormatterValueLambda.Context = valueLambda);
        }

    }
}