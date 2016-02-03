using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
public static class _StringWriter
{
    
public static IObservable<System.Reactive.Unit> Close(this IObservable<System.IO.StringWriter> StringWriterValue)
{
    return Observable.Do(StringWriterValue, (StringWriterValueLambda) => StringWriterValueLambda.Close()).ToUnit();
}


public static IObservable<System.Text.StringBuilder> GetStringBuilder(this IObservable<System.IO.StringWriter> StringWriterValue)
{
    return Observable.Select(StringWriterValue, (StringWriterValueLambda) => StringWriterValueLambda.GetStringBuilder());
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.StringWriter> StringWriterValue, IObservable<System.Char> value)
{
    return ObservableExt.ZipExecute(StringWriterValue, value, (StringWriterValueLambda, valueLambda) => StringWriterValueLambda.Write(valueLambda));
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.StringWriter> StringWriterValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(StringWriterValue, buffer, index, count, (StringWriterValueLambda, bufferLambda, indexLambda, countLambda) => StringWriterValueLambda.Write(bufferLambda, indexLambda, countLambda));
}


public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.StringWriter> StringWriterValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(StringWriterValue, value, (StringWriterValueLambda, valueLambda) => StringWriterValueLambda.Write(valueLambda));
}


public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.StringWriter> StringWriterValue, IObservable<System.Char> value)
{
    return Observable.Zip(StringWriterValue, value, (StringWriterValueLambda, valueLambda) => StringWriterValueLambda.WriteAsync(valueLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.StringWriter> StringWriterValue, IObservable<System.String> value)
{
    return Observable.Zip(StringWriterValue, value, (StringWriterValueLambda, valueLambda) => StringWriterValueLambda.WriteAsync(valueLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.StringWriter> StringWriterValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(StringWriterValue, buffer, index, count, (StringWriterValueLambda, bufferLambda, indexLambda, countLambda) => StringWriterValueLambda.WriteAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.StringWriter> StringWriterValue, IObservable<System.Char> value)
{
    return Observable.Zip(StringWriterValue, value, (StringWriterValueLambda, valueLambda) => StringWriterValueLambda.WriteLineAsync(valueLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.StringWriter> StringWriterValue, IObservable<System.String> value)
{
    return Observable.Zip(StringWriterValue, value, (StringWriterValueLambda, valueLambda) => StringWriterValueLambda.WriteLineAsync(valueLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.StringWriter> StringWriterValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(StringWriterValue, buffer, index, count, (StringWriterValueLambda, bufferLambda, indexLambda, countLambda) => StringWriterValueLambda.WriteLineAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
}


public static IObservable<System.Reactive.Unit> FlushAsync(this IObservable<System.IO.StringWriter> StringWriterValue)
{
    return Observable.Select(StringWriterValue, (StringWriterValueLambda) => StringWriterValueLambda.FlushAsync().ToObservable()).Flatten().ToUnit();
}


public static IObservable<System.String> ToString(this IObservable<System.IO.StringWriter> StringWriterValue)
{
    return Observable.Select(StringWriterValue, (StringWriterValueLambda) => StringWriterValueLambda.ToString());
}


public static IObservable<System.Text.Encoding> get_Encoding(this IObservable<System.IO.StringWriter> StringWriterValue)
{
    return Observable.Select(StringWriterValue, (StringWriterValueLambda) => StringWriterValueLambda.Encoding);
}

}
}