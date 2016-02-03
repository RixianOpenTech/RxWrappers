using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __CodeGroup
    {
        
        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return ObservableExt.ZipExecute(CodeGroupValue, e, level, (CodeGroupValueLambda, eLambda, levelLambda) => CodeGroupValueLambda.FromXml(eLambda, levelLambda));
        }


        public static IObservable<System.Reactive.Unit> AddChild(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Security.Policy.CodeGroup> group)
        {
            return ObservableExt.ZipExecute(CodeGroupValue, group, (CodeGroupValueLambda, groupLambda) => CodeGroupValueLambda.AddChild(groupLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveChild(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Security.Policy.CodeGroup> group)
        {
            return ObservableExt.ZipExecute(CodeGroupValue, group, (CodeGroupValueLambda, groupLambda) => CodeGroupValueLambda.RemoveChild(groupLambda));
        }


        public static IObservable<System.Security.Policy.PolicyStatement> Resolve(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(CodeGroupValue, evidence, (CodeGroupValueLambda, evidenceLambda) => CodeGroupValueLambda.Resolve(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.CodeGroup> ResolveMatchingCodeGroups(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(CodeGroupValue, evidence, (CodeGroupValueLambda, evidenceLambda) => CodeGroupValueLambda.ResolveMatchingCodeGroups(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.CodeGroup> Copy(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.Copy());
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Security.SecurityElement> e)
        {
            return ObservableExt.ZipExecute(CodeGroupValue, e, (CodeGroupValueLambda, eLambda) => CodeGroupValueLambda.FromXml(eLambda));
        }


        public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Security.Policy.PolicyLevel> level)
        {
            return Observable.Zip(CodeGroupValue, level, (CodeGroupValueLambda, levelLambda) => CodeGroupValueLambda.ToXml(levelLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Object> o)
        {
            return Observable.Zip(CodeGroupValue, o, (CodeGroupValueLambda, oLambda) => CodeGroupValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Security.Policy.CodeGroup> cg, IObservable<System.Boolean> compareChildren)
        {
            return Observable.Zip(CodeGroupValue, cg, compareChildren, (CodeGroupValueLambda, cgLambda, compareChildrenLambda) => CodeGroupValueLambda.Equals(cgLambda, compareChildrenLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.GetHashCode());
        }


        public static IObservable<System.Collections.IList> get_Children(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.Children);
        }


        public static IObservable<System.Security.Policy.IMembershipCondition> get_MembershipCondition(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.MembershipCondition);
        }


        public static IObservable<System.Security.Policy.PolicyStatement> get_PolicyStatement(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.PolicyStatement);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.Name);
        }


        public static IObservable<System.String> get_Description(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.Description);
        }


        public static IObservable<System.String> get_PermissionSetName(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.PermissionSetName);
        }


        public static IObservable<System.String> get_AttributeString(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.AttributeString);
        }


        public static IObservable<System.String> get_MergeLogic(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue)
        {
            return Observable.Select(CodeGroupValue, (CodeGroupValueLambda) => CodeGroupValueLambda.MergeLogic);
        }


        public static IObservable<System.Reactive.Unit> set_Children(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Collections.IList> value)
        {
            return ObservableExt.ZipExecute(CodeGroupValue, value, (CodeGroupValueLambda, valueLambda) => CodeGroupValueLambda.Children = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MembershipCondition(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Security.Policy.IMembershipCondition> value)
        {
            return ObservableExt.ZipExecute(CodeGroupValue, value, (CodeGroupValueLambda, valueLambda) => CodeGroupValueLambda.MembershipCondition = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PolicyStatement(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.Security.Policy.PolicyStatement> value)
        {
            return ObservableExt.ZipExecute(CodeGroupValue, value, (CodeGroupValueLambda, valueLambda) => CodeGroupValueLambda.PolicyStatement = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Name(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(CodeGroupValue, value, (CodeGroupValueLambda, valueLambda) => CodeGroupValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Description(this IObservable<System.Security.Policy.CodeGroup> CodeGroupValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(CodeGroupValue, value, (CodeGroupValueLambda, valueLambda) => CodeGroupValueLambda.Description = valueLambda);
        }

    }
}