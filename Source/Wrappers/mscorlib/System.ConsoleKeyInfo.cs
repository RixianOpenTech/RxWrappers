using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _ConsoleKeyInfo
{
    
public static IObservable<System.Boolean> Equals(this IObservable<System.ConsoleKeyInfo> ConsoleKeyInfoValue, IObservable<System.Object> value)
{
    return Observable.Zip(ConsoleKeyInfoValue, value, (ConsoleKeyInfoValueLambda, valueLambda) => ConsoleKeyInfoValueLambda.Equals(valueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.ConsoleKeyInfo> ConsoleKeyInfoValue, IObservable<System.ConsoleKeyInfo> obj)
{
    return Observable.Zip(ConsoleKeyInfoValue, obj, (ConsoleKeyInfoValueLambda, objLambda) => ConsoleKeyInfoValueLambda.Equals(objLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.ConsoleKeyInfo> ConsoleKeyInfoValue)
{
    return Observable.Select(ConsoleKeyInfoValue, (ConsoleKeyInfoValueLambda) => ConsoleKeyInfoValueLambda.GetHashCode());
}


public static IObservable<System.Char> get_KeyChar(this IObservable<System.ConsoleKeyInfo> ConsoleKeyInfoValue)
{
    return Observable.Select(ConsoleKeyInfoValue, (ConsoleKeyInfoValueLambda) => ConsoleKeyInfoValueLambda.KeyChar);
}


public static IObservable<System.ConsoleKey> get_Key(this IObservable<System.ConsoleKeyInfo> ConsoleKeyInfoValue)
{
    return Observable.Select(ConsoleKeyInfoValue, (ConsoleKeyInfoValueLambda) => ConsoleKeyInfoValueLambda.Key);
}


public static IObservable<System.ConsoleModifiers> get_Modifiers(this IObservable<System.ConsoleKeyInfo> ConsoleKeyInfoValue)
{
    return Observable.Select(ConsoleKeyInfoValue, (ConsoleKeyInfoValueLambda) => ConsoleKeyInfoValueLambda.Modifiers);
}

}
}