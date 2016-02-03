using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __CommonAce
    {
        public static IObservable<System.Int32> MaxOpaqueLength(IObservable<System.Boolean> isCallback)
        {
            return Observable.Select(isCallback,
                (isCallbackLambda) => System.Security.AccessControl.CommonAce.MaxOpaqueLength(isCallbackLambda));
        }


        public static IObservable<System.Reactive.Unit> GetBinaryForm(
            this IObservable<System.Security.AccessControl.CommonAce> CommonAceValue,
            IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
        {
            return ObservableExt.ZipExecute(CommonAceValue, binaryForm, offset,
                (CommonAceValueLambda, binaryFormLambda, offsetLambda) =>
                    CommonAceValueLambda.GetBinaryForm(binaryFormLambda, offsetLambda));
        }


        public static IObservable<System.Int32> get_BinaryLength(
            this IObservable<System.Security.AccessControl.CommonAce> CommonAceValue)
        {
            return Observable.Select(CommonAceValue, (CommonAceValueLambda) => CommonAceValueLambda.BinaryLength);
        }
    }
}