using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _CommonAcl
{
    
public static IObservable<System.Reactive.Unit> GetBinaryForm(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue, IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
{
    return ObservableExt.ZipExecute(CommonAclValue, binaryForm, offset, (CommonAclValueLambda, binaryFormLambda, offsetLambda) => CommonAclValueLambda.GetBinaryForm(binaryFormLambda, offsetLambda));
}


public static IObservable<System.Reactive.Unit> RemoveInheritedAces(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue)
{
    return Observable.Do(CommonAclValue, (CommonAclValueLambda) => CommonAclValueLambda.RemoveInheritedAces()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Purge(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue, IObservable<System.Security.Principal.SecurityIdentifier> sid)
{
    return ObservableExt.ZipExecute(CommonAclValue, sid, (CommonAclValueLambda, sidLambda) => CommonAclValueLambda.Purge(sidLambda));
}


public static IObservable<System.Byte> get_Revision(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue)
{
    return Observable.Select(CommonAclValue, (CommonAclValueLambda) => CommonAclValueLambda.Revision);
}


public static IObservable<System.Int32> get_Count(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue)
{
    return Observable.Select(CommonAclValue, (CommonAclValueLambda) => CommonAclValueLambda.Count);
}


public static IObservable<System.Int32> get_BinaryLength(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue)
{
    return Observable.Select(CommonAclValue, (CommonAclValueLambda) => CommonAclValueLambda.BinaryLength);
}


public static IObservable<System.Boolean> get_IsCanonical(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue)
{
    return Observable.Select(CommonAclValue, (CommonAclValueLambda) => CommonAclValueLambda.IsCanonical);
}


public static IObservable<System.Boolean> get_IsContainer(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue)
{
    return Observable.Select(CommonAclValue, (CommonAclValueLambda) => CommonAclValueLambda.IsContainer);
}


public static IObservable<System.Boolean> get_IsDS(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue)
{
    return Observable.Select(CommonAclValue, (CommonAclValueLambda) => CommonAclValueLambda.IsDS);
}


public static IObservable<System.Security.AccessControl.GenericAce> get_Item(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue, IObservable<System.Int32> index)
{
    return Observable.Zip(CommonAclValue, index, (CommonAclValueLambda, indexLambda) => CommonAclValueLambda.Item);
}


public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Security.AccessControl.CommonAcl> CommonAclValue, IObservable<System.Int32> index, IObservable<System.Security.AccessControl.GenericAce> value)
{
    return ObservableExt.ZipExecute(CommonAclValue, index, value, (CommonAclValueLambda, indexLambda, valueLambda) => CommonAclValueLambda.Item = valueLambda);
}

}
}