using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _KeyContainerPermissionAccessEntryCollection
{
    
public static IObservable<System.Int32> Add(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection> KeyContainerPermissionAccessEntryCollectionValue, IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry> accessEntry)
{
    return Observable.Zip(KeyContainerPermissionAccessEntryCollectionValue, accessEntry, (KeyContainerPermissionAccessEntryCollectionValueLambda, accessEntryLambda) => KeyContainerPermissionAccessEntryCollectionValueLambda.Add(accessEntryLambda));
}


public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection> KeyContainerPermissionAccessEntryCollectionValue)
{
    return Observable.Do(KeyContainerPermissionAccessEntryCollectionValue, (KeyContainerPermissionAccessEntryCollectionValueLambda) => KeyContainerPermissionAccessEntryCollectionValueLambda.Clear()).ToUnit();
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection> KeyContainerPermissionAccessEntryCollectionValue, IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry> accessEntry)
{
    return Observable.Zip(KeyContainerPermissionAccessEntryCollectionValue, accessEntry, (KeyContainerPermissionAccessEntryCollectionValueLambda, accessEntryLambda) => KeyContainerPermissionAccessEntryCollectionValueLambda.IndexOf(accessEntryLambda));
}


public static IObservable<System.Reactive.Unit> Remove(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection> KeyContainerPermissionAccessEntryCollectionValue, IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry> accessEntry)
{
    return ObservableExt.ZipExecute(KeyContainerPermissionAccessEntryCollectionValue, accessEntry, (KeyContainerPermissionAccessEntryCollectionValueLambda, accessEntryLambda) => KeyContainerPermissionAccessEntryCollectionValueLambda.Remove(accessEntryLambda));
}


public static IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator> GetEnumerator(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection> KeyContainerPermissionAccessEntryCollectionValue)
{
    return Observable.Select(KeyContainerPermissionAccessEntryCollectionValue, (KeyContainerPermissionAccessEntryCollectionValueLambda) => KeyContainerPermissionAccessEntryCollectionValueLambda.GetEnumerator());
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection> KeyContainerPermissionAccessEntryCollectionValue, IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry[]> array, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(KeyContainerPermissionAccessEntryCollectionValue, array, index, (KeyContainerPermissionAccessEntryCollectionValueLambda, arrayLambda, indexLambda) => KeyContainerPermissionAccessEntryCollectionValueLambda.CopyTo(arrayLambda, indexLambda));
}


public static IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry> get_Item(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection> KeyContainerPermissionAccessEntryCollectionValue, IObservable<System.Int32> index)
{
    return Observable.Zip(KeyContainerPermissionAccessEntryCollectionValue, index, (KeyContainerPermissionAccessEntryCollectionValueLambda, indexLambda) => KeyContainerPermissionAccessEntryCollectionValueLambda.Item);
}


public static IObservable<System.Int32> get_Count(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection> KeyContainerPermissionAccessEntryCollectionValue)
{
    return Observable.Select(KeyContainerPermissionAccessEntryCollectionValue, (KeyContainerPermissionAccessEntryCollectionValueLambda) => KeyContainerPermissionAccessEntryCollectionValueLambda.Count);
}


public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection> KeyContainerPermissionAccessEntryCollectionValue)
{
    return Observable.Select(KeyContainerPermissionAccessEntryCollectionValue, (KeyContainerPermissionAccessEntryCollectionValueLambda) => KeyContainerPermissionAccessEntryCollectionValueLambda.IsSynchronized);
}


public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryCollection> KeyContainerPermissionAccessEntryCollectionValue)
{
    return Observable.Select(KeyContainerPermissionAccessEntryCollectionValue, (KeyContainerPermissionAccessEntryCollectionValueLambda) => KeyContainerPermissionAccessEntryCollectionValueLambda.SyncRoot);
}

}
}