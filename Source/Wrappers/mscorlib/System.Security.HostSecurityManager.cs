using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
    public static class __HostSecurityManager
    {
        public static IObservable<System.Security.Policy.Evidence> ProvideAppDomainEvidence(
            this IObservable<System.Security.HostSecurityManager> HostSecurityManagerValue,
            IObservable<System.Security.Policy.Evidence> inputEvidence)
        {
            return Observable.Zip(HostSecurityManagerValue, inputEvidence,
                (HostSecurityManagerValueLambda, inputEvidenceLambda) =>
                    HostSecurityManagerValueLambda.ProvideAppDomainEvidence(inputEvidenceLambda));
        }


        public static IObservable<System.Security.Policy.Evidence> ProvideAssemblyEvidence(
            this IObservable<System.Security.HostSecurityManager> HostSecurityManagerValue,
            IObservable<System.Reflection.Assembly> loadedAssembly,
            IObservable<System.Security.Policy.Evidence> inputEvidence)
        {
            return Observable.Zip(HostSecurityManagerValue, loadedAssembly, inputEvidence,
                (HostSecurityManagerValueLambda, loadedAssemblyLambda, inputEvidenceLambda) =>
                    HostSecurityManagerValueLambda.ProvideAssemblyEvidence(loadedAssemblyLambda, inputEvidenceLambda));
        }


        public static IObservable<System.Security.Policy.ApplicationTrust> DetermineApplicationTrust(
            this IObservable<System.Security.HostSecurityManager> HostSecurityManagerValue,
            IObservable<System.Security.Policy.Evidence> applicationEvidence,
            IObservable<System.Security.Policy.Evidence> activatorEvidence,
            IObservable<System.Security.Policy.TrustManagerContext> context)
        {
            return Observable.Zip(HostSecurityManagerValue, applicationEvidence, activatorEvidence, context,
                (HostSecurityManagerValueLambda, applicationEvidenceLambda, activatorEvidenceLambda, contextLambda) =>
                    HostSecurityManagerValueLambda.DetermineApplicationTrust(applicationEvidenceLambda,
                        activatorEvidenceLambda, contextLambda));
        }


        public static IObservable<System.Security.PermissionSet> ResolvePolicy(
            this IObservable<System.Security.HostSecurityManager> HostSecurityManagerValue,
            IObservable<System.Security.Policy.Evidence> evidence)
        {
            return Observable.Zip(HostSecurityManagerValue, evidence,
                (HostSecurityManagerValueLambda, evidenceLambda) =>
                    HostSecurityManagerValueLambda.ResolvePolicy(evidenceLambda));
        }


        public static IObservable<System.Type[]> GetHostSuppliedAppDomainEvidenceTypes(
            this IObservable<System.Security.HostSecurityManager> HostSecurityManagerValue)
        {
            return Observable.Select(HostSecurityManagerValue,
                (HostSecurityManagerValueLambda) =>
                    HostSecurityManagerValueLambda.GetHostSuppliedAppDomainEvidenceTypes());
        }


        public static IObservable<System.Type[]> GetHostSuppliedAssemblyEvidenceTypes(
            this IObservable<System.Security.HostSecurityManager> HostSecurityManagerValue,
            IObservable<System.Reflection.Assembly> assembly)
        {
            return Observable.Zip(HostSecurityManagerValue, assembly,
                (HostSecurityManagerValueLambda, assemblyLambda) =>
                    HostSecurityManagerValueLambda.GetHostSuppliedAssemblyEvidenceTypes(assemblyLambda));
        }


        public static IObservable<System.Security.Policy.EvidenceBase> GenerateAppDomainEvidence(
            this IObservable<System.Security.HostSecurityManager> HostSecurityManagerValue,
            IObservable<System.Type> evidenceType)
        {
            return Observable.Zip(HostSecurityManagerValue, evidenceType,
                (HostSecurityManagerValueLambda, evidenceTypeLambda) =>
                    HostSecurityManagerValueLambda.GenerateAppDomainEvidence(evidenceTypeLambda));
        }


        public static IObservable<System.Security.Policy.EvidenceBase> GenerateAssemblyEvidence(
            this IObservable<System.Security.HostSecurityManager> HostSecurityManagerValue,
            IObservable<System.Type> evidenceType, IObservable<System.Reflection.Assembly> assembly)
        {
            return Observable.Zip(HostSecurityManagerValue, evidenceType, assembly,
                (HostSecurityManagerValueLambda, evidenceTypeLambda, assemblyLambda) =>
                    HostSecurityManagerValueLambda.GenerateAssemblyEvidence(evidenceTypeLambda, assemblyLambda));
        }


        public static IObservable<System.Security.HostSecurityManagerOptions> get_Flags(
            this IObservable<System.Security.HostSecurityManager> HostSecurityManagerValue)
        {
            return Observable.Select(HostSecurityManagerValue,
                (HostSecurityManagerValueLambda) => HostSecurityManagerValueLambda.Flags);
        }


        public static IObservable<System.Security.Policy.PolicyLevel> get_DomainPolicy(
            this IObservable<System.Security.HostSecurityManager> HostSecurityManagerValue)
        {
            return Observable.Select(HostSecurityManagerValue,
                (HostSecurityManagerValueLambda) => HostSecurityManagerValueLambda.DomainPolicy);
        }
    }
}