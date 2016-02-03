using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __InterfaceTypeAttribute
    {
        public static IObservable<System.Runtime.InteropServices.ComInterfaceType> get_Value(
            this IObservable<System.Runtime.InteropServices.InterfaceTypeAttribute> InterfaceTypeAttributeValue)
        {
            return Observable.Select(InterfaceTypeAttributeValue,
                (InterfaceTypeAttributeValueLambda) => InterfaceTypeAttributeValueLambda.Value);
        }
    }
}