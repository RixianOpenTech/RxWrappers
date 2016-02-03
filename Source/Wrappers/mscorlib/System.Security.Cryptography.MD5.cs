using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _MD5
{
    
public static IObservable<System.Security.Cryptography.MD5> Create()
{
    return ObservableExt.Factory(() => System.Security.Cryptography.MD5.Create());
}


public static IObservable<System.Security.Cryptography.MD5> Create(IObservable<System.String> algName)
{
    return Observable.Select(algName, (algNameLambda) => System.Security.Cryptography.MD5.Create(algNameLambda));
}

}
}