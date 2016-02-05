using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __AuthenticationHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.AuthenticationHeaderValue> AuthenticationHeaderValueValue)
        {
            return Observable.Select(AuthenticationHeaderValueValue, (AuthenticationHeaderValueValueLambda) => AuthenticationHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.AuthenticationHeaderValue> AuthenticationHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(AuthenticationHeaderValueValue, obj, (AuthenticationHeaderValueValueLambda, objLambda) => AuthenticationHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.AuthenticationHeaderValue> AuthenticationHeaderValueValue)
        {
            return Observable.Select(AuthenticationHeaderValueValue, (AuthenticationHeaderValueValueLambda) => AuthenticationHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.AuthenticationHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.AuthenticationHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.AuthenticationHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.AuthenticationHeaderValue parsedValueOutput = default(System.Net.Http.Headers.AuthenticationHeaderValue);
var result = System.Net.Http.Headers.AuthenticationHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> get_Scheme(this IObservable<System.Net.Http.Headers.AuthenticationHeaderValue> AuthenticationHeaderValueValue)
        {
            return Observable.Select(AuthenticationHeaderValueValue, (AuthenticationHeaderValueValueLambda) => AuthenticationHeaderValueValueLambda.Scheme);
        }


        public static IObservable<System.String> get_Parameter(this IObservable<System.Net.Http.Headers.AuthenticationHeaderValue> AuthenticationHeaderValueValue)
        {
            return Observable.Select(AuthenticationHeaderValueValue, (AuthenticationHeaderValueValueLambda) => AuthenticationHeaderValueValueLambda.Parameter);
        }

    }
}