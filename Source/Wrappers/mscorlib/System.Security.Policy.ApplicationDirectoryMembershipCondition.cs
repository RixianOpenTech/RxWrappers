using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
public static class _ApplicationDirectoryMembershipCondition
{
    
public static IObservable<System.Boolean> Check(this IObservable<System.Security.Policy.ApplicationDirectoryMembershipCondition> ApplicationDirectoryMembershipConditionValue, IObservable<System.Security.Policy.Evidence> evidence)
{
    return Observable.Zip(ApplicationDirectoryMembershipConditionValue, evidence, (ApplicationDirectoryMembershipConditionValueLambda, evidenceLambda) => ApplicationDirectoryMembershipConditionValueLambda.Check(evidenceLambda));
}


public static IObservable<System.Security.Policy.IMembershipCondition> Copy(this IObservable<System.Security.Policy.ApplicationDirectoryMembershipCondition> ApplicationDirectoryMembershipConditionValue)
{
    return Observable.Select(ApplicationDirectoryMembershipConditionValue, (ApplicationDirectoryMembershipConditionValueLambda) => ApplicationDirectoryMembershipConditionValueLambda.Copy());
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.ApplicationDirectoryMembershipCondition> ApplicationDirectoryMembershipConditionValue)
{
    return Observable.Select(ApplicationDirectoryMembershipConditionValue, (ApplicationDirectoryMembershipConditionValueLambda) => ApplicationDirectoryMembershipConditionValueLambda.ToXml());
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.ApplicationDirectoryMembershipCondition> ApplicationDirectoryMembershipConditionValue, IObservable<System.Security.SecurityElement> e)
{
    return ObservableExt.ZipExecute(ApplicationDirectoryMembershipConditionValue, e, (ApplicationDirectoryMembershipConditionValueLambda, eLambda) => ApplicationDirectoryMembershipConditionValueLambda.FromXml(eLambda));
}


public static IObservable<System.Security.SecurityElement> ToXml(this IObservable<System.Security.Policy.ApplicationDirectoryMembershipCondition> ApplicationDirectoryMembershipConditionValue, IObservable<System.Security.Policy.PolicyLevel> level)
{
    return Observable.Zip(ApplicationDirectoryMembershipConditionValue, level, (ApplicationDirectoryMembershipConditionValueLambda, levelLambda) => ApplicationDirectoryMembershipConditionValueLambda.ToXml(levelLambda));
}


public static IObservable<System.Reactive.Unit> FromXml(this IObservable<System.Security.Policy.ApplicationDirectoryMembershipCondition> ApplicationDirectoryMembershipConditionValue, IObservable<System.Security.SecurityElement> e, IObservable<System.Security.Policy.PolicyLevel> level)
{
    return ObservableExt.ZipExecute(ApplicationDirectoryMembershipConditionValue, e, level, (ApplicationDirectoryMembershipConditionValueLambda, eLambda, levelLambda) => ApplicationDirectoryMembershipConditionValueLambda.FromXml(eLambda, levelLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Policy.ApplicationDirectoryMembershipCondition> ApplicationDirectoryMembershipConditionValue, IObservable<System.Object> o)
{
    return Observable.Zip(ApplicationDirectoryMembershipConditionValue, o, (ApplicationDirectoryMembershipConditionValueLambda, oLambda) => ApplicationDirectoryMembershipConditionValueLambda.Equals(oLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Policy.ApplicationDirectoryMembershipCondition> ApplicationDirectoryMembershipConditionValue)
{
    return Observable.Select(ApplicationDirectoryMembershipConditionValue, (ApplicationDirectoryMembershipConditionValueLambda) => ApplicationDirectoryMembershipConditionValueLambda.GetHashCode());
}


public static IObservable<System.String> ToString(this IObservable<System.Security.Policy.ApplicationDirectoryMembershipCondition> ApplicationDirectoryMembershipConditionValue)
{
    return Observable.Select(ApplicationDirectoryMembershipConditionValue, (ApplicationDirectoryMembershipConditionValueLambda) => ApplicationDirectoryMembershipConditionValueLambda.ToString());
}

}
}