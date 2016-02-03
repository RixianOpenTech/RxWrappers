using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _CryptoKeyAuditRule
{
    
public static IObservable<System.Security.AccessControl.CryptoKeyRights> get_CryptoKeyRights(this IObservable<System.Security.AccessControl.CryptoKeyAuditRule> CryptoKeyAuditRuleValue)
{
    return Observable.Select(CryptoKeyAuditRuleValue, (CryptoKeyAuditRuleValueLambda) => CryptoKeyAuditRuleValueLambda.CryptoKeyRights);
}

}
}