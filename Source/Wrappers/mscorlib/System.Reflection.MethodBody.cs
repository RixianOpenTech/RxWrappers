using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __MethodBody
    {
        public static IObservable<System.Byte[]> GetILAsByteArray(
            this IObservable<System.Reflection.MethodBody> MethodBodyValue)
        {
            return Observable.Select(MethodBodyValue,
                (MethodBodyValueLambda) => MethodBodyValueLambda.GetILAsByteArray());
        }


        public static IObservable<System.Int32> get_LocalSignatureMetadataToken(
            this IObservable<System.Reflection.MethodBody> MethodBodyValue)
        {
            return Observable.Select(MethodBodyValue,
                (MethodBodyValueLambda) => MethodBodyValueLambda.LocalSignatureMetadataToken);
        }


        public static IObservable<System.Collections.Generic.IList<System.Reflection.LocalVariableInfo>>
            get_LocalVariables(this IObservable<System.Reflection.MethodBody> MethodBodyValue)
        {
            return Observable.Select(MethodBodyValue, (MethodBodyValueLambda) => MethodBodyValueLambda.LocalVariables);
        }


        public static IObservable<System.Int32> get_MaxStackSize(
            this IObservable<System.Reflection.MethodBody> MethodBodyValue)
        {
            return Observable.Select(MethodBodyValue, (MethodBodyValueLambda) => MethodBodyValueLambda.MaxStackSize);
        }


        public static IObservable<System.Boolean> get_InitLocals(
            this IObservable<System.Reflection.MethodBody> MethodBodyValue)
        {
            return Observable.Select(MethodBodyValue, (MethodBodyValueLambda) => MethodBodyValueLambda.InitLocals);
        }


        public static IObservable<System.Collections.Generic.IList<System.Reflection.ExceptionHandlingClause>>
            get_ExceptionHandlingClauses(this IObservable<System.Reflection.MethodBody> MethodBodyValue)
        {
            return Observable.Select(MethodBodyValue,
                (MethodBodyValueLambda) => MethodBodyValueLambda.ExceptionHandlingClauses);
        }
    }
}