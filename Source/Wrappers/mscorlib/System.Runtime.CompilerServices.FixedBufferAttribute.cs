using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __FixedBufferAttribute
    {
        public static IObservable<System.Type> get_ElementType(
            this IObservable<System.Runtime.CompilerServices.FixedBufferAttribute> FixedBufferAttributeValue)
        {
            return Observable.Select(FixedBufferAttributeValue,
                (FixedBufferAttributeValueLambda) => FixedBufferAttributeValueLambda.ElementType);
        }


        public static IObservable<System.Int32> get_Length(
            this IObservable<System.Runtime.CompilerServices.FixedBufferAttribute> FixedBufferAttributeValue)
        {
            return Observable.Select(FixedBufferAttributeValue,
                (FixedBufferAttributeValueLambda) => FixedBufferAttributeValueLambda.Length);
        }
    }
}