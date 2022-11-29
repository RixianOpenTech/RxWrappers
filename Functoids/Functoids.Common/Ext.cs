using System.Reactive.Linq;

namespace Functoids.Common;

public static class Ext
{
    public static IObservable<T> DoAsync<T>(this IObservable<T> source, Func<T, Task> doWork)
    {
        return source
            .Select(t => Observable.Defer(() => Observable.FromAsync(async () => await doWork(t))).Select(_ => t))
            .Concat();
    }

    public static IObservable<T> AsCheckpoint<T>(this IObservable<T> source, ObservableLoader<T> loader)
    {
        return loader.Checkpoint(source);
    }

    public static IObservable<T> AsCheckpoint<T>(this IObservable<T> source, string filename)
    {
        return source.AsCheckpoint(new FileObservableLoader<T>(filename));
    }

    public static IObservable<T> Coalesce<T>(this IObservable<T> source, IObservable<T> fallback)
    {
        return Observable.Create<T>(observer =>
        {
            object gate = new();
            bool gotValue = false;

            IDisposable? finalDisposable = null;
            IDisposable? sourceDisposable = null;
            finalDisposable = sourceDisposable = source.Do(
                t =>
                {
                    if (gotValue == false)
                    {
                        gotValue = true;
                    }
                },
                () =>
                {
                    if (gotValue == false)
                    {
                        sourceDisposable?.Dispose();
                        finalDisposable = fallback.Subscribe(observer);
                    }
                })
                .Subscribe(observer);

            return finalDisposable;
        });
    }

    public static (IObservable<TSource1> First, IObservable<TSource2> Second) Unzip<TSource1, TSource2>(this IObservable<(TSource1, TSource2)> source, bool replay = false)
    {
        IObservable<(TSource1, TSource2)> target = source.Once();
        if (replay)
        {
            target = target.Replay(1).AutoConnect();
        }
        return (target.Select(t => t.Item1), target.Select(t => t.Item2));
    }

    public static IObservable<T> AsCold<T>(this IObservable<T> observable)
    {
        return Observable.Create<T>(observable.Subscribe);
    }

    public static IObservable<T> AsColdOnce<T>(this IObservable<T> observable)
    {
        return Observable.Create<T>(observable.Subscribe).Once();
    }
}
