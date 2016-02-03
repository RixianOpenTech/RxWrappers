using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMIBindCtx
    {
        
        public static IObservable<System.Reactive.Unit> RegisterObjectBound(this IObservable<System.Runtime.InteropServices.UCOMIBindCtx> UCOMIBindCtxValue, IObservable<System.Object> punk)
        {
            return ObservableExt.ZipExecute(UCOMIBindCtxValue, punk, (UCOMIBindCtxValueLambda, punkLambda) => UCOMIBindCtxValueLambda.RegisterObjectBound(punkLambda));
        }


        public static IObservable<System.Reactive.Unit> RevokeObjectBound(this IObservable<System.Runtime.InteropServices.UCOMIBindCtx> UCOMIBindCtxValue, IObservable<System.Object> punk)
        {
            return ObservableExt.ZipExecute(UCOMIBindCtxValue, punk, (UCOMIBindCtxValueLambda, punkLambda) => UCOMIBindCtxValueLambda.RevokeObjectBound(punkLambda));
        }


        public static IObservable<System.Reactive.Unit> ReleaseBoundObjects(this IObservable<System.Runtime.InteropServices.UCOMIBindCtx> UCOMIBindCtxValue)
        {
            return Observable.Do(UCOMIBindCtxValue, (UCOMIBindCtxValueLambda) => UCOMIBindCtxValueLambda.ReleaseBoundObjects()).ToUnit();
        }


        public static IObservable<System.Runtime.InteropServices.BIND_OPTS> SetBindOptions(this IObservable<System.Runtime.InteropServices.UCOMIBindCtx> UCOMIBindCtxValue, IObservable<System.Runtime.InteropServices.BIND_OPTS> pbindopts)
        {
            return Observable.Zip(UCOMIBindCtxValue, pbindopts, (UCOMIBindCtxValueLambda, pbindoptsLambda) => {
UCOMIBindCtxValueLambda.SetBindOptions(ref pbindoptsLambda);
return pbindoptsLambda;
});
        }


        public static IObservable<System.Runtime.InteropServices.BIND_OPTS> GetBindOptions(this IObservable<System.Runtime.InteropServices.UCOMIBindCtx> UCOMIBindCtxValue, IObservable<System.Runtime.InteropServices.BIND_OPTS> pbindopts)
        {
            return Observable.Zip(UCOMIBindCtxValue, pbindopts, (UCOMIBindCtxValueLambda, pbindoptsLambda) => {
UCOMIBindCtxValueLambda.GetBindOptions(ref pbindoptsLambda);
return pbindoptsLambda;
});
        }


        public static IObservable<System.Runtime.InteropServices.UCOMIRunningObjectTable> GetRunningObjectTable(this IObservable<System.Runtime.InteropServices.UCOMIBindCtx> UCOMIBindCtxValue)
        {
            return Observable.Select(UCOMIBindCtxValue, (UCOMIBindCtxValueLambda) => {
System.Runtime.InteropServices.UCOMIRunningObjectTable pprotOutput = default(System.Runtime.InteropServices.UCOMIRunningObjectTable);
UCOMIBindCtxValueLambda.GetRunningObjectTable(out pprotOutput);
return pprotOutput;
});
        }


        public static IObservable<System.Reactive.Unit> RegisterObjectParam(this IObservable<System.Runtime.InteropServices.UCOMIBindCtx> UCOMIBindCtxValue, IObservable<System.String> pszKey, IObservable<System.Object> punk)
        {
            return ObservableExt.ZipExecute(UCOMIBindCtxValue, pszKey, punk, (UCOMIBindCtxValueLambda, pszKeyLambda, punkLambda) => UCOMIBindCtxValueLambda.RegisterObjectParam(pszKeyLambda, punkLambda));
        }


        public static IObservable<System.Object> GetObjectParam(this IObservable<System.Runtime.InteropServices.UCOMIBindCtx> UCOMIBindCtxValue, IObservable<System.String> pszKey)
        {
            return Observable.Zip(UCOMIBindCtxValue, pszKey, (UCOMIBindCtxValueLambda, pszKeyLambda) => {
System.Object ppunkOutput = default(System.Object);
UCOMIBindCtxValueLambda.GetObjectParam(pszKeyLambda, out ppunkOutput);
return ppunkOutput;
});
        }


        public static IObservable<System.Runtime.InteropServices.UCOMIEnumString> EnumObjectParam(this IObservable<System.Runtime.InteropServices.UCOMIBindCtx> UCOMIBindCtxValue)
        {
            return Observable.Select(UCOMIBindCtxValue, (UCOMIBindCtxValueLambda) => {
System.Runtime.InteropServices.UCOMIEnumString ppenumOutput = default(System.Runtime.InteropServices.UCOMIEnumString);
UCOMIBindCtxValueLambda.EnumObjectParam(out ppenumOutput);
return ppenumOutput;
});
        }


        public static IObservable<System.Reactive.Unit> RevokeObjectParam(this IObservable<System.Runtime.InteropServices.UCOMIBindCtx> UCOMIBindCtxValue, IObservable<System.String> pszKey)
        {
            return ObservableExt.ZipExecute(UCOMIBindCtxValue, pszKey, (UCOMIBindCtxValueLambda, pszKeyLambda) => UCOMIBindCtxValueLambda.RevokeObjectParam(pszKeyLambda));
        }

    }
}