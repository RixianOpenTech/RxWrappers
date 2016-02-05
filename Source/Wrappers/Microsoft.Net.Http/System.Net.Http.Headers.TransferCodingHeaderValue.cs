using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __TransferCodingHeaderValue
    {
        
        public static IObservable<System.Net.Http.Headers.TransferCodingHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.TransferCodingHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.TransferCodingHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.TransferCodingHeaderValue parsedValueOutput = default(System.Net.Http.Headers.TransferCodingHeaderValue);
var result = System.Net.Http.Headers.TransferCodingHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.TransferCodingHeaderValue> TransferCodingHeaderValueValue)
        {
            return Observable.Select(TransferCodingHeaderValueValue, (TransferCodingHeaderValueValueLambda) => TransferCodingHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.TransferCodingHeaderValue> TransferCodingHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(TransferCodingHeaderValueValue, obj, (TransferCodingHeaderValueValueLambda, objLambda) => TransferCodingHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.TransferCodingHeaderValue> TransferCodingHeaderValueValue)
        {
            return Observable.Select(TransferCodingHeaderValueValue, (TransferCodingHeaderValueValueLambda) => TransferCodingHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.String> get_Value(this IObservable<System.Net.Http.Headers.TransferCodingHeaderValue> TransferCodingHeaderValueValue)
        {
            return Observable.Select(TransferCodingHeaderValueValue, (TransferCodingHeaderValueValueLambda) => TransferCodingHeaderValueValueLambda.Value);
        }


        public static IObservable<System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue>> get_Parameters(this IObservable<System.Net.Http.Headers.TransferCodingHeaderValue> TransferCodingHeaderValueValue)
        {
            return Observable.Select(TransferCodingHeaderValueValue, (TransferCodingHeaderValueValueLambda) => TransferCodingHeaderValueValueLambda.Parameters);
        }

    }
}