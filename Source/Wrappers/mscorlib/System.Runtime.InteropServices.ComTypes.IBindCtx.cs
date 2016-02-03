using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
public static class _IBindCtx
{
    
public static IObservable<System.Reactive.Unit> RegisterObjectBound(this IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> IBindCtxValue, IObservable<System.Object> punk)
{
    return ObservableExt.ZipExecute(IBindCtxValue, punk, (IBindCtxValueLambda, punkLambda) => IBindCtxValueLambda.RegisterObjectBound(punkLambda));
}


public static IObservable<System.Reactive.Unit> RevokeObjectBound(this IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> IBindCtxValue, IObservable<System.Object> punk)
{
    return ObservableExt.ZipExecute(IBindCtxValue, punk, (IBindCtxValueLambda, punkLambda) => IBindCtxValueLambda.RevokeObjectBound(punkLambda));
}


public static IObservable<System.Reactive.Unit> ReleaseBoundObjects(this IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> IBindCtxValue)
{
    return Observable.Do(IBindCtxValue, (IBindCtxValueLambda) => IBindCtxValueLambda.ReleaseBoundObjects()).ToUnit();
}


public static IObservable<System.Runtime.InteropServices.ComTypes.BIND_OPTS> SetBindOptions(this IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> IBindCtxValue, IObservable<System.Runtime.InteropServices.ComTypes.BIND_OPTS> pbindopts)
{
    return Observable.Zip(IBindCtxValue, pbindopts, (IBindCtxValueLambda, pbindoptsLambda) => {
IBindCtxValueLambda.SetBindOptions(ref pbindoptsLambda);
return pbindoptsLambda;
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.BIND_OPTS> GetBindOptions(this IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> IBindCtxValue, IObservable<System.Runtime.InteropServices.ComTypes.BIND_OPTS> pbindopts)
{
    return Observable.Zip(IBindCtxValue, pbindopts, (IBindCtxValueLambda, pbindoptsLambda) => {
IBindCtxValueLambda.GetBindOptions(ref pbindoptsLambda);
return pbindoptsLambda;
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.IRunningObjectTable> GetRunningObjectTable(this IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> IBindCtxValue)
{
    return Observable.Select(IBindCtxValue, (IBindCtxValueLambda) => {
System.Runtime.InteropServices.ComTypes.IRunningObjectTable pprotOutput = default(System.Runtime.InteropServices.ComTypes.IRunningObjectTable);
IBindCtxValueLambda.GetRunningObjectTable(out pprotOutput);
return pprotOutput;
});
}


public static IObservable<System.Reactive.Unit> RegisterObjectParam(this IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> IBindCtxValue, IObservable<System.String> pszKey, IObservable<System.Object> punk)
{
    return ObservableExt.ZipExecute(IBindCtxValue, pszKey, punk, (IBindCtxValueLambda, pszKeyLambda, punkLambda) => IBindCtxValueLambda.RegisterObjectParam(pszKeyLambda, punkLambda));
}


public static IObservable<System.Object> GetObjectParam(this IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> IBindCtxValue, IObservable<System.String> pszKey)
{
    return Observable.Zip(IBindCtxValue, pszKey, (IBindCtxValueLambda, pszKeyLambda) => {
System.Object ppunkOutput = default(System.Object);
IBindCtxValueLambda.GetObjectParam(pszKeyLambda, out ppunkOutput);
return ppunkOutput;
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.IEnumString> EnumObjectParam(this IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> IBindCtxValue)
{
    return Observable.Select(IBindCtxValue, (IBindCtxValueLambda) => {
System.Runtime.InteropServices.ComTypes.IEnumString ppenumOutput = default(System.Runtime.InteropServices.ComTypes.IEnumString);
IBindCtxValueLambda.EnumObjectParam(out ppenumOutput);
return ppenumOutput;
});
}


public static IObservable<System.Int32> RevokeObjectParam(this IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> IBindCtxValue, IObservable<System.String> pszKey)
{
    return Observable.Zip(IBindCtxValue, pszKey, (IBindCtxValueLambda, pszKeyLambda) => IBindCtxValueLambda.RevokeObjectParam(pszKeyLambda));
}

}
}