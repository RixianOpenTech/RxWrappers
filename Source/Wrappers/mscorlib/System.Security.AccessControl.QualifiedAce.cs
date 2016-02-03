using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __QualifiedAce
    {
        public static IObservable<System.Byte[]> GetOpaque(
            this IObservable<System.Security.AccessControl.QualifiedAce> QualifiedAceValue)
        {
            return Observable.Select(QualifiedAceValue, (QualifiedAceValueLambda) => QualifiedAceValueLambda.GetOpaque());
        }


        public static IObservable<System.Reactive.Unit> SetOpaque(
            this IObservable<System.Security.AccessControl.QualifiedAce> QualifiedAceValue,
            IObservable<System.Byte[]> opaque)
        {
            return ObservableExt.ZipExecute(QualifiedAceValue, opaque,
                (QualifiedAceValueLambda, opaqueLambda) => QualifiedAceValueLambda.SetOpaque(opaqueLambda));
        }


        public static IObservable<System.Security.AccessControl.AceQualifier> get_AceQualifier(
            this IObservable<System.Security.AccessControl.QualifiedAce> QualifiedAceValue)
        {
            return Observable.Select(QualifiedAceValue,
                (QualifiedAceValueLambda) => QualifiedAceValueLambda.AceQualifier);
        }


        public static IObservable<System.Boolean> get_IsCallback(
            this IObservable<System.Security.AccessControl.QualifiedAce> QualifiedAceValue)
        {
            return Observable.Select(QualifiedAceValue, (QualifiedAceValueLambda) => QualifiedAceValueLambda.IsCallback);
        }


        public static IObservable<System.Int32> get_OpaqueLength(
            this IObservable<System.Security.AccessControl.QualifiedAce> QualifiedAceValue)
        {
            return Observable.Select(QualifiedAceValue,
                (QualifiedAceValueLambda) => QualifiedAceValueLambda.OpaqueLength);
        }
    }
}