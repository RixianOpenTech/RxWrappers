using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __IDictionaryEnumerator
    {
        
        public static IObservable<System.Object> get_Key(this IObservable<System.Collections.IDictionaryEnumerator> IDictionaryEnumeratorValue)
        {
            return Observable.Select(IDictionaryEnumeratorValue, (IDictionaryEnumeratorValueLambda) => IDictionaryEnumeratorValueLambda.Key);
        }


        public static IObservable<System.Object> get_Value(this IObservable<System.Collections.IDictionaryEnumerator> IDictionaryEnumeratorValue)
        {
            return Observable.Select(IDictionaryEnumeratorValue, (IDictionaryEnumeratorValueLambda) => IDictionaryEnumeratorValueLambda.Value);
        }


        public static IObservable<System.Collections.DictionaryEntry> get_Entry(this IObservable<System.Collections.IDictionaryEnumerator> IDictionaryEnumeratorValue)
        {
            return Observable.Select(IDictionaryEnumeratorValue, (IDictionaryEnumeratorValueLambda) => IDictionaryEnumeratorValueLambda.Entry);
        }

    }
}