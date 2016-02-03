using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __CompoundAce
    {
        
        public static IObservable<System.Reactive.Unit> GetBinaryForm(this IObservable<System.Security.AccessControl.CompoundAce> CompoundAceValue, IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
        {
            return ObservableExt.ZipExecute(CompoundAceValue, binaryForm, offset, (CompoundAceValueLambda, binaryFormLambda, offsetLambda) => CompoundAceValueLambda.GetBinaryForm(binaryFormLambda, offsetLambda));
        }


        public static IObservable<System.Security.AccessControl.CompoundAceType> get_CompoundAceType(this IObservable<System.Security.AccessControl.CompoundAce> CompoundAceValue)
        {
            return Observable.Select(CompoundAceValue, (CompoundAceValueLambda) => CompoundAceValueLambda.CompoundAceType);
        }


        public static IObservable<System.Int32> get_BinaryLength(this IObservable<System.Security.AccessControl.CompoundAce> CompoundAceValue)
        {
            return Observable.Select(CompoundAceValue, (CompoundAceValueLambda) => CompoundAceValueLambda.BinaryLength);
        }


        public static IObservable<System.Reactive.Unit> set_CompoundAceType(this IObservable<System.Security.AccessControl.CompoundAce> CompoundAceValue, IObservable<System.Security.AccessControl.CompoundAceType> value)
        {
            return ObservableExt.ZipExecute(CompoundAceValue, value, (CompoundAceValueLambda, valueLambda) => CompoundAceValueLambda.CompoundAceType = valueLambda);
        }

    }
}