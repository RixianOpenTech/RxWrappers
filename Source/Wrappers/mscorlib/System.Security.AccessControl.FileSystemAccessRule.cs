using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __FileSystemAccessRule
    {
        
        public static IObservable<System.Security.AccessControl.FileSystemRights> get_FileSystemRights(this IObservable<System.Security.AccessControl.FileSystemAccessRule> FileSystemAccessRuleValue)
        {
            return Observable.Select(FileSystemAccessRuleValue, (FileSystemAccessRuleValueLambda) => FileSystemAccessRuleValueLambda.FileSystemRights);
        }

    }
}