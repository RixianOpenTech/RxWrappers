using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __FormattableString
    {
        
        public static IObservable<System.Object[]> GetArguments(this IObservable<System.FormattableString> FormattableStringValue)
        {
            return Observable.Select(FormattableStringValue, (FormattableStringValueLambda) => FormattableStringValueLambda.GetArguments());
        }


        public static IObservable<System.Object> GetArgument(this IObservable<System.FormattableString> FormattableStringValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(FormattableStringValue, index, (FormattableStringValueLambda, indexLambda) => FormattableStringValueLambda.GetArgument(indexLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.FormattableString> FormattableStringValue, IObservable<System.IFormatProvider> formatProvider)
        {
            return Observable.Zip(FormattableStringValue, formatProvider, (FormattableStringValueLambda, formatProviderLambda) => FormattableStringValueLambda.ToString(formatProviderLambda));
        }


        public static IObservable<System.String> Invariant(IObservable<System.FormattableString> formattable)
        {
            return Observable.Select(formattable, (formattableLambda) => System.FormattableString.Invariant(formattableLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<System.FormattableString> FormattableStringValue)
        {
            return Observable.Select(FormattableStringValue, (FormattableStringValueLambda) => FormattableStringValueLambda.ToString());
        }


        public static IObservable<System.String> get_Format(this IObservable<System.FormattableString> FormattableStringValue)
        {
            return Observable.Select(FormattableStringValue, (FormattableStringValueLambda) => FormattableStringValueLambda.Format);
        }


        public static IObservable<System.Int32> get_ArgumentCount(this IObservable<System.FormattableString> FormattableStringValue)
        {
            return Observable.Select(FormattableStringValue, (FormattableStringValueLambda) => FormattableStringValueLambda.ArgumentCount);
        }

    }
}