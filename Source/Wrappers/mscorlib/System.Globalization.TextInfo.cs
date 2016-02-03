using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __TextInfo
    {
        public static IObservable<System.Object> Clone(this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.Clone());
        }


        public static IObservable<System.Globalization.TextInfo> ReadOnly(
            IObservable<System.Globalization.TextInfo> textInfo)
        {
            return Observable.Select(textInfo,
                (textInfoLambda) => System.Globalization.TextInfo.ReadOnly(textInfoLambda));
        }


        public static IObservable<System.Char> ToLower(this IObservable<System.Globalization.TextInfo> TextInfoValue,
            IObservable<System.Char> c)
        {
            return Observable.Zip(TextInfoValue, c,
                (TextInfoValueLambda, cLambda) => TextInfoValueLambda.ToLower(cLambda));
        }


        public static IObservable<System.String> ToLower(this IObservable<System.Globalization.TextInfo> TextInfoValue,
            IObservable<System.String> str)
        {
            return Observable.Zip(TextInfoValue, str,
                (TextInfoValueLambda, strLambda) => TextInfoValueLambda.ToLower(strLambda));
        }


        public static IObservable<System.Char> ToUpper(this IObservable<System.Globalization.TextInfo> TextInfoValue,
            IObservable<System.Char> c)
        {
            return Observable.Zip(TextInfoValue, c,
                (TextInfoValueLambda, cLambda) => TextInfoValueLambda.ToUpper(cLambda));
        }


        public static IObservable<System.String> ToUpper(this IObservable<System.Globalization.TextInfo> TextInfoValue,
            IObservable<System.String> str)
        {
            return Observable.Zip(TextInfoValue, str,
                (TextInfoValueLambda, strLambda) => TextInfoValueLambda.ToUpper(strLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Globalization.TextInfo> TextInfoValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(TextInfoValue, obj,
                (TextInfoValueLambda, objLambda) => TextInfoValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.ToString());
        }


        public static IObservable<System.String> ToTitleCase(
            this IObservable<System.Globalization.TextInfo> TextInfoValue, IObservable<System.String> str)
        {
            return Observable.Zip(TextInfoValue, str,
                (TextInfoValueLambda, strLambda) => TextInfoValueLambda.ToTitleCase(strLambda));
        }


        public static IObservable<System.Int32> get_ANSICodePage(
            this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.ANSICodePage);
        }


        public static IObservable<System.Int32> get_OEMCodePage(
            this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.OEMCodePage);
        }


        public static IObservable<System.Int32> get_MacCodePage(
            this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.MacCodePage);
        }


        public static IObservable<System.Int32> get_EBCDICCodePage(
            this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.EBCDICCodePage);
        }


        public static IObservable<System.Int32> get_LCID(this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.LCID);
        }


        public static IObservable<System.String> get_CultureName(
            this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.CultureName);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(
            this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.IsReadOnly);
        }


        public static IObservable<System.String> get_ListSeparator(
            this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.ListSeparator);
        }


        public static IObservable<System.Boolean> get_IsRightToLeft(
            this IObservable<System.Globalization.TextInfo> TextInfoValue)
        {
            return Observable.Select(TextInfoValue, (TextInfoValueLambda) => TextInfoValueLambda.IsRightToLeft);
        }


        public static IObservable<System.Reactive.Unit> set_ListSeparator(
            this IObservable<System.Globalization.TextInfo> TextInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(TextInfoValue, value,
                (TextInfoValueLambda, valueLambda) => TextInfoValueLambda.ListSeparator = valueLambda);
        }
    }
}