using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __IContractResolver
    {
        
        public static IObservable<Newtonsoft.Json.Serialization.JsonContract> ResolveContract(this IObservable<Newtonsoft.Json.Serialization.IContractResolver> IContractResolverValue, IObservable<System.Type> type)
        {
            return Observable.Zip(IContractResolverValue, type, (IContractResolverValueLambda, typeLambda) => IContractResolverValueLambda.ResolveContract(typeLambda));
        }

    }
}