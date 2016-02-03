using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __Site
    {
        public static IObservable<System.Security.Policy.Site> CreateFromUrl(IObservable<System.String> url)
        {
            return Observable.Select(url, (urlLambda) => System.Security.Policy.Site.CreateFromUrl(urlLambda));
        }


        public static IObservable<System.Security.IPermission> CreateIdentityPermission(
            this IObservable<System.Security.Policy.Site> SiteValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(SiteValue, evidence,
                (SiteValueLambda, evidenceLambda) => SiteValueLambda.CreateIdentityPermission(evidenceLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.Site> SiteValue,
            IObservable<System.Object> o)
        {
            return Observable.Zip(SiteValue, o, (SiteValueLambda, oLambda) => SiteValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.Site> SiteValue)
        {
            return Observable.Select(SiteValue, (SiteValueLambda) => SiteValueLambda.GetHashCode());
        }


        public static IObservable<System.Security.Policy.EvidenceBase> Clone(
            this IObservable<System.Security.Policy.Site> SiteValue)
        {
            return Observable.Select(SiteValue, (SiteValueLambda) => SiteValueLambda.Clone());
        }


        public static IObservable<System.Object> Copy(this IObservable<System.Security.Policy.Site> SiteValue)
        {
            return Observable.Select(SiteValue, (SiteValueLambda) => SiteValueLambda.Copy());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.Site> SiteValue)
        {
            return Observable.Select(SiteValue, (SiteValueLambda) => SiteValueLambda.ToString());
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Security.Policy.Site> SiteValue)
        {
            return Observable.Select(SiteValue, (SiteValueLambda) => SiteValueLambda.Name);
        }
    }
}