using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading.Tasks
{
public static class _Parallel
{
    
public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<IEnumerable<TSource>> source, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Action<TSource>> body)
{
    return Observable.Zip(source, parallelOptions, body, (sourceLambda, parallelOptionsLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, parallelOptionsLambda, bodyLambda));
}


public static IObservable<System.Reactive.Unit> Invoke(IObservable<System.Action[]> actions)
{
    return Observable.Do(actions, (actionsLambda) => System.Threading.Tasks.Parallel.Invoke(actionsLambda)).ToUnit();
}


public static IObservable<System.Reactive.Unit> Invoke(IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<System.Action[]> actions)
{
    return ObservableExt.ZipExecute(parallelOptions, actions, (parallelOptionsLambda, actionsLambda) => System.Threading.Tasks.Parallel.Invoke(parallelOptionsLambda, actionsLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For(IObservable<System.Int32> fromInclusive, IObservable<System.Int32> toExclusive, IObservable<System.Action<System.Int32>> body)
{
    return Observable.Zip(fromInclusive, toExclusive, body, (fromInclusiveLambda, toExclusiveLambda, bodyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For(IObservable<System.Int64> fromInclusive, IObservable<System.Int64> toExclusive, IObservable<System.Action<System.Int64>> body)
{
    return Observable.Zip(fromInclusive, toExclusive, body, (fromInclusiveLambda, toExclusiveLambda, bodyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For(IObservable<System.Int32> fromInclusive, IObservable<System.Int32> toExclusive, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<System.Action<System.Int32>> body)
{
    return Observable.Zip(fromInclusive, toExclusive, parallelOptions, body, (fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, bodyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For(IObservable<System.Int64> fromInclusive, IObservable<System.Int64> toExclusive, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<System.Action<System.Int64>> body)
{
    return Observable.Zip(fromInclusive, toExclusive, parallelOptions, body, (fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, bodyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For(IObservable<System.Int32> fromInclusive, IObservable<System.Int32> toExclusive, IObservable<System.Action<System.Int32, System.Threading.Tasks.ParallelLoopState>> body)
{
    return Observable.Zip(fromInclusive, toExclusive, body, (fromInclusiveLambda, toExclusiveLambda, bodyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For(IObservable<System.Int64> fromInclusive, IObservable<System.Int64> toExclusive, IObservable<System.Action<System.Int64, System.Threading.Tasks.ParallelLoopState>> body)
{
    return Observable.Zip(fromInclusive, toExclusive, body, (fromInclusiveLambda, toExclusiveLambda, bodyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For(IObservable<System.Int32> fromInclusive, IObservable<System.Int32> toExclusive, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<System.Action<System.Int32, System.Threading.Tasks.ParallelLoopState>> body)
{
    return Observable.Zip(fromInclusive, toExclusive, parallelOptions, body, (fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, bodyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For(IObservable<System.Int64> fromInclusive, IObservable<System.Int64> toExclusive, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<System.Action<System.Int64, System.Threading.Tasks.ParallelLoopState>> body)
{
    return Observable.Zip(fromInclusive, toExclusive, parallelOptions, body, (fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, bodyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For<TLocal>(IObservable<System.Int32> fromInclusive, IObservable<System.Int32> toExclusive, IObservable<Func<TLocal>> localInit, IObservable<Func<System.Int32, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(fromInclusive, toExclusive, localInit, body, localFinally, (fromInclusiveLambda, toExclusiveLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For<TLocal>(IObservable<System.Int64> fromInclusive, IObservable<System.Int64> toExclusive, IObservable<Func<TLocal>> localInit, IObservable<Func<System.Int64, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(fromInclusive, toExclusive, localInit, body, localFinally, (fromInclusiveLambda, toExclusiveLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For<TLocal>(IObservable<System.Int32> fromInclusive, IObservable<System.Int32> toExclusive, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Func<TLocal>> localInit, IObservable<Func<System.Int32, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(fromInclusive, toExclusive, parallelOptions, localInit, body, localFinally, (fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> For<TLocal>(IObservable<System.Int64> fromInclusive, IObservable<System.Int64> toExclusive, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Func<TLocal>> localInit, IObservable<Func<System.Int64, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(fromInclusive, toExclusive, parallelOptions, localInit, body, localFinally, (fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.For(fromInclusiveLambda, toExclusiveLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<IEnumerable<TSource>> source, IObservable<Action<TSource>> body)
{
    return Observable.Zip(source, body, (sourceLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<IEnumerable<TSource>> source, IObservable<Action<TSource, System.Threading.Tasks.ParallelLoopState>> body)
{
    return Observable.Zip(source, body, (sourceLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<IEnumerable<TSource>> source, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Action<TSource, System.Threading.Tasks.ParallelLoopState>> body)
{
    return Observable.Zip(source, parallelOptions, body, (sourceLambda, parallelOptionsLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, parallelOptionsLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<IEnumerable<TSource>> source, IObservable<Action<TSource, System.Threading.Tasks.ParallelLoopState, System.Int64>> body)
{
    return Observable.Zip(source, body, (sourceLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<IEnumerable<TSource>> source, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Action<TSource, System.Threading.Tasks.ParallelLoopState, System.Int64>> body)
{
    return Observable.Zip(source, parallelOptions, body, (sourceLambda, parallelOptionsLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, parallelOptionsLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource, TLocal>(IObservable<IEnumerable<TSource>> source, IObservable<Func<TLocal>> localInit, IObservable<Func<TSource, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(source, localInit, body, localFinally, (sourceLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource, TLocal>(IObservable<IEnumerable<TSource>> source, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Func<TLocal>> localInit, IObservable<Func<TSource, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(source, parallelOptions, localInit, body, localFinally, (sourceLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource, TLocal>(IObservable<IEnumerable<TSource>> source, IObservable<Func<TLocal>> localInit, IObservable<Func<TSource, System.Threading.Tasks.ParallelLoopState, System.Int64, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(source, localInit, body, localFinally, (sourceLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource, TLocal>(IObservable<IEnumerable<TSource>> source, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Func<TLocal>> localInit, IObservable<Func<TSource, System.Threading.Tasks.ParallelLoopState, System.Int64, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(source, parallelOptions, localInit, body, localFinally, (sourceLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<Partitioner<TSource>> source, IObservable<Action<TSource>> body)
{
    return Observable.Zip(source, body, (sourceLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<Partitioner<TSource>> source, IObservable<Action<TSource, System.Threading.Tasks.ParallelLoopState>> body)
{
    return Observable.Zip(source, body, (sourceLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<OrderablePartitioner<TSource>> source, IObservable<Action<TSource, System.Threading.Tasks.ParallelLoopState, System.Int64>> body)
{
    return Observable.Zip(source, body, (sourceLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource, TLocal>(IObservable<Partitioner<TSource>> source, IObservable<Func<TLocal>> localInit, IObservable<Func<TSource, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(source, localInit, body, localFinally, (sourceLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource, TLocal>(IObservable<OrderablePartitioner<TSource>> source, IObservable<Func<TLocal>> localInit, IObservable<Func<TSource, System.Threading.Tasks.ParallelLoopState, System.Int64, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(source, localInit, body, localFinally, (sourceLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<Partitioner<TSource>> source, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Action<TSource>> body)
{
    return Observable.Zip(source, parallelOptions, body, (sourceLambda, parallelOptionsLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, parallelOptionsLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<Partitioner<TSource>> source, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Action<TSource, System.Threading.Tasks.ParallelLoopState>> body)
{
    return Observable.Zip(source, parallelOptions, body, (sourceLambda, parallelOptionsLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, parallelOptionsLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource>(IObservable<OrderablePartitioner<TSource>> source, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Action<TSource, System.Threading.Tasks.ParallelLoopState, System.Int64>> body)
{
    return Observable.Zip(source, parallelOptions, body, (sourceLambda, parallelOptionsLambda, bodyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, parallelOptionsLambda, bodyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource, TLocal>(IObservable<Partitioner<TSource>> source, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Func<TLocal>> localInit, IObservable<Func<TSource, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(source, parallelOptions, localInit, body, localFinally, (sourceLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda));
}


public static IObservable<System.Threading.Tasks.ParallelLoopResult> ForEach<TSource, TLocal>(IObservable<OrderablePartitioner<TSource>> source, IObservable<System.Threading.Tasks.ParallelOptions> parallelOptions, IObservable<Func<TLocal>> localInit, IObservable<Func<TSource, System.Threading.Tasks.ParallelLoopState, System.Int64, TLocal, TLocal>> body, IObservable<Action<TLocal>> localFinally)
{
    return Observable.Zip(source, parallelOptions, localInit, body, localFinally, (sourceLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda) => System.Threading.Tasks.Parallel.ForEach(sourceLambda, parallelOptionsLambda, localInitLambda, bodyLambda, localFinallyLambda));
}

}
}