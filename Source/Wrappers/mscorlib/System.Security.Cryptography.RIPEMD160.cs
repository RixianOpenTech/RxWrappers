using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RIPEMD160
    {
        public static IObservable<System.Security.Cryptography.RIPEMD160> Create()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RIPEMD160.Create());
        }


        public static IObservable<System.Security.Cryptography.RIPEMD160> Create(IObservable<System.String> hashName)
        {
            return Observable.Select(hashName,
                (hashNameLambda) => System.Security.Cryptography.RIPEMD160.Create(hashNameLambda));
        }
    }
}