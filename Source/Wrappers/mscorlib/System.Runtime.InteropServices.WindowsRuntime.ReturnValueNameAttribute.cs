using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.WindowsRuntime
{
public static class _ReturnValueNameAttribute
{
    
public static IObservable<System.String> get_Name(this IObservable<System.Runtime.InteropServices.WindowsRuntime.ReturnValueNameAttribute> ReturnValueNameAttributeValue)
{
    return Observable.Select(ReturnValueNameAttributeValue, (ReturnValueNameAttributeValueLambda) => ReturnValueNameAttributeValueLambda.Name);
}

}
}