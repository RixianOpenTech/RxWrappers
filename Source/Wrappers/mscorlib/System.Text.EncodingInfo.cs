using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __EncodingInfo
    {
        
        public static IObservable<System.Text.Encoding> GetEncoding(this IObservable<System.Text.EncodingInfo> EncodingInfoValue)
        {
            return Observable.Select(EncodingInfoValue, (EncodingInfoValueLambda) => EncodingInfoValueLambda.GetEncoding());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Text.EncodingInfo> EncodingInfoValue, IObservable<System.Object> value)
        {
            return Observable.Zip(EncodingInfoValue, value, (EncodingInfoValueLambda, valueLambda) => EncodingInfoValueLambda.Equals(valueLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Text.EncodingInfo> EncodingInfoValue)
        {
            return Observable.Select(EncodingInfoValue, (EncodingInfoValueLambda) => EncodingInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Int32> get_CodePage(this IObservable<System.Text.EncodingInfo> EncodingInfoValue)
        {
            return Observable.Select(EncodingInfoValue, (EncodingInfoValueLambda) => EncodingInfoValueLambda.CodePage);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Text.EncodingInfo> EncodingInfoValue)
        {
            return Observable.Select(EncodingInfoValue, (EncodingInfoValueLambda) => EncodingInfoValueLambda.Name);
        }


        public static IObservable<System.String> get_DisplayName(this IObservable<System.Text.EncodingInfo> EncodingInfoValue)
        {
            return Observable.Select(EncodingInfoValue, (EncodingInfoValueLambda) => EncodingInfoValueLambda.DisplayName);
        }

    }
}