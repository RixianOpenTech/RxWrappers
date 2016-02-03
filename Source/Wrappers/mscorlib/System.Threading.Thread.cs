using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
public static class _Thread
{
    
public static IObservable<System.Int32> GetHashCode(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.GetHashCode());
}


public static IObservable<System.Reactive.Unit> Start(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Do(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.Start()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Start(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Object> parameter)
{
    return ObservableExt.ZipExecute(ThreadValue, parameter, (ThreadValueLambda, parameterLambda) => ThreadValueLambda.Start(parameterLambda));
}


public static IObservable<System.Reactive.Unit> SetCompressedStack(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Threading.CompressedStack> stack)
{
    return ObservableExt.ZipExecute(ThreadValue, stack, (ThreadValueLambda, stackLambda) => ThreadValueLambda.SetCompressedStack(stackLambda));
}


public static IObservable<System.Threading.CompressedStack> GetCompressedStack(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.GetCompressedStack());
}


public static IObservable<System.Reactive.Unit> Abort(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Object> stateInfo)
{
    return ObservableExt.ZipExecute(ThreadValue, stateInfo, (ThreadValueLambda, stateInfoLambda) => ThreadValueLambda.Abort(stateInfoLambda));
}


public static IObservable<System.Reactive.Unit> Abort(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Do(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.Abort()).ToUnit();
}


public static IObservable<System.Reactive.Unit> ResetAbort()
{
    return ObservableExt.Factory(() => System.Threading.Thread.ResetAbort());
}


public static IObservable<System.Reactive.Unit> Suspend(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Do(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.Suspend()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Resume(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Do(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.Resume()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Interrupt(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Do(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.Interrupt()).ToUnit();
}


public static IObservable<System.Reactive.Unit> Join(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Do(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.Join()).ToUnit();
}


public static IObservable<System.Boolean> Join(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Int32> millisecondsTimeout)
{
    return Observable.Zip(ThreadValue, millisecondsTimeout, (ThreadValueLambda, millisecondsTimeoutLambda) => ThreadValueLambda.Join(millisecondsTimeoutLambda));
}


public static IObservable<System.Boolean> Join(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.TimeSpan> timeout)
{
    return Observable.Zip(ThreadValue, timeout, (ThreadValueLambda, timeoutLambda) => ThreadValueLambda.Join(timeoutLambda));
}


public static IObservable<System.Reactive.Unit> Sleep(IObservable<System.Int32> millisecondsTimeout)
{
    return Observable.Do(millisecondsTimeout, (millisecondsTimeoutLambda) => System.Threading.Thread.Sleep(millisecondsTimeoutLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Sleep(IObservable<System.TimeSpan> timeout)
{
    return Observable.Do(timeout, (timeoutLambda) => System.Threading.Thread.Sleep(timeoutLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> SpinWait(IObservable<System.Int32> iterations)
{
    return Observable.Do(iterations, (iterationsLambda) => System.Threading.Thread.SpinWait(iterationsLambda)).ToUnit();
}


public static IObservable<System.Boolean> Yield()
{
    return ObservableExt.Factory(() => System.Threading.Thread.Yield());
}


public static IObservable<System.Reactive.Unit> DisableComObjectEagerCleanup(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Do(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.DisableComObjectEagerCleanup()).ToUnit();
}


public static IObservable<System.Threading.ApartmentState> GetApartmentState(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.GetApartmentState());
}


public static IObservable<System.Boolean> TrySetApartmentState(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Threading.ApartmentState> state)
{
    return Observable.Zip(ThreadValue, state, (ThreadValueLambda, stateLambda) => ThreadValueLambda.TrySetApartmentState(stateLambda));
}


public static IObservable<System.Reactive.Unit> SetApartmentState(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Threading.ApartmentState> state)
{
    return ObservableExt.ZipExecute(ThreadValue, state, (ThreadValueLambda, stateLambda) => ThreadValueLambda.SetApartmentState(stateLambda));
}


public static IObservable<System.LocalDataStoreSlot> AllocateDataSlot()
{
    return ObservableExt.Factory(() => System.Threading.Thread.AllocateDataSlot());
}


public static IObservable<System.LocalDataStoreSlot> AllocateNamedDataSlot(IObservable<System.String> name)
{
    return Observable.Select(name, (nameLambda) => System.Threading.Thread.AllocateNamedDataSlot(nameLambda));
}


public static IObservable<System.LocalDataStoreSlot> GetNamedDataSlot(IObservable<System.String> name)
{
    return Observable.Select(name, (nameLambda) => System.Threading.Thread.GetNamedDataSlot(nameLambda));
}


public static IObservable<System.Reactive.Unit> FreeNamedDataSlot(IObservable<System.String> name)
{
    return Observable.Do(name, (nameLambda) => System.Threading.Thread.FreeNamedDataSlot(nameLambda)).ToUnit();
}


public static IObservable<System.Object> GetData(IObservable<System.LocalDataStoreSlot> slot)
{
    return Observable.Select(slot, (slotLambda) => System.Threading.Thread.GetData(slotLambda));
}


public static IObservable<System.Reactive.Unit> SetData(IObservable<System.LocalDataStoreSlot> slot, IObservable<System.Object> data)
{
    return ObservableExt.ZipExecute(slot, data, (slotLambda, dataLambda) => System.Threading.Thread.SetData(slotLambda, dataLambda));
}


public static IObservable<System.AppDomain> GetDomain()
{
    return ObservableExt.Factory(() => System.Threading.Thread.GetDomain());
}


public static IObservable<System.Int32> GetDomainID()
{
    return ObservableExt.Factory(() => System.Threading.Thread.GetDomainID());
}


public static IObservable<System.Reactive.Unit> BeginCriticalRegion()
{
    return ObservableExt.Factory(() => System.Threading.Thread.BeginCriticalRegion());
}


public static IObservable<System.Reactive.Unit> EndCriticalRegion()
{
    return ObservableExt.Factory(() => System.Threading.Thread.EndCriticalRegion());
}


public static IObservable<System.Reactive.Unit> BeginThreadAffinity()
{
    return ObservableExt.Factory(() => System.Threading.Thread.BeginThreadAffinity());
}


public static IObservable<System.Reactive.Unit> EndThreadAffinity()
{
    return ObservableExt.Factory(() => System.Threading.Thread.EndThreadAffinity());
}


public static IObservable<Tuple<System.Byte, System.Byte>> VolatileRead(IObservable<System.Byte> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.Int16, System.Int16>> VolatileRead(IObservable<System.Int16> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.Int32, System.Int32>> VolatileRead(IObservable<System.Int32> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.Int64, System.Int64>> VolatileRead(IObservable<System.Int64> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.SByte, System.SByte>> VolatileRead(IObservable<System.SByte> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.UInt16, System.UInt16>> VolatileRead(IObservable<System.UInt16> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.UInt32, System.UInt32>> VolatileRead(IObservable<System.UInt32> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.IntPtr, System.IntPtr>> VolatileRead(IObservable<System.IntPtr> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.UIntPtr, System.UIntPtr>> VolatileRead(IObservable<System.UIntPtr> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.UInt64, System.UInt64>> VolatileRead(IObservable<System.UInt64> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.Single, System.Single>> VolatileRead(IObservable<System.Single> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.Double, System.Double>> VolatileRead(IObservable<System.Double> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<Tuple<System.Object, System.Object>> VolatileRead(IObservable<System.Object> address)
{
    return Observable.Select(address, (addressLambda) => {
var result = System.Threading.Thread.VolatileRead(ref addressLambda);
return Tuple.Create(result, addressLambda);
});
}


public static IObservable<System.Byte> VolatileWrite(IObservable<System.Byte> address, IObservable<System.Byte> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.Int16> VolatileWrite(IObservable<System.Int16> address, IObservable<System.Int16> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.Int32> VolatileWrite(IObservable<System.Int32> address, IObservable<System.Int32> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.Int64> VolatileWrite(IObservable<System.Int64> address, IObservable<System.Int64> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.SByte> VolatileWrite(IObservable<System.SByte> address, IObservable<System.SByte> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.UInt16> VolatileWrite(IObservable<System.UInt16> address, IObservable<System.UInt16> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.UInt32> VolatileWrite(IObservable<System.UInt32> address, IObservable<System.UInt32> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.IntPtr> VolatileWrite(IObservable<System.IntPtr> address, IObservable<System.IntPtr> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.UIntPtr> VolatileWrite(IObservable<System.UIntPtr> address, IObservable<System.UIntPtr> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.UInt64> VolatileWrite(IObservable<System.UInt64> address, IObservable<System.UInt64> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.Single> VolatileWrite(IObservable<System.Single> address, IObservable<System.Single> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.Double> VolatileWrite(IObservable<System.Double> address, IObservable<System.Double> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.Object> VolatileWrite(IObservable<System.Object> address, IObservable<System.Object> value)
{
    return Observable.Zip(address, value, (addressLambda, valueLambda) => {
System.Threading.Thread.VolatileWrite(ref addressLambda, valueLambda);
return addressLambda;
});
}


public static IObservable<System.Reactive.Unit> MemoryBarrier()
{
    return ObservableExt.Factory(() => System.Threading.Thread.MemoryBarrier());
}


public static IObservable<System.Int32> get_ManagedThreadId(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.ManagedThreadId);
}


public static IObservable<System.Threading.ExecutionContext> get_ExecutionContext(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.ExecutionContext);
}


public static IObservable<System.Threading.ThreadPriority> get_Priority(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.Priority);
}


public static IObservable<System.Boolean> get_IsAlive(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.IsAlive);
}


public static IObservable<System.Boolean> get_IsThreadPoolThread(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.IsThreadPoolThread);
}


public static IObservable<System.Threading.Thread> get_CurrentThread()
{
    return ObservableExt.Factory(() => System.Threading.Thread.CurrentThread);
}


public static IObservable<System.Boolean> get_IsBackground(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.IsBackground);
}


public static IObservable<System.Threading.ThreadState> get_ThreadState(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.ThreadState);
}


public static IObservable<System.Threading.ApartmentState> get_ApartmentState(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.ApartmentState);
}


public static IObservable<System.Globalization.CultureInfo> get_CurrentUICulture(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.CurrentUICulture);
}


public static IObservable<System.Globalization.CultureInfo> get_CurrentCulture(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.CurrentCulture);
}


public static IObservable<System.Runtime.Remoting.Contexts.Context> get_CurrentContext()
{
    return ObservableExt.Factory(() => System.Threading.Thread.CurrentContext);
}


public static IObservable<System.Security.Principal.IPrincipal> get_CurrentPrincipal()
{
    return ObservableExt.Factory(() => System.Threading.Thread.CurrentPrincipal);
}


public static IObservable<System.String> get_Name(this IObservable<System.Threading.Thread> ThreadValue)
{
    return Observable.Select(ThreadValue, (ThreadValueLambda) => ThreadValueLambda.Name);
}


public static IObservable<System.Reactive.Unit> set_Priority(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Threading.ThreadPriority> value)
{
    return ObservableExt.ZipExecute(ThreadValue, value, (ThreadValueLambda, valueLambda) => ThreadValueLambda.Priority = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_IsBackground(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Boolean> value)
{
    return ObservableExt.ZipExecute(ThreadValue, value, (ThreadValueLambda, valueLambda) => ThreadValueLambda.IsBackground = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_ApartmentState(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Threading.ApartmentState> value)
{
    return ObservableExt.ZipExecute(ThreadValue, value, (ThreadValueLambda, valueLambda) => ThreadValueLambda.ApartmentState = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_CurrentUICulture(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Globalization.CultureInfo> value)
{
    return ObservableExt.ZipExecute(ThreadValue, value, (ThreadValueLambda, valueLambda) => ThreadValueLambda.CurrentUICulture = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_CurrentCulture(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.Globalization.CultureInfo> value)
{
    return ObservableExt.ZipExecute(ThreadValue, value, (ThreadValueLambda, valueLambda) => ThreadValueLambda.CurrentCulture = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_CurrentPrincipal(IObservable<System.Security.Principal.IPrincipal> value)
{
    return Observable.Do(value, (valueLambda) => System.Threading.Thread.CurrentPrincipal = valueLambda).ToUnit();
}


public static IObservable<System.Reactive.Unit> set_Name(this IObservable<System.Threading.Thread> ThreadValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(ThreadValue, value, (ThreadValueLambda, valueLambda) => ThreadValueLambda.Name = valueLambda);
}

}
}