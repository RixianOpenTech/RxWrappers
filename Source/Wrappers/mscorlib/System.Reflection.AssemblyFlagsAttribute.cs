using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __AssemblyFlagsAttribute
    {
        
        public static IObservable<System.UInt32> get_Flags(this IObservable<System.Reflection.AssemblyFlagsAttribute> AssemblyFlagsAttributeValue)
        {
            return Observable.Select(AssemblyFlagsAttributeValue, (AssemblyFlagsAttributeValueLambda) => AssemblyFlagsAttributeValueLambda.Flags);
        }


        public static IObservable<System.Int32> get_AssemblyFlags(this IObservable<System.Reflection.AssemblyFlagsAttribute> AssemblyFlagsAttributeValue)
        {
            return Observable.Select(AssemblyFlagsAttributeValue, (AssemblyFlagsAttributeValueLambda) => AssemblyFlagsAttributeValueLambda.AssemblyFlags);
        }

    }
}