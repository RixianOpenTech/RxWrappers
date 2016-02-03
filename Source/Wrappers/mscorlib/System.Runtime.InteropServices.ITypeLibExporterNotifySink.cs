using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _ITypeLibExporterNotifySink
{
    
public static IObservable<System.Reactive.Unit> ReportEvent(this IObservable<System.Runtime.InteropServices.ITypeLibExporterNotifySink> ITypeLibExporterNotifySinkValue, IObservable<System.Runtime.InteropServices.ExporterEventKind> eventKind, IObservable<System.Int32> eventCode, IObservable<System.String> eventMsg)
{
    return ObservableExt.ZipExecute(ITypeLibExporterNotifySinkValue, eventKind, eventCode, eventMsg, (ITypeLibExporterNotifySinkValueLambda, eventKindLambda, eventCodeLambda, eventMsgLambda) => ITypeLibExporterNotifySinkValueLambda.ReportEvent(eventKindLambda, eventCodeLambda, eventMsgLambda));
}


public static IObservable<System.Object> ResolveRef(this IObservable<System.Runtime.InteropServices.ITypeLibExporterNotifySink> ITypeLibExporterNotifySinkValue, IObservable<System.Reflection.Assembly> assembly)
{
    return Observable.Zip(ITypeLibExporterNotifySinkValue, assembly, (ITypeLibExporterNotifySinkValueLambda, assemblyLambda) => ITypeLibExporterNotifySinkValueLambda.ResolveRef(assemblyLambda));
}

}
}