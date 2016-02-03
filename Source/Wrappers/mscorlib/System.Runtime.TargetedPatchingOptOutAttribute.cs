using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime
{
public static class _TargetedPatchingOptOutAttribute
{
    
public static IObservable<System.String> get_Reason(this IObservable<System.Runtime.TargetedPatchingOptOutAttribute> TargetedPatchingOptOutAttributeValue)
{
    return Observable.Select(TargetedPatchingOptOutAttributeValue, (TargetedPatchingOptOutAttributeValueLambda) => TargetedPatchingOptOutAttributeValueLambda.Reason);
}

}
}