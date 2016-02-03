using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __StreamReader
    {
        
        public static IObservable<System.Reactive.Unit> Close(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Do(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> DiscardBufferedData(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Do(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.DiscardBufferedData()).ToUnit();
        }


        public static IObservable<System.Int32> Peek(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Select(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.Peek());
        }


        public static IObservable<System.Int32> Read(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Select(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.Read());
        }


        public static IObservable<int> Read(this IObservable<System.IO.StreamReader> StreamReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(StreamReaderValue, buffer, index, count, (StreamReaderValueLambda, bufferLambda, indexLambda, countLambda) => StreamReaderValueLambda.Read(bufferLambda, indexLambda, countLambda));
        }


        public static IObservable<System.String> ReadToEnd(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Select(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.ReadToEnd());
        }


        public static IObservable<int> ReadBlock(this IObservable<System.IO.StreamReader> StreamReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(StreamReaderValue, buffer, index, count, (StreamReaderValueLambda, bufferLambda, indexLambda, countLambda) => StreamReaderValueLambda.ReadBlock(bufferLambda, indexLambda, countLambda));
        }


        public static IObservable<System.String> ReadLine(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Select(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.ReadLine());
        }


        public static IObservable<System.String> ReadLineAsync(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Select(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.ReadLineAsync().ToObservable()).Flatten();
        }


        public static IObservable<System.String> ReadToEndAsync(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Select(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.ReadToEndAsync().ToObservable()).Flatten();
        }


        public static IObservable<System.Int32> ReadAsync(this IObservable<System.IO.StreamReader> StreamReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(StreamReaderValue, buffer, index, count, (StreamReaderValueLambda, bufferLambda, indexLambda, countLambda) => StreamReaderValueLambda.ReadAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Int32> ReadBlockAsync(this IObservable<System.IO.StreamReader> StreamReaderValue, IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(StreamReaderValue, buffer, index, count, (StreamReaderValueLambda, bufferLambda, indexLambda, countLambda) => StreamReaderValueLambda.ReadBlockAsync(bufferLambda, indexLambda, countLambda).ToObservable()).Flatten();
        }


        public static IObservable<System.Text.Encoding> get_CurrentEncoding(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Select(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.CurrentEncoding);
        }


        public static IObservable<System.IO.Stream> get_BaseStream(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Select(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.BaseStream);
        }


        public static IObservable<System.Boolean> get_EndOfStream(this IObservable<System.IO.StreamReader> StreamReaderValue)
        {
            return Observable.Select(StreamReaderValue, (StreamReaderValueLambda) => StreamReaderValueLambda.EndOfStream);
        }

    }
}