using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Contracts
{
    public static class __ContractFailedEventArgs
    {
        public static IObservable<System.Reactive.Unit> SetHandled(
            this IObservable<System.Diagnostics.Contracts.ContractFailedEventArgs> ContractFailedEventArgsValue)
        {
            return
                Observable.Do(ContractFailedEventArgsValue,
                    (ContractFailedEventArgsValueLambda) => ContractFailedEventArgsValueLambda.SetHandled()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> SetUnwind(
            this IObservable<System.Diagnostics.Contracts.ContractFailedEventArgs> ContractFailedEventArgsValue)
        {
            return
                Observable.Do(ContractFailedEventArgsValue,
                    (ContractFailedEventArgsValueLambda) => ContractFailedEventArgsValueLambda.SetUnwind()).ToUnit();
        }


        public static IObservable<System.String> get_Message(
            this IObservable<System.Diagnostics.Contracts.ContractFailedEventArgs> ContractFailedEventArgsValue)
        {
            return Observable.Select(ContractFailedEventArgsValue,
                (ContractFailedEventArgsValueLambda) => ContractFailedEventArgsValueLambda.Message);
        }


        public static IObservable<System.String> get_Condition(
            this IObservable<System.Diagnostics.Contracts.ContractFailedEventArgs> ContractFailedEventArgsValue)
        {
            return Observable.Select(ContractFailedEventArgsValue,
                (ContractFailedEventArgsValueLambda) => ContractFailedEventArgsValueLambda.Condition);
        }


        public static IObservable<System.Diagnostics.Contracts.ContractFailureKind> get_FailureKind(
            this IObservable<System.Diagnostics.Contracts.ContractFailedEventArgs> ContractFailedEventArgsValue)
        {
            return Observable.Select(ContractFailedEventArgsValue,
                (ContractFailedEventArgsValueLambda) => ContractFailedEventArgsValueLambda.FailureKind);
        }


        public static IObservable<System.Exception> get_OriginalException(
            this IObservable<System.Diagnostics.Contracts.ContractFailedEventArgs> ContractFailedEventArgsValue)
        {
            return Observable.Select(ContractFailedEventArgsValue,
                (ContractFailedEventArgsValueLambda) => ContractFailedEventArgsValueLambda.OriginalException);
        }


        public static IObservable<System.Boolean> get_Handled(
            this IObservable<System.Diagnostics.Contracts.ContractFailedEventArgs> ContractFailedEventArgsValue)
        {
            return Observable.Select(ContractFailedEventArgsValue,
                (ContractFailedEventArgsValueLambda) => ContractFailedEventArgsValueLambda.Handled);
        }


        public static IObservable<System.Boolean> get_Unwind(
            this IObservable<System.Diagnostics.Contracts.ContractFailedEventArgs> ContractFailedEventArgsValue)
        {
            return Observable.Select(ContractFailedEventArgsValue,
                (ContractFailedEventArgsValueLambda) => ContractFailedEventArgsValueLambda.Unwind);
        }
    }
}