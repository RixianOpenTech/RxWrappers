using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __BStrWrapper
    {
        
        public static IObservable<System.String> get_WrappedObject(this IObservable<System.Runtime.InteropServices.BStrWrapper> BStrWrapperValue)
        {
            return Observable.Select(BStrWrapperValue, (BStrWrapperValueLambda) => BStrWrapperValueLambda.WrappedObject);
        }

    }
}