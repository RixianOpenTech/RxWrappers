using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
public static class _StreamWriter
{
    
public static IObservable<System.Reactive.Unit> Close(this IObservable<System.IO.StreamWriter> StreamWriterValue)
{
    return Observable.Do(StreamWriterValue, (StreamWriterValueLambda) => StreamWriterValueLambda.Close()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.IO.StreamWriter> StreamWriterValue)
{
    return Observable.Do(StreamWriterValue, (StreamWriterValueLambda) => StreamWriterValueLambda.Flush()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.Char> value)
{
    return ObservableExt.ZipExecute(StreamWriterValue, value, (StreamWriterValueLambda, valueLambda) => StreamWriterValueLambda.Write(valueLambda));
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.Char[]> buffer)
{
    return ObservableExt.ZipExecute(StreamWriterValue, buffer, (StreamWriterValueLambda, bufferLambda) => StreamWriterValueLambda.Write(bufferLambda));
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(StreamWriterValue, buffer, index, count, (StreamWriterValueLambda, bufferLambda, indexLambda, countLambda) => StreamWriterValueLambda.Write(bufferLambda, indexLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(StreamWriterValue, value, (StreamWriterValueLambda, valueLambda) => StreamWriterValueLambda.Write(valueLambda));
}


public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.Char> value)
{
    return Observable.Zip(StreamWriterValue, value, (StreamWriterValueLambda, valueLambda) => StreamWriterValueLambda.WriteAsync(valueLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.String> value)
{
    return Observable.Zip(StreamWriterValue, value, (StreamWriterValueLambda, valueLambda) => StreamWriterValueLambda.WriteAsync(valueLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(StreamWriterValue, buffer, index, count, (StreamWriterValueLambda, bufferLambda, indexLambda, countLambda) => StreamWriterValueLambda.WriteAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.StreamWriter> StreamWriterValue)
{
    return Observable.Select(StreamWriterValue, (StreamWriterValueLambda) => StreamWriterValueLambda.WriteLineAsync().ToObservable()).Flatten().ToUnit();
}


public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.Char> value)
{
    return Observable.Zip(StreamWriterValue, value, (StreamWriterValueLambda, valueLambda) => StreamWriterValueLambda.WriteLineAsync(valueLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.String> value)
{
    return Observable.Zip(StreamWriterValue, value, (StreamWriterValueLambda, valueLambda) => StreamWriterValueLambda.WriteLineAsync(valueLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(StreamWriterValue, buffer, index, count, (StreamWriterValueLambda, bufferLambda, indexLambda, countLambda) => StreamWriterValueLambda.WriteLineAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> FlushAsync(this IObservable<System.IO.StreamWriter> StreamWriterValue)
{
    return Observable.Select(StreamWriterValue, (StreamWriterValueLambda) => StreamWriterValueLambda.FlushAsync().ToObservable()).Flatten().ToUnit();
}


public static IObservable<System.Boolean> get_AutoFlush(this IObservable<System.IO.StreamWriter> StreamWriterValue)
{
    return Observable.Select(StreamWriterValue, (StreamWriterValueLambda) => StreamWriterValueLambda.AutoFlush);
}


public static IObservable<System.IO.Stream> get_BaseStream(this IObservable<System.IO.StreamWriter> StreamWriterValue)
{
    return Observable.Select(StreamWriterValue, (StreamWriterValueLambda) => StreamWriterValueLambda.BaseStream);
}


public static IObservable<System.Text.Encoding> get_Encoding(this IObservable<System.IO.StreamWriter> StreamWriterValue)
{
    return Observable.Select(StreamWriterValue, (StreamWriterValueLambda) => StreamWriterValueLambda.Encoding);
}


public static IObservable<System.Reactive.Unit> set_AutoFlush(this IObservable<System.IO.StreamWriter> StreamWriterValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(StreamWriterValue, value, (StreamWriterValueLambda, valueLambda) => StreamWriterValueLambda.AutoFlush = valueLambda);
}

}
}