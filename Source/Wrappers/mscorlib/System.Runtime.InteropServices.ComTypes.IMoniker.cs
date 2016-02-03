using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
public static class _IMoniker
{
    
public static IObservable<System.Guid> GetClassID(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue)
{
    return Observable.Select(IMonikerValue, (IMonikerValueLambda) => {
System.Guid pClassIDOutput = default(System.Guid);
IMonikerValueLambda.GetClassID(out pClassIDOutput);
return pClassIDOutput;
});
}


public static IObservable<System.Int32> IsDirty(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue)
{
    return Observable.Select(IMonikerValue, (IMonikerValueLambda) => IMonikerValueLambda.IsDirty());
}


public static IObservable<System.Reactive.Unit> Load(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IStream> pStm)
{
    return ObservableExt.ZipExecute(IMonikerValue, pStm, (IMonikerValueLambda, pStmLambda) => IMonikerValueLambda.Load(pStmLambda));
}


public static IObservable<System.Reactive.Unit> Save(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IStream> pStm, IObservable<System.Boolean> fClearDirty)
{
    return ObservableExt.ZipExecute(IMonikerValue, pStm, fClearDirty, (IMonikerValueLambda, pStmLambda, fClearDirtyLambda) => IMonikerValueLambda.Save(pStmLambda, fClearDirtyLambda));
}


public static IObservable<System.Int64> GetSizeMax(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue)
{
    return Observable.Select(IMonikerValue, (IMonikerValueLambda) => {
System.Int64 pcbSizeOutput = default(System.Int64);
IMonikerValueLambda.GetSizeMax(out pcbSizeOutput);
return pcbSizeOutput;
});
}


public static IObservable<Tuple<System.Guid, System.Object>> BindToObject(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> pbc, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkToLeft, IObservable<System.Guid> riidResult)
{
    return Observable.Zip(IMonikerValue, pbc, pmkToLeft, riidResult, (IMonikerValueLambda, pbcLambda, pmkToLeftLambda, riidResultLambda) => {
System.Object ppvResultOutput = default(System.Object);
IMonikerValueLambda.BindToObject(pbcLambda, pmkToLeftLambda, ref riidResultLambda, out ppvResultOutput);
return Tuple.Create(riidResultLambda, ppvResultOutput);
});
}


public static IObservable<Tuple<System.Guid, System.Object>> BindToStorage(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> pbc, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkToLeft, IObservable<System.Guid> riid)
{
    return Observable.Zip(IMonikerValue, pbc, pmkToLeft, riid, (IMonikerValueLambda, pbcLambda, pmkToLeftLambda, riidLambda) => {
System.Object ppvObjOutput = default(System.Object);
IMonikerValueLambda.BindToStorage(pbcLambda, pmkToLeftLambda, ref riidLambda, out ppvObjOutput);
return Tuple.Create(riidLambda, ppvObjOutput);
});
}


public static IObservable<Tuple<System.Runtime.InteropServices.ComTypes.IMoniker, System.Runtime.InteropServices.ComTypes.IMoniker>> Reduce(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> pbc, IObservable<System.Int32> dwReduceHowFar, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> ppmkToLeft)
{
    return Observable.Zip(IMonikerValue, pbc, dwReduceHowFar, ppmkToLeft, (IMonikerValueLambda, pbcLambda, dwReduceHowFarLambda, ppmkToLeftLambda) => {
System.Runtime.InteropServices.ComTypes.IMoniker ppmkReducedOutput = default(System.Runtime.InteropServices.ComTypes.IMoniker);
IMonikerValueLambda.Reduce(pbcLambda, dwReduceHowFarLambda, ref ppmkToLeftLambda, out ppmkReducedOutput);
return Tuple.Create(ppmkToLeftLambda, ppmkReducedOutput);
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> ComposeWith(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkRight, IObservable<System.Boolean> fOnlyIfNotGeneric)
{
    return Observable.Zip(IMonikerValue, pmkRight, fOnlyIfNotGeneric, (IMonikerValueLambda, pmkRightLambda, fOnlyIfNotGenericLambda) => {
System.Runtime.InteropServices.ComTypes.IMoniker ppmkCompositeOutput = default(System.Runtime.InteropServices.ComTypes.IMoniker);
IMonikerValueLambda.ComposeWith(pmkRightLambda, fOnlyIfNotGenericLambda, out ppmkCompositeOutput);
return ppmkCompositeOutput;
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.IEnumMoniker> Enum(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Boolean> fForward)
{
    return Observable.Zip(IMonikerValue, fForward, (IMonikerValueLambda, fForwardLambda) => {
System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenumMonikerOutput = default(System.Runtime.InteropServices.ComTypes.IEnumMoniker);
IMonikerValueLambda.Enum(fForwardLambda, out ppenumMonikerOutput);
return ppenumMonikerOutput;
});
}


public static IObservable<System.Int32> IsEqual(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkOtherMoniker)
{
    return Observable.Zip(IMonikerValue, pmkOtherMoniker, (IMonikerValueLambda, pmkOtherMonikerLambda) => IMonikerValueLambda.IsEqual(pmkOtherMonikerLambda));
}


public static IObservable<System.Int32> Hash(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue)
{
    return Observable.Select(IMonikerValue, (IMonikerValueLambda) => {
System.Int32 pdwHashOutput = default(System.Int32);
IMonikerValueLambda.Hash(out pdwHashOutput);
return pdwHashOutput;
});
}


public static IObservable<System.Int32> IsRunning(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> pbc, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkToLeft, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkNewlyRunning)
{
    return Observable.Zip(IMonikerValue, pbc, pmkToLeft, pmkNewlyRunning, (IMonikerValueLambda, pbcLambda, pmkToLeftLambda, pmkNewlyRunningLambda) => IMonikerValueLambda.IsRunning(pbcLambda, pmkToLeftLambda, pmkNewlyRunningLambda));
}


public static IObservable<System.Runtime.InteropServices.ComTypes.FILETIME> GetTimeOfLastChange(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> pbc, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkToLeft)
{
    return Observable.Zip(IMonikerValue, pbc, pmkToLeft, (IMonikerValueLambda, pbcLambda, pmkToLeftLambda) => {
System.Runtime.InteropServices.ComTypes.FILETIME pFileTimeOutput = default(System.Runtime.InteropServices.ComTypes.FILETIME);
IMonikerValueLambda.GetTimeOfLastChange(pbcLambda, pmkToLeftLambda, out pFileTimeOutput);
return pFileTimeOutput;
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> Inverse(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue)
{
    return Observable.Select(IMonikerValue, (IMonikerValueLambda) => {
System.Runtime.InteropServices.ComTypes.IMoniker ppmkOutput = default(System.Runtime.InteropServices.ComTypes.IMoniker);
IMonikerValueLambda.Inverse(out ppmkOutput);
return ppmkOutput;
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> CommonPrefixWith(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkOther)
{
    return Observable.Zip(IMonikerValue, pmkOther, (IMonikerValueLambda, pmkOtherLambda) => {
System.Runtime.InteropServices.ComTypes.IMoniker ppmkPrefixOutput = default(System.Runtime.InteropServices.ComTypes.IMoniker);
IMonikerValueLambda.CommonPrefixWith(pmkOtherLambda, out ppmkPrefixOutput);
return ppmkPrefixOutput;
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> RelativePathTo(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkOther)
{
    return Observable.Zip(IMonikerValue, pmkOther, (IMonikerValueLambda, pmkOtherLambda) => {
System.Runtime.InteropServices.ComTypes.IMoniker ppmkRelPathOutput = default(System.Runtime.InteropServices.ComTypes.IMoniker);
IMonikerValueLambda.RelativePathTo(pmkOtherLambda, out ppmkRelPathOutput);
return ppmkRelPathOutput;
});
}


public static IObservable<System.String> GetDisplayName(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> pbc, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkToLeft)
{
    return Observable.Zip(IMonikerValue, pbc, pmkToLeft, (IMonikerValueLambda, pbcLambda, pmkToLeftLambda) => {
System.String ppszDisplayNameOutput = default(System.String);
IMonikerValueLambda.GetDisplayName(pbcLambda, pmkToLeftLambda, out ppszDisplayNameOutput);
return ppszDisplayNameOutput;
});
}


public static IObservable<Tuple<System.Int32, System.Runtime.InteropServices.ComTypes.IMoniker>> ParseDisplayName(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue, IObservable<System.Runtime.InteropServices.ComTypes.IBindCtx> pbc, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkToLeft, IObservable<System.String> pszDisplayName)
{
    return Observable.Zip(IMonikerValue, pbc, pmkToLeft, pszDisplayName, (IMonikerValueLambda, pbcLambda, pmkToLeftLambda, pszDisplayNameLambda) => {
System.Int32 pchEatenOutput = default(System.Int32);
System.Runtime.InteropServices.ComTypes.IMoniker ppmkOutOutput = default(System.Runtime.InteropServices.ComTypes.IMoniker);
IMonikerValueLambda.ParseDisplayName(pbcLambda, pmkToLeftLambda, pszDisplayNameLambda, out pchEatenOutput, out ppmkOutOutput);
return Tuple.Create(pchEatenOutput, ppmkOutOutput);
});
}


public static IObservable<Tuple<System.Int32, System.Int32>> IsSystemMoniker(this IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> IMonikerValue)
{
    return Observable.Select(IMonikerValue, (IMonikerValueLambda) => {
System.Int32 pdwMksysOutput = default(System.Int32);
var result = IMonikerValueLambda.IsSystemMoniker(out pdwMksysOutput);
return Tuple.Create(result, pdwMksysOutput);
});
}

}
}