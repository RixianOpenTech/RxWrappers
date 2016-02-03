using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __Publisher
    {
        public static IObservable<System.Security.IPermission> CreateIdentityPermission(
            this IObservable<System.Security.Policy.Publisher> PublisherValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(PublisherValue, evidence,
                (PublisherValueLambda, evidenceLambda) => PublisherValueLambda.CreateIdentityPermission(evidenceLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Security.Policy.Publisher> PublisherValue, IObservable<System.Object> o)
        {
            return Observable.Zip(PublisherValue, o,
                (PublisherValueLambda, oLambda) => PublisherValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Security.Policy.Publisher> PublisherValue)
        {
            return Observable.Select(PublisherValue, (PublisherValueLambda) => PublisherValueLambda.GetHashCode());
        }


        public static IObservable<System.Security.Policy.EvidenceBase> Clone(
            this IObservable<System.Security.Policy.Publisher> PublisherValue)
        {
            return Observable.Select(PublisherValue, (PublisherValueLambda) => PublisherValueLambda.Clone());
        }


        public static IObservable<System.Object> Copy(this IObservable<System.Security.Policy.Publisher> PublisherValue)
        {
            return Observable.Select(PublisherValue, (PublisherValueLambda) => PublisherValueLambda.Copy());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Security.Policy.Publisher> PublisherValue)
        {
            return Observable.Select(PublisherValue, (PublisherValueLambda) => PublisherValueLambda.ToString());
        }


        public static IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> get_Certificate(
            this IObservable<System.Security.Policy.Publisher> PublisherValue)
        {
            return Observable.Select(PublisherValue, (PublisherValueLambda) => PublisherValueLambda.Certificate);
        }
    }
}