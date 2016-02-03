using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __StrongNameMembershipCondition
    {
        public static IObservable<System.Boolean> Check(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(StrongNameMembershipConditionValue, evidence,
                (StrongNameMembershipConditionValueLambda, evidenceLambda) =>
                    StrongNameMembershipConditionValueLambda.Check(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.IMembershipCondition> Copy(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue)
        {
            return Observable.Select(StrongNameMembershipConditionValue,
                (StrongNameMembershipConditionValueLambda) => StrongNameMembershipConditionValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue)
        {
            return Observable.Select(StrongNameMembershipConditionValue,
                (StrongNameMembershipConditionValueLambda) => StrongNameMembershipConditionValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue,
            IObservable<System.Security.SecurityElement> e)
        {
            return ObservableExt.ZipExecute(StrongNameMembershipConditionValue, e,
                (StrongNameMembershipConditionValueLambda, eLambda) =>
                    StrongNameMembershipConditionValueLambda.FromXml(eLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue,
            IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return Observable.Zip(StrongNameMembershipConditionValue, level,
                (StrongNameMembershipConditionValueLambda, levelLambda) =>
                    StrongNameMembershipConditionValueLambda.ToXml(levelLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue,
            IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return ObservableExt.ZipExecute(StrongNameMembershipConditionValue, e, level,
                (StrongNameMembershipConditionValueLambda, eLambda, levelLambda) =>
                    StrongNameMembershipConditionValueLambda.FromXml(eLambda, levelLambda));
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue)
        {
            return Observable.Select(StrongNameMembershipConditionValue,
                (StrongNameMembershipConditionValueLambda) => StrongNameMembershipConditionValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue,
            IObservable<System.Object> o)
        {
            return Observable.Zip(StrongNameMembershipConditionValue, o,
                (StrongNameMembershipConditionValueLambda, oLambda) =>
                    StrongNameMembershipConditionValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue)
        {
            return Observable.Select(StrongNameMembershipConditionValue,
                (StrongNameMembershipConditionValueLambda) => StrongNameMembershipConditionValueLambda.GetHashCode());
        }


        public static IObservable<System.Security.Permissions.StrongNamePublicKeyBlob> get_PublicKey(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue)
        {
            return Observable.Select(StrongNameMembershipConditionValue,
                (StrongNameMembershipConditionValueLambda) => StrongNameMembershipConditionValueLambda.PublicKey);
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue)
        {
            return Observable.Select(StrongNameMembershipConditionValue,
                (StrongNameMembershipConditionValueLambda) => StrongNameMembershipConditionValueLambda.Name);
        }


        public static IObservable<System.Version> get_Version(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue)
        {
            return Observable.Select(StrongNameMembershipConditionValue,
                (StrongNameMembershipConditionValueLambda) => StrongNameMembershipConditionValueLambda.Version);
        }


        public static IObservable<System.Reactive.Unit> set_PublicKey(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue,
            IObservable<System.Security.Permissions.StrongNamePublicKeyBlob> value)
        {
            return ObservableExt.ZipExecute(StrongNameMembershipConditionValue, value,
                (StrongNameMembershipConditionValueLambda, valueLambda) =>
                    StrongNameMembershipConditionValueLambda.PublicKey = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Name(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(StrongNameMembershipConditionValue, value,
                (StrongNameMembershipConditionValueLambda, valueLambda) =>
                    StrongNameMembershipConditionValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Version(
            this IObservable<System.Security.Policy.StrongNameMembershipCondition> StrongNameMembershipConditionValue,
            IObservable<System.Version> value)
        {
            return ObservableExt.ZipExecute(StrongNameMembershipConditionValue, value,
                (StrongNameMembershipConditionValueLambda, valueLambda) =>
                    StrongNameMembershipConditionValueLambda.Version = valueLambda);
        }
    }
}