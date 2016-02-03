using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __StructLayoutAttribute
    {
        
        public static IObservable<System.Runtime.InteropServices.LayoutKind> get_Value(this IObservable<System.Runtime.InteropServices.StructLayoutAttribute> StructLayoutAttributeValue)
        {
            return Observable.Select(StructLayoutAttributeValue, (StructLayoutAttributeValueLambda) => StructLayoutAttributeValueLambda.Value);
        }

    }
}