using System.Reactive.Linq;

namespace Functoids.Common;

public abstract class ObservableLoader<T>
{
    protected abstract Task SaveValueAsync(T value);
    protected abstract Task<T> ReadLatestAsync();
    protected abstract ValueTask<bool> HasValue();
    private readonly IObservable<bool> hasValueObs;

    public ObservableLoader()
    {
        this.hasValueObs = Observable.FromAsync(async () => await this.HasValue());
    }

    public IObservable<T> SaveLatest(IObservable<T> source)
    {
        return source.DoAsync(async t => await SaveValueAsync(t));
    }

    public IObservable<T> ReadLatest()
    {
        return ObservableExt.If(this.hasValueObs,
            Observable.FromAsync(() => this.ReadLatestAsync()),
            Observable.Empty<T>());
    }

    public IObservable<T> Checkpoint(IObservable<T> source)
    {
        return Ext.Coalesce(ReadLatest(), SaveLatest(source));
    }
}
