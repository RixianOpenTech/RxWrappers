using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __EventToken
    {
        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Reflection.Emit.EventToken> EventTokenValue)
        {
            return Observable.Select(EventTokenValue, (EventTokenValueLambda) => EventTokenValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.Emit.EventToken> EventTokenValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(EventTokenValue, obj,
                (EventTokenValueLambda, objLambda) => EventTokenValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Reflection.Emit.EventToken> EventTokenValue,
            IObservable<System.Reflection.Emit.EventToken> obj)
        {
            return Observable.Zip(EventTokenValue, obj,
                (EventTokenValueLambda, objLambda) => EventTokenValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> get_Token(
            this IObservable<System.Reflection.Emit.EventToken> EventTokenValue)
        {
            return Observable.Select(EventTokenValue, (EventTokenValueLambda) => EventTokenValueLambda.Token);
        }
    }
}