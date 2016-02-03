using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __StringToken
    {
        
        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.StringToken> StringTokenValue)
        {
            return Observable.Select(StringTokenValue, (StringTokenValueLambda) => StringTokenValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.StringToken> StringTokenValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(StringTokenValue, obj, (StringTokenValueLambda, objLambda) => StringTokenValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.StringToken> StringTokenValue, IObservable<System.Reflection.Emit.StringToken> obj)
        {
            return Observable.Zip(StringTokenValue, obj, (StringTokenValueLambda, objLambda) => StringTokenValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> get_Token(this IObservable<System.Reflection.Emit.StringToken> StringTokenValue)
        {
            return Observable.Select(StringTokenValue, (StringTokenValueLambda) => StringTokenValueLambda.Token);
        }

    }
}