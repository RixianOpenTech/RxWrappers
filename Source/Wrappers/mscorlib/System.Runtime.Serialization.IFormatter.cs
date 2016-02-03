using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
public static class _IFormatter
{
    
public static IObservable<System.Object> Deserialize(this IObservable<System.Runtime.Serialization.IFormatter> IFormatterValue, IObservable<System.IO.Stream> serializationStream)
{
    return Observable.Zip(IFormatterValue, serializationStream, (IFormatterValueLambda, serializationStreamLambda) => IFormatterValueLambda.Deserialize(serializationStreamLambda));
}


public static IObservable<System.Reactive.Unit> Serialize(this IObservable<System.Runtime.Serialization.IFormatter> IFormatterValue, IObservable<System.IO.Stream> serializationStream, IObservable<System.Object> graph)
{
    return ObservableExt.ZipExecute(IFormatterValue, serializationStream, graph, (IFormatterValueLambda, serializationStreamLambda, graphLambda) => IFormatterValueLambda.Serialize(serializationStreamLambda, graphLambda));
}


public static IObservable<System.Runtime.Serialization.ISurrogateSelector> get_SurrogateSelector(this IObservable<System.Runtime.Serialization.IFormatter> IFormatterValue)
{
    return Observable.Select(IFormatterValue, (IFormatterValueLambda) => IFormatterValueLambda.SurrogateSelector);
}


public static IObservable<System.Runtime.Serialization.SerializationBinder> get_Binder(this IObservable<System.Runtime.Serialization.IFormatter> IFormatterValue)
{
    return Observable.Select(IFormatterValue, (IFormatterValueLambda) => IFormatterValueLambda.Binder);
}


public static IObservable<System.Runtime.Serialization.StreamingContext> get_Context(this IObservable<System.Runtime.Serialization.IFormatter> IFormatterValue)
{
    return Observable.Select(IFormatterValue, (IFormatterValueLambda) => IFormatterValueLambda.Context);
}


public static IObservable<System.Reactive.Unit> set_SurrogateSelector(this IObservable<System.Runtime.Serialization.IFormatter> IFormatterValue, IObservable<System.Runtime.Serialization.ISurrogateSelector> value)
{
    return ObservableExt.ZipExecute(IFormatterValue, value, (IFormatterValueLambda, valueLambda) => IFormatterValueLambda.SurrogateSelector = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Binder(this IObservable<System.Runtime.Serialization.IFormatter> IFormatterValue, IObservable<System.Runtime.Serialization.SerializationBinder> value)
{
    return ObservableExt.ZipExecute(IFormatterValue, value, (IFormatterValueLambda, valueLambda) => IFormatterValueLambda.Binder = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Context(this IObservable<System.Runtime.Serialization.IFormatter> IFormatterValue, IObservable<System.Runtime.Serialization.StreamingContext> value)
{
    return ObservableExt.ZipExecute(IFormatterValue, value, (IFormatterValueLambda, valueLambda) => IFormatterValueLambda.Context = valueLambda);
}

}
}