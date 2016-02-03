using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
public static class _PermissionSet
{
    
public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Security.PermissionSet> PermissionSetValue, IObservable<System.Array> array, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(PermissionSetValue, array, index, (PermissionSetValueLambda, arrayLambda, indexLambda) => PermissionSetValueLambda.CopyTo(arrayLambda, indexLambda));
}


public static IObservable<System.Boolean> IsEmpty(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.IsEmpty());
}


public static IObservable<System.Security.IPermission> GetPermission(this IObservable<System.Security.PermissionSet> PermissionSetValue, IObservable<System.Type> permClass)
{
    return Observable.Zip(PermissionSetValue, permClass, (PermissionSetValueLambda, permClassLambda) => PermissionSetValueLambda.GetPermission(permClassLambda));
}


public static IObservable<System.Security.IPermission> SetPermission(this IObservable<System.Security.PermissionSet> PermissionSetValue, IObservable<System.Security.IPermission> perm)
{
    return Observable.Zip(PermissionSetValue, perm, (PermissionSetValueLambda, permLambda) => PermissionSetValueLambda.SetPermission(permLambda));
}


public static IObservable<System.Security.IPermission> AddPermission(this IObservable<System.Security.PermissionSet> PermissionSetValue, IObservable<System.Security.IPermission> perm)
{
    return Observable.Zip(PermissionSetValue, perm, (PermissionSetValueLambda, permLambda) => PermissionSetValueLambda.AddPermission(permLambda));
}


public static IObservable<System.Security.IPermission> RemovePermission(this IObservable<System.Security.PermissionSet> PermissionSetValue, IObservable<System.Type> permClass)
{
    return Observable.Zip(PermissionSetValue, permClass, (PermissionSetValueLambda, permClassLambda) => PermissionSetValueLambda.RemovePermission(permClassLambda));
}


public static IObservable<System.Boolean> IsUnrestricted(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.IsUnrestricted());
}


public static IObservable<System.Boolean> IsSubsetOf(this IObservable<System.Security.PermissionSet> PermissionSetValue, IObservable<System.Security.PermissionSet> target)
{
    return Observable.Zip(PermissionSetValue, target, (PermissionSetValueLambda, targetLambda) => PermissionSetValueLambda.IsSubsetOf(targetLambda));
}


public static IObservable<System.Security.PermissionSet> Intersect(this IObservable<System.Security.PermissionSet> PermissionSetValue, IObservable<System.Security.PermissionSet> other)
{
    return Observable.Zip(PermissionSetValue, other, (PermissionSetValueLambda, otherLambda) => PermissionSetValueLambda.Intersect(otherLambda));
}


public static IObservable<System.Security.PermissionSet> Union(this IObservable<System.Security.PermissionSet> PermissionSetValue, IObservable<System.Security.PermissionSet> other)
{
    return Observable.Zip(PermissionSetValue, other, (PermissionSetValueLambda, otherLambda) => PermissionSetValueLambda.Union(otherLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.PermissionSet> PermissionSetValue, IObservable<System.Object> obj)
{
    return Observable.Zip(PermissionSetValue, obj, (PermissionSetValueLambda, objLambda) => PermissionSetValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.GetHashCode());
}


public static IObservable<System.Reactive.Unit> Demand(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Do(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.Demand()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Assert(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Do(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.Assert()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Deny(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Do(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.Deny()).ToUnit();
}


public static IObservable<System.Reactive.Unit> PermitOnly(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Do(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.PermitOnly()).ToUnit();
}


public static IObservable<System.Security.PermissionSet> Copy(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.Copy());
}


public static IObservable<System.Collections.IEnumerator> GetEnumerator(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.GetEnumerator());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.ToString());
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.PermissionSet> PermissionSetValue, IObservable<System.Security.SecurityElement> et)
{
    return ObservableExt.ZipExecute(PermissionSetValue, et, (PermissionSetValueLambda, etLambda) => PermissionSetValueLambda.FromXml(etLambda));
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.ToXml());
}


public static IObservable<System.Byte[]> ConvertPermissionSet(IObservable<System.String> inFormat, IObservable<System.Byte[]> inData, IObservable<System.String> outFormat)
{
    return Observable.Zip(inFormat, inData, outFormat, (inFormatLambda, inDataLambda, outFormatLambda) => System.Security.PermissionSet.ConvertPermissionSet(inFormatLambda, inDataLambda, outFormatLambda));
}


public static IObservable<System.Boolean> ContainsNonCodeAccessPermissions(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.ContainsNonCodeAccessPermissions());
}


public static IObservable<System.Reactive.Unit> RevertAssert()
{
    return ObservableExt.Factory(() => System.Security.PermissionSet.RevertAssert());
}


public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.SyncRoot);
}


public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.IsSynchronized);
}


public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.IsReadOnly);
}


public static IObservable<System.Int32> get_Count(this IObservable<System.Security.PermissionSet> PermissionSetValue)
{
    return Observable.Select(PermissionSetValue, (PermissionSetValueLambda) => PermissionSetValueLambda.Count);
}

}
}