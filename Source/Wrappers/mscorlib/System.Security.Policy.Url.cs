using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __Url
    {
        public static IObservable<System.Security.IPermission> CreateIdentityPermission(
            this IObservable<System.Security.Policy.Url> UrlValue, IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(UrlValue, evidence,
                (UrlValueLambda, evidenceLambda) => UrlValueLambda.CreateIdentityPermission(evidenceLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.Url> UrlValue,
            IObservable<System.Object> o)
        {
            return Observable.Zip(UrlValue, o, (UrlValueLambda, oLambda) => UrlValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.Url> UrlValue)
        {
            return Observable.Select(UrlValue, (UrlValueLambda) => UrlValueLambda.GetHashCode());
        }


        public static IObservable<System.Security.Policy.EvidenceBase> Clone(
            this IObservable<System.Security.Policy.Url> UrlValue)
        {
            return Observable.Select(UrlValue, (UrlValueLambda) => UrlValueLambda.Clone());
        }


        public static IObservable<System.Object> Copy(this IObservable<System.Security.Policy.Url> UrlValue)
        {
            return Observable.Select(UrlValue, (UrlValueLambda) => UrlValueLambda.Copy());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.Url> UrlValue)
        {
            return Observable.Select(UrlValue, (UrlValueLambda) => UrlValueLambda.ToString());
        }


        public static IObservable<System.String> get_Value(this IObservable<System.Security.Policy.Url> UrlValue)
        {
            return Observable.Select(UrlValue, (UrlValueLambda) => UrlValueLambda.Value);
        }
    }
}