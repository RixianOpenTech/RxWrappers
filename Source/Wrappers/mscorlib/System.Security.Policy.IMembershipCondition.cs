using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __IMembershipCondition
    {
        public static IObservable<System.Boolean> Check(
            this IObservable<System.Security.Policy.IMembershipCondition> IMembershipConditionValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(IMembershipConditionValue, evidence,
                (IMembershipConditionValueLambda, evidenceLambda) =>
                    IMembershipConditionValueLambda.Check(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.IMembershipCondition> Copy(
            this IObservable<System.Security.Policy.IMembershipCondition> IMembershipConditionValue)
        {
            return Observable.Select(IMembershipConditionValue,
                (IMembershipConditionValueLambda) => IMembershipConditionValueLambda.Copy());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Security.Policy.IMembershipCondition> IMembershipConditionValue)
        {
            return Observable.Select(IMembershipConditionValue,
                (IMembershipConditionValueLambda) => IMembershipConditionValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Security.Policy.IMembershipCondition> IMembershipConditionValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(IMembershipConditionValue, obj,
                (IMembershipConditionValueLambda, objLambda) => IMembershipConditionValueLambda.Equals(objLambda));
        }
    }
}