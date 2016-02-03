using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _ZoneMembershipCondition
{
    
public static IObservable<System.Boolean> Check(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(ZoneMembershipConditionValue, evidence, (ZoneMembershipConditionValueLambda, evidenceLambda) => ZoneMembershipConditionValueLambda.Check(evidenceLambda));
}


public static IObservable<System.Security.Policy.IMembershipCondition> Copy(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue)
{
    return Observable.Select(ZoneMembershipConditionValue, (ZoneMembershipConditionValueLambda) => ZoneMembershipConditionValueLambda.Copy());
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue)
{
    return Observable.Select(ZoneMembershipConditionValue, (ZoneMembershipConditionValueLambda) => ZoneMembershipConditionValueLambda.ToXml());
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue, IObservable<System.Security.SecurityElement> e)
{
    return ObservableExt.ZipExecute(ZoneMembershipConditionValue, e, (ZoneMembershipConditionValueLambda, eLambda) => ZoneMembershipConditionValueLambda.FromXml(eLambda));
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue, IObservable<System.Security.Policy.PolicyLevel> level)
{
    return Observable.Zip(ZoneMembershipConditionValue, level, (ZoneMembershipConditionValueLambda, levelLambda) => ZoneMembershipConditionValueLambda.ToXml(levelLambda));
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue, IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
{
    return ObservableExt.ZipExecute(ZoneMembershipConditionValue, e, level, (ZoneMembershipConditionValueLambda, eLambda, levelLambda) => ZoneMembershipConditionValueLambda.FromXml(eLambda, levelLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue, IObservable<System.Object> o)
{
    return Observable.Zip(ZoneMembershipConditionValue, o, (ZoneMembershipConditionValueLambda, oLambda) => ZoneMembershipConditionValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue)
{
    return Observable.Select(ZoneMembershipConditionValue, (ZoneMembershipConditionValueLambda) => ZoneMembershipConditionValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue)
{
    return Observable.Select(ZoneMembershipConditionValue, (ZoneMembershipConditionValueLambda) => ZoneMembershipConditionValueLambda.ToString());
}


public static IObservable<System.Security.SecurityZone> get_SecurityZone(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue)
{
    return Observable.Select(ZoneMembershipConditionValue, (ZoneMembershipConditionValueLambda) => ZoneMembershipConditionValueLambda.SecurityZone);
}


public static IObservable<System.Reactive.Unit> set_SecurityZone(this IObservable<System.Security.Policy.ZoneMembershipCondition> ZoneMembershipConditionValue, IObservable<System.Security.SecurityZone> value)
{
    return ObservableExt.ZipExecute(ZoneMembershipConditionValue, value, (ZoneMembershipConditionValueLambda, valueLambda) => ZoneMembershipConditionValueLambda.SecurityZone = valueLambda);
}

}
}