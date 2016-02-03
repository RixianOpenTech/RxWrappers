using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _GenericAce
{
    
public static IObservable<System.Security.AccessControl.GenericAce> CreateFromBinaryForm(IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
{
    return Observable.Zip(binaryForm, offset, (binaryFormLambda, offsetLambda) => System.Security.AccessControl.GenericAce.CreateFromBinaryForm(binaryFormLambda, offsetLambda));
}


public static IObservable<System.Reactive.Unit> GetBinaryForm(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue, IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
{
    return ObservableExt.ZipExecute(GenericAceValue, binaryForm, offset, (GenericAceValueLambda, binaryFormLambda, offsetLambda) => GenericAceValueLambda.GetBinaryForm(binaryFormLambda, offsetLambda));
}


public static IObservable<System.Security.AccessControl.GenericAce> Copy(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue)
{
    return Observable.Select(GenericAceValue, (GenericAceValueLambda) => GenericAceValueLambda.Copy());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue, IObservable<System.Object> o)
{
    return Observable.Zip(GenericAceValue, o, (GenericAceValueLambda, oLambda) => GenericAceValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue)
{
    return Observable.Select(GenericAceValue, (GenericAceValueLambda) => GenericAceValueLambda.GetHashCode());
}


public static IObservable<System.Security.AccessControl.AceType> get_AceType(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue)
{
    return Observable.Select(GenericAceValue, (GenericAceValueLambda) => GenericAceValueLambda.AceType);
}


public static IObservable<System.Security.AccessControl.AceFlags> get_AceFlags(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue)
{
    return Observable.Select(GenericAceValue, (GenericAceValueLambda) => GenericAceValueLambda.AceFlags);
}


public static IObservable<System.Boolean> get_IsInherited(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue)
{
    return Observable.Select(GenericAceValue, (GenericAceValueLambda) => GenericAceValueLambda.IsInherited);
}


public static IObservable<System.Security.AccessControl.InheritanceFlags> get_InheritanceFlags(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue)
{
    return Observable.Select(GenericAceValue, (GenericAceValueLambda) => GenericAceValueLambda.InheritanceFlags);
}


public static IObservable<System.Security.AccessControl.PropagationFlags> get_PropagationFlags(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue)
{
    return Observable.Select(GenericAceValue, (GenericAceValueLambda) => GenericAceValueLambda.PropagationFlags);
}


public static IObservable<System.Security.AccessControl.AuditFlags> get_AuditFlags(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue)
{
    return Observable.Select(GenericAceValue, (GenericAceValueLambda) => GenericAceValueLambda.AuditFlags);
}


public static IObservable<System.Int32> get_BinaryLength(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue)
{
    return Observable.Select(GenericAceValue, (GenericAceValueLambda) => GenericAceValueLambda.BinaryLength);
}


public static IObservable<System.Reactive.Unit> set_AceFlags(this IObservable<System.Security.AccessControl.GenericAce> GenericAceValue, IObservable<System.Security.AccessControl.AceFlags> value)
{
    return ObservableExt.ZipExecute(GenericAceValue, value, (GenericAceValueLambda, valueLambda) => GenericAceValueLambda.AceFlags = valueLambda);
}

}
}