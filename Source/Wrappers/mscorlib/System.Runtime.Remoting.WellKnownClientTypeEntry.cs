using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
    public static class __WellKnownClientTypeEntry
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.WellKnownClientTypeEntry> WellKnownClientTypeEntryValue)
        {
            return Observable.Select(WellKnownClientTypeEntryValue, (WellKnownClientTypeEntryValueLambda) => WellKnownClientTypeEntryValueLambda.ToString());
        }


        public static IObservable<System.String> get_ObjectUrl(this IObservable<System.Runtime.Remoting.WellKnownClientTypeEntry> WellKnownClientTypeEntryValue)
        {
            return Observable.Select(WellKnownClientTypeEntryValue, (WellKnownClientTypeEntryValueLambda) => WellKnownClientTypeEntryValueLambda.ObjectUrl);
        }


        public static IObservable<System.Type> get_ObjectType(this IObservable<System.Runtime.Remoting.WellKnownClientTypeEntry> WellKnownClientTypeEntryValue)
        {
            return Observable.Select(WellKnownClientTypeEntryValue, (WellKnownClientTypeEntryValueLambda) => WellKnownClientTypeEntryValueLambda.ObjectType);
        }


        public static IObservable<System.String> get_ApplicationUrl(this IObservable<System.Runtime.Remoting.WellKnownClientTypeEntry> WellKnownClientTypeEntryValue)
        {
            return Observable.Select(WellKnownClientTypeEntryValue, (WellKnownClientTypeEntryValueLambda) => WellKnownClientTypeEntryValueLambda.ApplicationUrl);
        }


        public static IObservable<System.Reactive.Unit> set_ApplicationUrl(this IObservable<System.Runtime.Remoting.WellKnownClientTypeEntry> WellKnownClientTypeEntryValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(WellKnownClientTypeEntryValue, value, (WellKnownClientTypeEntryValueLambda, valueLambda) => WellKnownClientTypeEntryValueLambda.ApplicationUrl = valueLambda);
        }

    }
}