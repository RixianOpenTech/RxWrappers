using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __KnownAce
    {
        public static IObservable<System.Int32> get_AccessMask(
            this IObservable<System.Security.AccessControl.KnownAce> KnownAceValue)
        {
            return Observable.Select(KnownAceValue, (KnownAceValueLambda) => KnownAceValueLambda.AccessMask);
        }


        public static IObservable<System.Security.Principal.SecurityIdentifier> get_SecurityIdentifier(
            this IObservable<System.Security.AccessControl.KnownAce> KnownAceValue)
        {
            return Observable.Select(KnownAceValue, (KnownAceValueLambda) => KnownAceValueLambda.SecurityIdentifier);
        }


        public static IObservable<System.Reactive.Unit> set_AccessMask(
            this IObservable<System.Security.AccessControl.KnownAce> KnownAceValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(KnownAceValue, value,
                (KnownAceValueLambda, valueLambda) => KnownAceValueLambda.AccessMask = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SecurityIdentifier(
            this IObservable<System.Security.AccessControl.KnownAce> KnownAceValue,
            IObservable<System.Security.Principal.SecurityIdentifier> value)
        {
            return ObservableExt.ZipExecute(KnownAceValue, value,
                (KnownAceValueLambda, valueLambda) => KnownAceValueLambda.SecurityIdentifier = valueLambda);
        }
    }
}