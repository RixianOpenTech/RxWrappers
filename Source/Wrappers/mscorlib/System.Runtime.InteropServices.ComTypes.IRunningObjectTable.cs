using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
public static class _IRunningObjectTable
{
    
public static IObservable<System.Int32> Register(this IObservable<System.Runtime.InteropServices.ComTypes.IRunningObjectTable> IRunningObjectTableValue, IObservable<System.Int32> grfFlags, IObservable<System.Object> punkObject, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkObjectName)
{
    return Observable.Zip(IRunningObjectTableValue, grfFlags, punkObject, pmkObjectName, (IRunningObjectTableValueLambda, grfFlagsLambda, punkObjectLambda, pmkObjectNameLambda) => IRunningObjectTableValueLambda.Register(grfFlagsLambda, punkObjectLambda, pmkObjectNameLambda));
}


public static IObservable<System.Reactive.Unit> Revoke(this IObservable<System.Runtime.InteropServices.ComTypes.IRunningObjectTable> IRunningObjectTableValue, IObservable<System.Int32> dwRegister)
{
    return ObservableExt.ZipExecute(IRunningObjectTableValue, dwRegister, (IRunningObjectTableValueLambda, dwRegisterLambda) => IRunningObjectTableValueLambda.Revoke(dwRegisterLambda));
}


public static IObservable<System.Int32> IsRunning(this IObservable<System.Runtime.InteropServices.ComTypes.IRunningObjectTable> IRunningObjectTableValue, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkObjectName)
{
    return Observable.Zip(IRunningObjectTableValue, pmkObjectName, (IRunningObjectTableValueLambda, pmkObjectNameLambda) => IRunningObjectTableValueLambda.IsRunning(pmkObjectNameLambda));
}


public static IObservable<Tuple<System.Int32, System.Object>> GetObject(this IObservable<System.Runtime.InteropServices.ComTypes.IRunningObjectTable> IRunningObjectTableValue, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkObjectName)
{
    return Observable.Zip(IRunningObjectTableValue, pmkObjectName, (IRunningObjectTableValueLambda, pmkObjectNameLambda) => {
System.Object ppunkObjectOutput = default(System.Object);
var result = IRunningObjectTableValueLambda.GetObject(pmkObjectNameLambda, out ppunkObjectOutput);
return Tuple.Create(result, ppunkObjectOutput);
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.FILETIME> NoteChangeTime(this IObservable<System.Runtime.InteropServices.ComTypes.IRunningObjectTable> IRunningObjectTableValue, IObservable<System.Int32> dwRegister, IObservable<System.Runtime.InteropServices.ComTypes.FILETIME> pfiletime)
{
    return Observable.Zip(IRunningObjectTableValue, dwRegister, pfiletime, (IRunningObjectTableValueLambda, dwRegisterLambda, pfiletimeLambda) => {
IRunningObjectTableValueLambda.NoteChangeTime(dwRegisterLambda, ref pfiletimeLambda);
return pfiletimeLambda;
});
}


public static IObservable<Tuple<System.Int32, System.Runtime.InteropServices.ComTypes.FILETIME>> GetTimeOfLastChange(this IObservable<System.Runtime.InteropServices.ComTypes.IRunningObjectTable> IRunningObjectTableValue, IObservable<System.Runtime.InteropServices.ComTypes.IMoniker> pmkObjectName)
{
    return Observable.Zip(IRunningObjectTableValue, pmkObjectName, (IRunningObjectTableValueLambda, pmkObjectNameLambda) => {
System.Runtime.InteropServices.ComTypes.FILETIME pfiletimeOutput = default(System.Runtime.InteropServices.ComTypes.FILETIME);
var result = IRunningObjectTableValueLambda.GetTimeOfLastChange(pmkObjectNameLambda, out pfiletimeOutput);
return Tuple.Create(result, pfiletimeOutput);
});
}


public static IObservable<System.Runtime.InteropServices.ComTypes.IEnumMoniker> EnumRunning(this IObservable<System.Runtime.InteropServices.ComTypes.IRunningObjectTable> IRunningObjectTableValue)
{
    return Observable.Select(IRunningObjectTableValue, (IRunningObjectTableValueLambda) => {
System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenumMonikerOutput = default(System.Runtime.InteropServices.ComTypes.IEnumMoniker);
IRunningObjectTableValueLambda.EnumRunning(out ppenumMonikerOutput);
return ppenumMonikerOutput;
});
}

}
}