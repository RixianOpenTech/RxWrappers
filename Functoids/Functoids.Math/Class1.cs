using System.Numerics;
using System.Reactive.Linq;
using Functoids.Common;

namespace Functoids.Math;

public static class Functoids
{
    public static (IObservable<int> Quotient, IObservable<int> Remainder) DivRem(IObservable<int> x, IObservable<int> y)
    {
        return ObservableEx.Zip(x, y).Select(t => System.Math.DivRem(t.First, t.Second)).Unzip();
    }

    public static IObservable<TNum> Add<TNum>(IObservable<TNum> x, IObservable<TNum> y)
        where TNum : INumber<TNum>
    {
        return ObservableEx.Zip(x, y).Select(t => t.First + t.Second);
    }

    public static IObservable<TNum> Subtract<TNum>(IObservable<TNum> x, IObservable<TNum> y)
        where TNum : INumber<TNum>
    {
        return ObservableEx.Zip(x, y).Select(t => t.First - t.Second);
    }

    public static IObservable<TNum> Multiply<TNum>(IObservable<TNum> x, IObservable<TNum> y)
        where TNum : INumber<TNum>
    {
        return ObservableEx.Zip(x, y).Select(t => t.First * t.Second);
    }

    public static IObservable<TNum> Divide<TNum>(IObservable<TNum> x, IObservable<TNum> y)
        where TNum : INumber<TNum>
    {
        return ObservableEx.Zip(x, y).Select(t => t.First / t.Second);
    }

    public static IObservable<TNum> Mod<TNum>(IObservable<TNum> x, IObservable<TNum> y)
        where TNum : INumber<TNum>
    {
        return ObservableEx.Zip(x, y).Select(t => t.First % t.Second);
    }
}
