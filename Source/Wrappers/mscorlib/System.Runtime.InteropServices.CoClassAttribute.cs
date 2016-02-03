using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __CoClassAttribute
    {
        public static IObservable<System.Type> get_CoClass(
            this IObservable<System.Runtime.InteropServices.CoClassAttribute> CoClassAttributeValue)
        {
            return Observable.Select(CoClassAttributeValue,
                (CoClassAttributeValueLambda) => CoClassAttributeValueLambda.CoClass);
        }
    }
}