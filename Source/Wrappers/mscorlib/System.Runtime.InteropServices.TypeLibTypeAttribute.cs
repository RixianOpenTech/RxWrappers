using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __TypeLibTypeAttribute
    {
        public static IObservable<System.Runtime.InteropServices.TypeLibTypeFlags> get_Value(
            this IObservable<System.Runtime.InteropServices.TypeLibTypeAttribute> TypeLibTypeAttributeValue)
        {
            return Observable.Select(TypeLibTypeAttributeValue,
                (TypeLibTypeAttributeValueLambda) => TypeLibTypeAttributeValueLambda.Value);
        }
    }
}