using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
public static class _Rijndael
{
    
public static IObservable<System.Security.Cryptography.Rijndael> Create()
{
    return ObservableExt.Factory(() => System.Security.Cryptography.Rijndael.Create());
}


public static IObservable<System.Security.Cryptography.Rijndael> Create(IObservable<System.String> algName)
{
    return Observable.Select(algName, (algNameLambda) => System.Security.Cryptography.Rijndael.Create(algNameLambda));
}

}
}