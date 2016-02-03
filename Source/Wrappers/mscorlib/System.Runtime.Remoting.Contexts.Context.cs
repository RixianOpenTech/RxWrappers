using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
public static class _Context
{
    
public static IObservable<System.Reactive.Unit> SetProperty(this IObservable<System.Runtime.Remoting.Contexts.Context> ContextValue, IObservable<System.Runtime.Remoting.Contexts.IContextProperty> prop)
{
    return ObservableExt.ZipExecute(ContextValue, prop, (ContextValueLambda, propLambda) => ContextValueLambda.SetProperty(propLambda));
}


public static IObservable<System.Runtime.Remoting.Contexts.IContextProperty> GetProperty(this IObservable<System.Runtime.Remoting.Contexts.Context> ContextValue, IObservable<System.String> name)
{
    return Observable.Zip(ContextValue, name, (ContextValueLambda, nameLambda) => ContextValueLambda.GetProperty(nameLambda));
}


public static IObservable<System.Reactive.Unit> Freeze(this IObservable<System.Runtime.Remoting.Contexts.Context> ContextValue)
{
    return Observable.Do(ContextValue, (ContextValueLambda) => ContextValueLambda.Freeze()).ToUnit();
}


public static IObservable<System.String> ToString(this IObservable<System.Runtime.Remoting.Contexts.Context> ContextValue)
{
    return Observable.Select(ContextValue, (ContextValueLambda) => ContextValueLambda.ToString());
}


public static IObservable<System.Reactive.Unit> DoCallBack(this IObservable<System.Runtime.Remoting.Contexts.Context> ContextValue, IObservable<System.Runtime.Remoting.Contexts.CrossContextDelegate> deleg)
{
    return ObservableExt.ZipExecute(ContextValue, deleg, (ContextValueLambda, delegLambda) => ContextValueLambda.DoCallBack(delegLambda));
}


public static IObservable<System.LocalDataStoreSlot> AllocateDataSlot()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Contexts.Context.AllocateDataSlot());
}


public static IObservable<System.LocalDataStoreSlot> AllocateNamedDataSlot(IObservable<System.String> name)
{
    return Observable.Select(name, (nameLambda) => System.Runtime.Remoting.Contexts.Context.AllocateNamedDataSlot(nameLambda));
}


public static IObservable<System.LocalDataStoreSlot> GetNamedDataSlot(IObservable<System.String> name)
{
    return Observable.Select(name, (nameLambda) => System.Runtime.Remoting.Contexts.Context.GetNamedDataSlot(nameLambda));
}


public static IObservable<System.Reactive.Unit> FreeNamedDataSlot(IObservable<System.String> name)
{
    return Observable.Do(name, (nameLambda) => System.Runtime.Remoting.Contexts.Context.FreeNamedDataSlot(nameLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> SetData(IObservable<System.LocalDataStoreSlot> slot, IObservable<System.Object> data)
{
    return ObservableExt.ZipExecute(slot, data, (slotLambda, dataLambda) => System.Runtime.Remoting.Contexts.Context.SetData(slotLambda, dataLambda));
}


public static IObservable<System.Object> GetData(IObservable<System.LocalDataStoreSlot> slot)
{
    return Observable.Select(slot, (slotLambda) => System.Runtime.Remoting.Contexts.Context.GetData(slotLambda));
}


public static IObservable<System.Boolean> RegisterDynamicProperty(IObservable<System.Runtime.Remoting.Contexts.IDynamicProperty> prop, IObservable<System.ContextBoundObject> obj, IObservable<System.Runtime.Remoting.Contexts.Context> ctx)
{
    return Observable.Zip(prop, obj, ctx, (propLambda, objLambda, ctxLambda) => System.Runtime.Remoting.Contexts.Context.RegisterDynamicProperty(propLambda, objLambda, ctxLambda));
}


public static IObservable<System.Boolean> UnregisterDynamicProperty(IObservable<System.String> name, IObservable<System.ContextBoundObject> obj, IObservable<System.Runtime.Remoting.Contexts.Context> ctx)
{
    return Observable.Zip(name, obj, ctx, (nameLambda, objLambda, ctxLambda) => System.Runtime.Remoting.Contexts.Context.UnregisterDynamicProperty(nameLambda, objLambda, ctxLambda));
}


public static IObservable<System.Int32> get_ContextID(this IObservable<System.Runtime.Remoting.Contexts.Context> ContextValue)
{
    return Observable.Select(ContextValue, (ContextValueLambda) => ContextValueLambda.ContextID);
}


public static IObservable<System.Runtime.Remoting.Contexts.Context> get_DefaultContext()
{
    return ObservableExt.Factory(() => System.Runtime.Remoting.Contexts.Context.DefaultContext);
}


public static IObservable<System.Runtime.Remoting.Contexts.IContextProperty[]> get_ContextProperties(this IObservable<System.Runtime.Remoting.Contexts.Context> ContextValue)
{
    return Observable.Select(ContextValue, (ContextValueLambda) => ContextValueLambda.ContextProperties);
}

}
}