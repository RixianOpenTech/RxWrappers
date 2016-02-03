using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __AssemblyTrademarkAttribute
    {
        public static IObservable<System.String> get_Trademark(
            this IObservable<System.Reflection.AssemblyTrademarkAttribute> AssemblyTrademarkAttributeValue)
        {
            return Observable.Select(AssemblyTrademarkAttributeValue,
                (AssemblyTrademarkAttributeValueLambda) => AssemblyTrademarkAttributeValueLambda.Trademark);
        }
    }
}