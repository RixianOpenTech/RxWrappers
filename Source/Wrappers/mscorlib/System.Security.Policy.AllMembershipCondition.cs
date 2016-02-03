using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __AllMembershipCondition
    {
        
        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.AllMembershipCondition> AllMembershipConditionValue, IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return Observable.Zip(AllMembershipConditionValue, level, (AllMembershipConditionValueLambda, levelLambda) => AllMembershipConditionValueLambda.ToXml(levelLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.AllMembershipCondition> AllMembershipConditionValue, IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return ObservableExt.ZipExecute(AllMembershipConditionValue, e, level, (AllMembershipConditionValueLambda, eLambda, levelLambda) => AllMembershipConditionValueLambda.FromXml(eLambda, levelLambda));
        }


        public static IObservable<System.Boolean> Check(this IObservable<System.Security.Policy.AllMembershipCondition> AllMembershipConditionValue, IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(AllMembershipConditionValue, evidence, (AllMembershipConditionValueLambda, evidenceLambda) => AllMembershipConditionValueLambda.Check(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.IMembershipCondition> Copy(this IObservable<System.Security.Policy.AllMembershipCondition> AllMembershipConditionValue)
        {
            return Observable.Select(AllMembershipConditionValue, (AllMembershipConditionValueLambda) => AllMembershipConditionValueLambda.Copy());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.AllMembershipCondition> AllMembershipConditionValue)
        {
            return Observable.Select(AllMembershipConditionValue, (AllMembershipConditionValueLambda) => AllMembershipConditionValueLambda.ToString());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.AllMembershipCondition> AllMembershipConditionValue)
        {
            return Observable.Select(AllMembershipConditionValue, (AllMembershipConditionValueLambda) => AllMembershipConditionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.AllMembershipCondition> AllMembershipConditionValue, IObservable<System.Security.SecurityElement> e)
        {
            return ObservableExt.ZipExecute(AllMembershipConditionValue, e, (AllMembershipConditionValueLambda, eLambda) => AllMembershipConditionValueLambda.FromXml(eLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.AllMembershipCondition> AllMembershipConditionValue, IObservable<System.Object> o)
        {
            return Observable.Zip(AllMembershipConditionValue, o, (AllMembershipConditionValueLambda, oLambda) => AllMembershipConditionValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.AllMembershipCondition> AllMembershipConditionValue)
        {
            return Observable.Select(AllMembershipConditionValue, (AllMembershipConditionValueLambda) => AllMembershipConditionValueLambda.GetHashCode());
        }

    }
}