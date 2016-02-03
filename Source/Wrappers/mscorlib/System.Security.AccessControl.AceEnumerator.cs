using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __AceEnumerator
    {
        public static IObservable<System.Boolean> MoveNext(
            this IObservable<System.Security.AccessControl.AceEnumerator> AceEnumeratorValue)
        {
            return Observable.Select(AceEnumeratorValue,
                (AceEnumeratorValueLambda) => AceEnumeratorValueLambda.MoveNext());
        }


        public static IObservable<System.Reactive.Unit> Reset(
            this IObservable<System.Security.AccessControl.AceEnumerator> AceEnumeratorValue)
        {
            return
                Observable.Do(AceEnumeratorValue, (AceEnumeratorValueLambda) => AceEnumeratorValueLambda.Reset())
                    .ToUnit();
        }


        public static IObservable<System.Security.AccessControl.GenericAce> get_Current(
            this IObservable<System.Security.AccessControl.AceEnumerator> AceEnumeratorValue)
        {
            return Observable.Select(AceEnumeratorValue, (AceEnumeratorValueLambda) => AceEnumeratorValueLambda.Current);
        }
    }
}