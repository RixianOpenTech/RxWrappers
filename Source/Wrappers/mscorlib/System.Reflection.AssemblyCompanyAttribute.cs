using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __AssemblyCompanyAttribute
    {
        
        public static IObservable<System.String> get_Company(this IObservable<System.Reflection.AssemblyCompanyAttribute> AssemblyCompanyAttributeValue)
        {
            return Observable.Select(AssemblyCompanyAttributeValue, (AssemblyCompanyAttributeValueLambda) => AssemblyCompanyAttributeValueLambda.Company);
        }

    }
}