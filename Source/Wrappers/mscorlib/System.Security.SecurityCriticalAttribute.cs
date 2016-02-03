using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __SecurityCriticalAttribute
    {
        public static IObservable<System.Security.SecurityCriticalScope> get_Scope(
            this IObservable<System.Security.SecurityCriticalAttribute> SecurityCriticalAttributeValue)
        {
            return Observable.Select(SecurityCriticalAttributeValue,
                (SecurityCriticalAttributeValueLambda) => SecurityCriticalAttributeValueLambda.Scope);
        }
    }
}