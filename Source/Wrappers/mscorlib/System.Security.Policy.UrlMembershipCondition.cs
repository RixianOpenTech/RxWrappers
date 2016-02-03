using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __UrlMembershipCondition
    {
        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue,
            IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return ObservableExt.ZipExecute(UrlMembershipConditionValue, e, level,
                (UrlMembershipConditionValueLambda, eLambda, levelLambda) =>
                    UrlMembershipConditionValueLambda.FromXml(eLambda, levelLambda));
        }


        public static IObservable<System.Boolean> Check(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(UrlMembershipConditionValue, evidence,
                (UrlMembershipConditionValueLambda, evidenceLambda) =>
                    UrlMembershipConditionValueLambda.Check(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.IMembershipCondition> Copy(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue)
        {
            return Observable.Select(UrlMembershipConditionValue,
                (UrlMembershipConditionValueLambda) => UrlMembershipConditionValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue)
        {
            return Observable.Select(UrlMembershipConditionValue,
                (UrlMembershipConditionValueLambda) => UrlMembershipConditionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue,
            IObservable<System.Security.SecurityElement> e)
        {
            return ObservableExt.ZipExecute(UrlMembershipConditionValue, e,
                (UrlMembershipConditionValueLambda, eLambda) => UrlMembershipConditionValueLambda.FromXml(eLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue,
            IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return Observable.Zip(UrlMembershipConditionValue, level,
                (UrlMembershipConditionValueLambda, levelLambda) => UrlMembershipConditionValueLambda.ToXml(levelLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue,
            IObservable<System.Object> o)
        {
            return Observable.Zip(UrlMembershipConditionValue, o,
                (UrlMembershipConditionValueLambda, oLambda) => UrlMembershipConditionValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue)
        {
            return Observable.Select(UrlMembershipConditionValue,
                (UrlMembershipConditionValueLambda) => UrlMembershipConditionValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue)
        {
            return Observable.Select(UrlMembershipConditionValue,
                (UrlMembershipConditionValueLambda) => UrlMembershipConditionValueLambda.ToString());
        }


        public static IObservable<System.String> get_Url(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue)
        {
            return Observable.Select(UrlMembershipConditionValue,
                (UrlMembershipConditionValueLambda) => UrlMembershipConditionValueLambda.Url);
        }


        public static IObservable<System.Reactive.Unit> set_Url(
            this IObservable<System.Security.Policy.UrlMembershipCondition> UrlMembershipConditionValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(UrlMembershipConditionValue, value,
                (UrlMembershipConditionValueLambda, valueLambda) => UrlMembershipConditionValueLambda.Url = valueLambda);
        }
    }
}