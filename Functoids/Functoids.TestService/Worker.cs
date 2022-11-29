using System.Reactive.Linq;

namespace Functoids.TestService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        //Subject<int> x = new();//Observable.Return(7);
        //Subject<int> y = new();//Observable.Return(13);
        IObservable<int> x = Observable.Return(7);
        IObservable<int> y = Observable.Return(13);
        _ = SampleFunctoids.Subtract_Obs(x, y).Subscribe(r => _logger.LogWarning($"Subtract Result: {r}"));
        (IObservable<int> a, IObservable<int> b) = SampleFunctoids.MulitipleParam_MulitipleReturn_Async_Obs(x, y);
        _ = a.LastAsync().Subscribe(r => _logger.LogWarning($"RESULT a: {r}"));
        _ = b.Subscribe(r => _logger.LogWarning($"RESULT b: {r}"));
        _ = SampleFunctoids.ZeroParam_ZeroReturn_Async_Obs().Subscribe();

        //x.OnNext(7);
        //y.OnNext(13);

        //x.OnCompleted();
        //y.OnCompleted();
        await Task.Delay(1000, stoppingToken);

        //SampleFunctoids.ZeroParam_MulitipleReturn_Sync_Obs()

        //while (!stoppingToken.IsCancellationRequested)
        //{
        //    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        //    await Task.Delay(1000, stoppingToken);
        //}
    }
    //public static IObservable<int> MulitipleParam_SingleReturn_Async(IObservable<int> x, IObservable<int> y)
    //{
    //    //return ObservableEx.Zip(x, y).Select(t => t.ToTuple()).Select(t => Functoids.TestService.SampleFunctoids.MulitipleParam_SingleReturn_Async(t.Item1, t.Item2));
    //    return ObservableEx.Zip(x, y).Select(t => t.ToTuple()).SelectMany(t => Observable.FromAsync(async () => await Functoids.TestService.SampleFunctoids.MulitipleParam_SingleReturn_Async(t.Item1, t.Item2)));
    //}
    //public static IObservable<int> SingleParam_SingleReturn_Async(IObservable<int> x)
    //{
    //    //return x.Select(t => Functoids.TestService.SampleFunctoids.SingleParam_SingleReturn_Async(t));
    //    return x.SelectMany(t => Observable.FromAsync(async () => await Functoids.TestService.SampleFunctoids.SingleParam_SingleReturn_Async(t)));
    //}

    //public static IObservable<int> ZeroParam_SingleReturn_Async_Obs()
    //{
    //    return Observable.FromAsync(async () => await Functoids.TestService.SampleFunctoids.ZeroParam_SingleReturn_Async());
    //}
}