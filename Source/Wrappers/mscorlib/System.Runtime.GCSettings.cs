using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime
{
    public static class __GCSettings
    {
        public static IObservable<System.Runtime.GCLatencyMode> get_LatencyMode()
        {
            return ObservableExt.Factory(() => System.Runtime.GCSettings.LatencyMode);
        }


        public static IObservable<System.Runtime.GCLargeObjectHeapCompactionMode> get_LargeObjectHeapCompactionMode()
        {
            return ObservableExt.Factory(() => System.Runtime.GCSettings.LargeObjectHeapCompactionMode);
        }


        public static IObservable<System.Boolean> get_IsServerGC()
        {
            return ObservableExt.Factory(() => System.Runtime.GCSettings.IsServerGC);
        }


        public static IObservable<System.Reactive.Unit> set_LatencyMode(IObservable<System.Runtime.GCLatencyMode> value)
        {
            return Observable.Do(value, (valueLambda) => System.Runtime.GCSettings.LatencyMode = valueLambda).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> set_LargeObjectHeapCompactionMode(
            IObservable<System.Runtime.GCLargeObjectHeapCompactionMode> value)
        {
            return
                Observable.Do(value,
                    (valueLambda) => System.Runtime.GCSettings.LargeObjectHeapCompactionMode = valueLambda).ToUnit();
        }
    }
}