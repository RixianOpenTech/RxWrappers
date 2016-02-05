using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __MediaTypeWithQualityHeaderValue
    {
        
        public static IObservable<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.MediaTypeWithQualityHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.MediaTypeWithQualityHeaderValue parsedValueOutput = default(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue);
var result = System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.Nullable<System.Double>> get_Quality(this IObservable<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue> MediaTypeWithQualityHeaderValueValue)
        {
            return Observable.Select(MediaTypeWithQualityHeaderValueValue, (MediaTypeWithQualityHeaderValueValueLambda) => MediaTypeWithQualityHeaderValueValueLambda.Quality);
        }


        public static IObservable<System.Reactive.Unit> set_Quality(this IObservable<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue> MediaTypeWithQualityHeaderValueValue, IObservable<System.Nullable<System.Double>> value)
        {
            return ObservableExt.ZipExecute(MediaTypeWithQualityHeaderValueValue, value, (MediaTypeWithQualityHeaderValueValueLambda, valueLambda) => MediaTypeWithQualityHeaderValueValueLambda.Quality = valueLambda);
        }

    }
}