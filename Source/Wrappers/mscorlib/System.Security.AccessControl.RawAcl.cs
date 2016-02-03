using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __RawAcl
    {
        
        public static IObservable<System.Reactive.Unit> GetBinaryForm(this IObservable<System.Security.AccessControl.RawAcl> RawAclValue, IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
        {
            return ObservableExt.ZipExecute(RawAclValue, binaryForm, offset, (RawAclValueLambda, binaryFormLambda, offsetLambda) => RawAclValueLambda.GetBinaryForm(binaryFormLambda, offsetLambda));
        }


        public static IObservable<System.Reactive.Unit> InsertAce(this IObservable<System.Security.AccessControl.RawAcl> RawAclValue, IObservable<System.Int32> index, IObservable<System.Security.AccessControl.GenericAce> ace)
        {
            return ObservableExt.ZipExecute(RawAclValue, index, ace, (RawAclValueLambda, indexLambda, aceLambda) => RawAclValueLambda.InsertAce(indexLambda, aceLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveAce(this IObservable<System.Security.AccessControl.RawAcl> RawAclValue, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(RawAclValue, index, (RawAclValueLambda, indexLambda) => RawAclValueLambda.RemoveAce(indexLambda));
        }


        public static IObservable<System.Byte> get_Revision(this IObservable<System.Security.AccessControl.RawAcl> RawAclValue)
        {
            return Observable.Select(RawAclValue, (RawAclValueLambda) => RawAclValueLambda.Revision);
        }


        public static IObservable<System.Int32> get_Count(this IObservable<System.Security.AccessControl.RawAcl> RawAclValue)
        {
            return Observable.Select(RawAclValue, (RawAclValueLambda) => RawAclValueLambda.Count);
        }


        public static IObservable<System.Int32> get_BinaryLength(this IObservable<System.Security.AccessControl.RawAcl> RawAclValue)
        {
            return Observable.Select(RawAclValue, (RawAclValueLambda) => RawAclValueLambda.BinaryLength);
        }


        public static IObservable<System.Security.AccessControl.GenericAce> get_Item(this IObservable<System.Security.AccessControl.RawAcl> RawAclValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(RawAclValue, index, (RawAclValueLambda, indexLambda) => RawAclValueLambda[indexLambda]);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Security.AccessControl.RawAcl> RawAclValue, IObservable<System.Int32> index, IObservable<System.Security.AccessControl.GenericAce> value)
        {
            return ObservableExt.ZipExecute(RawAclValue, index, value, (RawAclValueLambda, indexLambda, valueLambda) => RawAclValueLambda[indexLambda] = valueLambda);
        }

    }
}