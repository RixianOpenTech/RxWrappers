using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __EntityTagHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.EntityTagHeaderValue> EntityTagHeaderValueValue)
        {
            return Observable.Select(EntityTagHeaderValueValue, (EntityTagHeaderValueValueLambda) => EntityTagHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.EntityTagHeaderValue> EntityTagHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(EntityTagHeaderValueValue, obj, (EntityTagHeaderValueValueLambda, objLambda) => EntityTagHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.EntityTagHeaderValue> EntityTagHeaderValueValue)
        {
            return Observable.Select(EntityTagHeaderValueValue, (EntityTagHeaderValueValueLambda) => EntityTagHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.EntityTagHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.EntityTagHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.EntityTagHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.EntityTagHeaderValue parsedValueOutput = default(System.Net.Http.Headers.EntityTagHeaderValue);
var result = System.Net.Http.Headers.EntityTagHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> get_Tag(this IObservable<System.Net.Http.Headers.EntityTagHeaderValue> EntityTagHeaderValueValue)
        {
            return Observable.Select(EntityTagHeaderValueValue, (EntityTagHeaderValueValueLambda) => EntityTagHeaderValueValueLambda.Tag);
        }


        public static IObservable<System.Boolean> get_IsWeak(this IObservable<System.Net.Http.Headers.EntityTagHeaderValue> EntityTagHeaderValueValue)
        {
            return Observable.Select(EntityTagHeaderValueValue, (EntityTagHeaderValueValueLambda) => EntityTagHeaderValueValueLambda.IsWeak);
        }


        public static IObservable<System.Net.Http.Headers.EntityTagHeaderValue> get_Any()
        {
            return ObservableExt.Factory(() => System.Net.Http.Headers.EntityTagHeaderValue.Any);
        }

    }
}