using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __ICustomMarshaler
    {
        
        public static IObservable<System.Object> MarshalNativeToManaged(this IObservable<System.Runtime.InteropServices.ICustomMarshaler> ICustomMarshalerValue, IObservable<System.IntPtr> pNativeData)
        {
            return Observable.Zip(ICustomMarshalerValue, pNativeData, (ICustomMarshalerValueLambda, pNativeDataLambda) => ICustomMarshalerValueLambda.MarshalNativeToManaged(pNativeDataLambda));
        }


        public static IObservable<System.IntPtr> MarshalManagedToNative(this IObservable<System.Runtime.InteropServices.ICustomMarshaler> ICustomMarshalerValue, IObservable<System.Object> ManagedObj)
        {
            return Observable.Zip(ICustomMarshalerValue, ManagedObj, (ICustomMarshalerValueLambda, ManagedObjLambda) => ICustomMarshalerValueLambda.MarshalManagedToNative(ManagedObjLambda));
        }


        public static IObservable<System.Reactive.Unit> CleanUpNativeData(this IObservable<System.Runtime.InteropServices.ICustomMarshaler> ICustomMarshalerValue, IObservable<System.IntPtr> pNativeData)
        {
            return ObservableExt.ZipExecute(ICustomMarshalerValue, pNativeData, (ICustomMarshalerValueLambda, pNativeDataLambda) => ICustomMarshalerValueLambda.CleanUpNativeData(pNativeDataLambda));
        }


        public static IObservable<System.Reactive.Unit> CleanUpManagedData(this IObservable<System.Runtime.InteropServices.ICustomMarshaler> ICustomMarshalerValue, IObservable<System.Object> ManagedObj)
        {
            return ObservableExt.ZipExecute(ICustomMarshalerValue, ManagedObj, (ICustomMarshalerValueLambda, ManagedObjLambda) => ICustomMarshalerValueLambda.CleanUpManagedData(ManagedObjLambda));
        }


        public static IObservable<System.Int32> GetNativeDataSize(this IObservable<System.Runtime.InteropServices.ICustomMarshaler> ICustomMarshalerValue)
        {
            return Observable.Select(ICustomMarshalerValue, (ICustomMarshalerValueLambda) => ICustomMarshalerValueLambda.GetNativeDataSize());
        }

    }
}