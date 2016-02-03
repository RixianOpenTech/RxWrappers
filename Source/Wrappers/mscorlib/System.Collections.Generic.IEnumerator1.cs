using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.Generic
{
    public static class __IEnumerator1
    {
        
        public static IObservable<T> get_Current<T>(this IObservable<System.Collections.Generic.IEnumerator<T>> IEnumeratorValue)
        {
            return Observable.Select(IEnumeratorValue, (IEnumeratorValueLambda) => IEnumeratorValueLambda.Current);
        }

    }
}