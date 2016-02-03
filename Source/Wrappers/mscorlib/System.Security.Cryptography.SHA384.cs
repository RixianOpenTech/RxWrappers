using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _SHA384
{
    
public static IObservable<System.Security.Cryptography.SHA384> Create()
{
    return ObservableExt.Factory(() => System.Security.Cryptography.SHA384.Create());
}


public static IObservable<System.Security.Cryptography.SHA384> Create(IObservable<System.String> hashName)
{
    return Observable.Select(hashName, (hashNameLambda) => System.Security.Cryptography.SHA384.Create(hashNameLambda));
}

}
}