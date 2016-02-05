using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __NameValueWithParametersHeaderValue
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.NameValueWithParametersHeaderValue> NameValueWithParametersHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(NameValueWithParametersHeaderValueValue, obj, (NameValueWithParametersHeaderValueValueLambda, objLambda) => NameValueWithParametersHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.NameValueWithParametersHeaderValue> NameValueWithParametersHeaderValueValue)
        {
            return Observable.Select(NameValueWithParametersHeaderValueValue, (NameValueWithParametersHeaderValueValueLambda) => NameValueWithParametersHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.NameValueWithParametersHeaderValue> NameValueWithParametersHeaderValueValue)
        {
            return Observable.Select(NameValueWithParametersHeaderValueValue, (NameValueWithParametersHeaderValueValueLambda) => NameValueWithParametersHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Net.Http.Headers.NameValueWithParametersHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.NameValueWithParametersHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.NameValueWithParametersHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.NameValueWithParametersHeaderValue parsedValueOutput = default(System.Net.Http.Headers.NameValueWithParametersHeaderValue);
var result = System.Net.Http.Headers.NameValueWithParametersHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue>> get_Parameters(this IObservable<System.Net.Http.Headers.NameValueWithParametersHeaderValue> NameValueWithParametersHeaderValueValue)
        {
            return Observable.Select(NameValueWithParametersHeaderValueValue, (NameValueWithParametersHeaderValueValueLambda) => NameValueWithParametersHeaderValueValueLambda.Parameters);
        }

    }
}