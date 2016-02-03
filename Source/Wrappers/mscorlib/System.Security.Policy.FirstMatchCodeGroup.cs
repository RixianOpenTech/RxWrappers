using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __FirstMatchCodeGroup
    {
        public static IObservable<System.Security.Policy.PolicyStatement> Resolve(
            this IObservable<System.Security.Policy.FirstMatchCodeGroup> FirstMatchCodeGroupValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(FirstMatchCodeGroupValue, evidence,
                (FirstMatchCodeGroupValueLambda, evidenceLambda) =>
                    FirstMatchCodeGroupValueLambda.Resolve(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.CodeGroup> ResolveMatchingCodeGroups(
            this IObservable<System.Security.Policy.FirstMatchCodeGroup> FirstMatchCodeGroupValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(FirstMatchCodeGroupValue, evidence,
                (FirstMatchCodeGroupValueLambda, evidenceLambda) =>
                    FirstMatchCodeGroupValueLambda.ResolveMatchingCodeGroups(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.CodeGroup> Copy(
            this IObservable<System.Security.Policy.FirstMatchCodeGroup> FirstMatchCodeGroupValue)
        {
            return Observable.Select(FirstMatchCodeGroupValue,
                (FirstMatchCodeGroupValueLambda) => FirstMatchCodeGroupValueLambda.Copy());
        }


        public static IObservable<System.String> get_MergeLogic(
            this IObservable<System.Security.Policy.FirstMatchCodeGroup> FirstMatchCodeGroupValue)
        {
            return Observable.Select(FirstMatchCodeGroupValue,
                (FirstMatchCodeGroupValueLambda) => FirstMatchCodeGroupValueLambda.MergeLogic);
        }
    }
}