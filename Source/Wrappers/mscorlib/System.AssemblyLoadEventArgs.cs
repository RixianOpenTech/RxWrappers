using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __AssemblyLoadEventArgs
    {
        
        public static IObservable<System.Reflection.Assembly> get_LoadedAssembly(this IObservable<System.AssemblyLoadEventArgs> AssemblyLoadEventArgsValue)
        {
            return Observable.Select(AssemblyLoadEventArgsValue, (AssemblyLoadEventArgsValueLambda) => AssemblyLoadEventArgsValueLambda.LoadedAssembly);
        }

    }
}