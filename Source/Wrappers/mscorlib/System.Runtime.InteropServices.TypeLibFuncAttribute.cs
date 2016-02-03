using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
public static class _TypeLibFuncAttribute
{
    
public static IObservable<System.Runtime.InteropServices.TypeLibFuncFlags> get_Value(this IObservable<System.Runtime.InteropServices.TypeLibFuncAttribute> TypeLibFuncAttributeValue)
{
    return Observable.Select(TypeLibFuncAttributeValue, (TypeLibFuncAttributeValueLambda) => TypeLibFuncAttributeValueLambda.Value);
}

}
}