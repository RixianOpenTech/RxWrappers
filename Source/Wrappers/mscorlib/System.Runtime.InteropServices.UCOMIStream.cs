using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMIStream
    {
        
        public static IObservable<Unit> Read(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue, IObservable<System.Byte[]> pv, IObservable<System.Int32> cb, IObservable<System.IntPtr> pcbRead)
        {
            return ObservableExt.ZipExecute(UCOMIStreamValue, pv, cb, pcbRead, (UCOMIStreamValueLambda, pvLambda, cbLambda, pcbReadLambda) => UCOMIStreamValueLambda.Read(pvLambda, cbLambda, pcbReadLambda));
        }


        public static IObservable<System.Reactive.Unit> Write(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue, IObservable<System.Byte[]> pv, IObservable<System.Int32> cb, IObservable<System.IntPtr> pcbWritten)
        {
            return ObservableExt.ZipExecute(UCOMIStreamValue, pv, cb, pcbWritten, (UCOMIStreamValueLambda, pvLambda, cbLambda, pcbWrittenLambda) => UCOMIStreamValueLambda.Write(pvLambda, cbLambda, pcbWrittenLambda));
        }


        public static IObservable<System.Reactive.Unit> Seek(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue, IObservable<System.Int64> dlibMove, IObservable<System.Int32> dwOrigin, IObservable<System.IntPtr> plibNewPosition)
        {
            return ObservableExt.ZipExecute(UCOMIStreamValue, dlibMove, dwOrigin, plibNewPosition, (UCOMIStreamValueLambda, dlibMoveLambda, dwOriginLambda, plibNewPositionLambda) => UCOMIStreamValueLambda.Seek(dlibMoveLambda, dwOriginLambda, plibNewPositionLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSize(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue, IObservable<System.Int64> libNewSize)
        {
            return ObservableExt.ZipExecute(UCOMIStreamValue, libNewSize, (UCOMIStreamValueLambda, libNewSizeLambda) => UCOMIStreamValueLambda.SetSize(libNewSizeLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue, IObservable<System.Runtime.InteropServices.UCOMIStream> pstm, IObservable<System.Int64> cb, IObservable<System.IntPtr> pcbRead, IObservable<System.IntPtr> pcbWritten)
        {
            return ObservableExt.ZipExecute(UCOMIStreamValue, pstm, cb, pcbRead, pcbWritten, (UCOMIStreamValueLambda, pstmLambda, cbLambda, pcbReadLambda, pcbWrittenLambda) => UCOMIStreamValueLambda.CopyTo(pstmLambda, cbLambda, pcbReadLambda, pcbWrittenLambda));
        }


        public static IObservable<System.Reactive.Unit> Commit(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue, IObservable<System.Int32> grfCommitFlags)
        {
            return ObservableExt.ZipExecute(UCOMIStreamValue, grfCommitFlags, (UCOMIStreamValueLambda, grfCommitFlagsLambda) => UCOMIStreamValueLambda.Commit(grfCommitFlagsLambda));
        }


        public static IObservable<System.Reactive.Unit> Revert(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue)
        {
            return Observable.Do(UCOMIStreamValue, (UCOMIStreamValueLambda) => UCOMIStreamValueLambda.Revert()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> LockRegion(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue, IObservable<System.Int64> libOffset, IObservable<System.Int64> cb, IObservable<System.Int32> dwLockType)
        {
            return ObservableExt.ZipExecute(UCOMIStreamValue, libOffset, cb, dwLockType, (UCOMIStreamValueLambda, libOffsetLambda, cbLambda, dwLockTypeLambda) => UCOMIStreamValueLambda.LockRegion(libOffsetLambda, cbLambda, dwLockTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> UnlockRegion(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue, IObservable<System.Int64> libOffset, IObservable<System.Int64> cb, IObservable<System.Int32> dwLockType)
        {
            return ObservableExt.ZipExecute(UCOMIStreamValue, libOffset, cb, dwLockType, (UCOMIStreamValueLambda, libOffsetLambda, cbLambda, dwLockTypeLambda) => UCOMIStreamValueLambda.UnlockRegion(libOffsetLambda, cbLambda, dwLockTypeLambda));
        }


        public static IObservable<System.Runtime.InteropServices.STATSTG> Stat(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue, IObservable<System.Int32> grfStatFlag)
        {
            return Observable.Zip(UCOMIStreamValue, grfStatFlag, (UCOMIStreamValueLambda, grfStatFlagLambda) => {
System.Runtime.InteropServices.STATSTG pstatstgOutput = default(System.Runtime.InteropServices.STATSTG);
UCOMIStreamValueLambda.Stat(out pstatstgOutput, grfStatFlagLambda);
return pstatstgOutput;
});
        }


        public static IObservable<System.Runtime.InteropServices.UCOMIStream> Clone(this IObservable<System.Runtime.InteropServices.UCOMIStream> UCOMIStreamValue)
        {
            return Observable.Select(UCOMIStreamValue, (UCOMIStreamValueLambda) => {
System.Runtime.InteropServices.UCOMIStream ppstmOutput = default(System.Runtime.InteropServices.UCOMIStream);
UCOMIStreamValueLambda.Clone(out ppstmOutput);
return ppstmOutput;
});
        }

    }
}