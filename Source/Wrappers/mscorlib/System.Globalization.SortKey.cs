using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
public static class _SortKey
{
    
public static IObservable<System.Int32> Compare(IObservable<System.Globalization.SortKey> sortkey1, IObservable<System.Globalization.SortKey> sortkey2)
{
    return Observable.Zip(sortkey1, sortkey2, (sortkey1Lambda, sortkey2Lambda) => System.Globalization.SortKey.Compare(sortkey1Lambda, sortkey2Lambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Globalization.SortKey> SortKeyValue, IObservable<System.Object> value)
{
    return Observable.Zip(SortKeyValue, value, (SortKeyValueLambda, valueLambda) => SortKeyValueLambda.Equals(valueLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Globalization.SortKey> SortKeyValue)
{
    return Observable.Select(SortKeyValue, (SortKeyValueLambda) => SortKeyValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Globalization.SortKey> SortKeyValue)
{
    return Observable.Select(SortKeyValue, (SortKeyValueLambda) => SortKeyValueLambda.ToString());
}


public static IObservable<System.String> get_OriginalString(this IObservable<System.Globalization.SortKey> SortKeyValue)
{
    return Observable.Select(SortKeyValue, (SortKeyValueLambda) => SortKeyValueLambda.OriginalString);
}


public static IObservable<System.Byte[]> get_KeyData(this IObservable<System.Globalization.SortKey> SortKeyValue)
{
    return Observable.Select(SortKeyValue, (SortKeyValueLambda) => SortKeyValueLambda.KeyData);
}

}
}