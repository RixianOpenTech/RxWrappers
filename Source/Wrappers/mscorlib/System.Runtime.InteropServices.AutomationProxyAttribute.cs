using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __AutomationProxyAttribute
    {
        
        public static IObservable<System.Boolean> get_Value(this IObservable<System.Runtime.InteropServices.AutomationProxyAttribute> AutomationProxyAttributeValue)
        {
            return Observable.Select(AutomationProxyAttributeValue, (AutomationProxyAttributeValueLambda) => AutomationProxyAttributeValueLambda.Value);
        }

    }
}