using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
public static class _TextReader
{
    
public static IObservable<System.Reactive.Unit> Close(this IObservable<System.IO.TextReader> TextReaderValue)
{
    return Observable.Do(TextReaderValue, (TextReaderValueLambda) => TextReaderValueLambda.Close()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.IO.TextReader> TextReaderValue)
{
    return Observable.Do(TextReaderValue, (TextReaderValueLambda) => TextReaderValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.Int32> Peek(this IObservable<System.IO.TextReader> TextReaderValue)
{
    return Observable.Select(TextReaderValue, (TextReaderValueLambda) => TextReaderValueLambda.Peek());
}


public static IObservable<System.Int32> Read(this IObservable<System.IO.TextReader> TextReaderValue)
{
    return Observable.Select(TextReaderValue, (TextReaderValueLambda) => TextReaderValueLambda.Read());
}


public static IObservable<Tuple<System.Int32, System.Char>> Read(this IObservable<System.IO.TextReader> TextReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(TextReaderValue, buffer, index, count, (TextReaderValueLambda, bufferLambda, indexLambda, countLambda) => TextReaderValueLambda.Read(bufferLambda, indexLambda, countLambda));
}


public static IObservable<System.String> ReadToEnd(this IObservable<System.IO.TextReader> TextReaderValue)
{
    return Observable.Select(TextReaderValue, (TextReaderValueLambda) => TextReaderValueLambda.ReadToEnd());
}


public static IObservable<Tuple<System.Int32, System.Char>> ReadBlock(this IObservable<System.IO.TextReader> TextReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(TextReaderValue, buffer, index, count, (TextReaderValueLambda, bufferLambda, indexLambda, countLambda) => TextReaderValueLambda.ReadBlock(bufferLambda, indexLambda, countLambda));
}


public static IObservable<System.String> ReadLine(this IObservable<System.IO.TextReader> TextReaderValue)
{
    return Observable.Select(TextReaderValue, (TextReaderValueLambda) => TextReaderValueLambda.ReadLine());
}


public static IObservable<System.String> ReadLineAsync(this IObservable<System.IO.TextReader> TextReaderValue)
{
    return Observable.Select(TextReaderValue, (TextReaderValueLambda) => TextReaderValueLambda.ReadLineAsync().ToObservable()).Flatten();
}


public static IObservable<System.String> ReadToEndAsync(this IObservable<System.IO.TextReader> TextReaderValue)
{
    return Observable.Select(TextReaderValue, (TextReaderValueLambda) => TextReaderValueLambda.ReadToEndAsync().ToObservable()).Flatten();
}


public static IObservable<System.Int32> ReadAsync(this IObservable<System.IO.TextReader> TextReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(TextReaderValue, buffer, index, count, (TextReaderValueLambda, bufferLambda, indexLambda, countLambda) => TextReaderValueLambda.ReadAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
}


public static IObservable<System.Int32> ReadBlockAsync(this IObservable<System.IO.TextReader> TextReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(TextReaderValue, buffer, index, count, (TextReaderValueLambda, bufferLambda, indexLambda, countLambda) => TextReaderValueLambda.ReadBlockAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
}


public static IObservable<System.IO.TextReader> Synchronized(IObservable<System.IO.TextReader> reader)
{
    return Observable.Select(reader, (readerLambda) => System.IO.TextReader.Synchronized(readerLambda));
}

}
}