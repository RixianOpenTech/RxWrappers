using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __TextWriter
    {
        
        public static IObservable<System.Reactive.Unit> Close(this IObservable<System.IO.TextWriter> TextWriterValue)
        {
            return Observable.Do(TextWriterValue, (TextWriterValueLambda) => TextWriterValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.IO.TextWriter> TextWriterValue)
        {
            return Observable.Do(TextWriterValue, (TextWriterValueLambda) => TextWriterValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.IO.TextWriter> TextWriterValue)
        {
            return Observable.Do(TextWriterValue, (TextWriterValueLambda) => TextWriterValueLambda.Flush()).ToUnit();
        }


        public static IObservable<System.IO.TextWriter> Synchronized(IObservable<System.IO.TextWriter> writer)
        {
            return Observable.Select(writer, (writerLambda) => System.IO.TextWriter.Synchronized(writerLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char[]> buffer)
        {
            return ObservableExt.ZipExecute(TextWriterValue, buffer, (TextWriterValueLambda, bufferLambda) => TextWriterValueLambda.Write(bufferLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(TextWriterValue, buffer, index, count, (TextWriterValueLambda, bufferLambda, indexLambda, countLambda) => TextWriterValueLambda.Write(bufferLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.UInt32> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.UInt64> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Single> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Double> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> format, IObservable<System.Object> arg0)
        {
            return ObservableExt.ZipExecute(TextWriterValue, format, arg0, (TextWriterValueLambda, formatLambda, arg0Lambda) => TextWriterValueLambda.Write(formatLambda, arg0Lambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1)
        {
            return ObservableExt.ZipExecute(TextWriterValue, format, arg0, arg1, (TextWriterValueLambda, formatLambda, arg0Lambda, arg1Lambda) => TextWriterValueLambda.Write(formatLambda, arg0Lambda, arg1Lambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2)
        {
            return ObservableExt.ZipExecute(TextWriterValue, format, arg0, arg1, arg2, (TextWriterValueLambda, formatLambda, arg0Lambda, arg1Lambda, arg2Lambda) => TextWriterValueLambda.Write(formatLambda, arg0Lambda, arg1Lambda, arg2Lambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> format, IObservable<System.Object[]> arg)
        {
            return ObservableExt.ZipExecute(TextWriterValue, format, arg, (TextWriterValueLambda, formatLambda, argLambda) => TextWriterValueLambda.Write(formatLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue)
        {
            return Observable.Do(TextWriterValue, (TextWriterValueLambda) => TextWriterValueLambda.WriteLine()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char[]> buffer)
        {
            return ObservableExt.ZipExecute(TextWriterValue, buffer, (TextWriterValueLambda, bufferLambda) => TextWriterValueLambda.WriteLine(bufferLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(TextWriterValue, buffer, index, count, (TextWriterValueLambda, bufferLambda, indexLambda, countLambda) => TextWriterValueLambda.WriteLine(bufferLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.UInt32> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.UInt64> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Single> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Double> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLine(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> format, IObservable<System.Object> arg0)
        {
            return ObservableExt.ZipExecute(TextWriterValue, format, arg0, (TextWriterValueLambda, formatLambda, arg0Lambda) => TextWriterValueLambda.WriteLine(formatLambda, arg0Lambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1)
        {
            return ObservableExt.ZipExecute(TextWriterValue, format, arg0, arg1, (TextWriterValueLambda, formatLambda, arg0Lambda, arg1Lambda) => TextWriterValueLambda.WriteLine(formatLambda, arg0Lambda, arg1Lambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2)
        {
            return ObservableExt.ZipExecute(TextWriterValue, format, arg0, arg1, arg2, (TextWriterValueLambda, formatLambda, arg0Lambda, arg1Lambda, arg2Lambda) => TextWriterValueLambda.WriteLine(formatLambda, arg0Lambda, arg1Lambda, arg2Lambda));
        }


        public static IObservable<System.Reactive.Unit> WriteLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> format, IObservable<System.Object[]> arg)
        {
            return ObservableExt.ZipExecute(TextWriterValue, format, arg, (TextWriterValueLambda, formatLambda, argLambda) => TextWriterValueLambda.WriteLine(formatLambda, argLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char> value)
        {
            return Observable.Zip(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteAsync(valueLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> value)
        {
            return Observable.Zip(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteAsync(valueLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char[]> buffer)
        {
            return Observable.Zip(TextWriterValue, buffer, (TextWriterValueLambda, bufferLambda) => TextWriterValueLambda.WriteAsync(bufferLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteAsync(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(TextWriterValue, buffer, index, count, (TextWriterValueLambda, bufferLambda, indexLambda, countLambda) => TextWriterValueLambda.WriteAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char> value)
        {
            return Observable.Zip(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLineAsync(valueLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> value)
        {
            return Observable.Zip(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.WriteLineAsync(valueLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char[]> buffer)
        {
            return Observable.Zip(TextWriterValue, buffer, (TextWriterValueLambda, bufferLambda) => TextWriterValueLambda.WriteLineAsync(bufferLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(TextWriterValue, buffer, index, count, (TextWriterValueLambda, bufferLambda, indexLambda, countLambda) => TextWriterValueLambda.WriteLineAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Reactive.Unit> WriteLineAsync(this IObservable<System.IO.TextWriter> TextWriterValue)
        {
            return Observable.Select(TextWriterValue, (TextWriterValueLambda) => TextWriterValueLambda.WriteLineAsync().ToObservable()).Flatten().ToUnit();
        }


        public static IObservable<System.Reactive.Unit> FlushAsync(this IObservable<System.IO.TextWriter> TextWriterValue)
        {
            return Observable.Select(TextWriterValue, (TextWriterValueLambda) => TextWriterValueLambda.FlushAsync().ToObservable()).Flatten().ToUnit();
        }


        public static IObservable<System.IFormatProvider> get_FormatProvider(this IObservable<System.IO.TextWriter> TextWriterValue)
        {
            return Observable.Select(TextWriterValue, (TextWriterValueLambda) => TextWriterValueLambda.FormatProvider);
        }


        public static IObservable<System.Text.Encoding> get_Encoding(this IObservable<System.IO.TextWriter> TextWriterValue)
        {
            return Observable.Select(TextWriterValue, (TextWriterValueLambda) => TextWriterValueLambda.Encoding);
        }


        public static IObservable<System.String> get_NewLine(this IObservable<System.IO.TextWriter> TextWriterValue)
        {
            return Observable.Select(TextWriterValue, (TextWriterValueLambda) => TextWriterValueLambda.NewLine);
        }


        public static IObservable<System.Reactive.Unit> set_NewLine(this IObservable<System.IO.TextWriter> TextWriterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(TextWriterValue, value, (TextWriterValueLambda, valueLambda) => TextWriterValueLambda.NewLine = valueLambda);
        }

    }
}