using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __PublisherMembershipCondition
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue)
        {
            return Observable.Select(PublisherMembershipConditionValue, (PublisherMembershipConditionValueLambda) => PublisherMembershipConditionValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Check(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue, IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(PublisherMembershipConditionValue, evidence, (PublisherMembershipConditionValueLambda, evidenceLambda) => PublisherMembershipConditionValueLambda.Check(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.IMembershipCondition> Copy(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue)
        {
            return Observable.Select(PublisherMembershipConditionValue, (PublisherMembershipConditionValueLambda) => PublisherMembershipConditionValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue)
        {
            return Observable.Select(PublisherMembershipConditionValue, (PublisherMembershipConditionValueLambda) => PublisherMembershipConditionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue, IObservable<System.Security.SecurityElement> e)
        {
            return ObservableExt.ZipExecute(PublisherMembershipConditionValue, e, (PublisherMembershipConditionValueLambda, eLambda) => PublisherMembershipConditionValueLambda.FromXml(eLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue, IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return Observable.Zip(PublisherMembershipConditionValue, level, (PublisherMembershipConditionValueLambda, levelLambda) => PublisherMembershipConditionValueLambda.ToXml(levelLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue, IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return ObservableExt.ZipExecute(PublisherMembershipConditionValue, e, level, (PublisherMembershipConditionValueLambda, eLambda, levelLambda) => PublisherMembershipConditionValueLambda.FromXml(eLambda, levelLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue, IObservable<System.Object> o)
        {
            return Observable.Zip(PublisherMembershipConditionValue, o, (PublisherMembershipConditionValueLambda, oLambda) => PublisherMembershipConditionValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue)
        {
            return Observable.Select(PublisherMembershipConditionValue, (PublisherMembershipConditionValueLambda) => PublisherMembershipConditionValueLambda.GetHashCode());
        }


        public static IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> get_Certificate(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue)
        {
            return Observable.Select(PublisherMembershipConditionValue, (PublisherMembershipConditionValueLambda) => PublisherMembershipConditionValueLambda.Certificate);
        }


        public static IObservable<System.Reactive.Unit> set_Certificate(this IObservable<System.Security.Policy.PublisherMembershipCondition> PublisherMembershipConditionValue, IObservable<System.Security.Cryptography.X509Certificates.X509Certificate> value)
        {
            return ObservableExt.ZipExecute(PublisherMembershipConditionValue, value, (PublisherMembershipConditionValueLambda, valueLambda) => PublisherMembershipConditionValueLambda.Certificate = valueLambda);
        }

    }
}