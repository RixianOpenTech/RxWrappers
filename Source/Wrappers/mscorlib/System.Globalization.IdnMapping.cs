using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __IdnMapping
    {
        
        public static IObservable<System.String> GetAscii(this IObservable<System.Globalization.IdnMapping> IdnMappingValue, IObservable<System.String> unicode)
        {
            return Observable.Zip(IdnMappingValue, unicode, (IdnMappingValueLambda, unicodeLambda) => IdnMappingValueLambda.GetAscii(unicodeLambda));
        }


        public static IObservable<System.String> GetAscii(this IObservable<System.Globalization.IdnMapping> IdnMappingValue, IObservable<System.String> unicode, IObservable<System.Int32> index)
        {
            return Observable.Zip(IdnMappingValue, unicode, index, (IdnMappingValueLambda, unicodeLambda, indexLambda) => IdnMappingValueLambda.GetAscii(unicodeLambda, indexLambda));
        }


        public static IObservable<System.String> GetAscii(this IObservable<System.Globalization.IdnMapping> IdnMappingValue, IObservable<System.String> unicode, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(IdnMappingValue, unicode, index, count, (IdnMappingValueLambda, unicodeLambda, indexLambda, countLambda) => IdnMappingValueLambda.GetAscii(unicodeLambda, indexLambda, countLambda));
        }


        public static IObservable<System.String> GetUnicode(this IObservable<System.Globalization.IdnMapping> IdnMappingValue, IObservable<System.String> ascii)
        {
            return Observable.Zip(IdnMappingValue, ascii, (IdnMappingValueLambda, asciiLambda) => IdnMappingValueLambda.GetUnicode(asciiLambda));
        }


        public static IObservable<System.String> GetUnicode(this IObservable<System.Globalization.IdnMapping> IdnMappingValue, IObservable<System.String> ascii, IObservable<System.Int32> index)
        {
            return Observable.Zip(IdnMappingValue, ascii, index, (IdnMappingValueLambda, asciiLambda, indexLambda) => IdnMappingValueLambda.GetUnicode(asciiLambda, indexLambda));
        }


        public static IObservable<System.String> GetUnicode(this IObservable<System.Globalization.IdnMapping> IdnMappingValue, IObservable<System.String> ascii, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(IdnMappingValue, ascii, index, count, (IdnMappingValueLambda, asciiLambda, indexLambda, countLambda) => IdnMappingValueLambda.GetUnicode(asciiLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Globalization.IdnMapping> IdnMappingValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(IdnMappingValue, obj, (IdnMappingValueLambda, objLambda) => IdnMappingValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Globalization.IdnMapping> IdnMappingValue)
        {
            return Observable.Select(IdnMappingValue, (IdnMappingValueLambda) => IdnMappingValueLambda.GetHashCode());
        }


        public static IObservable<System.Boolean> get_AllowUnassigned(this IObservable<System.Globalization.IdnMapping> IdnMappingValue)
        {
            return Observable.Select(IdnMappingValue, (IdnMappingValueLambda) => IdnMappingValueLambda.AllowUnassigned);
        }


        public static IObservable<System.Boolean> get_UseStd3AsciiRules(this IObservable<System.Globalization.IdnMapping> IdnMappingValue)
        {
            return Observable.Select(IdnMappingValue, (IdnMappingValueLambda) => IdnMappingValueLambda.UseStd3AsciiRules);
        }


        public static IObservable<System.Reactive.Unit> set_AllowUnassigned(this IObservable<System.Globalization.IdnMapping> IdnMappingValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(IdnMappingValue, value, (IdnMappingValueLambda, valueLambda) => IdnMappingValueLambda.AllowUnassigned = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_UseStd3AsciiRules(this IObservable<System.Globalization.IdnMapping> IdnMappingValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(IdnMappingValue, value, (IdnMappingValueLambda, valueLambda) => IdnMappingValueLambda.UseStd3AsciiRules = valueLambda);
        }

    }
}