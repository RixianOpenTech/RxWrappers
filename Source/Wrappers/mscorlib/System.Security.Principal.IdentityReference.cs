using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
    public static class __IdentityReference
    {
        
        public static IObservable<System.Boolean> IsValidTargetType(this IObservable<System.Security.Principal.IdentityReference> IdentityReferenceValue, IObservable<System.Type> targetType)
        {
            return Observable.Zip(IdentityReferenceValue, targetType, (IdentityReferenceValueLambda, targetTypeLambda) => IdentityReferenceValueLambda.IsValidTargetType(targetTypeLambda));
        }


        public static IObservable<System.Security.Principal.IdentityReference> Translate(this IObservable<System.Security.Principal.IdentityReference> IdentityReferenceValue, IObservable<System.Type> targetType)
        {
            return Observable.Zip(IdentityReferenceValue, targetType, (IdentityReferenceValueLambda, targetTypeLambda) => IdentityReferenceValueLambda.Translate(targetTypeLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Principal.IdentityReference> IdentityReferenceValue, IObservable<System.Object> o)
        {
            return Observable.Zip(IdentityReferenceValue, o, (IdentityReferenceValueLambda, oLambda) => IdentityReferenceValueLambda.Equals(oLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Principal.IdentityReference> IdentityReferenceValue)
        {
            return Observable.Select(IdentityReferenceValue, (IdentityReferenceValueLambda) => IdentityReferenceValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.Principal.IdentityReference> IdentityReferenceValue)
        {
            return Observable.Select(IdentityReferenceValue, (IdentityReferenceValueLambda) => IdentityReferenceValueLambda.ToString());
        }


        public static IObservable<System.String> get_Value(this IObservable<System.Security.Principal.IdentityReference> IdentityReferenceValue)
        {
            return Observable.Select(IdentityReferenceValue, (IdentityReferenceValueLambda) => IdentityReferenceValueLambda.Value);
        }

    }
}