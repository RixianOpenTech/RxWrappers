using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __LockCookie
    {
        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Threading.LockCookie> LockCookieValue)
        {
            return Observable.Select(LockCookieValue, (LockCookieValueLambda) => LockCookieValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Threading.LockCookie> LockCookieValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(LockCookieValue, obj,
                (LockCookieValueLambda, objLambda) => LockCookieValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Threading.LockCookie> LockCookieValue,
            IObservable<System.Threading.LockCookie> obj)
        {
            return Observable.Zip(LockCookieValue, obj,
                (LockCookieValueLambda, objLambda) => LockCookieValueLambda.Equals(objLambda));
        }
    }
}