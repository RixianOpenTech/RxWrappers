using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __AssemblyAlgorithmIdAttribute
    {
        
        public static IObservable<System.UInt32> get_AlgorithmId(this IObservable<System.Reflection.AssemblyAlgorithmIdAttribute> AssemblyAlgorithmIdAttributeValue)
        {
            return Observable.Select(AssemblyAlgorithmIdAttributeValue, (AssemblyAlgorithmIdAttributeValueLambda) => AssemblyAlgorithmIdAttributeValueLambda.AlgorithmId);
        }

    }
}