using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __TransferCodingWithQualityHeaderValue
    {
        
        public static IObservable<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.TransferCodingWithQualityHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.TransferCodingWithQualityHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.TransferCodingWithQualityHeaderValue parsedValueOutput = default(System.Net.Http.Headers.TransferCodingWithQualityHeaderValue);
var result = System.Net.Http.Headers.TransferCodingWithQualityHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.Nullable<System.Double>> get_Quality(this IObservable<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue> TransferCodingWithQualityHeaderValueValue)
        {
            return Observable.Select(TransferCodingWithQualityHeaderValueValue, (TransferCodingWithQualityHeaderValueValueLambda) => TransferCodingWithQualityHeaderValueValueLambda.Quality);
        }


        public static IObservable<System.Reactive.Unit> set_Quality(this IObservable<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue> TransferCodingWithQualityHeaderValueValue, IObservable<System.Nullable<System.Double>> value)
        {
            return ObservableExt.ZipExecute(TransferCodingWithQualityHeaderValueValue, value, (TransferCodingWithQualityHeaderValueValueLambda, valueLambda) => TransferCodingWithQualityHeaderValueValueLambda.Quality = valueLambda);
        }

    }
}