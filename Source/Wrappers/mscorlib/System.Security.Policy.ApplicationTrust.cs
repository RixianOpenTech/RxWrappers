using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __ApplicationTrust
    {
        public static IObservable<System.Security.SecurityElement> ToXml(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue)
        {
            return Observable.Select(ApplicationTrustValue,
                (ApplicationTrustValueLambda) => ApplicationTrustValueLambda.ToXml());
        }


        public static IObservable<System.Reactive.Unit> FromXml(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue,
            IObservable<System.Security.SecurityElement> element)
        {
            return ObservableExt.ZipExecute(ApplicationTrustValue, element,
                (ApplicationTrustValueLambda, elementLambda) => ApplicationTrustValueLambda.FromXml(elementLambda));
        }


        public static IObservable<System.Security.Policy.EvidenceBase> Clone(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue)
        {
            return Observable.Select(ApplicationTrustValue,
                (ApplicationTrustValueLambda) => ApplicationTrustValueLambda.Clone());
        }


        public static IObservable<System.ApplicationIdentity> get_ApplicationIdentity(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue)
        {
            return Observable.Select(ApplicationTrustValue,
                (ApplicationTrustValueLambda) => ApplicationTrustValueLambda.ApplicationIdentity);
        }


        public static IObservable<System.Security.Policy.PolicyStatement> get_DefaultGrantSet(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue)
        {
            return Observable.Select(ApplicationTrustValue,
                (ApplicationTrustValueLambda) => ApplicationTrustValueLambda.DefaultGrantSet);
        }


        public static IObservable<System.Collections.Generic.IList<System.Security.Policy.StrongName>>
            get_FullTrustAssemblies(this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue)
        {
            return Observable.Select(ApplicationTrustValue,
                (ApplicationTrustValueLambda) => ApplicationTrustValueLambda.FullTrustAssemblies);
        }


        public static IObservable<System.Boolean> get_IsApplicationTrustedToRun(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue)
        {
            return Observable.Select(ApplicationTrustValue,
                (ApplicationTrustValueLambda) => ApplicationTrustValueLambda.IsApplicationTrustedToRun);
        }


        public static IObservable<System.Boolean> get_Persist(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue)
        {
            return Observable.Select(ApplicationTrustValue,
                (ApplicationTrustValueLambda) => ApplicationTrustValueLambda.Persist);
        }


        public static IObservable<System.Object> get_ExtraInfo(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue)
        {
            return Observable.Select(ApplicationTrustValue,
                (ApplicationTrustValueLambda) => ApplicationTrustValueLambda.ExtraInfo);
        }


        public static IObservable<System.Reactive.Unit> set_ApplicationIdentity(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue,
            IObservable<System.ApplicationIdentity> value)
        {
            return ObservableExt.ZipExecute(ApplicationTrustValue, value,
                (ApplicationTrustValueLambda, valueLambda) =>
                    ApplicationTrustValueLambda.ApplicationIdentity = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultGrantSet(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue,
            IObservable<System.Security.Policy.PolicyStatement> value)
        {
            return ObservableExt.ZipExecute(ApplicationTrustValue, value,
                (ApplicationTrustValueLambda, valueLambda) => ApplicationTrustValueLambda.DefaultGrantSet = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IsApplicationTrustedToRun(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(ApplicationTrustValue, value,
                (ApplicationTrustValueLambda, valueLambda) =>
                    ApplicationTrustValueLambda.IsApplicationTrustedToRun = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Persist(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue,
            IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(ApplicationTrustValue, value,
                (ApplicationTrustValueLambda, valueLambda) => ApplicationTrustValueLambda.Persist = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ExtraInfo(
            this IObservable<System.Security.Policy.ApplicationTrust> ApplicationTrustValue,
            IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(ApplicationTrustValue, value,
                (ApplicationTrustValueLambda, valueLambda) => ApplicationTrustValueLambda.ExtraInfo = valueLambda);
        }
    }
}