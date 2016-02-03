using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _GacMembershipCondition
{
    
public static IObservable<System.Boolean> Check(this IObservable<System.Security.Policy.GacMembershipCondition> GacMembershipConditionValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(GacMembershipConditionValue, evidence, (GacMembershipConditionValueLambda, evidenceLambda) => GacMembershipConditionValueLambda.Check(evidenceLambda));
}


public static IObservable<System.Security.Policy.IMembershipCondition> Copy(this IObservable<System.Security.Policy.GacMembershipCondition> GacMembershipConditionValue)
{
    return Observable.Select(GacMembershipConditionValue, (GacMembershipConditionValueLambda) => GacMembershipConditionValueLambda.Copy());
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.GacMembershipCondition> GacMembershipConditionValue)
{
    return Observable.Select(GacMembershipConditionValue, (GacMembershipConditionValueLambda) => GacMembershipConditionValueLambda.ToXml());
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.GacMembershipCondition> GacMembershipConditionValue, IObservable<System.Security.SecurityElement> e)
{
    return ObservableExt.ZipExecute(GacMembershipConditionValue, e, (GacMembershipConditionValueLambda, eLambda) => GacMembershipConditionValueLambda.FromXml(eLambda));
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.GacMembershipCondition> GacMembershipConditionValue, IObservable<System.Security.Policy.PolicyLevel> level)
{
    return Observable.Zip(GacMembershipConditionValue, level, (GacMembershipConditionValueLambda, levelLambda) => GacMembershipConditionValueLambda.ToXml(levelLambda));
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.GacMembershipCondition> GacMembershipConditionValue, IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
{
    return ObservableExt.ZipExecute(GacMembershipConditionValue, e, level, (GacMembershipConditionValueLambda, eLambda, levelLambda) => GacMembershipConditionValueLambda.FromXml(eLambda, levelLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.GacMembershipCondition> GacMembershipConditionValue, IObservable<System.Object> o)
{
    return Observable.Zip(GacMembershipConditionValue, o, (GacMembershipConditionValueLambda, oLambda) => GacMembershipConditionValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.GacMembershipCondition> GacMembershipConditionValue)
{
    return Observable.Select(GacMembershipConditionValue, (GacMembershipConditionValueLambda) => GacMembershipConditionValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.GacMembershipCondition> GacMembershipConditionValue)
{
    return Observable.Select(GacMembershipConditionValue, (GacMembershipConditionValueLambda) => GacMembershipConditionValueLambda.ToString());
}

}
}