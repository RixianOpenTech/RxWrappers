using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __FieldOffsetAttribute
    {
        
        public static IObservable<System.Int32> get_Value(this IObservable<System.Runtime.InteropServices.FieldOffsetAttribute> FieldOffsetAttributeValue)
        {
            return Observable.Select(FieldOffsetAttributeValue, (FieldOffsetAttributeValueLambda) => FieldOffsetAttributeValueLambda.Value);
        }

    }
}