using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __CurrencyWrapper
    {
        public static IObservable<System.Decimal> get_WrappedObject(
            this IObservable<System.Runtime.InteropServices.CurrencyWrapper> CurrencyWrapperValue)
        {
            return Observable.Select(CurrencyWrapperValue,
                (CurrencyWrapperValueLambda) => CurrencyWrapperValueLambda.WrappedObject);
        }
    }
}