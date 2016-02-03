using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ComDefaultInterfaceAttribute
    {
        
        public static IObservable<System.Type> get_Value(this IObservable<System.Runtime.InteropServices.ComDefaultInterfaceAttribute> ComDefaultInterfaceAttributeValue)
        {
            return Observable.Select(ComDefaultInterfaceAttributeValue, (ComDefaultInterfaceAttributeValueLambda) => ComDefaultInterfaceAttributeValueLambda.Value);
        }

    }
}