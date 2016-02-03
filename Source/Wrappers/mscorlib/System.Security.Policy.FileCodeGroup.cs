using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __FileCodeGroup
    {
        public static IObservable<System.Security.Policy.PolicyStatement> Resolve(
            this IObservable<System.Security.Policy.FileCodeGroup> FileCodeGroupValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(FileCodeGroupValue, evidence,
                (FileCodeGroupValueLambda, evidenceLambda) => FileCodeGroupValueLambda.Resolve(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.CodeGroup> ResolveMatchingCodeGroups(
            this IObservable<System.Security.Policy.FileCodeGroup> FileCodeGroupValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(FileCodeGroupValue, evidence,
                (FileCodeGroupValueLambda, evidenceLambda) =>
                    FileCodeGroupValueLambda.ResolveMatchingCodeGroups(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.CodeGroup> Copy(
            this IObservable<System.Security.Policy.FileCodeGroup> FileCodeGroupValue)
        {
            return Observable.Select(FileCodeGroupValue, (FileCodeGroupValueLambda) => FileCodeGroupValueLambda.Copy());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Security.Policy.FileCodeGroup> FileCodeGroupValue, IObservable<System.Object> o)
        {
            return Observable.Zip(FileCodeGroupValue, o,
                (FileCodeGroupValueLambda, oLambda) => FileCodeGroupValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Security.Policy.FileCodeGroup> FileCodeGroupValue)
        {
            return Observable.Select(FileCodeGroupValue,
                (FileCodeGroupValueLambda) => FileCodeGroupValueLambda.GetHashCode());
        }


        public static IObservable<System.String> get_MergeLogic(
            this IObservable<System.Security.Policy.FileCodeGroup> FileCodeGroupValue)
        {
            return Observable.Select(FileCodeGroupValue,
                (FileCodeGroupValueLambda) => FileCodeGroupValueLambda.MergeLogic);
        }


        public static IObservable<System.String> get_PermissionSetName(
            this IObservable<System.Security.Policy.FileCodeGroup> FileCodeGroupValue)
        {
            return Observable.Select(FileCodeGroupValue,
                (FileCodeGroupValueLambda) => FileCodeGroupValueLambda.PermissionSetName);
        }


        public static IObservable<System.String> get_AttributeString(
            this IObservable<System.Security.Policy.FileCodeGroup> FileCodeGroupValue)
        {
            return Observable.Select(FileCodeGroupValue,
                (FileCodeGroupValueLambda) => FileCodeGroupValueLambda.AttributeString);
        }
    }
}