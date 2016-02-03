using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _ObjectAce
{
    
public static IObservable<System.Int32> MaxOpaqueLength(IObservable<System.Boolean> isCallback)
{
    return Observable.Select(isCallback, (isCallbackLambda) => System.Security.AccessControl.ObjectAce.MaxOpaqueLength(isCallbackLambda));
}


public static IObservable<System.Reactive.Unit> GetBinaryForm(this IObservable<System.Security.AccessControl.ObjectAce> ObjectAceValue, IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
{
    return ObservableExt.ZipExecute(ObjectAceValue, binaryForm, offset, (ObjectAceValueLambda, binaryFormLambda, offsetLambda) => ObjectAceValueLambda.GetBinaryForm(binaryFormLambda, offsetLambda));
}


public static IObservable<System.Security.AccessControl.ObjectAceFlags> get_ObjectAceFlags(this IObservable<System.Security.AccessControl.ObjectAce> ObjectAceValue)
{
    return Observable.Select(ObjectAceValue, (ObjectAceValueLambda) => ObjectAceValueLambda.ObjectAceFlags);
}


public static IObservable<System.Guid> get_ObjectAceType(this IObservable<System.Security.AccessControl.ObjectAce> ObjectAceValue)
{
    return Observable.Select(ObjectAceValue, (ObjectAceValueLambda) => ObjectAceValueLambda.ObjectAceType);
}


public static IObservable<System.Guid> get_InheritedObjectAceType(this IObservable<System.Security.AccessControl.ObjectAce> ObjectAceValue)
{
    return Observable.Select(ObjectAceValue, (ObjectAceValueLambda) => ObjectAceValueLambda.InheritedObjectAceType);
}


public static IObservable<System.Int32> get_BinaryLength(this IObservable<System.Security.AccessControl.ObjectAce> ObjectAceValue)
{
    return Observable.Select(ObjectAceValue, (ObjectAceValueLambda) => ObjectAceValueLambda.BinaryLength);
}


public static IObservable<System.Reactive.Unit> set_ObjectAceFlags(this IObservable<System.Security.AccessControl.ObjectAce> ObjectAceValue, IObservable<System.Security.AccessControl.ObjectAceFlags> value)
{
    return ObservableExt.ZipExecute(ObjectAceValue, value, (ObjectAceValueLambda, valueLambda) => ObjectAceValueLambda.ObjectAceFlags = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ObjectAceType(this IObservable<System.Security.AccessControl.ObjectAce> ObjectAceValue, IObservable<System.Guid> value)
{
    return ObservableExt.ZipExecute(ObjectAceValue, value, (ObjectAceValueLambda, valueLambda) => ObjectAceValueLambda.ObjectAceType = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_InheritedObjectAceType(this IObservable<System.Security.AccessControl.ObjectAce> ObjectAceValue, IObservable<System.Guid> value)
{
    return ObservableExt.ZipExecute(ObjectAceValue, value, (ObjectAceValueLambda, valueLambda) => ObjectAceValueLambda.InheritedObjectAceType = valueLambda);
}

}
}