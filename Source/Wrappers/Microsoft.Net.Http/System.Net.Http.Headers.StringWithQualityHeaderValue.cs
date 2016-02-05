using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __StringWithQualityHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.StringWithQualityHeaderValue> StringWithQualityHeaderValueValue)
        {
            return Observable.Select(StringWithQualityHeaderValueValue, (StringWithQualityHeaderValueValueLambda) => StringWithQualityHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.StringWithQualityHeaderValue> StringWithQualityHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(StringWithQualityHeaderValueValue, obj, (StringWithQualityHeaderValueValueLambda, objLambda) => StringWithQualityHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.StringWithQualityHeaderValue> StringWithQualityHeaderValueValue)
        {
            return Observable.Select(StringWithQualityHeaderValueValue, (StringWithQualityHeaderValueValueLambda) => StringWithQualityHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.StringWithQualityHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.StringWithQualityHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.StringWithQualityHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.StringWithQualityHeaderValue parsedValueOutput = default(System.Net.Http.Headers.StringWithQualityHeaderValue);
var result = System.Net.Http.Headers.StringWithQualityHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> get_Value(this IObservable<System.Net.Http.Headers.StringWithQualityHeaderValue> StringWithQualityHeaderValueValue)
        {
            return Observable.Select(StringWithQualityHeaderValueValue, (StringWithQualityHeaderValueValueLambda) => StringWithQualityHeaderValueValueLambda.Value);
        }


        public static IObservable<System.Nullable<System.Double>> get_Quality(this IObservable<System.Net.Http.Headers.StringWithQualityHeaderValue> StringWithQualityHeaderValueValue)
        {
            return Observable.Select(StringWithQualityHeaderValueValue, (StringWithQualityHeaderValueValueLambda) => StringWithQualityHeaderValueValueLambda.Quality);
        }

    }
}