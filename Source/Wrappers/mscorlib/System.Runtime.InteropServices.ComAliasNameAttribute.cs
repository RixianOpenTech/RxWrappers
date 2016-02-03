using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ComAliasNameAttribute
    {
        public static IObservable<System.String> get_Value(
            this IObservable<System.Runtime.InteropServices.ComAliasNameAttribute> ComAliasNameAttributeValue)
        {
            return Observable.Select(ComAliasNameAttributeValue,
                (ComAliasNameAttributeValueLambda) => ComAliasNameAttributeValueLambda.Value);
        }
    }
}