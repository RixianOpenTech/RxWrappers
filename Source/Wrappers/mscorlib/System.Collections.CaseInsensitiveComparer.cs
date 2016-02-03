using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __CaseInsensitiveComparer
    {
        public static IObservable<System.Int32> Compare(
            this IObservable<System.Collections.CaseInsensitiveComparer> CaseInsensitiveComparerValue,
            IObservable<System.Object> a, IObservable<System.Object> b)
        {
            return Observable.Zip(CaseInsensitiveComparerValue, a, b,
                (CaseInsensitiveComparerValueLambda, aLambda, bLambda) =>
                    CaseInsensitiveComparerValueLambda.Compare(aLambda, bLambda));
        }


        public static IObservable<System.Collections.CaseInsensitiveComparer> get_Default()
        {
            return ObservableExt.Factory(() => System.Collections.CaseInsensitiveComparer.Default);
        }


        public static IObservable<System.Collections.CaseInsensitiveComparer> get_DefaultInvariant()
        {
            return ObservableExt.Factory(() => System.Collections.CaseInsensitiveComparer.DefaultInvariant);
        }
    }
}