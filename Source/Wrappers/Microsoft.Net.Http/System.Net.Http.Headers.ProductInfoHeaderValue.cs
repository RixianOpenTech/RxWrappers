using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __ProductInfoHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.ProductInfoHeaderValue> ProductInfoHeaderValueValue)
        {
            return Observable.Select(ProductInfoHeaderValueValue, (ProductInfoHeaderValueValueLambda) => ProductInfoHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.ProductInfoHeaderValue> ProductInfoHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(ProductInfoHeaderValueValue, obj, (ProductInfoHeaderValueValueLambda, objLambda) => ProductInfoHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.ProductInfoHeaderValue> ProductInfoHeaderValueValue)
        {
            return Observable.Select(ProductInfoHeaderValueValue, (ProductInfoHeaderValueValueLambda) => ProductInfoHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.ProductInfoHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.ProductInfoHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.ProductInfoHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.ProductInfoHeaderValue parsedValueOutput = default(System.Net.Http.Headers.ProductInfoHeaderValue);
var result = System.Net.Http.Headers.ProductInfoHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.Net.Http.Headers.ProductHeaderValue> get_Product(this IObservable<System.Net.Http.Headers.ProductInfoHeaderValue> ProductInfoHeaderValueValue)
        {
            return Observable.Select(ProductInfoHeaderValueValue, (ProductInfoHeaderValueValueLambda) => ProductInfoHeaderValueValueLambda.Product);
        }


        public static IObservable<System.String> get_Comment(this IObservable<System.Net.Http.Headers.ProductInfoHeaderValue> ProductInfoHeaderValueValue)
        {
            return Observable.Select(ProductInfoHeaderValueValue, (ProductInfoHeaderValueValueLambda) => ProductInfoHeaderValueValueLambda.Comment);
        }

    }
}