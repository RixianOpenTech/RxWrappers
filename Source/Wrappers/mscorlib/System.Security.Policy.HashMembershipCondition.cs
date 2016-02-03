using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _HashMembershipCondition
{
    
public static IObservable<System.Boolean> Check(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(HashMembershipConditionValue, evidence, (HashMembershipConditionValueLambda, evidenceLambda) => HashMembershipConditionValueLambda.Check(evidenceLambda));
}


public static IObservable<System.Security.Policy.IMembershipCondition> Copy(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue)
{
    return Observable.Select(HashMembershipConditionValue, (HashMembershipConditionValueLambda) => HashMembershipConditionValueLambda.Copy());
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue)
{
    return Observable.Select(HashMembershipConditionValue, (HashMembershipConditionValueLambda) => HashMembershipConditionValueLambda.ToXml());
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue, IObservable<System.Security.SecurityElement> e)
{
    return ObservableExt.ZipExecute(HashMembershipConditionValue, e, (HashMembershipConditionValueLambda, eLambda) => HashMembershipConditionValueLambda.FromXml(eLambda));
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue, IObservable<System.Security.Policy.PolicyLevel> level)
{
    return Observable.Zip(HashMembershipConditionValue, level, (HashMembershipConditionValueLambda, levelLambda) => HashMembershipConditionValueLambda.ToXml(levelLambda));
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue, IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
{
    return ObservableExt.ZipExecute(HashMembershipConditionValue, e, level, (HashMembershipConditionValueLambda, eLambda, levelLambda) => HashMembershipConditionValueLambda.FromXml(eLambda, levelLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue, IObservable<System.Object> o)
{
    return Observable.Zip(HashMembershipConditionValue, o, (HashMembershipConditionValueLambda, oLambda) => HashMembershipConditionValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue)
{
    return Observable.Select(HashMembershipConditionValue, (HashMembershipConditionValueLambda) => HashMembershipConditionValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue)
{
    return Observable.Select(HashMembershipConditionValue, (HashMembershipConditionValueLambda) => HashMembershipConditionValueLambda.ToString());
}


public static IObservable<System.Security.Cryptography.HashAlgorithm> get_HashAlgorithm(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue)
{
    return Observable.Select(HashMembershipConditionValue, (HashMembershipConditionValueLambda) => HashMembershipConditionValueLambda.HashAlgorithm);
}


public static IObservable<System.Byte[]> get_HashValue(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue)
{
    return Observable.Select(HashMembershipConditionValue, (HashMembershipConditionValueLambda) => HashMembershipConditionValueLambda.HashValue);
}


public static IObservable<System.Reactive.Unit> set_HashAlgorithm(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue, IObservable<System.Security.Cryptography.HashAlgorithm> value)
{
    return ObservableExt.ZipExecute(HashMembershipConditionValue, value, (HashMembershipConditionValueLambda, valueLambda) => HashMembershipConditionValueLambda.HashAlgorithm = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_HashValue(this IObservable<System.Security.Policy.HashMembershipCondition> HashMembershipConditionValue, IObservable<System.Byte[]> value)
{
    return ObservableExt.ZipExecute(HashMembershipConditionValue, value, (HashMembershipConditionValueLambda, valueLambda) => HashMembershipConditionValueLambda.HashValue = valueLambda);
}

}
}