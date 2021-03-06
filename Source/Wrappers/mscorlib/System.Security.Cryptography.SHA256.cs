using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __SHA256
    {
        public static IObservable<System.Security.Cryptography.SHA256> Create()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.SHA256.Create());
        }


        public static IObservable<System.Security.Cryptography.SHA256> Create(IObservable<System.String> hashName)
        {
            return Observable.Select(hashName,
                (hashNameLambda) => System.Security.Cryptography.SHA256.Create(hashNameLambda));
        }
    }
}