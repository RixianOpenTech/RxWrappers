using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics
{
public static class _DebuggerBrowsableAttribute
{
    
public static IObservable<System.Diagnostics.DebuggerBrowsableState> get_State(this IObservable<System.Diagnostics.DebuggerBrowsableAttribute> DebuggerBrowsableAttributeValue)
{
    return Observable.Select(DebuggerBrowsableAttributeValue, (DebuggerBrowsableAttributeValueLambda) => DebuggerBrowsableAttributeValueLambda.State);
}

}
}