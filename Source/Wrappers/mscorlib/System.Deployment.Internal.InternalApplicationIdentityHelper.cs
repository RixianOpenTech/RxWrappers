using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Deployment.Internal
{
    public static class __InternalApplicationIdentityHelper
    {
        public static IObservable<System.Object> GetInternalAppId(IObservable<System.ApplicationIdentity> id)
        {
            return Observable.Select(id,
                (idLambda) => System.Deployment.Internal.InternalApplicationIdentityHelper.GetInternalAppId(idLambda));
        }
    }
}