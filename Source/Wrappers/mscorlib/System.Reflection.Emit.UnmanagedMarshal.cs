using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __UnmanagedMarshal
    {
        public static IObservable<System.Reflection.Emit.UnmanagedMarshal> DefineUnmanagedMarshal(
            IObservable<System.Runtime.InteropServices.UnmanagedType> unmanagedType)
        {
            return Observable.Select(unmanagedType,
                (unmanagedTypeLambda) =>
                    System.Reflection.Emit.UnmanagedMarshal.DefineUnmanagedMarshal(unmanagedTypeLambda));
        }


        public static IObservable<System.Reflection.Emit.UnmanagedMarshal> DefineByValTStr(
            IObservable<System.Int32> elemCount)
        {
            return Observable.Select(elemCount,
                (elemCountLambda) => System.Reflection.Emit.UnmanagedMarshal.DefineByValTStr(elemCountLambda));
        }


        public static IObservable<System.Reflection.Emit.UnmanagedMarshal> DefineSafeArray(
            IObservable<System.Runtime.InteropServices.UnmanagedType> elemType)
        {
            return Observable.Select(elemType,
                (elemTypeLambda) => System.Reflection.Emit.UnmanagedMarshal.DefineSafeArray(elemTypeLambda));
        }


        public static IObservable<System.Reflection.Emit.UnmanagedMarshal> DefineByValArray(
            IObservable<System.Int32> elemCount)
        {
            return Observable.Select(elemCount,
                (elemCountLambda) => System.Reflection.Emit.UnmanagedMarshal.DefineByValArray(elemCountLambda));
        }


        public static IObservable<System.Reflection.Emit.UnmanagedMarshal> DefineLPArray(
            IObservable<System.Runtime.InteropServices.UnmanagedType> elemType)
        {
            return Observable.Select(elemType,
                (elemTypeLambda) => System.Reflection.Emit.UnmanagedMarshal.DefineLPArray(elemTypeLambda));
        }


        public static IObservable<System.Runtime.InteropServices.UnmanagedType> get_GetUnmanagedType(
            this IObservable<System.Reflection.Emit.UnmanagedMarshal> UnmanagedMarshalValue)
        {
            return Observable.Select(UnmanagedMarshalValue,
                (UnmanagedMarshalValueLambda) => UnmanagedMarshalValueLambda.GetUnmanagedType);
        }


        public static IObservable<System.Guid> get_IIDGuid(
            this IObservable<System.Reflection.Emit.UnmanagedMarshal> UnmanagedMarshalValue)
        {
            return Observable.Select(UnmanagedMarshalValue,
                (UnmanagedMarshalValueLambda) => UnmanagedMarshalValueLambda.IIDGuid);
        }


        public static IObservable<System.Int32> get_ElementCount(
            this IObservable<System.Reflection.Emit.UnmanagedMarshal> UnmanagedMarshalValue)
        {
            return Observable.Select(UnmanagedMarshalValue,
                (UnmanagedMarshalValueLambda) => UnmanagedMarshalValueLambda.ElementCount);
        }


        public static IObservable<System.Runtime.InteropServices.UnmanagedType> get_BaseType(
            this IObservable<System.Reflection.Emit.UnmanagedMarshal> UnmanagedMarshalValue)
        {
            return Observable.Select(UnmanagedMarshalValue,
                (UnmanagedMarshalValueLambda) => UnmanagedMarshalValueLambda.BaseType);
        }
    }
}