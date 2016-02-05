using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __ViaHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.ViaHeaderValue> ViaHeaderValueValue)
        {
            return Observable.Select(ViaHeaderValueValue, (ViaHeaderValueValueLambda) => ViaHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.ViaHeaderValue> ViaHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(ViaHeaderValueValue, obj, (ViaHeaderValueValueLambda, objLambda) => ViaHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.ViaHeaderValue> ViaHeaderValueValue)
        {
            return Observable.Select(ViaHeaderValueValue, (ViaHeaderValueValueLambda) => ViaHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.ViaHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.ViaHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.ViaHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.ViaHeaderValue parsedValueOutput = default(System.Net.Http.Headers.ViaHeaderValue);
var result = System.Net.Http.Headers.ViaHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> get_ProtocolName(this IObservable<System.Net.Http.Headers.ViaHeaderValue> ViaHeaderValueValue)
        {
            return Observable.Select(ViaHeaderValueValue, (ViaHeaderValueValueLambda) => ViaHeaderValueValueLambda.ProtocolName);
        }


        public static IObservable<System.String> get_ProtocolVersion(this IObservable<System.Net.Http.Headers.ViaHeaderValue> ViaHeaderValueValue)
        {
            return Observable.Select(ViaHeaderValueValue, (ViaHeaderValueValueLambda) => ViaHeaderValueValueLambda.ProtocolVersion);
        }


        public static IObservable<System.String> get_ReceivedBy(this IObservable<System.Net.Http.Headers.ViaHeaderValue> ViaHeaderValueValue)
        {
            return Observable.Select(ViaHeaderValueValue, (ViaHeaderValueValueLambda) => ViaHeaderValueValueLambda.ReceivedBy);
        }


        public static IObservable<System.String> get_Comment(this IObservable<System.Net.Http.Headers.ViaHeaderValue> ViaHeaderValueValue)
        {
            return Observable.Select(ViaHeaderValueValue, (ViaHeaderValueValueLambda) => ViaHeaderValueValueLambda.Comment);
        }

    }
}