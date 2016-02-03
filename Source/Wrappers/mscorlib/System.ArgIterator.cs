using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __ArgIterator
    {
        
        public static IObservable<System.TypedReference> GetNextArg(this IObservable<System.ArgIterator> ArgIteratorValue)
        {
            return Observable.Select(ArgIteratorValue, (ArgIteratorValueLambda) => ArgIteratorValueLambda.GetNextArg());
        }


        public static IObservable<System.TypedReference> GetNextArg(this IObservable<System.ArgIterator> ArgIteratorValue, IObservable<System.RuntimeTypeHandle> rth)
        {
            return Observable.Zip(ArgIteratorValue, rth, (ArgIteratorValueLambda, rthLambda) => ArgIteratorValueLambda.GetNextArg(rthLambda));
        }


        public static IObservable<System.Reactive.Unit> End(this IObservable<System.ArgIterator> ArgIteratorValue)
        {
            return Observable.Do(ArgIteratorValue, (ArgIteratorValueLambda) => ArgIteratorValueLambda.End()).ToUnit();
        }


        public static IObservable<System.Int32> GetRemainingCount(this IObservable<System.ArgIterator> ArgIteratorValue)
        {
            return Observable.Select(ArgIteratorValue, (ArgIteratorValueLambda) => ArgIteratorValueLambda.GetRemainingCount());
        }


        public static IObservable<System.RuntimeTypeHandle> GetNextArgType(this IObservable<System.ArgIterator> ArgIteratorValue)
        {
            return Observable.Select(ArgIteratorValue, (ArgIteratorValueLambda) => ArgIteratorValueLambda.GetNextArgType());
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.ArgIterator> ArgIteratorValue)
        {
            return Observable.Select(ArgIteratorValue, (ArgIteratorValueLambda) => ArgIteratorValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.ArgIterator> ArgIteratorValue, IObservable<System.Object> o)
        {
            return Observable.Zip(ArgIteratorValue, o, (ArgIteratorValueLambda, oLambda) => ArgIteratorValueLambda.Equals(oLambda));
        }

    }
}