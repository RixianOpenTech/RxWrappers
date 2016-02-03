using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.SymbolStore
{
    public static class __ISymbolVariable
    {
        
        public static IObservable<System.Byte[]> GetSignature(this IObservable<System.Diagnostics.SymbolStore.ISymbolVariable> ISymbolVariableValue)
        {
            return Observable.Select(ISymbolVariableValue, (ISymbolVariableValueLambda) => ISymbolVariableValueLambda.GetSignature());
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Diagnostics.SymbolStore.ISymbolVariable> ISymbolVariableValue)
        {
            return Observable.Select(ISymbolVariableValue, (ISymbolVariableValueLambda) => ISymbolVariableValueLambda.Name);
        }


        public static IObservable<System.Object> get_Attributes(this IObservable<System.Diagnostics.SymbolStore.ISymbolVariable> ISymbolVariableValue)
        {
            return Observable.Select(ISymbolVariableValue, (ISymbolVariableValueLambda) => ISymbolVariableValueLambda.Attributes);
        }


        public static IObservable<System.Diagnostics.SymbolStore.SymAddressKind> get_AddressKind(this IObservable<System.Diagnostics.SymbolStore.ISymbolVariable> ISymbolVariableValue)
        {
            return Observable.Select(ISymbolVariableValue, (ISymbolVariableValueLambda) => ISymbolVariableValueLambda.AddressKind);
        }


        public static IObservable<System.Int32> get_AddressField1(this IObservable<System.Diagnostics.SymbolStore.ISymbolVariable> ISymbolVariableValue)
        {
            return Observable.Select(ISymbolVariableValue, (ISymbolVariableValueLambda) => ISymbolVariableValueLambda.AddressField1);
        }


        public static IObservable<System.Int32> get_AddressField2(this IObservable<System.Diagnostics.SymbolStore.ISymbolVariable> ISymbolVariableValue)
        {
            return Observable.Select(ISymbolVariableValue, (ISymbolVariableValueLambda) => ISymbolVariableValueLambda.AddressField2);
        }


        public static IObservable<System.Int32> get_AddressField3(this IObservable<System.Diagnostics.SymbolStore.ISymbolVariable> ISymbolVariableValue)
        {
            return Observable.Select(ISymbolVariableValue, (ISymbolVariableValueLambda) => ISymbolVariableValueLambda.AddressField3);
        }


        public static IObservable<System.Int32> get_StartOffset(this IObservable<System.Diagnostics.SymbolStore.ISymbolVariable> ISymbolVariableValue)
        {
            return Observable.Select(ISymbolVariableValue, (ISymbolVariableValueLambda) => ISymbolVariableValueLambda.StartOffset);
        }


        public static IObservable<System.Int32> get_EndOffset(this IObservable<System.Diagnostics.SymbolStore.ISymbolVariable> ISymbolVariableValue)
        {
            return Observable.Select(ISymbolVariableValue, (ISymbolVariableValueLambda) => ISymbolVariableValueLambda.EndOffset);
        }

    }
}