using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __CodeConnectAccess
    {
        public static IObservable<System.Security.Policy.CodeConnectAccess> CreateOriginSchemeAccess(
            IObservable<System.Int32> allowPort)
        {
            return Observable.Select(allowPort,
                (allowPortLambda) => System.Security.Policy.CodeConnectAccess.CreateOriginSchemeAccess(allowPortLambda));
        }


        public static IObservable<System.Security.Policy.CodeConnectAccess> CreateAnySchemeAccess(
            IObservable<System.Int32> allowPort)
        {
            return Observable.Select(allowPort,
                (allowPortLambda) => System.Security.Policy.CodeConnectAccess.CreateAnySchemeAccess(allowPortLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Security.Policy.CodeConnectAccess> CodeConnectAccessValue,
            IObservable<System.Object> o)
        {
            return Observable.Zip(CodeConnectAccessValue, o,
                (CodeConnectAccessValueLambda, oLambda) => CodeConnectAccessValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Security.Policy.CodeConnectAccess> CodeConnectAccessValue)
        {
            return Observable.Select(CodeConnectAccessValue,
                (CodeConnectAccessValueLambda) => CodeConnectAccessValueLambda.GetHashCode());
        }


        public static IObservable<System.String> get_Scheme(
            this IObservable<System.Security.Policy.CodeConnectAccess> CodeConnectAccessValue)
        {
            return Observable.Select(CodeConnectAccessValue,
                (CodeConnectAccessValueLambda) => CodeConnectAccessValueLambda.Scheme);
        }


        public static IObservable<System.Int32> get_Port(
            this IObservable<System.Security.Policy.CodeConnectAccess> CodeConnectAccessValue)
        {
            return Observable.Select(CodeConnectAccessValue,
                (CodeConnectAccessValueLambda) => CodeConnectAccessValueLambda.Port);
        }
    }
}