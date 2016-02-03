using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    public static class __DesignerNamespaceResolveEventArgs
    {
        public static IObservable<System.String> get_NamespaceName(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.DesignerNamespaceResolveEventArgs>
                DesignerNamespaceResolveEventArgsValue)
        {
            return Observable.Select(DesignerNamespaceResolveEventArgsValue,
                (DesignerNamespaceResolveEventArgsValueLambda) =>
                    DesignerNamespaceResolveEventArgsValueLambda.NamespaceName);
        }


        public static IObservable<System.Collections.ObjectModel.Collection<System.String>> get_ResolvedAssemblyFiles(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.DesignerNamespaceResolveEventArgs>
                DesignerNamespaceResolveEventArgsValue)
        {
            return Observable.Select(DesignerNamespaceResolveEventArgsValue,
                (DesignerNamespaceResolveEventArgsValueLambda) =>
                    DesignerNamespaceResolveEventArgsValueLambda.ResolvedAssemblyFiles);
        }
    }
}