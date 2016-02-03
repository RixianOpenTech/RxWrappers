using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __CustomAce
    {
        
        public static IObservable<System.Byte[]> GetOpaque(this IObservable<System.Security.AccessControl.CustomAce> CustomAceValue)
        {
            return Observable.Select(CustomAceValue, (CustomAceValueLambda) => CustomAceValueLambda.GetOpaque());
        }


        public static IObservable<System.Reactive.Unit> SetOpaque(this IObservable<System.Security.AccessControl.CustomAce> CustomAceValue, IObservable<System.Byte[]> opaque)
        {
            return ObservableExt.ZipExecute(CustomAceValue, opaque, (CustomAceValueLambda, opaqueLambda) => CustomAceValueLambda.SetOpaque(opaqueLambda));
        }


        public static IObservable<System.Reactive.Unit> GetBinaryForm(this IObservable<System.Security.AccessControl.CustomAce> CustomAceValue, IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
        {
            return ObservableExt.ZipExecute(CustomAceValue, binaryForm, offset, (CustomAceValueLambda, binaryFormLambda, offsetLambda) => CustomAceValueLambda.GetBinaryForm(binaryFormLambda, offsetLambda));
        }


        public static IObservable<System.Int32> get_OpaqueLength(this IObservable<System.Security.AccessControl.CustomAce> CustomAceValue)
        {
            return Observable.Select(CustomAceValue, (CustomAceValueLambda) => CustomAceValueLambda.OpaqueLength);
        }


        public static IObservable<System.Int32> get_BinaryLength(this IObservable<System.Security.AccessControl.CustomAce> CustomAceValue)
        {
            return Observable.Select(CustomAceValue, (CustomAceValueLambda) => CustomAceValueLambda.BinaryLength);
        }

    }
}