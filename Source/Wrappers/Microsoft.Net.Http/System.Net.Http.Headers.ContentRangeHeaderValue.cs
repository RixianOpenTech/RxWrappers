using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __ContentRangeHeaderValue
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> ContentRangeHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(ContentRangeHeaderValueValue, obj, (ContentRangeHeaderValueValueLambda, objLambda) => ContentRangeHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> ContentRangeHeaderValueValue)
        {
            return Observable.Select(ContentRangeHeaderValueValue, (ContentRangeHeaderValueValueLambda) => ContentRangeHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> ContentRangeHeaderValueValue)
        {
            return Observable.Select(ContentRangeHeaderValueValue, (ContentRangeHeaderValueValueLambda) => ContentRangeHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.ContentRangeHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.ContentRangeHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.ContentRangeHeaderValue parsedValueOutput = default(System.Net.Http.Headers.ContentRangeHeaderValue);
var result = System.Net.Http.Headers.ContentRangeHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> get_Unit(this IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> ContentRangeHeaderValueValue)
        {
            return Observable.Select(ContentRangeHeaderValueValue, (ContentRangeHeaderValueValueLambda) => ContentRangeHeaderValueValueLambda.Unit);
        }


        public static IObservable<System.Nullable<System.Int64>> get_From(this IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> ContentRangeHeaderValueValue)
        {
            return Observable.Select(ContentRangeHeaderValueValue, (ContentRangeHeaderValueValueLambda) => ContentRangeHeaderValueValueLambda.From);
        }


        public static IObservable<System.Nullable<System.Int64>> get_To(this IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> ContentRangeHeaderValueValue)
        {
            return Observable.Select(ContentRangeHeaderValueValue, (ContentRangeHeaderValueValueLambda) => ContentRangeHeaderValueValueLambda.To);
        }


        public static IObservable<System.Nullable<System.Int64>> get_Length(this IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> ContentRangeHeaderValueValue)
        {
            return Observable.Select(ContentRangeHeaderValueValue, (ContentRangeHeaderValueValueLambda) => ContentRangeHeaderValueValueLambda.Length);
        }


        public static IObservable<System.Boolean> get_HasLength(this IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> ContentRangeHeaderValueValue)
        {
            return Observable.Select(ContentRangeHeaderValueValue, (ContentRangeHeaderValueValueLambda) => ContentRangeHeaderValueValueLambda.HasLength);
        }


        public static IObservable<System.Boolean> get_HasRange(this IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> ContentRangeHeaderValueValue)
        {
            return Observable.Select(ContentRangeHeaderValueValue, (ContentRangeHeaderValueValueLambda) => ContentRangeHeaderValueValueLambda.HasRange);
        }


        public static IObservable<System.Reactive.Unit> set_Unit(this IObservable<System.Net.Http.Headers.ContentRangeHeaderValue> ContentRangeHeaderValueValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ContentRangeHeaderValueValue, value, (ContentRangeHeaderValueValueLambda, valueLambda) => ContentRangeHeaderValueValueLambda.Unit = valueLambda);
        }

    }
}