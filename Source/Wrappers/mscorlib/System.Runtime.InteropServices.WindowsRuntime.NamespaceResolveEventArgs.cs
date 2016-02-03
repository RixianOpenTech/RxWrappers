using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    public static class __NamespaceResolveEventArgs
    {
        public static IObservable<System.String> get_NamespaceName(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.NamespaceResolveEventArgs>
                NamespaceResolveEventArgsValue)
        {
            return Observable.Select(NamespaceResolveEventArgsValue,
                (NamespaceResolveEventArgsValueLambda) => NamespaceResolveEventArgsValueLambda.NamespaceName);
        }


        public static IObservable<System.Reflection.Assembly> get_RequestingAssembly(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.NamespaceResolveEventArgs>
                NamespaceResolveEventArgsValue)
        {
            return Observable.Select(NamespaceResolveEventArgsValue,
                (NamespaceResolveEventArgsValueLambda) => NamespaceResolveEventArgsValueLambda.RequestingAssembly);
        }


        public static IObservable<System.Collections.ObjectModel.Collection<System.Reflection.Assembly>>
            get_ResolvedAssemblies(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.NamespaceResolveEventArgs>
                NamespaceResolveEventArgsValue)
        {
            return Observable.Select(NamespaceResolveEventArgsValue,
                (NamespaceResolveEventArgsValueLambda) => NamespaceResolveEventArgsValueLambda.ResolvedAssemblies);
        }
    }
}