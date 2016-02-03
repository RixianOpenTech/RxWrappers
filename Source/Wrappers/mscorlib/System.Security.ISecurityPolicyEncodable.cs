using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __ISecurityPolicyEncodable
    {
        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.ISecurityPolicyEncodable> ISecurityPolicyEncodableValue,
            IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return Observable.Zip(ISecurityPolicyEncodableValue, level,
                (ISecurityPolicyEncodableValueLambda, levelLambda) =>
                    ISecurityPolicyEncodableValueLambda.ToXml(levelLambda));
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.ISecurityPolicyEncodable> ISecurityPolicyEncodableValue,
            IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return ObservableExt.ZipExecute(ISecurityPolicyEncodableValue, e, level,
                (ISecurityPolicyEncodableValueLambda, eLambda, levelLambda) =>
                    ISecurityPolicyEncodableValueLambda.FromXml(eLambda, levelLambda));
        }
    }
}