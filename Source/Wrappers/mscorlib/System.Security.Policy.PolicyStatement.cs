using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __PolicyStatement
    {
        public static IObservable<System.Security.Policy.PolicyStatement> Copy(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue)
        {
            return Observable.Select(PolicyStatementValue,
                (PolicyStatementValueLambda) => PolicyStatementValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue)
        {
            return Observable.Select(PolicyStatementValue,
                (PolicyStatementValueLambda) => PolicyStatementValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue,
            IObservable<System.Security.SecurityElement> et)
        {
            return ObservableExt.ZipExecute(PolicyStatementValue, et,
                (PolicyStatementValueLambda, etLambda) => PolicyStatementValueLambda.FromXml(etLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue,
            IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return Observable.Zip(PolicyStatementValue, level,
                (PolicyStatementValueLambda, levelLambda) => PolicyStatementValueLambda.ToXml(levelLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue,
            IObservable<System.Security.SecurityElement> et, IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return ObservableExt.ZipExecute(PolicyStatementValue, et, level,
                (PolicyStatementValueLambda, etLambda, levelLambda) =>
                    PolicyStatementValueLambda.FromXml(etLambda, levelLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(PolicyStatementValue, obj,
                (PolicyStatementValueLambda, objLambda) => PolicyStatementValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue)
        {
            return Observable.Select(PolicyStatementValue,
                (PolicyStatementValueLambda) => PolicyStatementValueLambda.GetHashCode());
        }


        public static IObservable<System.Security.PermissionSet> get_PermissionSet(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue)
        {
            return Observable.Select(PolicyStatementValue,
                (PolicyStatementValueLambda) => PolicyStatementValueLambda.PermissionSet);
        }


        public static IObservable<System.Security.Policy.PolicyStatementAttribute> get_Attributes(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue)
        {
            return Observable.Select(PolicyStatementValue,
                (PolicyStatementValueLambda) => PolicyStatementValueLambda.Attributes);
        }


        public static IObservable<System.String> get_AttributeString(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue)
        {
            return Observable.Select(PolicyStatementValue,
                (PolicyStatementValueLambda) => PolicyStatementValueLambda.AttributeString);
        }


        public static IObservable<System.Reactive.Unit> set_PermissionSet(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue,
            IObservable<System.Security.PermissionSet> value)
        {
            return ObservableExt.ZipExecute(PolicyStatementValue, value,
                (PolicyStatementValueLambda, valueLambda) => PolicyStatementValueLambda.PermissionSet = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Attributes(
            this IObservable<System.Security.Policy.PolicyStatement> PolicyStatementValue,
            IObservable<System.Security.Policy.PolicyStatementAttribute> value)
        {
            return ObservableExt.ZipExecute(PolicyStatementValue, value,
                (PolicyStatementValueLambda, valueLambda) => PolicyStatementValueLambda.Attributes = valueLambda);
        }
    }
}