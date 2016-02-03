using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __AssemblyConfigurationAttribute
    {
        public static IObservable<System.String> get_Configuration(
            this IObservable<System.Reflection.AssemblyConfigurationAttribute> AssemblyConfigurationAttributeValue)
        {
            return Observable.Select(AssemblyConfigurationAttributeValue,
                (AssemblyConfigurationAttributeValueLambda) => AssemblyConfigurationAttributeValueLambda.Configuration);
        }
    }
}