using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization.Formatters.Binary
{
public static class _BinaryFormatter
{
    
public static IObservable<System.Object> Deserialize(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.IO.Stream> serializationStream)
{
    return Observable.Zip(BinaryFormatterValue, serializationStream, (BinaryFormatterValueLambda, serializationStreamLambda) => BinaryFormatterValueLambda.Deserialize(serializationStreamLambda));
}


public static IObservable<System.Object> Deserialize(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.IO.Stream> serializationStream, IObservable<System.Runtime.Remoting.Messaging.HeaderHandler> handler)
{
    return Observable.Zip(BinaryFormatterValue, serializationStream, handler, (BinaryFormatterValueLambda, serializationStreamLambda, handlerLambda) => BinaryFormatterValueLambda.Deserialize(serializationStreamLambda, handlerLambda));
}


public static IObservable<System.Object> DeserializeMethodResponse(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.IO.Stream> serializationStream, IObservable<System.Runtime.Remoting.Messaging.HeaderHandler> handler, IObservable<System.Runtime.Remoting.Messaging.IMethodCallMessage> methodCallMessage)
{
    return Observable.Zip(BinaryFormatterValue, serializationStream, handler, methodCallMessage, (BinaryFormatterValueLambda, serializationStreamLambda, handlerLambda, methodCallMessageLambda) => BinaryFormatterValueLambda.DeserializeMethodResponse(serializationStreamLambda, handlerLambda, methodCallMessageLambda));
}


public static IObservable<System.Object> UnsafeDeserialize(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.IO.Stream> serializationStream, IObservable<System.Runtime.Remoting.Messaging.HeaderHandler> handler)
{
    return Observable.Zip(BinaryFormatterValue, serializationStream, handler, (BinaryFormatterValueLambda, serializationStreamLambda, handlerLambda) => BinaryFormatterValueLambda.UnsafeDeserialize(serializationStreamLambda, handlerLambda));
}


public static IObservable<System.Object> UnsafeDeserializeMethodResponse(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.IO.Stream> serializationStream, IObservable<System.Runtime.Remoting.Messaging.HeaderHandler> handler, IObservable<System.Runtime.Remoting.Messaging.IMethodCallMessage> methodCallMessage)
{
    return Observable.Zip(BinaryFormatterValue, serializationStream, handler, methodCallMessage, (BinaryFormatterValueLambda, serializationStreamLambda, handlerLambda, methodCallMessageLambda) => BinaryFormatterValueLambda.UnsafeDeserializeMethodResponse(serializationStreamLambda, handlerLambda, methodCallMessageLambda));
}


public static IObservable<System.Reactive.Unit> Serialize(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.IO.Stream> serializationStream, IObservable<System.Object> graph)
{
    return ObservableExt.ZipExecute(BinaryFormatterValue, serializationStream, graph, (BinaryFormatterValueLambda, serializationStreamLambda, graphLambda) => BinaryFormatterValueLambda.Serialize(serializationStreamLambda, graphLambda));
}


public static IObservable<System.Reactive.Unit> Serialize(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.IO.Stream> serializationStream, IObservable<System.Object> graph, IObservable<System.Runtime.Remoting.Messaging.Header[]> headers)
{
    return ObservableExt.ZipExecute(BinaryFormatterValue, serializationStream, graph, headers, (BinaryFormatterValueLambda, serializationStreamLambda, graphLambda, headersLambda) => BinaryFormatterValueLambda.Serialize(serializationStreamLambda, graphLambda, headersLambda));
}


public static IObservable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> get_TypeFormat(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue)
{
    return Observable.Select(BinaryFormatterValue, (BinaryFormatterValueLambda) => BinaryFormatterValueLambda.TypeFormat);
}


public static IObservable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> get_AssemblyFormat(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue)
{
    return Observable.Select(BinaryFormatterValue, (BinaryFormatterValueLambda) => BinaryFormatterValueLambda.AssemblyFormat);
}


public static IObservable<System.Runtime.Serialization.Formatters.TypeFilterLevel> get_FilterLevel(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue)
{
    return Observable.Select(BinaryFormatterValue, (BinaryFormatterValueLambda) => BinaryFormatterValueLambda.FilterLevel);
}


public static IObservable<System.Runtime.Serialization.ISurrogateSelector> get_SurrogateSelector(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue)
{
    return Observable.Select(BinaryFormatterValue, (BinaryFormatterValueLambda) => BinaryFormatterValueLambda.SurrogateSelector);
}


public static IObservable<System.Runtime.Serialization.SerializationBinder> get_Binder(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue)
{
    return Observable.Select(BinaryFormatterValue, (BinaryFormatterValueLambda) => BinaryFormatterValueLambda.Binder);
}


public static IObservable<System.Runtime.Serialization.StreamingContext> get_Context(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue)
{
    return Observable.Select(BinaryFormatterValue, (BinaryFormatterValueLambda) => BinaryFormatterValueLambda.Context);
}


public static IObservable<System.Reactive.Unit> set_TypeFormat(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> value)
{
    return ObservableExt.ZipExecute(BinaryFormatterValue, value, (BinaryFormatterValueLambda, valueLambda) => BinaryFormatterValueLambda.TypeFormat = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_AssemblyFormat(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> value)
{
    return ObservableExt.ZipExecute(BinaryFormatterValue, value, (BinaryFormatterValueLambda, valueLambda) => BinaryFormatterValueLambda.AssemblyFormat = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_FilterLevel(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.Runtime.Serialization.Formatters.TypeFilterLevel> value)
{
    return ObservableExt.ZipExecute(BinaryFormatterValue, value, (BinaryFormatterValueLambda, valueLambda) => BinaryFormatterValueLambda.FilterLevel = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_SurrogateSelector(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.Runtime.Serialization.ISurrogateSelector> value)
{
    return ObservableExt.ZipExecute(BinaryFormatterValue, value, (BinaryFormatterValueLambda, valueLambda) => BinaryFormatterValueLambda.SurrogateSelector = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Binder(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.Runtime.Serialization.SerializationBinder> value)
{
    return ObservableExt.ZipExecute(BinaryFormatterValue, value, (BinaryFormatterValueLambda, valueLambda) => BinaryFormatterValueLambda.Binder = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Context(this IObservable<System.Runtime.Serialization.Formatters.Binary.BinaryFormatter> BinaryFormatterValue, IObservable<System.Runtime.Serialization.StreamingContext> value)
{
    return ObservableExt.ZipExecute(BinaryFormatterValue, value, (BinaryFormatterValueLambda, valueLambda) => BinaryFormatterValueLambda.Context = valueLambda);
}

}
}