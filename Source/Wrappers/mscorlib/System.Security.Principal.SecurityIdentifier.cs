using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
public static class _SecurityIdentifier
{
    
public static IObservable<System.Security.Principal.IdentityReference> Translate(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue, IObservable<System.Type> targetType)
{
    return Observable.Zip(SecurityIdentifierValue, targetType, (SecurityIdentifierValueLambda, targetTypeLambda) => SecurityIdentifierValueLambda.Translate(targetTypeLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue, IObservable<System.Object> o)
{
    return Observable.Zip(SecurityIdentifierValue, o, (SecurityIdentifierValueLambda, oLambda) => SecurityIdentifierValueLambda.Equals(oLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue, IObservable<System.Security.Principal.SecurityIdentifier> sid)
{
    return Observable.Zip(SecurityIdentifierValue, sid, (SecurityIdentifierValueLambda, sidLambda) => SecurityIdentifierValueLambda.Equals(sidLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue)
{
    return Observable.Select(SecurityIdentifierValue, (SecurityIdentifierValueLambda) => SecurityIdentifierValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue)
{
    return Observable.Select(SecurityIdentifierValue, (SecurityIdentifierValueLambda) => SecurityIdentifierValueLambda.ToString());
}


public static IObservable<System.Boolean> IsValidTargetType(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue, IObservable<System.Type> targetType)
{
    return Observable.Zip(SecurityIdentifierValue, targetType, (SecurityIdentifierValueLambda, targetTypeLambda) => SecurityIdentifierValueLambda.IsValidTargetType(targetTypeLambda));
}


public static IObservable<System.Boolean> IsAccountSid(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue)
{
    return Observable.Select(SecurityIdentifierValue, (SecurityIdentifierValueLambda) => SecurityIdentifierValueLambda.IsAccountSid());
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue, IObservable<System.Security.Principal.SecurityIdentifier> sid)
{
    return Observable.Zip(SecurityIdentifierValue, sid, (SecurityIdentifierValueLambda, sidLambda) => SecurityIdentifierValueLambda.CompareTo(sidLambda));
}


public static IObservable<System.Boolean> IsWellKnown(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue, IObservable<System.Security.Principal.WellKnownSidType> type)
{
    return Observable.Zip(SecurityIdentifierValue, type, (SecurityIdentifierValueLambda, typeLambda) => SecurityIdentifierValueLambda.IsWellKnown(typeLambda));
}


public static IObservable<System.Reactive.Unit> GetBinaryForm(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue, IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
{
    return ObservableExt.ZipExecute(SecurityIdentifierValue, binaryForm, offset, (SecurityIdentifierValueLambda, binaryFormLambda, offsetLambda) => SecurityIdentifierValueLambda.GetBinaryForm(binaryFormLambda, offsetLambda));
}


public static IObservable<System.Boolean> IsEqualDomainSid(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue, IObservable<System.Security.Principal.SecurityIdentifier> sid)
{
    return Observable.Zip(SecurityIdentifierValue, sid, (SecurityIdentifierValueLambda, sidLambda) => SecurityIdentifierValueLambda.IsEqualDomainSid(sidLambda));
}


public static IObservable<System.Int32> get_BinaryLength(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue)
{
    return Observable.Select(SecurityIdentifierValue, (SecurityIdentifierValueLambda) => SecurityIdentifierValueLambda.BinaryLength);
}


public static IObservable<System.Security.Principal.SecurityIdentifier> get_AccountDomainSid(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue)
{
    return Observable.Select(SecurityIdentifierValue, (SecurityIdentifierValueLambda) => SecurityIdentifierValueLambda.AccountDomainSid);
}


public static IObservable<System.String> get_Value(this IObservable<System.Security.Principal.SecurityIdentifier> SecurityIdentifierValue)
{
    return Observable.Select(SecurityIdentifierValue, (SecurityIdentifierValueLambda) => SecurityIdentifierValueLambda.Value);
}

}
}