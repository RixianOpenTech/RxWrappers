using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMIRunningObjectTable
    {
        public static IObservable<System.Int32> Register(
            this IObservable<System.Runtime.InteropServices.UCOMIRunningObjectTable> UCOMIRunningObjectTableValue,
            IObservable<System.Int32> grfFlags, IObservable<System.Object> punkObject,
            IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkObjectName)
        {
            return Observable.Zip(UCOMIRunningObjectTableValue, grfFlags, punkObject, pmkObjectName,
                (UCOMIRunningObjectTableValueLambda, grfFlagsLambda, punkObjectLambda, pmkObjectNameLambda) =>
                {
                    System.Int32 pdwRegisterOutput = default(System.Int32);
                    UCOMIRunningObjectTableValueLambda.Register(grfFlagsLambda, punkObjectLambda, pmkObjectNameLambda,
                        out pdwRegisterOutput);
                    return pdwRegisterOutput;
                });
        }


        public static IObservable<System.Reactive.Unit> Revoke(
            this IObservable<System.Runtime.InteropServices.UCOMIRunningObjectTable> UCOMIRunningObjectTableValue,
            IObservable<System.Int32> dwRegister)
        {
            return ObservableExt.ZipExecute(UCOMIRunningObjectTableValue, dwRegister,
                (UCOMIRunningObjectTableValueLambda, dwRegisterLambda) =>
                    UCOMIRunningObjectTableValueLambda.Revoke(dwRegisterLambda));
        }


        public static IObservable<System.Reactive.Unit> IsRunning(
            this IObservable<System.Runtime.InteropServices.UCOMIRunningObjectTable> UCOMIRunningObjectTableValue,
            IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkObjectName)
        {
            return ObservableExt.ZipExecute(UCOMIRunningObjectTableValue, pmkObjectName,
                (UCOMIRunningObjectTableValueLambda, pmkObjectNameLambda) =>
                    UCOMIRunningObjectTableValueLambda.IsRunning(pmkObjectNameLambda));
        }


        public static IObservable<System.Object> GetObject(
            this IObservable<System.Runtime.InteropServices.UCOMIRunningObjectTable> UCOMIRunningObjectTableValue,
            IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkObjectName)
        {
            return Observable.Zip(UCOMIRunningObjectTableValue, pmkObjectName,
                (UCOMIRunningObjectTableValueLambda, pmkObjectNameLambda) =>
                {
                    System.Object ppunkObjectOutput = default(System.Object);
                    UCOMIRunningObjectTableValueLambda.GetObject(pmkObjectNameLambda, out ppunkObjectOutput);
                    return ppunkObjectOutput;
                });
        }


        public static IObservable<System.Runtime.InteropServices.FILETIME> NoteChangeTime(
            this IObservable<System.Runtime.InteropServices.UCOMIRunningObjectTable> UCOMIRunningObjectTableValue,
            IObservable<System.Int32> dwRegister, IObservable<System.Runtime.InteropServices.FILETIME> pfiletime)
        {
            return Observable.Zip(UCOMIRunningObjectTableValue, dwRegister, pfiletime,
                (UCOMIRunningObjectTableValueLambda, dwRegisterLambda, pfiletimeLambda) =>
                {
                    UCOMIRunningObjectTableValueLambda.NoteChangeTime(dwRegisterLambda, ref pfiletimeLambda);
                    return pfiletimeLambda;
                });
        }


        public static IObservable<System.Runtime.InteropServices.FILETIME> GetTimeOfLastChange(
            this IObservable<System.Runtime.InteropServices.UCOMIRunningObjectTable> UCOMIRunningObjectTableValue,
            IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkObjectName)
        {
            return Observable.Zip(UCOMIRunningObjectTableValue, pmkObjectName,
                (UCOMIRunningObjectTableValueLambda, pmkObjectNameLambda) =>
                {
                    System.Runtime.InteropServices.FILETIME pfiletimeOutput =
                        default(System.Runtime.InteropServices.FILETIME);
                    UCOMIRunningObjectTableValueLambda.GetTimeOfLastChange(pmkObjectNameLambda, out pfiletimeOutput);
                    return pfiletimeOutput;
                });
        }


        public static IObservable<System.Runtime.InteropServices.UCOMIEnumMoniker> EnumRunning(
            this IObservable<System.Runtime.InteropServices.UCOMIRunningObjectTable> UCOMIRunningObjectTableValue)
        {
            return Observable.Select(UCOMIRunningObjectTableValue, (UCOMIRunningObjectTableValueLambda) =>
            {
                System.Runtime.InteropServices.UCOMIEnumMoniker ppenumMonikerOutput =
                    default(System.Runtime.InteropServices.UCOMIEnumMoniker);
                UCOMIRunningObjectTableValueLambda.EnumRunning(out ppenumMonikerOutput);
                return ppenumMonikerOutput;
            });
        }
    }
}