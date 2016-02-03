using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
    public static class __WellKnownServiceTypeEntry
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.WellKnownServiceTypeEntry> WellKnownServiceTypeEntryValue)
        {
            return Observable.Select(WellKnownServiceTypeEntryValue, (WellKnownServiceTypeEntryValueLambda) => WellKnownServiceTypeEntryValueLambda.ToString());
        }


        public static IObservable<System.String> get_ObjectUri(this IObservable<System.Runtime.Remoting.WellKnownServiceTypeEntry> WellKnownServiceTypeEntryValue)
        {
            return Observable.Select(WellKnownServiceTypeEntryValue, (WellKnownServiceTypeEntryValueLambda) => WellKnownServiceTypeEntryValueLambda.ObjectUri);
        }


        public static IObservable<System.Runtime.Remoting.WellKnownObjectMode> get_Mode(this IObservable<System.Runtime.Remoting.WellKnownServiceTypeEntry> WellKnownServiceTypeEntryValue)
        {
            return Observable.Select(WellKnownServiceTypeEntryValue, (WellKnownServiceTypeEntryValueLambda) => WellKnownServiceTypeEntryValueLambda.Mode);
        }


        public static IObservable<System.Type> get_ObjectType(this IObservable<System.Runtime.Remoting.WellKnownServiceTypeEntry> WellKnownServiceTypeEntryValue)
        {
            return Observable.Select(WellKnownServiceTypeEntryValue, (WellKnownServiceTypeEntryValueLambda) => WellKnownServiceTypeEntryValueLambda.ObjectType);
        }


        public static IObservable<System.Runtime.Remoting.Contexts.IContextAttribute[]> get_ContextAttributes(this IObservable<System.Runtime.Remoting.WellKnownServiceTypeEntry> WellKnownServiceTypeEntryValue)
        {
            return Observable.Select(WellKnownServiceTypeEntryValue, (WellKnownServiceTypeEntryValueLambda) => WellKnownServiceTypeEntryValueLambda.ContextAttributes);
        }


        public static IObservable<System.Reactive.Unit> set_ContextAttributes(this IObservable<System.Runtime.Remoting.WellKnownServiceTypeEntry> WellKnownServiceTypeEntryValue, IObservable<System.Runtime.Remoting.Contexts.IContextAttribute[]> value)
        {
            return ObservableExt.ZipExecute(WellKnownServiceTypeEntryValue, value, (WellKnownServiceTypeEntryValueLambda, valueLambda) => WellKnownServiceTypeEntryValueLambda.ContextAttributes = valueLambda);
        }

    }
}