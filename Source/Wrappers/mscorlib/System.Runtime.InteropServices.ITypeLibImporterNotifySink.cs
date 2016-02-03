using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ITypeLibImporterNotifySink
    {
        public static IObservable<System.Reactive.Unit> ReportEvent(
            this IObservable<System.Runtime.InteropServices.ITypeLibImporterNotifySink> ITypeLibImporterNotifySinkValue,
            IObservable<System.Runtime.InteropServices.ImporterEventKind> eventKind, IObservable<System.Int32> eventCode,
            IObservable<System.String> eventMsg)
        {
            return ObservableExt.ZipExecute(ITypeLibImporterNotifySinkValue, eventKind, eventCode, eventMsg,
                (ITypeLibImporterNotifySinkValueLambda, eventKindLambda, eventCodeLambda, eventMsgLambda) =>
                    ITypeLibImporterNotifySinkValueLambda.ReportEvent(eventKindLambda, eventCodeLambda, eventMsgLambda));
        }


        public static IObservable<System.Reflection.Assembly> ResolveRef(
            this IObservable<System.Runtime.InteropServices.ITypeLibImporterNotifySink> ITypeLibImporterNotifySinkValue,
            IObservable<System.Object> typeLib)
        {
            return Observable.Zip(ITypeLibImporterNotifySinkValue, typeLib,
                (ITypeLibImporterNotifySinkValueLambda, typeLibLambda) =>
                    ITypeLibImporterNotifySinkValueLambda.ResolveRef(typeLibLambda));
        }
    }
}