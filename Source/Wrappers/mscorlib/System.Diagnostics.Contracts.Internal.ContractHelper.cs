using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Contracts.Internal
{
    public static class __ContractHelper
    {
        public static IObservable<System.String> RaiseContractFailedEvent(
            IObservable<System.Diagnostics.Contracts.ContractFailureKind> failureKind,
            IObservable<System.String> userMessage, IObservable<System.String> conditionText,
            IObservable<System.Exception> innerException)
        {
            return Observable.Zip(failureKind, userMessage, conditionText, innerException,
                (failureKindLambda, userMessageLambda, conditionTextLambda, innerExceptionLambda) =>
                    System.Diagnostics.Contracts.Internal.ContractHelper.RaiseContractFailedEvent(failureKindLambda,
                        userMessageLambda, conditionTextLambda, innerExceptionLambda));
        }


        public static IObservable<System.Reactive.Unit> TriggerFailure(
            IObservable<System.Diagnostics.Contracts.ContractFailureKind> kind,
            IObservable<System.String> displayMessage, IObservable<System.String> userMessage,
            IObservable<System.String> conditionText, IObservable<System.Exception> innerException)
        {
            return ObservableExt.ZipExecute(kind, displayMessage, userMessage, conditionText, innerException,
                (kindLambda, displayMessageLambda, userMessageLambda, conditionTextLambda, innerExceptionLambda) =>
                    System.Diagnostics.Contracts.Internal.ContractHelper.TriggerFailure(kindLambda, displayMessageLambda,
                        userMessageLambda, conditionTextLambda, innerExceptionLambda));
        }
    }
}