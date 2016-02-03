using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __TypeLibVarAttribute
    {
        public static IObservable<System.Runtime.InteropServices.TypeLibVarFlags> get_Value(
            this IObservable<System.Runtime.InteropServices.TypeLibVarAttribute> TypeLibVarAttributeValue)
        {
            return Observable.Select(TypeLibVarAttributeValue,
                (TypeLibVarAttributeValueLambda) => TypeLibVarAttributeValueLambda.Value);
        }
    }
}