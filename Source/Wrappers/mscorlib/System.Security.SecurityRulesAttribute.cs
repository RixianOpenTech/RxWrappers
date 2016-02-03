using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
public static class _SecurityRulesAttribute
{
    
public static IObservable<System.Boolean> get_SkipVerificationInFullTrust(this IObservable<System.Security.SecurityRulesAttribute> SecurityRulesAttributeValue)
{
    return Observable.Select(SecurityRulesAttributeValue, (SecurityRulesAttributeValueLambda) => SecurityRulesAttributeValueLambda.SkipVerificationInFullTrust);
}


public static IObservable<System.Security.SecurityRuleSet> get_RuleSet(this IObservable<System.Security.SecurityRulesAttribute> SecurityRulesAttributeValue)
{
    return Observable.Select(SecurityRulesAttributeValue, (SecurityRulesAttributeValueLambda) => SecurityRulesAttributeValueLambda.RuleSet);
}


public static IObservable<System.Reactive.Unit> set_SkipVerificationInFullTrust(this IObservable<System.Security.SecurityRulesAttribute> SecurityRulesAttributeValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(SecurityRulesAttributeValue, value, (SecurityRulesAttributeValueLambda, valueLambda) => SecurityRulesAttributeValueLambda.SkipVerificationInFullTrust = valueLambda);
}

}
}