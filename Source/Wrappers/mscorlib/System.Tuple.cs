using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _Tuple
{
    
public static IObservable<Tuple<T1>> Create<T1>(IObservable<T1> item1)
{
    return Observable.Select(item1, (item1Lambda) => System.Tuple.Create(item1Lambda));
}


public static IObservable<Tuple<T1, T2>> Create<T1, T2>(IObservable<T1> item1, IObservable<T2> item2)
{
    return Observable.Zip(item1, item2, (item1Lambda, item2Lambda) => System.Tuple.Create(item1Lambda, item2Lambda));
}


public static IObservable<Tuple<T1, T2, T3>> Create<T1, T2, T3>(IObservable<T1> item1, IObservable<T2> item2, IObservable<T3> item3)
{
    return Observable.Zip(item1, item2, item3, (item1Lambda, item2Lambda, item3Lambda) => System.Tuple.Create(item1Lambda, item2Lambda, item3Lambda));
}


public static IObservable<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IObservable<T1> item1, IObservable<T2> item2, IObservable<T3> item3, IObservable<T4> item4)
{
    return Observable.Zip(item1, item2, item3, item4, (item1Lambda, item2Lambda, item3Lambda, item4Lambda) => System.Tuple.Create(item1Lambda, item2Lambda, item3Lambda, item4Lambda));
}


public static IObservable<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IObservable<T1> item1, IObservable<T2> item2, IObservable<T3> item3, IObservable<T4> item4, IObservable<T5> item5)
{
    return Observable.Zip(item1, item2, item3, item4, item5, (item1Lambda, item2Lambda, item3Lambda, item4Lambda, item5Lambda) => System.Tuple.Create(item1Lambda, item2Lambda, item3Lambda, item4Lambda, item5Lambda));
}


public static IObservable<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IObservable<T1> item1, IObservable<T2> item2, IObservable<T3> item3, IObservable<T4> item4, IObservable<T5> item5, IObservable<T6> item6)
{
    return Observable.Zip(item1, item2, item3, item4, item5, item6, (item1Lambda, item2Lambda, item3Lambda, item4Lambda, item5Lambda, item6Lambda) => System.Tuple.Create(item1Lambda, item2Lambda, item3Lambda, item4Lambda, item5Lambda, item6Lambda));
}


public static IObservable<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IObservable<T1> item1, IObservable<T2> item2, IObservable<T3> item3, IObservable<T4> item4, IObservable<T5> item5, IObservable<T6> item6, IObservable<T7> item7)
{
    return Observable.Zip(item1, item2, item3, item4, item5, item6, item7, (item1Lambda, item2Lambda, item3Lambda, item4Lambda, item5Lambda, item6Lambda, item7Lambda) => System.Tuple.Create(item1Lambda, item2Lambda, item3Lambda, item4Lambda, item5Lambda, item6Lambda, item7Lambda));
}


public static IObservable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(IObservable<T1> item1, IObservable<T2> item2, IObservable<T3> item3, IObservable<T4> item4, IObservable<T5> item5, IObservable<T6> item6, IObservable<T7> item7, IObservable<T8> item8)
{
    return Observable.Zip(item1, item2, item3, item4, item5, item6, item7, item8, (item1Lambda, item2Lambda, item3Lambda, item4Lambda, item5Lambda, item6Lambda, item7Lambda, item8Lambda) => System.Tuple.Create(item1Lambda, item2Lambda, item3Lambda, item4Lambda, item5Lambda, item6Lambda, item7Lambda, item8Lambda));
}

}
}