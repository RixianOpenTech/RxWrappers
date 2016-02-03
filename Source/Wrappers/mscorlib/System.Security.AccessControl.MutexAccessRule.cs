using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __MutexAccessRule
    {
        public static IObservable<System.Security.AccessControl.MutexRights> get_MutexRights(
            this IObservable<System.Security.AccessControl.MutexAccessRule> MutexAccessRuleValue)
        {
            return Observable.Select(MutexAccessRuleValue,
                (MutexAccessRuleValueLambda) => MutexAccessRuleValueLambda.MutexRights);
        }
    }
}