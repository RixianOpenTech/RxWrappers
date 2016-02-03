using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
public static class _StringReader
{
    
public static IObservable<System.Reactive.Unit> Close(this IObservable<System.IO.StringReader> StringReaderValue)
{
    return Observable.Do(StringReaderValue, (StringReaderValueLambda) => StringReaderValueLambda.Close()).ToUnit();
}


public static IObservable<System.Int32> Peek(this IObservable<System.IO.StringReader> StringReaderValue)
{
    return Observable.Select(StringReaderValue, (StringReaderValueLambda) => StringReaderValueLambda.Peek());
}


public static IObservable<System.Int32> Read(this IObservable<System.IO.StringReader> StringReaderValue)
{
    return Observable.Select(StringReaderValue, (StringReaderValueLambda) => StringReaderValueLambda.Read());
}


public static IObservable<Tuple<System.Int32, System.Char>> Read(this IObservable<System.IO.StringReader> StringReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(StringReaderValue, buffer, index, count, (StringReaderValueLambda, bufferLambda, indexLambda, countLambda) => StringReaderValueLambda.Read(bufferLambda, indexLambda, countLambda));
}


public static IObservable<System.String> ReadToEnd(this IObservable<System.IO.StringReader> StringReaderValue)
{
    return Observable.Select(StringReaderValue, (StringReaderValueLambda) => StringReaderValueLambda.ReadToEnd());
}


public static IObservable<System.String> ReadLine(this IObservable<System.IO.StringReader> StringReaderValue)
{
    return Observable.Select(StringReaderValue, (StringReaderValueLambda) => StringReaderValueLambda.ReadLine());
}


public static IObservable<System.String> ReadLineAsync(this IObservable<System.IO.StringReader> StringReaderValue)
{
    return Observable.Select(StringReaderValue, (StringReaderValueLambda) => StringReaderValueLambda.ReadLineAsync().ToObservable()).Flatten();
}


public static IObservable<System.String> ReadToEndAsync(this IObservable<System.IO.StringReader> StringReaderValue)
{
    return Observable.Select(StringReaderValue, (StringReaderValueLambda) => StringReaderValueLambda.ReadToEndAsync().ToObservable()).Flatten();
}


public static IObservable<System.Int32> ReadBlockAsync(this IObservable<System.IO.StringReader> StringReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(StringReaderValue, buffer, index, count, (StringReaderValueLambda, bufferLambda, indexLambda, countLambda) => StringReaderValueLambda.ReadBlockAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
}


public static IObservable<System.Int32> ReadAsync(this IObservable<System.IO.StringReader> StringReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(StringReaderValue, buffer, index, count, (StringReaderValueLambda, bufferLambda, indexLambda, countLambda) => StringReaderValueLambda.ReadAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
}

}
}