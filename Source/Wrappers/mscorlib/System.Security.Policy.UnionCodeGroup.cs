using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __UnionCodeGroup
    {
        
        public static IObservable<System.Security.Policy.PolicyStatement> Resolve(this IObservable<System.Security.Policy.UnionCodeGroup> UnionCodeGroupValue, IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(UnionCodeGroupValue, evidence, (UnionCodeGroupValueLambda, evidenceLambda) => UnionCodeGroupValueLambda.Resolve(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.CodeGroup> ResolveMatchingCodeGroups(this IObservable<System.Security.Policy.UnionCodeGroup> UnionCodeGroupValue, IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(UnionCodeGroupValue, evidence, (UnionCodeGroupValueLambda, evidenceLambda) => UnionCodeGroupValueLambda.ResolveMatchingCodeGroups(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.CodeGroup> Copy(this IObservable<System.Security.Policy.UnionCodeGroup> UnionCodeGroupValue)
        {
            return Observable.Select(UnionCodeGroupValue, (UnionCodeGroupValueLambda) => UnionCodeGroupValueLambda.Copy());
        }


        public static IObservable<System.String> get_MergeLogic(this IObservable<System.Security.Policy.UnionCodeGroup> UnionCodeGroupValue)
        {
            return Observable.Select(UnionCodeGroupValue, (UnionCodeGroupValueLambda) => UnionCodeGroupValueLambda.MergeLogic);
        }

    }
}