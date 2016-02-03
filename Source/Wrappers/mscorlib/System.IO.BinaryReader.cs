using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __BinaryReader
    {
        public static IObservable<System.Reactive.Unit> Close(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return
                Observable.Do(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return
                Observable.Do(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.Dispose())
                    .ToUnit();
        }


        public static IObservable<System.Int32> PeekChar(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.PeekChar());
        }


        public static IObservable<System.Int32> Read(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.Read());
        }


        public static IObservable<System.Boolean> ReadBoolean(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue,
                (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadBoolean());
        }


        public static IObservable<System.Byte> ReadByte(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadByte());
        }


        public static IObservable<System.SByte> ReadSByte(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadSByte());
        }


        public static IObservable<System.Char> ReadChar(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadChar());
        }


        public static IObservable<System.Int16> ReadInt16(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadInt16());
        }


        public static IObservable<System.UInt16> ReadUInt16(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue,
                (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadUInt16());
        }


        public static IObservable<System.Int32> ReadInt32(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadInt32());
        }


        public static IObservable<System.UInt32> ReadUInt32(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue,
                (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadUInt32());
        }


        public static IObservable<System.Int64> ReadInt64(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadInt64());
        }


        public static IObservable<System.UInt64> ReadUInt64(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue,
                (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadUInt64());
        }


        public static IObservable<System.Single> ReadSingle(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue,
                (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadSingle());
        }


        public static IObservable<System.Double> ReadDouble(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue,
                (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadDouble());
        }


        public static IObservable<System.Decimal> ReadDecimal(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue,
                (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadDecimal());
        }


        public static IObservable<System.String> ReadString(this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue,
                (BinaryReaderValueLambda) => BinaryReaderValueLambda.ReadString());
        }


        public static IObservable<System.Int32> Read(this IObservable<System.IO.BinaryReader> BinaryReaderValue,
            IObservable<System.Char[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(BinaryReaderValue, buffer, index, count,
                (BinaryReaderValueLambda, bufferLambda, indexLambda, countLambda) =>
                    BinaryReaderValueLambda.Read(bufferLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Char[]> ReadChars(this IObservable<System.IO.BinaryReader> BinaryReaderValue,
            IObservable<System.Int32> count)
        {
            return Observable.Zip(BinaryReaderValue, count,
                (BinaryReaderValueLambda, countLambda) => BinaryReaderValueLambda.ReadChars(countLambda));
        }


        public static IObservable<System.Int32> Read(this IObservable<System.IO.BinaryReader> BinaryReaderValue,
            IObservable<System.Byte[]> buffer, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(BinaryReaderValue, buffer, index, count,
                (BinaryReaderValueLambda, bufferLambda, indexLambda, countLambda) =>
                    BinaryReaderValueLambda.Read(bufferLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Byte[]> ReadBytes(this IObservable<System.IO.BinaryReader> BinaryReaderValue,
            IObservable<System.Int32> count)
        {
            return Observable.Zip(BinaryReaderValue, count,
                (BinaryReaderValueLambda, countLambda) => BinaryReaderValueLambda.ReadBytes(countLambda));
        }


        public static IObservable<System.IO.Stream> get_BaseStream(
            this IObservable<System.IO.BinaryReader> BinaryReaderValue)
        {
            return Observable.Select(BinaryReaderValue, (BinaryReaderValueLambda) => BinaryReaderValueLambda.BaseStream);
        }
    }
}