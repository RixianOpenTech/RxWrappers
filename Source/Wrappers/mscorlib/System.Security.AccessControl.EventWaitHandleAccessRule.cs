using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __EventWaitHandleAccessRule
    {
        
        public static IObservable<System.Security.AccessControl.EventWaitHandleRights> get_EventWaitHandleRights(this IObservable<System.Security.AccessControl.EventWaitHandleAccessRule> EventWaitHandleAccessRuleValue)
        {
            return Observable.Select(EventWaitHandleAccessRuleValue, (EventWaitHandleAccessRuleValueLambda) => EventWaitHandleAccessRuleValueLambda.EventWaitHandleRights);
        }

    }
}