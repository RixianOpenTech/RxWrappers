using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __TypeToken
    {
        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Reflection.Emit.TypeToken> TypeTokenValue)
        {
            return Observable.Select(TypeTokenValue, (TypeTokenValueLambda) => TypeTokenValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.Emit.TypeToken> TypeTokenValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(TypeTokenValue, obj,
                (TypeTokenValueLambda, objLambda) => TypeTokenValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.Emit.TypeToken> TypeTokenValue,
            IObservable<System.Reflection.Emit.TypeToken> obj)
        {
            return Observable.Zip(TypeTokenValue, obj,
                (TypeTokenValueLambda, objLambda) => TypeTokenValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> get_Token(
            this IObservable<System.Reflection.Emit.TypeToken> TypeTokenValue)
        {
            return Observable.Select(TypeTokenValue, (TypeTokenValueLambda) => TypeTokenValueLambda.Token);
        }
    }
}