using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
public static class _DictionaryEntry
{
    
public static IObservable<System.Object> get_Key(this IObservable<System.Collections.DictionaryEntry> DictionaryEntryValue)
{
    return Observable.Select(DictionaryEntryValue, (DictionaryEntryValueLambda) => DictionaryEntryValueLambda.Key);
}


public static IObservable<System.Object> get_Value(this IObservable<System.Collections.DictionaryEntry> DictionaryEntryValue)
{
    return Observable.Select(DictionaryEntryValue, (DictionaryEntryValueLambda) => DictionaryEntryValueLambda.Value);
}


public static IObservable<System.Reactive.Unit> set_Key(this IObservable<System.Collections.DictionaryEntry> DictionaryEntryValue, IObservable<System.Object> value)
{
    return ObservableExt.ZipExecute(DictionaryEntryValue, value, (DictionaryEntryValueLambda, valueLambda) => DictionaryEntryValueLambda.Key = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Collections.DictionaryEntry> DictionaryEntryValue, IObservable<System.Object> value)
{
    return ObservableExt.ZipExecute(DictionaryEntryValue, value, (DictionaryEntryValueLambda, valueLambda) => DictionaryEntryValueLambda.Value = valueLambda);
}

}
}