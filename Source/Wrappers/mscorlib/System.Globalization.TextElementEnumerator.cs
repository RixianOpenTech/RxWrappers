using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __TextElementEnumerator
    {
        public static IObservable<System.Boolean> MoveNext(
            this IObservable<System.Globalization.TextElementEnumerator> TextElementEnumeratorValue)
        {
            return Observable.Select(TextElementEnumeratorValue,
                (TextElementEnumeratorValueLambda) => TextElementEnumeratorValueLambda.MoveNext());
        }


        public static IObservable<System.String> GetTextElement(
            this IObservable<System.Globalization.TextElementEnumerator> TextElementEnumeratorValue)
        {
            return Observable.Select(TextElementEnumeratorValue,
                (TextElementEnumeratorValueLambda) => TextElementEnumeratorValueLambda.GetTextElement());
        }


        public static IObservable<System.Reactive.Unit> Reset(
            this IObservable<System.Globalization.TextElementEnumerator> TextElementEnumeratorValue)
        {
            return
                Observable.Do(TextElementEnumeratorValue,
                    (TextElementEnumeratorValueLambda) => TextElementEnumeratorValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Object> get_Current(
            this IObservable<System.Globalization.TextElementEnumerator> TextElementEnumeratorValue)
        {
            return Observable.Select(TextElementEnumeratorValue,
                (TextElementEnumeratorValueLambda) => TextElementEnumeratorValueLambda.Current);
        }


        public static IObservable<System.Int32> get_ElementIndex(
            this IObservable<System.Globalization.TextElementEnumerator> TextElementEnumeratorValue)
        {
            return Observable.Select(TextElementEnumeratorValue,
                (TextElementEnumeratorValueLambda) => TextElementEnumeratorValueLambda.ElementIndex);
        }
    }
}