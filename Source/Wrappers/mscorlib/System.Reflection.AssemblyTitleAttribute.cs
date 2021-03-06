using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __AssemblyTitleAttribute
    {
        public static IObservable<System.String> get_Title(
            this IObservable<System.Reflection.AssemblyTitleAttribute> AssemblyTitleAttributeValue)
        {
            return Observable.Select(AssemblyTitleAttributeValue,
                (AssemblyTitleAttributeValueLambda) => AssemblyTitleAttributeValueLambda.Title);
        }
    }
}