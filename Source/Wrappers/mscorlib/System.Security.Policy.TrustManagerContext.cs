using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Policy
{
    public static class __TrustManagerContext
    {
        
        public static IObservable<System.Security.Policy.TrustManagerUIContext> get_UIContext(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue)
        {
            return Observable.Select(TrustManagerContextValue, (TrustManagerContextValueLambda) => TrustManagerContextValueLambda.UIContext);
        }


        public static IObservable<System.Boolean> get_NoPrompt(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue)
        {
            return Observable.Select(TrustManagerContextValue, (TrustManagerContextValueLambda) => TrustManagerContextValueLambda.NoPrompt);
        }


        public static IObservable<System.Boolean> get_IgnorePersistedDecision(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue)
        {
            return Observable.Select(TrustManagerContextValue, (TrustManagerContextValueLambda) => TrustManagerContextValueLambda.IgnorePersistedDecision);
        }


        public static IObservable<System.Boolean> get_KeepAlive(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue)
        {
            return Observable.Select(TrustManagerContextValue, (TrustManagerContextValueLambda) => TrustManagerContextValueLambda.KeepAlive);
        }


        public static IObservable<System.Boolean> get_Persist(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue)
        {
            return Observable.Select(TrustManagerContextValue, (TrustManagerContextValueLambda) => TrustManagerContextValueLambda.Persist);
        }


        public static IObservable<System.ApplicationIdentity> get_PreviousApplicationIdentity(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue)
        {
            return Observable.Select(TrustManagerContextValue, (TrustManagerContextValueLambda) => TrustManagerContextValueLambda.PreviousApplicationIdentity);
        }


        public static IObservable<System.Reactive.Unit> set_UIContext(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue, IObservable<System.Security.Policy.TrustManagerUIContext> value)
        {
            return ObservableExt.ZipExecute(TrustManagerContextValue, value, (TrustManagerContextValueLambda, valueLambda) => TrustManagerContextValueLambda.UIContext = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NoPrompt(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(TrustManagerContextValue, value, (TrustManagerContextValueLambda, valueLambda) => TrustManagerContextValueLambda.NoPrompt = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IgnorePersistedDecision(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(TrustManagerContextValue, value, (TrustManagerContextValueLambda, valueLambda) => TrustManagerContextValueLambda.IgnorePersistedDecision = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_KeepAlive(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(TrustManagerContextValue, value, (TrustManagerContextValueLambda, valueLambda) => TrustManagerContextValueLambda.KeepAlive = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Persist(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(TrustManagerContextValue, value, (TrustManagerContextValueLambda, valueLambda) => TrustManagerContextValueLambda.Persist = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PreviousApplicationIdentity(this IObservable<System.Security.Policy.TrustManagerContext> TrustManagerContextValue, IObservable<System.ApplicationIdentity> value)
        {
            return ObservableExt.ZipExecute(TrustManagerContextValue, value, (TrustManagerContextValueLambda, valueLambda) => TrustManagerContextValueLambda.PreviousApplicationIdentity = valueLambda);
        }

    }
}