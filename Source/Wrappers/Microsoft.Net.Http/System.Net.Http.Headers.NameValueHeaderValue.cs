using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __NameValueHeaderValue
    {
        
        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.NameValueHeaderValue> NameValueHeaderValueValue)
        {
            return Observable.Select(NameValueHeaderValueValue, (NameValueHeaderValueValueLambda) => NameValueHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.NameValueHeaderValue> NameValueHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(NameValueHeaderValueValue, obj, (NameValueHeaderValueValueLambda, objLambda) => NameValueHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Net.Http.Headers.NameValueHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.NameValueHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.NameValueHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.NameValueHeaderValue parsedValueOutput = default(System.Net.Http.Headers.NameValueHeaderValue);
var result = System.Net.Http.Headers.NameValueHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.NameValueHeaderValue> NameValueHeaderValueValue)
        {
            return Observable.Select(NameValueHeaderValueValue, (NameValueHeaderValueValueLambda) => NameValueHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Net.Http.Headers.NameValueHeaderValue> NameValueHeaderValueValue)
        {
            return Observable.Select(NameValueHeaderValueValue, (NameValueHeaderValueValueLambda) => NameValueHeaderValueValueLambda.Name);
        }


        public static IObservable<System.String> get_Value(this IObservable<System.Net.Http.Headers.NameValueHeaderValue> NameValueHeaderValueValue)
        {
            return Observable.Select(NameValueHeaderValueValue, (NameValueHeaderValueValueLambda) => NameValueHeaderValueValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(this IObservable<System.Net.Http.Headers.NameValueHeaderValue> NameValueHeaderValueValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NameValueHeaderValueValue, value, (NameValueHeaderValueValueLambda, valueLambda) => NameValueHeaderValueValueLambda.Value = valueLambda);
        }

    }
}