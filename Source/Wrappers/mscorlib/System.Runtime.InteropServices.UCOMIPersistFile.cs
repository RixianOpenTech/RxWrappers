using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMIPersistFile
    {
        public static IObservable<System.Guid> GetClassID(
            this IObservable<System.Runtime.InteropServices.UCOMIPersistFile> UCOMIPersistFileValue)
        {
            return Observable.Select(UCOMIPersistFileValue, (UCOMIPersistFileValueLambda) =>
            {
                System.Guid pClassIDOutput = default(System.Guid);
                UCOMIPersistFileValueLambda.GetClassID(out pClassIDOutput);
                return pClassIDOutput;
            });
        }


        public static IObservable<System.Int32> IsDirty(
            this IObservable<System.Runtime.InteropServices.UCOMIPersistFile> UCOMIPersistFileValue)
        {
            return Observable.Select(UCOMIPersistFileValue,
                (UCOMIPersistFileValueLambda) => UCOMIPersistFileValueLambda.IsDirty());
        }


        public static IObservable<System.Reactive.Unit> Load(
            this IObservable<System.Runtime.InteropServices.UCOMIPersistFile> UCOMIPersistFileValue,
            IObservable<System.String> pszFileName, IObservable<System.Int32> dwMode)
        {
            return ObservableExt.ZipExecute(UCOMIPersistFileValue, pszFileName, dwMode,
                (UCOMIPersistFileValueLambda, pszFileNameLambda, dwModeLambda) =>
                    UCOMIPersistFileValueLambda.Load(pszFileNameLambda, dwModeLambda));
        }


        public static IObservable<System.Reactive.Unit> Save(
            this IObservable<System.Runtime.InteropServices.UCOMIPersistFile> UCOMIPersistFileValue,
            IObservable<System.String> pszFileName, IObservable<System.Boolean> fRemember)
        {
            return ObservableExt.ZipExecute(UCOMIPersistFileValue, pszFileName, fRemember,
                (UCOMIPersistFileValueLambda, pszFileNameLambda, fRememberLambda) =>
                    UCOMIPersistFileValueLambda.Save(pszFileNameLambda, fRememberLambda));
        }


        public static IObservable<System.Reactive.Unit> SaveCompleted(
            this IObservable<System.Runtime.InteropServices.UCOMIPersistFile> UCOMIPersistFileValue,
            IObservable<System.String> pszFileName)
        {
            return ObservableExt.ZipExecute(UCOMIPersistFileValue, pszFileName,
                (UCOMIPersistFileValueLambda, pszFileNameLambda) =>
                    UCOMIPersistFileValueLambda.SaveCompleted(pszFileNameLambda));
        }


        public static IObservable<System.String> GetCurFile(
            this IObservable<System.Runtime.InteropServices.UCOMIPersistFile> UCOMIPersistFileValue)
        {
            return Observable.Select(UCOMIPersistFileValue, (UCOMIPersistFileValueLambda) =>
            {
                System.String ppszFileNameOutput = default(System.String);
                UCOMIPersistFileValueLambda.GetCurFile(out ppszFileNameOutput);
                return ppszFileNameOutput;
            });
        }
    }
}