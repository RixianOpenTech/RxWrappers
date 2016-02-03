using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __DirectoryObjectSecurity
    {
        
        public static IObservable<System.Security.AccessControl.AccessRule> AccessRuleFactory(this IObservable<System.Security.AccessControl.DirectoryObjectSecurity> DirectoryObjectSecurityValue, IObservable<System.Security.Principal.IdentityReference> identityReference, IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited, IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags, IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags, IObservable<System.Security.AccessControl.AccessControlType> type, IObservable<System.Guid> objectType, IObservable<System.Guid> inheritedObjectType)
        {
            return Observable.Zip(DirectoryObjectSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, type, objectType, inheritedObjectType, (DirectoryObjectSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda, objectTypeLambda, inheritedObjectTypeLambda) => DirectoryObjectSecurityValueLambda.AccessRuleFactory(identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, typeLambda, objectTypeLambda, inheritedObjectTypeLambda));
        }


        public static IObservable<System.Security.AccessControl.AuditRule> AuditRuleFactory(this IObservable<System.Security.AccessControl.DirectoryObjectSecurity> DirectoryObjectSecurityValue, IObservable<System.Security.Principal.IdentityReference> identityReference, IObservable<System.Int32> accessMask, IObservable<System.Boolean> isInherited, IObservable<System.Security.AccessControl.InheritanceFlags> inheritanceFlags, IObservable<System.Security.AccessControl.PropagationFlags> propagationFlags, IObservable<System.Security.AccessControl.AuditFlags> flags, IObservable<System.Guid> objectType, IObservable<System.Guid> inheritedObjectType)
        {
            return Observable.Zip(DirectoryObjectSecurityValue, identityReference, accessMask, isInherited, inheritanceFlags, propagationFlags, flags, objectType, inheritedObjectType, (DirectoryObjectSecurityValueLambda, identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda, objectTypeLambda, inheritedObjectTypeLambda) => DirectoryObjectSecurityValueLambda.AuditRuleFactory(identityReferenceLambda, accessMaskLambda, isInheritedLambda, inheritanceFlagsLambda, propagationFlagsLambda, flagsLambda, objectTypeLambda, inheritedObjectTypeLambda));
        }


        public static IObservable<System.Security.AccessControl.AuthorizationRuleCollection> GetAccessRules(this IObservable<System.Security.AccessControl.DirectoryObjectSecurity> DirectoryObjectSecurityValue, IObservable<System.Boolean> includeExplicit, IObservable<System.Boolean> includeInherited, IObservable<System.Type> targetType)
        {
            return Observable.Zip(DirectoryObjectSecurityValue, includeExplicit, includeInherited, targetType, (DirectoryObjectSecurityValueLambda, includeExplicitLambda, includeInheritedLambda, targetTypeLambda) => DirectoryObjectSecurityValueLambda.GetAccessRules(includeExplicitLambda, includeInheritedLambda, targetTypeLambda));
        }


        public static IObservable<System.Security.AccessControl.AuthorizationRuleCollection> GetAuditRules(this IObservable<System.Security.AccessControl.DirectoryObjectSecurity> DirectoryObjectSecurityValue, IObservable<System.Boolean> includeExplicit, IObservable<System.Boolean> includeInherited, IObservable<System.Type> targetType)
        {
            return Observable.Zip(DirectoryObjectSecurityValue, includeExplicit, includeInherited, targetType, (DirectoryObjectSecurityValueLambda, includeExplicitLambda, includeInheritedLambda, targetTypeLambda) => DirectoryObjectSecurityValueLambda.GetAuditRules(includeExplicitLambda, includeInheritedLambda, targetTypeLambda));
        }

    }
}