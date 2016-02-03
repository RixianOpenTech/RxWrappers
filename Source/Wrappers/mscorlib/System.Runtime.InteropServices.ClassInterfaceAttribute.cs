using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ClassInterfaceAttribute
    {
        public static IObservable<System.Runtime.InteropServices.ClassInterfaceType> get_Value(
            this IObservable<System.Runtime.InteropServices.ClassInterfaceAttribute> ClassInterfaceAttributeValue)
        {
            return Observable.Select(ClassInterfaceAttributeValue,
                (ClassInterfaceAttributeValueLambda) => ClassInterfaceAttributeValueLambda.Value);
        }
    }
}