using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __AccessRule1
    {
        public static IObservable<T> get_Rights<T>(
            this IObservable<System.Security.AccessControl.AccessRule<T>> AccessRuleValue) where T : struct
        {
            return Observable.Select(AccessRuleValue, (AccessRuleValueLambda) => AccessRuleValueLambda.Rights);
        }
    }
}