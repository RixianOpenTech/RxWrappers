using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics
{
    public static class __DebuggerDisplayAttribute
    {
        
        public static IObservable<System.String> get_Value(this IObservable<System.Diagnostics.DebuggerDisplayAttribute> DebuggerDisplayAttributeValue)
        {
            return Observable.Select(DebuggerDisplayAttributeValue, (DebuggerDisplayAttributeValueLambda) => DebuggerDisplayAttributeValueLambda.Value);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Diagnostics.DebuggerDisplayAttribute> DebuggerDisplayAttributeValue)
        {
            return Observable.Select(DebuggerDisplayAttributeValue, (DebuggerDisplayAttributeValueLambda) => DebuggerDisplayAttributeValueLambda.Name);
        }


        public static IObservable<System.String> get_Type(this IObservable<System.Diagnostics.DebuggerDisplayAttribute> DebuggerDisplayAttributeValue)
        {
            return Observable.Select(DebuggerDisplayAttributeValue, (DebuggerDisplayAttributeValueLambda) => DebuggerDisplayAttributeValueLambda.Type);
        }


        public static IObservable<System.Type> get_Target(this IObservable<System.Diagnostics.DebuggerDisplayAttribute> DebuggerDisplayAttributeValue)
        {
            return Observable.Select(DebuggerDisplayAttributeValue, (DebuggerDisplayAttributeValueLambda) => DebuggerDisplayAttributeValueLambda.Target);
        }


        public static IObservable<System.String> get_TargetTypeName(this IObservable<System.Diagnostics.DebuggerDisplayAttribute> DebuggerDisplayAttributeValue)
        {
            return Observable.Select(DebuggerDisplayAttributeValue, (DebuggerDisplayAttributeValueLambda) => DebuggerDisplayAttributeValueLambda.TargetTypeName);
        }


        public static IObservable<System.Reactive.Unit> set_Name(this IObservable<System.Diagnostics.DebuggerDisplayAttribute> DebuggerDisplayAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DebuggerDisplayAttributeValue, value, (DebuggerDisplayAttributeValueLambda, valueLambda) => DebuggerDisplayAttributeValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Type(this IObservable<System.Diagnostics.DebuggerDisplayAttribute> DebuggerDisplayAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DebuggerDisplayAttributeValue, value, (DebuggerDisplayAttributeValueLambda, valueLambda) => DebuggerDisplayAttributeValueLambda.Type = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Target(this IObservable<System.Diagnostics.DebuggerDisplayAttribute> DebuggerDisplayAttributeValue, IObservable<System.Type> value)
        {
            return ObservableExt.ZipExecute(DebuggerDisplayAttributeValue, value, (DebuggerDisplayAttributeValueLambda, valueLambda) => DebuggerDisplayAttributeValueLambda.Target = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TargetTypeName(this IObservable<System.Diagnostics.DebuggerDisplayAttribute> DebuggerDisplayAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(DebuggerDisplayAttributeValue, value, (DebuggerDisplayAttributeValueLambda, valueLambda) => DebuggerDisplayAttributeValueLambda.TargetTypeName = valueLambda);
        }

    }
}