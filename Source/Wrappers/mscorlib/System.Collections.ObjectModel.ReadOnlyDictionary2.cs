using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections.ObjectModel
{
public static class _ReadOnlyDictionary2
{
    
public static IObservable<IEnumerator<KeyValuePair<TKey, TValue>>> GetEnumerator<TKey, TValue>(this IObservable<System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>> ReadOnlyDictionaryValue)
{
    return Observable.Select(ReadOnlyDictionaryValue, (ReadOnlyDictionaryValueLambda) => ReadOnlyDictionaryValueLambda.GetEnumerator());
}


public static IObservable<System.Boolean> ContainsKey<TKey, TValue>(this IObservable<System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>> ReadOnlyDictionaryValue, IObservable<TKey> key)
{
    return Observable.Zip(ReadOnlyDictionaryValue, key, (ReadOnlyDictionaryValueLambda, keyLambda) => ReadOnlyDictionaryValueLambda.ContainsKey(keyLambda));
}


public static IObservable<Tuple<System.Boolean, TValue>> TryGetValue<TKey, TValue>(this IObservable<System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>> ReadOnlyDictionaryValue, IObservable<TKey> key)
{
    return Observable.Zip(ReadOnlyDictionaryValue, key, (ReadOnlyDictionaryValueLambda, keyLambda) => {
TValue valueOutput = default(TValue);
var result = ReadOnlyDictionaryValueLambda.TryGetValue(keyLambda, out valueOutput);
return Tuple.Create(result, valueOutput);
});
}

}
}