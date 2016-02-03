using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __CompilationRelaxationsAttribute
    {
        
        public static IObservable<System.Int32> get_CompilationRelaxations(this IObservable<System.Runtime.CompilerServices.CompilationRelaxationsAttribute> CompilationRelaxationsAttributeValue)
        {
            return Observable.Select(CompilationRelaxationsAttributeValue, (CompilationRelaxationsAttributeValueLambda) => CompilationRelaxationsAttributeValueLambda.CompilationRelaxations);
        }

    }
}