using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
    public static class __ActivatedServiceTypeEntry
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.ActivatedServiceTypeEntry> ActivatedServiceTypeEntryValue)
        {
            return Observable.Select(ActivatedServiceTypeEntryValue, (ActivatedServiceTypeEntryValueLambda) => ActivatedServiceTypeEntryValueLambda.ToString());
        }


        public static IObservable<System.Type> get_ObjectType(this IObservable<System.Runtime.Remoting.ActivatedServiceTypeEntry> ActivatedServiceTypeEntryValue)
        {
            return Observable.Select(ActivatedServiceTypeEntryValue, (ActivatedServiceTypeEntryValueLambda) => ActivatedServiceTypeEntryValueLambda.ObjectType);
        }


        public static IObservable<System.Runtime.Remoting.Contexts.IContextAttribute[]> get_ContextAttributes(this IObservable<System.Runtime.Remoting.ActivatedServiceTypeEntry> ActivatedServiceTypeEntryValue)
        {
            return Observable.Select(ActivatedServiceTypeEntryValue, (ActivatedServiceTypeEntryValueLambda) => ActivatedServiceTypeEntryValueLambda.ContextAttributes);
        }


        public static IObservable<System.Reactive.Unit> set_ContextAttributes(this IObservable<System.Runtime.Remoting.ActivatedServiceTypeEntry> ActivatedServiceTypeEntryValue, IObservable<System.Runtime.Remoting.Contexts.IContextAttribute[]> value)
        {
            return ObservableExt.ZipExecute(ActivatedServiceTypeEntryValue, value, (ActivatedServiceTypeEntryValueLambda, valueLambda) => ActivatedServiceTypeEntryValueLambda.ContextAttributes = valueLambda);
        }

    }
}