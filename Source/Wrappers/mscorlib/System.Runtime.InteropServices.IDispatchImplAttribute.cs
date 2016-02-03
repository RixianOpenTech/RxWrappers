using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __IDispatchImplAttribute
    {
        
        public static IObservable<System.Runtime.InteropServices.IDispatchImplType> get_Value(this IObservable<System.Runtime.InteropServices.IDispatchImplAttribute> IDispatchImplAttributeValue)
        {
            return Observable.Select(IDispatchImplAttributeValue, (IDispatchImplAttributeValueLambda) => IDispatchImplAttributeValueLambda.Value);
        }

    }
}