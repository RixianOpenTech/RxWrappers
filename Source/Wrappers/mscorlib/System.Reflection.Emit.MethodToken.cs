using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __MethodToken
    {
        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Reflection.Emit.MethodToken> MethodTokenValue)
        {
            return Observable.Select(MethodTokenValue, (MethodTokenValueLambda) => MethodTokenValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.Emit.MethodToken> MethodTokenValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(MethodTokenValue, obj,
                (MethodTokenValueLambda, objLambda) => MethodTokenValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.Emit.MethodToken> MethodTokenValue,
            IObservable<System.Reflection.Emit.MethodToken> obj)
        {
            return Observable.Zip(MethodTokenValue, obj,
                (MethodTokenValueLambda, objLambda) => MethodTokenValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> get_Token(
            this IObservable<System.Reflection.Emit.MethodToken> MethodTokenValue)
        {
            return Observable.Select(MethodTokenValue, (MethodTokenValueLambda) => MethodTokenValueLambda.Token);
        }
    }
}