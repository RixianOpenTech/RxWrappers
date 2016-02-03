using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __AssemblyProductAttribute
    {
        public static IObservable<System.String> get_Product(
            this IObservable<System.Reflection.AssemblyProductAttribute> AssemblyProductAttributeValue)
        {
            return Observable.Select(AssemblyProductAttributeValue,
                (AssemblyProductAttributeValueLambda) => AssemblyProductAttributeValueLambda.Product);
        }
    }
}