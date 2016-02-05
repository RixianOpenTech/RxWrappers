using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __RangeItemHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.RangeItemHeaderValue> RangeItemHeaderValueValue)
        {
            return Observable.Select(RangeItemHeaderValueValue, (RangeItemHeaderValueValueLambda) => RangeItemHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.RangeItemHeaderValue> RangeItemHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(RangeItemHeaderValueValue, obj, (RangeItemHeaderValueValueLambda, objLambda) => RangeItemHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.RangeItemHeaderValue> RangeItemHeaderValueValue)
        {
            return Observable.Select(RangeItemHeaderValueValue, (RangeItemHeaderValueValueLambda) => RangeItemHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Nullable<System.Int64>> get_From(this IObservable<System.Net.Http.Headers.RangeItemHeaderValue> RangeItemHeaderValueValue)
        {
            return Observable.Select(RangeItemHeaderValueValue, (RangeItemHeaderValueValueLambda) => RangeItemHeaderValueValueLambda.From);
        }


        public static IObservable<System.Nullable<System.Int64>> get_To(this IObservable<System.Net.Http.Headers.RangeItemHeaderValue> RangeItemHeaderValueValue)
        {
            return Observable.Select(RangeItemHeaderValueValue, (RangeItemHeaderValueValueLambda) => RangeItemHeaderValueValueLambda.To);
        }

    }
}