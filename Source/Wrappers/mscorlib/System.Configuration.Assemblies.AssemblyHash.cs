using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Configuration.Assemblies
{
    public static class __AssemblyHash
    {
        
        public static IObservable<System.Byte[]> GetValue(this IObservable<System.Configuration.Assemblies.AssemblyHash> AssemblyHashValue)
        {
            return Observable.Select(AssemblyHashValue, (AssemblyHashValueLambda) => AssemblyHashValueLambda.GetValue());
        }


        public static IObservable<System.Reactive.Unit> SetValue(this IObservable<System.Configuration.Assemblies.AssemblyHash> AssemblyHashValue, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(AssemblyHashValue, value, (AssemblyHashValueLambda, valueLambda) => AssemblyHashValueLambda.SetValue(valueLambda));
        }


        public static IObservable<System.Object> Clone(this IObservable<System.Configuration.Assemblies.AssemblyHash> AssemblyHashValue)
        {
            return Observable.Select(AssemblyHashValue, (AssemblyHashValueLambda) => AssemblyHashValueLambda.Clone());
        }


        public static IObservable<System.Configuration.Assemblies.AssemblyHashAlgorithm> get_Algorithm(this IObservable<System.Configuration.Assemblies.AssemblyHash> AssemblyHashValue)
        {
            return Observable.Select(AssemblyHashValue, (AssemblyHashValueLambda) => AssemblyHashValueLambda.Algorithm);
        }


        public static IObservable<System.Reactive.Unit> set_Algorithm(this IObservable<System.Configuration.Assemblies.AssemblyHash> AssemblyHashValue, IObservable<System.Configuration.Assemblies.AssemblyHashAlgorithm> value)
        {
            return ObservableExt.ZipExecute(AssemblyHashValue, value, (AssemblyHashValueLambda, valueLambda) => AssemblyHashValueLambda.Algorithm = valueLambda);
        }

    }
}