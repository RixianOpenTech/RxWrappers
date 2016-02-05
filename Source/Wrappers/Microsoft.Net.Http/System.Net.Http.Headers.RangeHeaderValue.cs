using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __RangeHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.RangeHeaderValue> RangeHeaderValueValue)
        {
            return Observable.Select(RangeHeaderValueValue, (RangeHeaderValueValueLambda) => RangeHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.RangeHeaderValue> RangeHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(RangeHeaderValueValue, obj, (RangeHeaderValueValueLambda, objLambda) => RangeHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.RangeHeaderValue> RangeHeaderValueValue)
        {
            return Observable.Select(RangeHeaderValueValue, (RangeHeaderValueValueLambda) => RangeHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.RangeHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.RangeHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.RangeHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.RangeHeaderValue parsedValueOutput = default(System.Net.Http.Headers.RangeHeaderValue);
var result = System.Net.Http.Headers.RangeHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> get_Unit(this IObservable<System.Net.Http.Headers.RangeHeaderValue> RangeHeaderValueValue)
        {
            return Observable.Select(RangeHeaderValueValue, (RangeHeaderValueValueLambda) => RangeHeaderValueValueLambda.Unit);
        }


        public static IObservable<System.Collections.Generic.ICollection<System.Net.Http.Headers.RangeItemHeaderValue>> get_Ranges(this IObservable<System.Net.Http.Headers.RangeHeaderValue> RangeHeaderValueValue)
        {
            return Observable.Select(RangeHeaderValueValue, (RangeHeaderValueValueLambda) => RangeHeaderValueValueLambda.Ranges);
        }


        public static IObservable<System.Reactive.Unit> set_Unit(this IObservable<System.Net.Http.Headers.RangeHeaderValue> RangeHeaderValueValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(RangeHeaderValueValue, value, (RangeHeaderValueValueLambda, valueLambda) => RangeHeaderValueValueLambda.Unit = valueLambda);
        }

    }
}