using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __WarningHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.WarningHeaderValue> WarningHeaderValueValue)
        {
            return Observable.Select(WarningHeaderValueValue, (WarningHeaderValueValueLambda) => WarningHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.WarningHeaderValue> WarningHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(WarningHeaderValueValue, obj, (WarningHeaderValueValueLambda, objLambda) => WarningHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.WarningHeaderValue> WarningHeaderValueValue)
        {
            return Observable.Select(WarningHeaderValueValue, (WarningHeaderValueValueLambda) => WarningHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.WarningHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.WarningHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.WarningHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.WarningHeaderValue parsedValueOutput = default(System.Net.Http.Headers.WarningHeaderValue);
var result = System.Net.Http.Headers.WarningHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.Int32> get_Code(this IObservable<System.Net.Http.Headers.WarningHeaderValue> WarningHeaderValueValue)
        {
            return Observable.Select(WarningHeaderValueValue, (WarningHeaderValueValueLambda) => WarningHeaderValueValueLambda.Code);
        }


        public static IObservable<System.String> get_Agent(this IObservable<System.Net.Http.Headers.WarningHeaderValue> WarningHeaderValueValue)
        {
            return Observable.Select(WarningHeaderValueValue, (WarningHeaderValueValueLambda) => WarningHeaderValueValueLambda.Agent);
        }


        public static IObservable<System.String> get_Text(this IObservable<System.Net.Http.Headers.WarningHeaderValue> WarningHeaderValueValue)
        {
            return Observable.Select(WarningHeaderValueValue, (WarningHeaderValueValueLambda) => WarningHeaderValueValueLambda.Text);
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_Date(this IObservable<System.Net.Http.Headers.WarningHeaderValue> WarningHeaderValueValue)
        {
            return Observable.Select(WarningHeaderValueValue, (WarningHeaderValueValueLambda) => WarningHeaderValueValueLambda.Date);
        }

    }
}