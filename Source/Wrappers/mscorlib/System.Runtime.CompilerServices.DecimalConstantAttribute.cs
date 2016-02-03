using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __DecimalConstantAttribute
    {
        public static IObservable<System.Decimal> get_Value(
            this IObservable<System.Runtime.CompilerServices.DecimalConstantAttribute> DecimalConstantAttributeValue)
        {
            return Observable.Select(DecimalConstantAttributeValue,
                (DecimalConstantAttributeValueLambda) => DecimalConstantAttributeValueLambda.Value);
        }
    }
}