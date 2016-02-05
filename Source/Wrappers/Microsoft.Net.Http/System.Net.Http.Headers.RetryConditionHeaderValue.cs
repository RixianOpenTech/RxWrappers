using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __RetryConditionHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.RetryConditionHeaderValue> RetryConditionHeaderValueValue)
        {
            return Observable.Select(RetryConditionHeaderValueValue, (RetryConditionHeaderValueValueLambda) => RetryConditionHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.RetryConditionHeaderValue> RetryConditionHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(RetryConditionHeaderValueValue, obj, (RetryConditionHeaderValueValueLambda, objLambda) => RetryConditionHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.RetryConditionHeaderValue> RetryConditionHeaderValueValue)
        {
            return Observable.Select(RetryConditionHeaderValueValue, (RetryConditionHeaderValueValueLambda) => RetryConditionHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.RetryConditionHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.RetryConditionHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.RetryConditionHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.RetryConditionHeaderValue parsedValueOutput = default(System.Net.Http.Headers.RetryConditionHeaderValue);
var result = System.Net.Http.Headers.RetryConditionHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_Date(this IObservable<System.Net.Http.Headers.RetryConditionHeaderValue> RetryConditionHeaderValueValue)
        {
            return Observable.Select(RetryConditionHeaderValueValue, (RetryConditionHeaderValueValueLambda) => RetryConditionHeaderValueValueLambda.Date);
        }


        public static IObservable<System.Nullable<System.TimeSpan>> get_Delta(this IObservable<System.Net.Http.Headers.RetryConditionHeaderValue> RetryConditionHeaderValueValue)
        {
            return Observable.Select(RetryConditionHeaderValueValue, (RetryConditionHeaderValueValueLambda) => RetryConditionHeaderValueValueLambda.Delta);
        }

    }
}