using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __BinaryWriter
    {
        
        public static IObservable<System.Reactive.Unit> Close(this IObservable<System.IO.BinaryWriter> BinaryWriterValue)
        {
            return Observable.Do(BinaryWriterValue, (BinaryWriterValueLambda) => BinaryWriterValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.IO.BinaryWriter> BinaryWriterValue)
        {
            return Observable.Do(BinaryWriterValue, (BinaryWriterValueLambda) => BinaryWriterValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Flush(this IObservable<System.IO.BinaryWriter> BinaryWriterValue)
        {
            return Observable.Do(BinaryWriterValue, (BinaryWriterValueLambda) => BinaryWriterValueLambda.Flush()).ToUnit();
        }


        public static IObservable<System.Int64> Seek(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Int32> offset, IObservable<System.IO.SeekOrigin> origin)
        {
            return Observable.Zip(BinaryWriterValue, offset, origin, (BinaryWriterValueLambda, offsetLambda, originLambda) => BinaryWriterValueLambda.Seek(offsetLambda, originLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.SByte> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Byte[]> buffer)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, buffer, (BinaryWriterValueLambda, bufferLambda) => BinaryWriterValueLambda.Write(bufferLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Byte[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, buffer, index, count, (BinaryWriterValueLambda, bufferLambda, indexLambda, countLambda) => BinaryWriterValueLambda.Write(bufferLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Char> ch)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, ch, (BinaryWriterValueLambda, chLambda) => BinaryWriterValueLambda.Write(chLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Char[]> chars)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, chars, (BinaryWriterValueLambda, charsLambda) => BinaryWriterValueLambda.Write(charsLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Char[]> chars, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, chars, index, count, (BinaryWriterValueLambda, charsLambda, indexLambda, countLambda) => BinaryWriterValueLambda.Write(charsLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Double> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Int16> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.UInt16> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.UInt32> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.UInt64> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.Single> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.BinaryWriter> BinaryWriterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(BinaryWriterValue, value, (BinaryWriterValueLambda, valueLambda) => BinaryWriterValueLambda.Write(valueLambda));
        }


        public static IObservable<System.IO.Stream> get_BaseStream(this IObservable<System.IO.BinaryWriter> BinaryWriterValue)
        {
            return Observable.Select(BinaryWriterValue, (BinaryWriterValueLambda) => BinaryWriterValueLambda.BaseStream);
        }

    }
}