using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __NumberFormatInfo
    {
        
        public static IObservable<System.Globalization.NumberFormatInfo> GetInstance(IObservable<System.IFormatProvider> formatProvider)
        {
            return Observable.Select(formatProvider, (formatProviderLambda) => System.Globalization.NumberFormatInfo.GetInstance(formatProviderLambda));
        }


        public static IObservable<System.Object> Clone(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.Clone());
        }


        public static IObservable<System.Object> GetFormat(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Type> formatType)
        {
            return Observable.Zip(NumberFormatInfoValue, formatType, (NumberFormatInfoValueLambda, formatTypeLambda) => NumberFormatInfoValueLambda.GetFormat(formatTypeLambda));
        }


        public static IObservable<System.Globalization.NumberFormatInfo> ReadOnly(IObservable<System.Globalization.NumberFormatInfo> nfi)
        {
            return Observable.Select(nfi, (nfiLambda) => System.Globalization.NumberFormatInfo.ReadOnly(nfiLambda));
        }


        public static IObservable<System.Globalization.NumberFormatInfo> get_InvariantInfo()
        {
            return ObservableExt.Factory(() => System.Globalization.NumberFormatInfo.InvariantInfo);
        }


        public static IObservable<System.Int32> get_CurrencyDecimalDigits(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.CurrencyDecimalDigits);
        }


        public static IObservable<System.String> get_CurrencyDecimalSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.CurrencyDecimalSeparator);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.IsReadOnly);
        }


        public static IObservable<System.Int32[]> get_CurrencyGroupSizes(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.CurrencyGroupSizes);
        }


        public static IObservable<System.Int32[]> get_NumberGroupSizes(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.NumberGroupSizes);
        }


        public static IObservable<System.Int32[]> get_PercentGroupSizes(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.PercentGroupSizes);
        }


        public static IObservable<System.String> get_CurrencyGroupSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.CurrencyGroupSeparator);
        }


        public static IObservable<System.String> get_CurrencySymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.CurrencySymbol);
        }


        public static IObservable<System.Globalization.NumberFormatInfo> get_CurrentInfo()
        {
            return ObservableExt.Factory(() => System.Globalization.NumberFormatInfo.CurrentInfo);
        }


        public static IObservable<System.String> get_NaNSymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.NaNSymbol);
        }


        public static IObservable<System.Int32> get_CurrencyNegativePattern(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.CurrencyNegativePattern);
        }


        public static IObservable<System.Int32> get_NumberNegativePattern(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.NumberNegativePattern);
        }


        public static IObservable<System.Int32> get_PercentPositivePattern(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.PercentPositivePattern);
        }


        public static IObservable<System.Int32> get_PercentNegativePattern(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.PercentNegativePattern);
        }


        public static IObservable<System.String> get_NegativeInfinitySymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.NegativeInfinitySymbol);
        }


        public static IObservable<System.String> get_NegativeSign(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.NegativeSign);
        }


        public static IObservable<System.Int32> get_NumberDecimalDigits(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.NumberDecimalDigits);
        }


        public static IObservable<System.String> get_NumberDecimalSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.NumberDecimalSeparator);
        }


        public static IObservable<System.String> get_NumberGroupSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.NumberGroupSeparator);
        }


        public static IObservable<System.Int32> get_CurrencyPositivePattern(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.CurrencyPositivePattern);
        }


        public static IObservable<System.String> get_PositiveInfinitySymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.PositiveInfinitySymbol);
        }


        public static IObservable<System.String> get_PositiveSign(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.PositiveSign);
        }


        public static IObservable<System.Int32> get_PercentDecimalDigits(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.PercentDecimalDigits);
        }


        public static IObservable<System.String> get_PercentDecimalSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.PercentDecimalSeparator);
        }


        public static IObservable<System.String> get_PercentGroupSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.PercentGroupSeparator);
        }


        public static IObservable<System.String> get_PercentSymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.PercentSymbol);
        }


        public static IObservable<System.String> get_PerMilleSymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.PerMilleSymbol);
        }


        public static IObservable<System.String[]> get_NativeDigits(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.NativeDigits);
        }


        public static IObservable<System.Globalization.DigitShapes> get_DigitSubstitution(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue)
        {
            return Observable.Select(NumberFormatInfoValue, (NumberFormatInfoValueLambda) => NumberFormatInfoValueLambda.DigitSubstitution);
        }


        public static IObservable<System.Reactive.Unit> set_CurrencyDecimalDigits(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.CurrencyDecimalDigits = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CurrencyDecimalSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.CurrencyDecimalSeparator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CurrencyGroupSizes(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32[]> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.CurrencyGroupSizes = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NumberGroupSizes(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32[]> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.NumberGroupSizes = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PercentGroupSizes(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32[]> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.PercentGroupSizes = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CurrencyGroupSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.CurrencyGroupSeparator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CurrencySymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.CurrencySymbol = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NaNSymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.NaNSymbol = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CurrencyNegativePattern(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.CurrencyNegativePattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NumberNegativePattern(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.NumberNegativePattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PercentPositivePattern(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.PercentPositivePattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PercentNegativePattern(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.PercentNegativePattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NegativeInfinitySymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.NegativeInfinitySymbol = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NegativeSign(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.NegativeSign = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NumberDecimalDigits(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.NumberDecimalDigits = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NumberDecimalSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.NumberDecimalSeparator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NumberGroupSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.NumberGroupSeparator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CurrencyPositivePattern(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.CurrencyPositivePattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PositiveInfinitySymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.PositiveInfinitySymbol = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PositiveSign(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.PositiveSign = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PercentDecimalDigits(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.PercentDecimalDigits = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PercentDecimalSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.PercentDecimalSeparator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PercentGroupSeparator(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.PercentGroupSeparator = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PercentSymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.PercentSymbol = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PerMilleSymbol(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.PerMilleSymbol = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NativeDigits(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.NativeDigits = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DigitSubstitution(this IObservable<System.Globalization.NumberFormatInfo> NumberFormatInfoValue, IObservable<System.Globalization.DigitShapes> value)
        {
            return ObservableExt.ZipExecute(NumberFormatInfoValue, value, (NumberFormatInfoValueLambda, valueLambda) => NumberFormatInfoValueLambda.DigitSubstitution = valueLambda);
        }

    }
}