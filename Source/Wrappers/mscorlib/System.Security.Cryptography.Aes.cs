using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _Aes
{
    
public static IObservable<System.Security.Cryptography.Aes> Create()
{
    return ObservableExt.Factory(() => System.Security.Cryptography.Aes.Create());
}


public static IObservable<System.Security.Cryptography.Aes> Create(IObservable<System.String> algorithmName)
{
    return Observable.Select(algorithmName, (algorithmNameLambda) => System.Security.Cryptography.Aes.Create(algorithmNameLambda));
}

}
}