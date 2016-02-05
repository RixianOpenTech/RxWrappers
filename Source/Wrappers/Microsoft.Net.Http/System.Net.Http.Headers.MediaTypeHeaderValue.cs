using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __MediaTypeHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> MediaTypeHeaderValueValue)
        {
            return Observable.Select(MediaTypeHeaderValueValue, (MediaTypeHeaderValueValueLambda) => MediaTypeHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> MediaTypeHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(MediaTypeHeaderValueValue, obj, (MediaTypeHeaderValueValueLambda, objLambda) => MediaTypeHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> MediaTypeHeaderValueValue)
        {
            return Observable.Select(MediaTypeHeaderValueValue, (MediaTypeHeaderValueValueLambda) => MediaTypeHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.MediaTypeHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.MediaTypeHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.MediaTypeHeaderValue parsedValueOutput = default(System.Net.Http.Headers.MediaTypeHeaderValue);
var result = System.Net.Http.Headers.MediaTypeHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> get_CharSet(this IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> MediaTypeHeaderValueValue)
        {
            return Observable.Select(MediaTypeHeaderValueValue, (MediaTypeHeaderValueValueLambda) => MediaTypeHeaderValueValueLambda.CharSet);
        }


        public static IObservable<System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue>> get_Parameters(this IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> MediaTypeHeaderValueValue)
        {
            return Observable.Select(MediaTypeHeaderValueValue, (MediaTypeHeaderValueValueLambda) => MediaTypeHeaderValueValueLambda.Parameters);
        }


        public static IObservable<System.String> get_MediaType(this IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> MediaTypeHeaderValueValue)
        {
            return Observable.Select(MediaTypeHeaderValueValue, (MediaTypeHeaderValueValueLambda) => MediaTypeHeaderValueValueLambda.MediaType);
        }


        public static IObservable<System.Reactive.Unit> set_CharSet(this IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> MediaTypeHeaderValueValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(MediaTypeHeaderValueValue, value, (MediaTypeHeaderValueValueLambda, valueLambda) => MediaTypeHeaderValueValueLambda.CharSet = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MediaType(this IObservable<System.Net.Http.Headers.MediaTypeHeaderValue> MediaTypeHeaderValueValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(MediaTypeHeaderValueValue, value, (MediaTypeHeaderValueValueLambda, valueLambda) => MediaTypeHeaderValueValueLambda.MediaType = valueLambda);
        }

    }
}