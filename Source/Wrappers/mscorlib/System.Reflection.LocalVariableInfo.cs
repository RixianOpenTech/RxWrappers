using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __LocalVariableInfo
    {
        public static IObservable<System.String> ToString(
            this IObservable<System.Reflection.LocalVariableInfo> LocalVariableInfoValue)
        {
            return Observable.Select(LocalVariableInfoValue,
                (LocalVariableInfoValueLambda) => LocalVariableInfoValueLambda.ToString());
        }


        public static IObservable<System.Type> get_LocalType(
            this IObservable<System.Reflection.LocalVariableInfo> LocalVariableInfoValue)
        {
            return Observable.Select(LocalVariableInfoValue,
                (LocalVariableInfoValueLambda) => LocalVariableInfoValueLambda.LocalType);
        }


        public static IObservable<System.Boolean> get_IsPinned(
            this IObservable<System.Reflection.LocalVariableInfo> LocalVariableInfoValue)
        {
            return Observable.Select(LocalVariableInfoValue,
                (LocalVariableInfoValueLambda) => LocalVariableInfoValueLambda.IsPinned);
        }


        public static IObservable<System.Int32> get_LocalIndex(
            this IObservable<System.Reflection.LocalVariableInfo> LocalVariableInfoValue)
        {
            return Observable.Select(LocalVariableInfoValue,
                (LocalVariableInfoValueLambda) => LocalVariableInfoValueLambda.LocalIndex);
        }
    }
}