using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __RuntimeHelpers
    {
        
        public static IObservable<System.Reactive.Unit> InitializeArray(IObservable<System.Array> array, IObservable<System.RuntimeFieldHandle> fldHandle)
        {
            return ObservableExt.ZipExecute(array, fldHandle, (arrayLambda, fldHandleLambda) => System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(arrayLambda, fldHandleLambda));
        }


        public static IObservable<System.Object> GetObjectValue(IObservable<System.Object> obj)
        {
            return Observable.Select(obj, (objLambda) => System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(objLambda));
        }


        public static IObservable<System.Reactive.Unit> RunClassConstructor(IObservable<System.RuntimeTypeHandle> type)
        {
            return Observable.Do(type, (typeLambda) => System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> RunModuleConstructor(IObservable<System.ModuleHandle> module)
        {
            return Observable.Do(module, (moduleLambda) => System.Runtime.CompilerServices.RuntimeHelpers.RunModuleConstructor(moduleLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> PrepareMethod(IObservable<System.RuntimeMethodHandle> method)
        {
            return Observable.Do(method, (methodLambda) => System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(methodLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> PrepareMethod(IObservable<System.RuntimeMethodHandle> method, IObservable<System.RuntimeTypeHandle[]> instantiation)
        {
            return ObservableExt.ZipExecute(method, instantiation, (methodLambda, instantiationLambda) => System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(methodLambda, instantiationLambda));
        }


        public static IObservable<System.Reactive.Unit> PrepareDelegate(IObservable<System.Delegate> d)
        {
            return Observable.Do(d, (dLambda) => System.Runtime.CompilerServices.RuntimeHelpers.PrepareDelegate(dLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> PrepareContractedDelegate(IObservable<System.Delegate> d)
        {
            return Observable.Do(d, (dLambda) => System.Runtime.CompilerServices.RuntimeHelpers.PrepareContractedDelegate(dLambda)).ToUnit();
        }


        public static IObservable<System.Int32> GetHashCode(IObservable<System.Object> o)
        {
            return Observable.Select(o, (oLambda) => System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(oLambda));
        }


        public static IObservable<System.Boolean> Equals(IObservable<System.Object> o1, IObservable<System.Object> o2)
        {
            return Observable.Zip(o1, o2, (o1Lambda, o2Lambda) => System.Runtime.CompilerServices.RuntimeHelpers.Equals(o1Lambda, o2Lambda));
        }


        public static IObservable<System.Reactive.Unit> EnsureSufficientExecutionStack()
        {
            return ObservableExt.Factory(() => System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack());
        }


        public static IObservable<System.Reactive.Unit> ProbeForSufficientStack()
        {
            return ObservableExt.Factory(() => System.Runtime.CompilerServices.RuntimeHelpers.ProbeForSufficientStack());
        }


        public static IObservable<System.Reactive.Unit> PrepareConstrainedRegions()
        {
            return ObservableExt.Factory(() => System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions());
        }


        public static IObservable<System.Reactive.Unit> PrepareConstrainedRegionsNoOP()
        {
            return ObservableExt.Factory(() => System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegionsNoOP());
        }


        public static IObservable<System.Reactive.Unit> ExecuteCodeWithGuaranteedCleanup(IObservable<System.Runtime.CompilerServices.RuntimeHelpers.TryCode> code, IObservable<System.Runtime.CompilerServices.RuntimeHelpers.CleanupCode> backoutCode, IObservable<System.Object> userData)
        {
            return ObservableExt.ZipExecute(code, backoutCode, userData, (codeLambda, backoutCodeLambda, userDataLambda) => System.Runtime.CompilerServices.RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup(codeLambda, backoutCodeLambda, userDataLambda));
        }


        public static IObservable<System.Int32> get_OffsetToStringData()
        {
            return ObservableExt.Factory(() => System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData);
        }

    }
}