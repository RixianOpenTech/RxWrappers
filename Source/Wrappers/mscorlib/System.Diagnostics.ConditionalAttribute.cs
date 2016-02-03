using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics
{
    public static class __ConditionalAttribute
    {
        public static IObservable<System.String> get_ConditionString(
            this IObservable<System.Diagnostics.ConditionalAttribute> ConditionalAttributeValue)
        {
            return Observable.Select(ConditionalAttributeValue,
                (ConditionalAttributeValueLambda) => ConditionalAttributeValueLambda.ConditionString);
        }
    }
}