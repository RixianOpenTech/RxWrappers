using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _SiteMembershipCondition
{
    
public static IObservable<System.Boolean> Check(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(SiteMembershipConditionValue, evidence, (SiteMembershipConditionValueLambda, evidenceLambda) => SiteMembershipConditionValueLambda.Check(evidenceLambda));
}


public static IObservable<System.Security.Policy.IMembershipCondition> Copy(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue)
{
    return Observable.Select(SiteMembershipConditionValue, (SiteMembershipConditionValueLambda) => SiteMembershipConditionValueLambda.Copy());
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue)
{
    return Observable.Select(SiteMembershipConditionValue, (SiteMembershipConditionValueLambda) => SiteMembershipConditionValueLambda.ToXml());
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue, IObservable<System.Security.SecurityElement> e)
{
    return ObservableExt.ZipExecute(SiteMembershipConditionValue, e, (SiteMembershipConditionValueLambda, eLambda) => SiteMembershipConditionValueLambda.FromXml(eLambda));
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue, IObservable<System.Security.Policy.PolicyLevel> level)
{
    return Observable.Zip(SiteMembershipConditionValue, level, (SiteMembershipConditionValueLambda, levelLambda) => SiteMembershipConditionValueLambda.ToXml(levelLambda));
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue, IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
{
    return ObservableExt.ZipExecute(SiteMembershipConditionValue, e, level, (SiteMembershipConditionValueLambda, eLambda, levelLambda) => SiteMembershipConditionValueLambda.FromXml(eLambda, levelLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue, IObservable<System.Object> o)
{
    return Observable.Zip(SiteMembershipConditionValue, o, (SiteMembershipConditionValueLambda, oLambda) => SiteMembershipConditionValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue)
{
    return Observable.Select(SiteMembershipConditionValue, (SiteMembershipConditionValueLambda) => SiteMembershipConditionValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue)
{
    return Observable.Select(SiteMembershipConditionValue, (SiteMembershipConditionValueLambda) => SiteMembershipConditionValueLambda.ToString());
}


public static IObservable<System.String> get_Site(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue)
{
    return Observable.Select(SiteMembershipConditionValue, (SiteMembershipConditionValueLambda) => SiteMembershipConditionValueLambda.Site);
}


public static IObservable<System.Reactive.Unit> set_Site(this IObservable<System.Security.Policy.SiteMembershipCondition> SiteMembershipConditionValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(SiteMembershipConditionValue, value, (SiteMembershipConditionValueLambda, valueLambda) => SiteMembershipConditionValueLambda.Site = valueLambda);
}

}
}