using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
    public static class __IPersistFile
    {
        
        public static IObservable<System.Guid> GetClassID(this IObservable<System.Runtime.InteropServices.ComTypes.IPersistFile> IPersistFileValue)
        {
            return Observable.Select(IPersistFileValue, (IPersistFileValueLambda) => {
System.Guid pClassIDOutput = default(System.Guid);
IPersistFileValueLambda.GetClassID(out pClassIDOutput);
return pClassIDOutput;
});
        }


        public static IObservable<System.Int32> IsDirty(this IObservable<System.Runtime.InteropServices.ComTypes.IPersistFile> IPersistFileValue)
        {
            return Observable.Select(IPersistFileValue, (IPersistFileValueLambda) => IPersistFileValueLambda.IsDirty());
        }


        public static IObservable<System.Reactive.Unit> Load(this IObservable<System.Runtime.InteropServices.ComTypes.IPersistFile> IPersistFileValue, IObservable<System.String> pszFileName, IObservable<System.Int32> dwMode)
        {
            return ObservableExt.ZipExecute(IPersistFileValue, pszFileName, dwMode, (IPersistFileValueLambda, pszFileNameLambda, dwModeLambda) => IPersistFileValueLambda.Load(pszFileNameLambda, dwModeLambda));
        }


        public static IObservable<System.Reactive.Unit> Save(this IObservable<System.Runtime.InteropServices.ComTypes.IPersistFile> IPersistFileValue, IObservable<System.String> pszFileName, IObservable<System.Boolean> fRemember)
        {
            return ObservableExt.ZipExecute(IPersistFileValue, pszFileName, fRemember, (IPersistFileValueLambda, pszFileNameLambda, fRememberLambda) => IPersistFileValueLambda.Save(pszFileNameLambda, fRememberLambda));
        }


        public static IObservable<System.Reactive.Unit> SaveCompleted(this IObservable<System.Runtime.InteropServices.ComTypes.IPersistFile> IPersistFileValue, IObservable<System.String> pszFileName)
        {
            return ObservableExt.ZipExecute(IPersistFileValue, pszFileName, (IPersistFileValueLambda, pszFileNameLambda) => IPersistFileValueLambda.SaveCompleted(pszFileNameLambda));
        }


        public static IObservable<System.String> GetCurFile(this IObservable<System.Runtime.InteropServices.ComTypes.IPersistFile> IPersistFileValue)
        {
            return Observable.Select(IPersistFileValue, (IPersistFileValueLambda) => {
System.String ppszFileNameOutput = default(System.String);
IPersistFileValueLambda.GetCurFile(out ppszFileNameOutput);
return ppszFileNameOutput;
});
        }

    }
}