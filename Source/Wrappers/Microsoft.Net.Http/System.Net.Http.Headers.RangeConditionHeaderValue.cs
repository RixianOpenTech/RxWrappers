using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __RangeConditionHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.RangeConditionHeaderValue> RangeConditionHeaderValueValue)
        {
            return Observable.Select(RangeConditionHeaderValueValue, (RangeConditionHeaderValueValueLambda) => RangeConditionHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.RangeConditionHeaderValue> RangeConditionHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(RangeConditionHeaderValueValue, obj, (RangeConditionHeaderValueValueLambda, objLambda) => RangeConditionHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.RangeConditionHeaderValue> RangeConditionHeaderValueValue)
        {
            return Observable.Select(RangeConditionHeaderValueValue, (RangeConditionHeaderValueValueLambda) => RangeConditionHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.RangeConditionHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.RangeConditionHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.RangeConditionHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.RangeConditionHeaderValue parsedValueOutput = default(System.Net.Http.Headers.RangeConditionHeaderValue);
var result = System.Net.Http.Headers.RangeConditionHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_Date(this IObservable<System.Net.Http.Headers.RangeConditionHeaderValue> RangeConditionHeaderValueValue)
        {
            return Observable.Select(RangeConditionHeaderValueValue, (RangeConditionHeaderValueValueLambda) => RangeConditionHeaderValueValueLambda.Date);
        }


        public static IObservable<System.Net.Http.Headers.EntityTagHeaderValue> get_EntityTag(this IObservable<System.Net.Http.Headers.RangeConditionHeaderValue> RangeConditionHeaderValueValue)
        {
            return Observable.Select(RangeConditionHeaderValueValue, (RangeConditionHeaderValueValueLambda) => RangeConditionHeaderValueValueLambda.EntityTag);
        }

    }
}