using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
public static class _DefaultMemberAttribute
{
    
public static IObservable<System.String> get_MemberName(this IObservable<System.Reflection.DefaultMemberAttribute> DefaultMemberAttributeValue)
{
    return Observable.Select(DefaultMemberAttributeValue, (DefaultMemberAttributeValueLambda) => DefaultMemberAttributeValueLambda.MemberName);
}

}
}