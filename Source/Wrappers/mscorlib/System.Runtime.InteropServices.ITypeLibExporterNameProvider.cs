using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ITypeLibExporterNameProvider
    {
        
        public static IObservable<System.String[]> GetNames(this IObservable<System.Runtime.InteropServices.ITypeLibExporterNameProvider> ITypeLibExporterNameProviderValue)
        {
            return Observable.Select(ITypeLibExporterNameProviderValue, (ITypeLibExporterNameProviderValueLambda) => ITypeLibExporterNameProviderValueLambda.GetNames());
        }

    }
}