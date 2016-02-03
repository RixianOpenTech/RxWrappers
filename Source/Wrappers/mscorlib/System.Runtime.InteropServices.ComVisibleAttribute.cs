using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ComVisibleAttribute
    {
        
        public static IObservable<System.Boolean> get_Value(this IObservable<System.Runtime.InteropServices.ComVisibleAttribute> ComVisibleAttributeValue)
        {
            return Observable.Select(ComVisibleAttributeValue, (ComVisibleAttributeValueLambda) => ComVisibleAttributeValueLambda.Value);
        }

    }
}