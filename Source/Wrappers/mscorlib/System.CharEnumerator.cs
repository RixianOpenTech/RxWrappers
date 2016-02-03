using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __CharEnumerator
    {
        public static IObservable<System.Object> Clone(this IObservable<System.CharEnumerator> CharEnumeratorValue)
        {
            return Observable.Select(CharEnumeratorValue,
                (CharEnumeratorValueLambda) => CharEnumeratorValueLambda.Clone());
        }


        public static IObservable<System.Boolean> MoveNext(this IObservable<System.CharEnumerator> CharEnumeratorValue)
        {
            return Observable.Select(CharEnumeratorValue,
                (CharEnumeratorValueLambda) => CharEnumeratorValueLambda.MoveNext());
        }


        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.CharEnumerator> CharEnumeratorValue)
        {
            return
                Observable.Do(CharEnumeratorValue, (CharEnumeratorValueLambda) => CharEnumeratorValueLambda.Dispose())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Reset(
            this IObservable<System.CharEnumerator> CharEnumeratorValue)
        {
            return
                Observable.Do(CharEnumeratorValue, (CharEnumeratorValueLambda) => CharEnumeratorValueLambda.Reset())
                    .ToUnit();
        }


        public static IObservable<System.Char> get_Current(this IObservable<System.CharEnumerator> CharEnumeratorValue)
        {
            return Observable.Select(CharEnumeratorValue,
                (CharEnumeratorValueLambda) => CharEnumeratorValueLambda.Current);
        }
    }
}