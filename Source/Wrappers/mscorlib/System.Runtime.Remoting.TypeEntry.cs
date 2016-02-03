using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
    public static class __TypeEntry
    {
        public static IObservable<System.String> get_TypeName(
            this IObservable<System.Runtime.Remoting.TypeEntry> TypeEntryValue)
        {
            return Observable.Select(TypeEntryValue, (TypeEntryValueLambda) => TypeEntryValueLambda.TypeName);
        }


        public static IObservable<System.String> get_AssemblyName(
            this IObservable<System.Runtime.Remoting.TypeEntry> TypeEntryValue)
        {
            return Observable.Select(TypeEntryValue, (TypeEntryValueLambda) => TypeEntryValueLambda.AssemblyName);
        }


        public static IObservable<System.Reactive.Unit> set_TypeName(
            this IObservable<System.Runtime.Remoting.TypeEntry> TypeEntryValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(TypeEntryValue, value,
                (TypeEntryValueLambda, valueLambda) => TypeEntryValueLambda.TypeName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AssemblyName(
            this IObservable<System.Runtime.Remoting.TypeEntry> TypeEntryValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(TypeEntryValue, value,
                (TypeEntryValueLambda, valueLambda) => TypeEntryValueLambda.AssemblyName = valueLambda);
        }
    }
}