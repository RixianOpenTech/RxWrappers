using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
public static class _KeyContainerPermissionAccessEntryEnumerator
{
    
public static IObservable<System.Boolean> MoveNext(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator> KeyContainerPermissionAccessEntryEnumeratorValue)
{
    return Observable.Select(KeyContainerPermissionAccessEntryEnumeratorValue, (KeyContainerPermissionAccessEntryEnumeratorValueLambda) => KeyContainerPermissionAccessEntryEnumeratorValueLambda.MoveNext());
}


public static IObservable<System.Reactive.Unit> Reset(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator> KeyContainerPermissionAccessEntryEnumeratorValue)
{
    return Observable.Do(KeyContainerPermissionAccessEntryEnumeratorValue, (KeyContainerPermissionAccessEntryEnumeratorValueLambda) => KeyContainerPermissionAccessEntryEnumeratorValueLambda.Reset()).ToUnit();
}


public static IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntry> get_Current(this IObservable<System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator> KeyContainerPermissionAccessEntryEnumeratorValue)
{
    return Observable.Select(KeyContainerPermissionAccessEntryEnumeratorValue, (KeyContainerPermissionAccessEntryEnumeratorValueLambda) => KeyContainerPermissionAccessEntryEnumeratorValueLambda.Current);
}

}
}