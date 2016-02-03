using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __SortVersion
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.Globalization.SortVersion> SortVersionValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(SortVersionValue, obj, (SortVersionValueLambda, objLambda) => SortVersionValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Globalization.SortVersion> SortVersionValue, IObservable<System.Globalization.SortVersion> other)
        {
            return Observable.Zip(SortVersionValue, other, (SortVersionValueLambda, otherLambda) => SortVersionValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Globalization.SortVersion> SortVersionValue)
        {
            return Observable.Select(SortVersionValue, (SortVersionValueLambda) => SortVersionValueLambda.GetHashCode());
        }


        public static IObservable<System.Int32> get_FullVersion(this IObservable<System.Globalization.SortVersion> SortVersionValue)
        {
            return Observable.Select(SortVersionValue, (SortVersionValueLambda) => SortVersionValueLambda.FullVersion);
        }


        public static IObservable<System.Guid> get_SortId(this IObservable<System.Globalization.SortVersion> SortVersionValue)
        {
            return Observable.Select(SortVersionValue, (SortVersionValueLambda) => SortVersionValueLambda.SortId);
        }

    }
}