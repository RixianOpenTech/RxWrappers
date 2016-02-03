using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __TypeForwardedFromAttribute
    {
        public static IObservable<System.String> get_AssemblyFullName(
            this IObservable<System.Runtime.CompilerServices.TypeForwardedFromAttribute> TypeForwardedFromAttributeValue)
        {
            return Observable.Select(TypeForwardedFromAttributeValue,
                (TypeForwardedFromAttributeValueLambda) => TypeForwardedFromAttributeValueLambda.AssemblyFullName);
        }
    }
}