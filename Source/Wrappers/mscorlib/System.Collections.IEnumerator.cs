using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __IEnumerator
    {
        
        public static IObservable<System.Boolean> MoveNext(this IObservable<System.Collections.IEnumerator> IEnumeratorValue)
        {
            return Observable.Select(IEnumeratorValue, (IEnumeratorValueLambda) => IEnumeratorValueLambda.MoveNext());
        }


        public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Collections.IEnumerator> IEnumeratorValue)
        {
            return Observable.Do(IEnumeratorValue, (IEnumeratorValueLambda) => IEnumeratorValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Object> get_Current(this IObservable<System.Collections.IEnumerator> IEnumeratorValue)
        {
            return Observable.Select(IEnumeratorValue, (IEnumeratorValueLambda) => IEnumeratorValueLambda.Current);
        }

    }
}