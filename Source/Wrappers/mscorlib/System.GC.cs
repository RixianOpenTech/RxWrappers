using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __GC
    {
        public static IObservable<System.Reactive.Unit> AddMemoryPressure(IObservable<System.Int64> bytesAllocated)
        {
            return
                Observable.Do(bytesAllocated,
                    (bytesAllocatedLambda) => System.GC.AddMemoryPressure(bytesAllocatedLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> RemoveMemoryPressure(IObservable<System.Int64> bytesAllocated)
        {
            return
                Observable.Do(bytesAllocated,
                    (bytesAllocatedLambda) => System.GC.RemoveMemoryPressure(bytesAllocatedLambda)).ToUnit();
        }


        public static IObservable<System.Int32> GetGeneration(IObservable<System.Object> obj)
        {
            return Observable.Select(obj, (objLambda) => System.GC.GetGeneration(objLambda));
        }


        public static IObservable<System.Reactive.Unit> Collect(IObservable<System.Int32> generation)
        {
            return Observable.Do(generation, (generationLambda) => System.GC.Collect(generationLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Collect()
        {
            return ObservableExt.Factory(() => System.GC.Collect());
        }


        public static IObservable<System.Reactive.Unit> Collect(IObservable<System.Int32> generation,
            IObservable<System.GCCollectionMode> mode)
        {
            return ObservableExt.ZipExecute(generation, mode,
                (generationLambda, modeLambda) => System.GC.Collect(generationLambda, modeLambda));
        }


        public static IObservable<System.Reactive.Unit> Collect(IObservable<System.Int32> generation,
            IObservable<System.GCCollectionMode> mode, IObservable<System.Boolean> blocking)
        {
            return ObservableExt.ZipExecute(generation, mode, blocking,
                (generationLambda, modeLambda, blockingLambda) =>
                    System.GC.Collect(generationLambda, modeLambda, blockingLambda));
        }


        public static IObservable<System.Reactive.Unit> Collect(IObservable<System.Int32> generation,
            IObservable<System.GCCollectionMode> mode, IObservable<System.Boolean> blocking,
            IObservable<System.Boolean> compacting)
        {
            return ObservableExt.ZipExecute(generation, mode, blocking, compacting,
                (generationLambda, modeLambda, blockingLambda, compactingLambda) =>
                    System.GC.Collect(generationLambda, modeLambda, blockingLambda, compactingLambda));
        }


        public static IObservable<System.Int32> CollectionCount(IObservable<System.Int32> generation)
        {
            return Observable.Select(generation, (generationLambda) => System.GC.CollectionCount(generationLambda));
        }


        public static IObservable<System.Reactive.Unit> KeepAlive(IObservable<System.Object> obj)
        {
            return Observable.Do(obj, (objLambda) => System.GC.KeepAlive(objLambda)).ToUnit();
        }


        public static IObservable<System.Int32> GetGeneration(IObservable<System.WeakReference> wo)
        {
            return Observable.Select(wo, (woLambda) => System.GC.GetGeneration(woLambda));
        }


        public static IObservable<System.Reactive.Unit> WaitForPendingFinalizers()
        {
            return ObservableExt.Factory(() => System.GC.WaitForPendingFinalizers());
        }


        public static IObservable<System.Reactive.Unit> SuppressFinalize(IObservable<System.Object> obj)
        {
            return Observable.Do(obj, (objLambda) => System.GC.SuppressFinalize(objLambda)).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> ReRegisterForFinalize(IObservable<System.Object> obj)
        {
            return Observable.Do(obj, (objLambda) => System.GC.ReRegisterForFinalize(objLambda)).ToUnit();
        }


        public static IObservable<System.Int64> GetTotalMemory(IObservable<System.Boolean> forceFullCollection)
        {
            return Observable.Select(forceFullCollection,
                (forceFullCollectionLambda) => System.GC.GetTotalMemory(forceFullCollectionLambda));
        }


        public static IObservable<System.Reactive.Unit> RegisterForFullGCNotification(
            IObservable<System.Int32> maxGenerationThreshold, IObservable<System.Int32> largeObjectHeapThreshold)
        {
            return ObservableExt.ZipExecute(maxGenerationThreshold, largeObjectHeapThreshold,
                (maxGenerationThresholdLambda, largeObjectHeapThresholdLambda) =>
                    System.GC.RegisterForFullGCNotification(maxGenerationThresholdLambda, largeObjectHeapThresholdLambda));
        }


        public static IObservable<System.Reactive.Unit> CancelFullGCNotification()
        {
            return ObservableExt.Factory(() => System.GC.CancelFullGCNotification());
        }


        public static IObservable<System.GCNotificationStatus> WaitForFullGCApproach()
        {
            return ObservableExt.Factory(() => System.GC.WaitForFullGCApproach());
        }


        public static IObservable<System.GCNotificationStatus> WaitForFullGCApproach(
            IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Select(millisecondsTimeout,
                (millisecondsTimeoutLambda) => System.GC.WaitForFullGCApproach(millisecondsTimeoutLambda));
        }


        public static IObservable<System.GCNotificationStatus> WaitForFullGCComplete()
        {
            return ObservableExt.Factory(() => System.GC.WaitForFullGCComplete());
        }


        public static IObservable<System.GCNotificationStatus> WaitForFullGCComplete(
            IObservable<System.Int32> millisecondsTimeout)
        {
            return Observable.Select(millisecondsTimeout,
                (millisecondsTimeoutLambda) => System.GC.WaitForFullGCComplete(millisecondsTimeoutLambda));
        }


        public static IObservable<System.Boolean> TryStartNoGCRegion(IObservable<System.Int64> totalSize)
        {
            return Observable.Select(totalSize, (totalSizeLambda) => System.GC.TryStartNoGCRegion(totalSizeLambda));
        }


        public static IObservable<System.Boolean> TryStartNoGCRegion(IObservable<System.Int64> totalSize,
            IObservable<System.Int64> lohSize)
        {
            return Observable.Zip(totalSize, lohSize,
                (totalSizeLambda, lohSizeLambda) => System.GC.TryStartNoGCRegion(totalSizeLambda, lohSizeLambda));
        }


        public static IObservable<System.Boolean> TryStartNoGCRegion(IObservable<System.Int64> totalSize,
            IObservable<System.Boolean> disallowFullBlockingGC)
        {
            return Observable.Zip(totalSize, disallowFullBlockingGC,
                (totalSizeLambda, disallowFullBlockingGCLambda) =>
                    System.GC.TryStartNoGCRegion(totalSizeLambda, disallowFullBlockingGCLambda));
        }


        public static IObservable<System.Boolean> TryStartNoGCRegion(IObservable<System.Int64> totalSize,
            IObservable<System.Int64> lohSize, IObservable<System.Boolean> disallowFullBlockingGC)
        {
            return Observable.Zip(totalSize, lohSize, disallowFullBlockingGC,
                (totalSizeLambda, lohSizeLambda, disallowFullBlockingGCLambda) =>
                    System.GC.TryStartNoGCRegion(totalSizeLambda, lohSizeLambda, disallowFullBlockingGCLambda));
        }


        public static IObservable<System.Reactive.Unit> EndNoGCRegion()
        {
            return ObservableExt.Factory(() => System.GC.EndNoGCRegion());
        }


        public static IObservable<System.Int32> get_MaxGeneration()
        {
            return ObservableExt.Factory(() => System.GC.MaxGeneration);
        }
    }
}