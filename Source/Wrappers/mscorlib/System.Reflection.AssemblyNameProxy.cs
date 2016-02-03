using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _AssemblyNameProxy
{
    
public static IObservable<System.Reflection.AssemblyName> GetAssemblyName(this IObservable<System.Reflection.AssemblyNameProxy> AssemblyNameProxyValue, IObservable<System.String> assemblyFile)
{
    return Observable.Zip(AssemblyNameProxyValue, assemblyFile, (AssemblyNameProxyValueLambda, assemblyFileLambda) => AssemblyNameProxyValueLambda.GetAssemblyName(assemblyFileLambda));
}

}
}