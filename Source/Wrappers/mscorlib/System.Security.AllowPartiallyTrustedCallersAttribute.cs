using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __AllowPartiallyTrustedCallersAttribute
    {
        public static IObservable<System.Security.PartialTrustVisibilityLevel> get_PartialTrustVisibilityLevel(
            this IObservable<System.Security.AllowPartiallyTrustedCallersAttribute>
                AllowPartiallyTrustedCallersAttributeValue)
        {
            return Observable.Select(AllowPartiallyTrustedCallersAttributeValue,
                (AllowPartiallyTrustedCallersAttributeValueLambda) =>
                    AllowPartiallyTrustedCallersAttributeValueLambda.PartialTrustVisibilityLevel);
        }


        public static IObservable<System.Reactive.Unit> set_PartialTrustVisibilityLevel(
            this IObservable<System.Security.AllowPartiallyTrustedCallersAttribute>
                AllowPartiallyTrustedCallersAttributeValue,
            IObservable<System.Security.PartialTrustVisibilityLevel> value)
        {
            return ObservableExt.ZipExecute(AllowPartiallyTrustedCallersAttributeValue, value,
                (AllowPartiallyTrustedCallersAttributeValueLambda, valueLambda) =>
                    AllowPartiallyTrustedCallersAttributeValueLambda.PartialTrustVisibilityLevel = valueLambda);
        }
    }
}