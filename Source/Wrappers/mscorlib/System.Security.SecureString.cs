using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security
{
public static class _SecureString
{
    
public static IObservable<System.Reactive.Unit> AppendChar(this IObservable<System.Security.SecureString> SecureStringValue, IObservable<System.Char> c)
{
    return ObservableExt.ZipExecute(SecureStringValue, c, (SecureStringValueLambda, cLambda) => SecureStringValueLambda.AppendChar(cLambda));
}


public static IObservable<System.Reactive.Unit> Clear(this IObservable<System.Security.SecureString> SecureStringValue)
{
    return Observable.Do(SecureStringValue, (SecureStringValueLambda) => SecureStringValueLambda.Clear()).ToUnit();
}


public static IObservable<System.Security.SecureString> Copy(this IObservable<System.Security.SecureString> SecureStringValue)
{
    return Observable.Select(SecureStringValue, (SecureStringValueLambda) => SecureStringValueLambda.Copy());
}


public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.SecureString> SecureStringValue)
{
    return Observable.Do(SecureStringValue, (SecureStringValueLambda) => SecureStringValueLambda.Dispose()).ToUnit();
}


public static IObservable<System.Reactive.Unit> InsertAt(this IObservable<System.Security.SecureString> SecureStringValue, IObservable<System.Int32> index, IObservable<System.Char> c)
{
    return ObservableExt.ZipExecute(SecureStringValue, index, c, (SecureStringValueLambda, indexLambda, cLambda) => SecureStringValueLambda.InsertAt(indexLambda, cLambda));
}


public static IObservable<System.Boolean> IsReadOnly(this IObservable<System.Security.SecureString> SecureStringValue)
{
    return Observable.Select(SecureStringValue, (SecureStringValueLambda) => SecureStringValueLambda.IsReadOnly());
}


public static IObservable<System.Reactive.Unit> MakeReadOnly(this IObservable<System.Security.SecureString> SecureStringValue)
{
    return Observable.Do(SecureStringValue, (SecureStringValueLambda) => SecureStringValueLambda.MakeReadOnly()).ToUnit();
}


public static IObservable<System.Reactive.Unit> RemoveAt(this IObservable<System.Security.SecureString> SecureStringValue, IObservable<System.Int32> index)
{
    return ObservableExt.ZipExecute(SecureStringValue, index, (SecureStringValueLambda, indexLambda) => SecureStringValueLambda.RemoveAt(indexLambda));
}


public static IObservable<System.Reactive.Unit> SetAt(this IObservable<System.Security.SecureString> SecureStringValue, IObservable<System.Int32> index, IObservable<System.Char> c)
{
    return ObservableExt.ZipExecute(SecureStringValue, index, c, (SecureStringValueLambda, indexLambda, cLambda) => SecureStringValueLambda.SetAt(indexLambda, cLambda));
}


public static IObservable<System.Int32> get_Length(this IObservable<System.Security.SecureString> SecureStringValue)
{
    return Observable.Select(SecureStringValue, (SecureStringValueLambda) => SecureStringValueLambda.Length);
}

}
}