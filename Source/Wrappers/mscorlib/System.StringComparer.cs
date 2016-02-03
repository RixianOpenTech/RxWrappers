using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __StringComparer
    {
        
        public static IObservable<System.StringComparer> Create(IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(culture, ignoreCase, (cultureLambda, ignoreCaseLambda) => System.StringComparer.Create(cultureLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Int32> Compare(this IObservable<System.StringComparer> StringComparerValue, IObservable<System.Object> x, IObservable<System.Object> y)
        {
            return Observable.Zip(StringComparerValue, x, y, (StringComparerValueLambda, xLambda, yLambda) => StringComparerValueLambda.Compare(xLambda, yLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.StringComparer> StringComparerValue, IObservable<System.Object> x, IObservable<System.Object> y)
        {
            return Observable.Zip(StringComparerValue, x, y, (StringComparerValueLambda, xLambda, yLambda) => StringComparerValueLambda.Equals(xLambda, yLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.StringComparer> StringComparerValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(StringComparerValue, obj, (StringComparerValueLambda, objLambda) => StringComparerValueLambda.GetHashCode(objLambda));
        }


        public static IObservable<System.Int32> Compare(this IObservable<System.StringComparer> StringComparerValue, IObservable<System.String> x, IObservable<System.String> y)
        {
            return Observable.Zip(StringComparerValue, x, y, (StringComparerValueLambda, xLambda, yLambda) => StringComparerValueLambda.Compare(xLambda, yLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.StringComparer> StringComparerValue, IObservable<System.String> x, IObservable<System.String> y)
        {
            return Observable.Zip(StringComparerValue, x, y, (StringComparerValueLambda, xLambda, yLambda) => StringComparerValueLambda.Equals(xLambda, yLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.StringComparer> StringComparerValue, IObservable<System.String> obj)
        {
            return Observable.Zip(StringComparerValue, obj, (StringComparerValueLambda, objLambda) => StringComparerValueLambda.GetHashCode(objLambda));
        }


        public static IObservable<System.StringComparer> get_InvariantCulture()
        {
            return ObservableExt.Factory(() => System.StringComparer.InvariantCulture);
        }


        public static IObservable<System.StringComparer> get_InvariantCultureIgnoreCase()
        {
            return ObservableExt.Factory(() => System.StringComparer.InvariantCultureIgnoreCase);
        }


        public static IObservable<System.StringComparer> get_CurrentCulture()
        {
            return ObservableExt.Factory(() => System.StringComparer.CurrentCulture);
        }


        public static IObservable<System.StringComparer> get_CurrentCultureIgnoreCase()
        {
            return ObservableExt.Factory(() => System.StringComparer.CurrentCultureIgnoreCase);
        }


        public static IObservable<System.StringComparer> get_Ordinal()
        {
            return ObservableExt.Factory(() => System.StringComparer.Ordinal);
        }


        public static IObservable<System.StringComparer> get_OrdinalIgnoreCase()
        {
            return ObservableExt.Factory(() => System.StringComparer.OrdinalIgnoreCase);
        }

    }
}