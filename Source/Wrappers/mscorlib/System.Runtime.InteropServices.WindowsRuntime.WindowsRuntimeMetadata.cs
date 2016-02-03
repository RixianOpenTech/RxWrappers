using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    public static class __WindowsRuntimeMetadata
    {
        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> ResolveNamespace(
            IObservable<System.String> namespaceName,
            IObservable<System.Collections.Generic.IEnumerable<System.String>> packageGraphFilePaths)
        {
            return Observable.Zip(namespaceName, packageGraphFilePaths,
                (namespaceNameLambda, packageGraphFilePathsLambda) =>
                    System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMetadata.ResolveNamespace(
                        namespaceNameLambda, packageGraphFilePathsLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> ResolveNamespace(
            IObservable<System.String> namespaceName, IObservable<System.String> windowsSdkFilePath,
            IObservable<System.Collections.Generic.IEnumerable<System.String>> packageGraphFilePaths)
        {
            return Observable.Zip(namespaceName, windowsSdkFilePath, packageGraphFilePaths,
                (namespaceNameLambda, windowsSdkFilePathLambda, packageGraphFilePathsLambda) =>
                    System.Runtime.InteropServices.WindowsRuntime.WindowsRuntimeMetadata.ResolveNamespace(
                        namespaceNameLambda, windowsSdkFilePathLambda, packageGraphFilePathsLambda));
        }
    }
}