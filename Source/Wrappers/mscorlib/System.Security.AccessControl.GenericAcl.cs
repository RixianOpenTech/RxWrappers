using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.AccessControl
{
    public static class __GenericAcl
    {
        
        public static IObservable<System.Reactive.Unit> GetBinaryForm(this IObservable<System.Security.AccessControl.GenericAcl> GenericAclValue, IObservable<System.Byte[]> binaryForm, IObservable<System.Int32> offset)
        {
            return ObservableExt.ZipExecute(GenericAclValue, binaryForm, offset, (GenericAclValueLambda, binaryFormLambda, offsetLambda) => GenericAclValueLambda.GetBinaryForm(binaryFormLambda, offsetLambda));
        }


        public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Security.AccessControl.GenericAcl> GenericAclValue, IObservable<System.Security.AccessControl.GenericAce[]> array, IObservable<System.Int32> index)
        {
            return ObservableExt.ZipExecute(GenericAclValue, array, index, (GenericAclValueLambda, arrayLambda, indexLambda) => GenericAclValueLambda.CopyTo(arrayLambda, indexLambda));
        }


        public static IObservable<System.Security.AccessControl.AceEnumerator> GetEnumerator(this IObservable<System.Security.AccessControl.GenericAcl> GenericAclValue)
        {
            return Observable.Select(GenericAclValue, (GenericAclValueLambda) => GenericAclValueLambda.GetEnumerator());
        }


        public static IObservable<System.Byte> get_Revision(this IObservable<System.Security.AccessControl.GenericAcl> GenericAclValue)
        {
            return Observable.Select(GenericAclValue, (GenericAclValueLambda) => GenericAclValueLambda.Revision);
        }


        public static IObservable<System.Int32> get_BinaryLength(this IObservable<System.Security.AccessControl.GenericAcl> GenericAclValue)
        {
            return Observable.Select(GenericAclValue, (GenericAclValueLambda) => GenericAclValueLambda.BinaryLength);
        }


        public static IObservable<System.Security.AccessControl.GenericAce> get_Item(this IObservable<System.Security.AccessControl.GenericAcl> GenericAclValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(GenericAclValue, index, (GenericAclValueLambda, indexLambda) => GenericAclValueLambda[indexLambda]);
        }


        public static IObservable<System.Int32> get_Count(this IObservable<System.Security.AccessControl.GenericAcl> GenericAclValue)
        {
            return Observable.Select(GenericAclValue, (GenericAclValueLambda) => GenericAclValueLambda.Count);
        }


        public static IObservable<System.Boolean> get_IsSynchronized(this IObservable<System.Security.AccessControl.GenericAcl> GenericAclValue)
        {
            return Observable.Select(GenericAclValue, (GenericAclValueLambda) => GenericAclValueLambda.IsSynchronized);
        }


        public static IObservable<System.Object> get_SyncRoot(this IObservable<System.Security.AccessControl.GenericAcl> GenericAclValue)
        {
            return Observable.Select(GenericAclValue, (GenericAclValueLambda) => GenericAclValueLambda.SyncRoot);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<System.Security.AccessControl.GenericAcl> GenericAclValue, IObservable<System.Int32> index, IObservable<System.Security.AccessControl.GenericAce> value)
        {
            return ObservableExt.ZipExecute(GenericAclValue, index, value, (GenericAclValueLambda, indexLambda, valueLambda) => GenericAclValueLambda[indexLambda] = valueLambda);
        }

    }
}