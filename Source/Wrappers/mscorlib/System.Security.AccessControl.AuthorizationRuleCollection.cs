using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _AuthorizationRuleCollection
{
    
public static IObservable<System.Reactive.Unit> AddRule(this IObservable<System.Security.AccessControl.AuthorizationRuleCollection> AuthorizationRuleCollectionValue, IObservable<System.Security.AccessControl.AuthorizationRule> rule)
{
    return ObservableExt.ZipExecute(AuthorizationRuleCollectionValue, rule, (AuthorizationRuleCollectionValueLambda, ruleLambda) => AuthorizationRuleCollectionValueLambda.AddRule(ruleLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Security.AccessControl.AuthorizationRuleCollection> AuthorizationRuleCollectionValue, IObservable<System.Security.AccessControl.AuthorizationRule[]> rules, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(AuthorizationRuleCollectionValue, rules, index, (AuthorizationRuleCollectionValueLambda, rulesLambda, indexLambda) => AuthorizationRuleCollectionValueLambda.CopyTo(rulesLambda, indexLambda));
}


public static IObservable<System.Security.AccessControl.AuthorizationRule> get_Item(this IObservable<System.Security.AccessControl.AuthorizationRuleCollection> AuthorizationRuleCollectionValue, IObservable<System.Int32> index)
{
    return Observable.Zip(AuthorizationRuleCollectionValue, index, (AuthorizationRuleCollectionValueLambda, indexLambda) => AuthorizationRuleCollectionValueLambda.Item);
}

}
}