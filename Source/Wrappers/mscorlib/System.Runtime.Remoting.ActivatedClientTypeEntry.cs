using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting
{
public static class _ActivatedClientTypeEntry
{
    
public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.ActivatedClientTypeEntry> ActivatedClientTypeEntryValue)
{
    return Observable.Select(ActivatedClientTypeEntryValue, (ActivatedClientTypeEntryValueLambda) => ActivatedClientTypeEntryValueLambda.ToString());
}


public static IObservable<System.String> get_ApplicationUrl(this IObservable<System.Runtime.Remoting.ActivatedClientTypeEntry> ActivatedClientTypeEntryValue)
{
    return Observable.Select(ActivatedClientTypeEntryValue, (ActivatedClientTypeEntryValueLambda) => ActivatedClientTypeEntryValueLambda.ApplicationUrl);
}


public static IObservable<System.Type> get_ObjectType(this IObservable<System.Runtime.Remoting.ActivatedClientTypeEntry> ActivatedClientTypeEntryValue)
{
    return Observable.Select(ActivatedClientTypeEntryValue, (ActivatedClientTypeEntryValueLambda) => ActivatedClientTypeEntryValueLambda.ObjectType);
}


public static IObservable<System.Runtime.Remoting.Contexts.IContextAttribute[]> get_ContextAttributes(this IObservable<System.Runtime.Remoting.ActivatedClientTypeEntry> ActivatedClientTypeEntryValue)
{
    return Observable.Select(ActivatedClientTypeEntryValue, (ActivatedClientTypeEntryValueLambda) => ActivatedClientTypeEntryValueLambda.ContextAttributes);
}


public static IObservable<System.Reactive.Unit> set_ContextAttributes(this IObservable<System.Runtime.Remoting.ActivatedClientTypeEntry> ActivatedClientTypeEntryValue, IObservable<System.Runtime.Remoting.Contexts.IContextAttribute[]> value)
{
    return ObservableExt.ZipExecute(ActivatedClientTypeEntryValue, value, (ActivatedClientTypeEntryValueLambda, valueLambda) => ActivatedClientTypeEntryValueLambda.ContextAttributes = valueLambda);
}

}
}