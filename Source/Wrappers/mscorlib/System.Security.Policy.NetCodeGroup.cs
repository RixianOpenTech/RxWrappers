using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __NetCodeGroup
    {
        public static IObservable<System.Reactive.Unit> ResetConnectAccess(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue)
        {
            return
                Observable.Do(NetCodeGroupValue,
                    (NetCodeGroupValueLambda) => NetCodeGroupValueLambda.ResetConnectAccess()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> AddConnectAccess(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue,
            IObservable<System.String> originScheme, IObservable<System.Security.Policy.CodeConnectAccess> connectAccess)
        {
            return ObservableExt.ZipExecute(NetCodeGroupValue, originScheme, connectAccess,
                (NetCodeGroupValueLambda, originSchemeLambda, connectAccessLambda) =>
                    NetCodeGroupValueLambda.AddConnectAccess(originSchemeLambda, connectAccessLambda));
        }


        public static IObservable<System.Collections.DictionaryEntry[]> GetConnectAccessRules(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue)
        {
            return Observable.Select(NetCodeGroupValue,
                (NetCodeGroupValueLambda) => NetCodeGroupValueLambda.GetConnectAccessRules());
        }


        public static IObservable<System.Security.Policy.PolicyStatement> Resolve(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(NetCodeGroupValue, evidence,
                (NetCodeGroupValueLambda, evidenceLambda) => NetCodeGroupValueLambda.Resolve(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.CodeGroup> ResolveMatchingCodeGroups(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(NetCodeGroupValue, evidence,
                (NetCodeGroupValueLambda, evidenceLambda) =>
                    NetCodeGroupValueLambda.ResolveMatchingCodeGroups(evidenceLambda));
        }


        public static IObservable<System.Security.Policy.CodeGroup> Copy(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue)
        {
            return Observable.Select(NetCodeGroupValue, (NetCodeGroupValueLambda) => NetCodeGroupValueLambda.Copy());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue, IObservable<System.Object> o)
        {
            return Observable.Zip(NetCodeGroupValue, o,
                (NetCodeGroupValueLambda, oLambda) => NetCodeGroupValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue)
        {
            return Observable.Select(NetCodeGroupValue,
                (NetCodeGroupValueLambda) => NetCodeGroupValueLambda.GetHashCode());
        }


        public static IObservable<System.String> get_MergeLogic(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue)
        {
            return Observable.Select(NetCodeGroupValue, (NetCodeGroupValueLambda) => NetCodeGroupValueLambda.MergeLogic);
        }


        public static IObservable<System.String> get_PermissionSetName(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue)
        {
            return Observable.Select(NetCodeGroupValue,
                (NetCodeGroupValueLambda) => NetCodeGroupValueLambda.PermissionSetName);
        }


        public static IObservable<System.String> get_AttributeString(
            this IObservable<System.Security.Policy.NetCodeGroup> NetCodeGroupValue)
        {
            return Observable.Select(NetCodeGroupValue,
                (NetCodeGroupValueLambda) => NetCodeGroupValueLambda.AttributeString);
        }
    }
}