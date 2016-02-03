using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __CharUnicodeInfo
    {
        public static IObservable<System.Double> GetNumericValue(IObservable<System.Char> ch)
        {
            return Observable.Select(ch, (chLambda) => System.Globalization.CharUnicodeInfo.GetNumericValue(chLambda));
        }


        public static IObservable<System.Double> GetNumericValue(IObservable<System.String> s,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(s, index,
                (sLambda, indexLambda) => System.Globalization.CharUnicodeInfo.GetNumericValue(sLambda, indexLambda));
        }


        public static IObservable<System.Int32> GetDecimalDigitValue(IObservable<System.Char> ch)
        {
            return Observable.Select(ch,
                (chLambda) => System.Globalization.CharUnicodeInfo.GetDecimalDigitValue(chLambda));
        }


        public static IObservable<System.Int32> GetDecimalDigitValue(IObservable<System.String> s,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(s, index,
                (sLambda, indexLambda) =>
                    System.Globalization.CharUnicodeInfo.GetDecimalDigitValue(sLambda, indexLambda));
        }


        public static IObservable<System.Int32> GetDigitValue(IObservable<System.Char> ch)
        {
            return Observable.Select(ch, (chLambda) => System.Globalization.CharUnicodeInfo.GetDigitValue(chLambda));
        }


        public static IObservable<System.Int32> GetDigitValue(IObservable<System.String> s,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(s, index,
                (sLambda, indexLambda) => System.Globalization.CharUnicodeInfo.GetDigitValue(sLambda, indexLambda));
        }


        public static IObservable<System.Globalization.UnicodeCategory> GetUnicodeCategory(IObservable<System.Char> ch)
        {
            return Observable.Select(ch, (chLambda) => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(chLambda));
        }


        public static IObservable<System.Globalization.UnicodeCategory> GetUnicodeCategory(IObservable<System.String> s,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(s, index,
                (sLambda, indexLambda) => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(sLambda, indexLambda));
        }
    }
}