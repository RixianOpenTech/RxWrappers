using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __ProductHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.ProductHeaderValue> ProductHeaderValueValue)
        {
            return Observable.Select(ProductHeaderValueValue, (ProductHeaderValueValueLambda) => ProductHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.ProductHeaderValue> ProductHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(ProductHeaderValueValue, obj, (ProductHeaderValueValueLambda, objLambda) => ProductHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.ProductHeaderValue> ProductHeaderValueValue)
        {
            return Observable.Select(ProductHeaderValueValue, (ProductHeaderValueValueLambda) => ProductHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.ProductHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.ProductHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.ProductHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.ProductHeaderValue parsedValueOutput = default(System.Net.Http.Headers.ProductHeaderValue);
var result = System.Net.Http.Headers.ProductHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Net.Http.Headers.ProductHeaderValue> ProductHeaderValueValue)
        {
            return Observable.Select(ProductHeaderValueValue, (ProductHeaderValueValueLambda) => ProductHeaderValueValueLambda.Name);
        }


        public static IObservable<System.String> get_Version(this IObservable<System.Net.Http.Headers.ProductHeaderValue> ProductHeaderValueValue)
        {
            return Observable.Select(ProductHeaderValueValue, (ProductHeaderValueValueLambda) => ProductHeaderValueValueLambda.Version);
        }

    }
}