using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _UCOMIMoniker
{
    
public static IObservable<System.Guid> GetClassID(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue)
{
    return Observable.Select(UCOMIMonikerValue, (UCOMIMonikerValueLambda) => {
System.Guid pClassIDOutput = default(System.Guid);
UCOMIMonikerValueLambda.GetClassID(out pClassIDOutput);
return pClassIDOutput;
});
}


public static IObservable<System.Int32> IsDirty(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue)
{
    return Observable.Select(UCOMIMonikerValue, (UCOMIMonikerValueLambda) => UCOMIMonikerValueLambda.IsDirty());
}


public static IObservable<System.Reactive.Unit> Load(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIStream> pStm)
{
    return ObservableExt.ZipExecute(UCOMIMonikerValue, pStm, (UCOMIMonikerValueLambda, pStmLambda) => UCOMIMonikerValueLambda.Load(pStmLambda));
}


public static IObservable<System.Reactive.Unit> Save(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIStream> pStm, IObservable<System.Boolean> fClearDirty)
{
    return ObservableExt.ZipExecute(UCOMIMonikerValue, pStm, fClearDirty, (UCOMIMonikerValueLambda, pStmLambda, fClearDirtyLambda) => UCOMIMonikerValueLambda.Save(pStmLambda, fClearDirtyLambda));
}


public static IObservable<System.Int64> GetSizeMax(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue)
{
    return Observable.Select(UCOMIMonikerValue, (UCOMIMonikerValueLambda) => {
System.Int64 pcbSizeOutput = default(System.Int64);
UCOMIMonikerValueLambda.GetSizeMax(out pcbSizeOutput);
return pcbSizeOutput;
});
}


public static IObservable<Tuple<System.Guid, System.Object>> BindToObject(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIBindCtx> pbc, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkToLeft, IObservable<System.Guid> riidResult)
{
    return Observable.Zip(UCOMIMonikerValue, pbc, pmkToLeft, riidResult, (UCOMIMonikerValueLambda, pbcLambda, pmkToLeftLambda, riidResultLambda) => {
System.Object ppvResultOutput = default(System.Object);
UCOMIMonikerValueLambda.BindToObject(pbcLambda, pmkToLeftLambda, ref riidResultLambda, out ppvResultOutput);
return Tuple.Create(riidResultLambda, ppvResultOutput);
});
}


public static IObservable<Tuple<System.Guid, System.Object>> BindToStorage(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIBindCtx> pbc, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkToLeft, IObservable<System.Guid> riid)
{
    return Observable.Zip(UCOMIMonikerValue, pbc, pmkToLeft, riid, (UCOMIMonikerValueLambda, pbcLambda, pmkToLeftLambda, riidLambda) => {
System.Object ppvObjOutput = default(System.Object);
UCOMIMonikerValueLambda.BindToStorage(pbcLambda, pmkToLeftLambda, ref riidLambda, out ppvObjOutput);
return Tuple.Create(riidLambda, ppvObjOutput);
});
}


public static IObservable<Tuple<System.Runtime.InteropServices.UCOMIMoniker, System.Runtime.InteropServices.UCOMIMoniker>> Reduce(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIBindCtx> pbc, IObservable<System.Int32> dwReduceHowFar, IObservable<System.Runtime.InteropServices.UCOMIMoniker> ppmkToLeft)
{
    return Observable.Zip(UCOMIMonikerValue, pbc, dwReduceHowFar, ppmkToLeft, (UCOMIMonikerValueLambda, pbcLambda, dwReduceHowFarLambda, ppmkToLeftLambda) => {
System.Runtime.InteropServices.UCOMIMoniker ppmkReducedOutput = default(System.Runtime.InteropServices.UCOMIMoniker);
UCOMIMonikerValueLambda.Reduce(pbcLambda, dwReduceHowFarLambda, ref ppmkToLeftLambda, out ppmkReducedOutput);
return Tuple.Create(ppmkToLeftLambda, ppmkReducedOutput);
});
}


public static IObservable<System.Runtime.InteropServices.UCOMIMoniker> ComposeWith(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkRight, IObservable<System.Boolean> fOnlyIfNotGeneric)
{
    return Observable.Zip(UCOMIMonikerValue, pmkRight, fOnlyIfNotGeneric, (UCOMIMonikerValueLambda, pmkRightLambda, fOnlyIfNotGenericLambda) => {
System.Runtime.InteropServices.UCOMIMoniker ppmkCompositeOutput = default(System.Runtime.InteropServices.UCOMIMoniker);
UCOMIMonikerValueLambda.ComposeWith(pmkRightLambda, fOnlyIfNotGenericLambda, out ppmkCompositeOutput);
return ppmkCompositeOutput;
});
}


public static IObservable<System.Runtime.InteropServices.UCOMIEnumMoniker> Enum(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Boolean> fForward)
{
    return Observable.Zip(UCOMIMonikerValue, fForward, (UCOMIMonikerValueLambda, fForwardLambda) => {
System.Runtime.InteropServices.UCOMIEnumMoniker ppenumMonikerOutput = default(System.Runtime.InteropServices.UCOMIEnumMoniker);
UCOMIMonikerValueLambda.Enum(fForwardLambda, out ppenumMonikerOutput);
return ppenumMonikerOutput;
});
}


public static IObservable<System.Reactive.Unit> IsEqual(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkOtherMoniker)
{
    return ObservableExt.ZipExecute(UCOMIMonikerValue, pmkOtherMoniker, (UCOMIMonikerValueLambda, pmkOtherMonikerLambda) => UCOMIMonikerValueLambda.IsEqual(pmkOtherMonikerLambda));
}


public static IObservable<System.Int32> Hash(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue)
{
    return Observable.Select(UCOMIMonikerValue, (UCOMIMonikerValueLambda) => {
System.Int32 pdwHashOutput = default(System.Int32);
UCOMIMonikerValueLambda.Hash(out pdwHashOutput);
return pdwHashOutput;
});
}


public static IObservable<System.Reactive.Unit> IsRunning(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIBindCtx> pbc, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkToLeft, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkNewlyRunning)
{
    return ObservableExt.ZipExecute(UCOMIMonikerValue, pbc, pmkToLeft, pmkNewlyRunning, (UCOMIMonikerValueLambda, pbcLambda, pmkToLeftLambda, pmkNewlyRunningLambda) => UCOMIMonikerValueLambda.IsRunning(pbcLambda, pmkToLeftLambda, pmkNewlyRunningLambda));
}


public static IObservable<System.Runtime.InteropServices.FILETIME> GetTimeOfLastChange(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIBindCtx> pbc, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkToLeft)
{
    return Observable.Zip(UCOMIMonikerValue, pbc, pmkToLeft, (UCOMIMonikerValueLambda, pbcLambda, pmkToLeftLambda) => {
System.Runtime.InteropServices.FILETIME pFileTimeOutput = default(System.Runtime.InteropServices.FILETIME);
UCOMIMonikerValueLambda.GetTimeOfLastChange(pbcLambda, pmkToLeftLambda, out pFileTimeOutput);
return pFileTimeOutput;
});
}


public static IObservable<System.Runtime.InteropServices.UCOMIMoniker> Inverse(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue)
{
    return Observable.Select(UCOMIMonikerValue, (UCOMIMonikerValueLambda) => {
System.Runtime.InteropServices.UCOMIMoniker ppmkOutput = default(System.Runtime.InteropServices.UCOMIMoniker);
UCOMIMonikerValueLambda.Inverse(out ppmkOutput);
return ppmkOutput;
});
}


public static IObservable<System.Runtime.InteropServices.UCOMIMoniker> CommonPrefixWith(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkOther)
{
    return Observable.Zip(UCOMIMonikerValue, pmkOther, (UCOMIMonikerValueLambda, pmkOtherLambda) => {
System.Runtime.InteropServices.UCOMIMoniker ppmkPrefixOutput = default(System.Runtime.InteropServices.UCOMIMoniker);
UCOMIMonikerValueLambda.CommonPrefixWith(pmkOtherLambda, out ppmkPrefixOutput);
return ppmkPrefixOutput;
});
}


public static IObservable<System.Runtime.InteropServices.UCOMIMoniker> RelativePathTo(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkOther)
{
    return Observable.Zip(UCOMIMonikerValue, pmkOther, (UCOMIMonikerValueLambda, pmkOtherLambda) => {
System.Runtime.InteropServices.UCOMIMoniker ppmkRelPathOutput = default(System.Runtime.InteropServices.UCOMIMoniker);
UCOMIMonikerValueLambda.RelativePathTo(pmkOtherLambda, out ppmkRelPathOutput);
return ppmkRelPathOutput;
});
}


public static IObservable<System.String> GetDisplayName(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIBindCtx> pbc, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkToLeft)
{
    return Observable.Zip(UCOMIMonikerValue, pbc, pmkToLeft, (UCOMIMonikerValueLambda, pbcLambda, pmkToLeftLambda) => {
System.String ppszDisplayNameOutput = default(System.String);
UCOMIMonikerValueLambda.GetDisplayName(pbcLambda, pmkToLeftLambda, out ppszDisplayNameOutput);
return ppszDisplayNameOutput;
});
}


public static IObservable<Tuple<System.Int32, System.Runtime.InteropServices.UCOMIMoniker>> ParseDisplayName(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue, IObservable<System.Runtime.InteropServices.UCOMIBindCtx> pbc, IObservable<System.Runtime.InteropServices.UCOMIMoniker> pmkToLeft, IObservable<System.String> pszDisplayName)
{
    return Observable.Zip(UCOMIMonikerValue, pbc, pmkToLeft, pszDisplayName, (UCOMIMonikerValueLambda, pbcLambda, pmkToLeftLambda, pszDisplayNameLambda) => {
System.Int32 pchEatenOutput = default(System.Int32);
System.Runtime.InteropServices.UCOMIMoniker ppmkOutOutput = default(System.Runtime.InteropServices.UCOMIMoniker);
UCOMIMonikerValueLambda.ParseDisplayName(pbcLambda, pmkToLeftLambda, pszDisplayNameLambda, out pchEatenOutput, out ppmkOutOutput);
return Tuple.Create(pchEatenOutput, ppmkOutOutput);
});
}


public static IObservable<System.Int32> IsSystemMoniker(this IObservable<System.Runtime.InteropServices.UCOMIMoniker> UCOMIMonikerValue)
{
    return Observable.Select(UCOMIMonikerValue, (UCOMIMonikerValueLambda) => {
System.Int32 pdwMksysOutput = default(System.Int32);
UCOMIMonikerValueLambda.IsSystemMoniker(out pdwMksysOutput);
return pdwMksysOutput;
});
}

}
}