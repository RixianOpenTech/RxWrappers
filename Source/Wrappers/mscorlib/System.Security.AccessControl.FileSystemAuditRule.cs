using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
public static class _FileSystemAuditRule
{
    
public static IObservable<System.Security.AccessControl.FileSystemRights> get_FileSystemRights(this IObservable<System.Security.AccessControl.FileSystemAuditRule> FileSystemAuditRuleValue)
{
    return Observable.Select(FileSystemAuditRuleValue, (FileSystemAuditRuleValueLambda) => FileSystemAuditRuleValueLambda.FileSystemRights);
}

}
}