using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
    public static class __IStream
    {
        public static IObservable<Unit> Read(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue,
            IObservable<System.Byte[]> pv, IObservable<System.Int32> cb, IObservable<System.IntPtr> pcbRead)
        {
            return ObservableExt.ZipExecute(IStreamValue, pv, cb, pcbRead,
                (IStreamValueLambda, pvLambda, cbLambda, pcbReadLambda) =>
                    IStreamValueLambda.Read(pvLambda, cbLambda, pcbReadLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue,
            IObservable<System.Byte[]> pv, IObservable<System.Int32> cb, IObservable<System.IntPtr> pcbWritten)
        {
            return ObservableExt.ZipExecute(IStreamValue, pv, cb, pcbWritten,
                (IStreamValueLambda, pvLambda, cbLambda, pcbWrittenLambda) =>
                    IStreamValueLambda.Write(pvLambda, cbLambda, pcbWrittenLambda));
        }


        public static IObservable<System.Reactive.Unit> Seek(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue,
            IObservable<System.Int64> dlibMove, IObservable<System.Int32> dwOrigin,
            IObservable<System.IntPtr> plibNewPosition)
        {
            return ObservableExt.ZipExecute(IStreamValue, dlibMove, dwOrigin, plibNewPosition,
                (IStreamValueLambda, dlibMoveLambda, dwOriginLambda, plibNewPositionLambda) =>
                    IStreamValueLambda.Seek(dlibMoveLambda, dwOriginLambda, plibNewPositionLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSize(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue,
            IObservable<System.Int64> libNewSize)
        {
            return ObservableExt.ZipExecute(IStreamValue, libNewSize,
                (IStreamValueLambda, libNewSizeLambda) => IStreamValueLambda.SetSize(libNewSizeLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyTo(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue,
            IObservable<System.Runtime.InteropServices.ComTypes.IStream> pstm, IObservable<System.Int64> cb,
            IObservable<System.IntPtr> pcbRead, IObservable<System.IntPtr> pcbWritten)
        {
            return ObservableExt.ZipExecute(IStreamValue, pstm, cb, pcbRead, pcbWritten,
                (IStreamValueLambda, pstmLambda, cbLambda, pcbReadLambda, pcbWrittenLambda) =>
                    IStreamValueLambda.CopyTo(pstmLambda, cbLambda, pcbReadLambda, pcbWrittenLambda));
        }


        public static IObservable<System.Reactive.Unit> Commit(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue,
            IObservable<System.Int32> grfCommitFlags)
        {
            return ObservableExt.ZipExecute(IStreamValue, grfCommitFlags,
                (IStreamValueLambda, grfCommitFlagsLambda) => IStreamValueLambda.Commit(grfCommitFlagsLambda));
        }


        public static IObservable<System.Reactive.Unit> Revert(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue)
        {
            return Observable.Do(IStreamValue, (IStreamValueLambda) => IStreamValueLambda.Revert()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> LockRegion(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue,
            IObservable<System.Int64> libOffset, IObservable<System.Int64> cb, IObservable<System.Int32> dwLockType)
        {
            return ObservableExt.ZipExecute(IStreamValue, libOffset, cb, dwLockType,
                (IStreamValueLambda, libOffsetLambda, cbLambda, dwLockTypeLambda) =>
                    IStreamValueLambda.LockRegion(libOffsetLambda, cbLambda, dwLockTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> UnlockRegion(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue,
            IObservable<System.Int64> libOffset, IObservable<System.Int64> cb, IObservable<System.Int32> dwLockType)
        {
            return ObservableExt.ZipExecute(IStreamValue, libOffset, cb, dwLockType,
                (IStreamValueLambda, libOffsetLambda, cbLambda, dwLockTypeLambda) =>
                    IStreamValueLambda.UnlockRegion(libOffsetLambda, cbLambda, dwLockTypeLambda));
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.STATSTG> Stat(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue,
            IObservable<System.Int32> grfStatFlag)
        {
            return Observable.Zip(IStreamValue, grfStatFlag, (IStreamValueLambda, grfStatFlagLambda) =>
            {
                System.Runtime.InteropServices.ComTypes.STATSTG pstatstgOutput =
                    default(System.Runtime.InteropServices.ComTypes.STATSTG);
                IStreamValueLambda.Stat(out pstatstgOutput, grfStatFlagLambda);
                return pstatstgOutput;
            });
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.IStream> Clone(
            this IObservable<System.Runtime.InteropServices.ComTypes.IStream> IStreamValue)
        {
            return Observable.Select(IStreamValue, (IStreamValueLambda) =>
            {
                System.Runtime.InteropServices.ComTypes.IStream ppstmOutput =
                    default(System.Runtime.InteropServices.ComTypes.IStream);
                IStreamValueLambda.Clone(out ppstmOutput);
                return ppstmOutput;
            });
        }
    }
}