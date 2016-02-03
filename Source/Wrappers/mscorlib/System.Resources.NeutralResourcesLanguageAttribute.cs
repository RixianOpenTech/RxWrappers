using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Resources
{
    public static class __NeutralResourcesLanguageAttribute
    {
        
        public static IObservable<System.String> get_CultureName(this IObservable<System.Resources.NeutralResourcesLanguageAttribute> NeutralResourcesLanguageAttributeValue)
        {
            return Observable.Select(NeutralResourcesLanguageAttributeValue, (NeutralResourcesLanguageAttributeValueLambda) => NeutralResourcesLanguageAttributeValueLambda.CultureName);
        }


        public static IObservable<System.Resources.UltimateResourceFallbackLocation> get_Location(this IObservable<System.Resources.NeutralResourcesLanguageAttribute> NeutralResourcesLanguageAttributeValue)
        {
            return Observable.Select(NeutralResourcesLanguageAttributeValue, (NeutralResourcesLanguageAttributeValueLambda) => NeutralResourcesLanguageAttributeValueLambda.Location);
        }

    }
}