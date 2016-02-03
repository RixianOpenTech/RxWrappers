using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __UnmanagedMemoryAccessor
    {
        
        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue)
        {
            return Observable.Do(UnmanagedMemoryAccessorValue, (UnmanagedMemoryAccessorValueLambda) => UnmanagedMemoryAccessorValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Boolean> ReadBoolean(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadBoolean(positionLambda));
        }


        public static IObservable<System.Byte> ReadByte(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadByte(positionLambda));
        }


        public static IObservable<System.Char> ReadChar(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadChar(positionLambda));
        }


        public static IObservable<System.Int16> ReadInt16(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadInt16(positionLambda));
        }


        public static IObservable<System.Int32> ReadInt32(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadInt32(positionLambda));
        }


        public static IObservable<System.Int64> ReadInt64(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadInt64(positionLambda));
        }


        public static IObservable<System.Decimal> ReadDecimal(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadDecimal(positionLambda));
        }


        public static IObservable<System.Single> ReadSingle(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadSingle(positionLambda));
        }


        public static IObservable<System.Double> ReadDouble(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadDouble(positionLambda));
        }


        public static IObservable<System.SByte> ReadSByte(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadSByte(positionLambda));
        }


        public static IObservable<System.UInt16> ReadUInt16(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadUInt16(positionLambda));
        }


        public static IObservable<System.UInt32> ReadUInt32(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadUInt32(positionLambda));
        }


        public static IObservable<System.UInt64> ReadUInt64(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position)
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => UnmanagedMemoryAccessorValueLambda.ReadUInt64(positionLambda));
        }


        public static IObservable<T> Read<T>(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position) where T : struct
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, (UnmanagedMemoryAccessorValueLambda, positionLambda) => {
T structureOutput = default(T);
UnmanagedMemoryAccessorValueLambda.Read(positionLambda, out structureOutput);
return structureOutput;
});
        }


        public static IObservable<System.Int32> ReadArray<T>(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<T[]> array, IObservable<System.Int32> offset, IObservable<System.Int32> count) where T : struct
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, array, offset, count, (UnmanagedMemoryAccessorValueLambda, positionLambda, arrayLambda, offsetLambda, countLambda) => UnmanagedMemoryAccessorValueLambda.ReadArray(positionLambda, arrayLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.Char> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.Int16> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.Single> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.Double> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.SByte> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.UInt16> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.UInt32> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<System.UInt64> value)
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, value, (UnmanagedMemoryAccessorValueLambda, positionLambda, valueLambda) => UnmanagedMemoryAccessorValueLambda.Write(positionLambda, valueLambda));
        }


        public static IObservable<T> Write<T>(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<T> structure) where T : struct
        {
            return Observable.Zip(UnmanagedMemoryAccessorValue, position, structure, (UnmanagedMemoryAccessorValueLambda, positionLambda, structureLambda) => {
UnmanagedMemoryAccessorValueLambda.Write(positionLambda, ref structureLambda);
return structureLambda;
});
        }


        public static IObservable<System.Reactive.Unit> WriteArray<T>(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue, IObservable<System.Int64> position, IObservable<T[]> array, IObservable<System.Int32> offset, IObservable<System.Int32> count) where T : struct
        {
            return ObservableExt.ZipExecute(UnmanagedMemoryAccessorValue, position, array, offset, count, (UnmanagedMemoryAccessorValueLambda, positionLambda, arrayLambda, offsetLambda, countLambda) => UnmanagedMemoryAccessorValueLambda.WriteArray(positionLambda, arrayLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.Int64> get_Capacity(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue)
        {
            return Observable.Select(UnmanagedMemoryAccessorValue, (UnmanagedMemoryAccessorValueLambda) => UnmanagedMemoryAccessorValueLambda.Capacity);
        }


        public static IObservable<System.Boolean> get_CanRead(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue)
        {
            return Observable.Select(UnmanagedMemoryAccessorValue, (UnmanagedMemoryAccessorValueLambda) => UnmanagedMemoryAccessorValueLambda.CanRead);
        }


        public static IObservable<System.Boolean> get_CanWrite(this IObservable<System.IO.UnmanagedMemoryAccessor> UnmanagedMemoryAccessorValue)
        {
            return Observable.Select(UnmanagedMemoryAccessorValue, (UnmanagedMemoryAccessorValueLambda) => UnmanagedMemoryAccessorValueLambda.CanWrite);
        }

    }
}