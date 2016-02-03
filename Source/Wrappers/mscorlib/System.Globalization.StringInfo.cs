using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
    public static class __StringInfo
    {
        
        public static IObservable<System.String> GetNextTextElement(IObservable<System.String> str, IObservable<System.Int32> index)
        {
            return Observable.Zip(str, index, (strLambda, indexLambda) => System.Globalization.StringInfo.GetNextTextElement(strLambda, indexLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Globalization.StringInfo> StringInfoValue, IObservable<System.Object> value)
        {
            return Observable.Zip(StringInfoValue, value, (StringInfoValueLambda, valueLambda) => StringInfoValueLambda.Equals(valueLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Globalization.StringInfo> StringInfoValue)
        {
            return Observable.Select(StringInfoValue, (StringInfoValueLambda) => StringInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.String> SubstringByTextElements(this IObservable<System.Globalization.StringInfo> StringInfoValue, IObservable<System.Int32> startingTextElement)
        {
            return Observable.Zip(StringInfoValue, startingTextElement, (StringInfoValueLambda, startingTextElementLambda) => StringInfoValueLambda.SubstringByTextElements(startingTextElementLambda));
        }


        public static IObservable<System.String> SubstringByTextElements(this IObservable<System.Globalization.StringInfo> StringInfoValue, IObservable<System.Int32> startingTextElement, IObservable<System.Int32> lengthInTextElements)
        {
            return Observable.Zip(StringInfoValue, startingTextElement, lengthInTextElements, (StringInfoValueLambda, startingTextElementLambda, lengthInTextElementsLambda) => StringInfoValueLambda.SubstringByTextElements(startingTextElementLambda, lengthInTextElementsLambda));
        }


        public static IObservable<System.String> GetNextTextElement(IObservable<System.String> str)
        {
            return Observable.Select(str, (strLambda) => System.Globalization.StringInfo.GetNextTextElement(strLambda));
        }


        public static IObservable<System.Globalization.TextElementEnumerator> GetTextElementEnumerator(IObservable<System.String> str)
        {
            return Observable.Select(str, (strLambda) => System.Globalization.StringInfo.GetTextElementEnumerator(strLambda));
        }


        public static IObservable<System.Globalization.TextElementEnumerator> GetTextElementEnumerator(IObservable<System.String> str, IObservable<System.Int32> index)
        {
            return Observable.Zip(str, index, (strLambda, indexLambda) => System.Globalization.StringInfo.GetTextElementEnumerator(strLambda, indexLambda));
        }


        public static IObservable<System.Int32[]> ParseCombiningCharacters(IObservable<System.String> str)
        {
            return Observable.Select(str, (strLambda) => System.Globalization.StringInfo.ParseCombiningCharacters(strLambda));
        }


        public static IObservable<System.String> get_String(this IObservable<System.Globalization.StringInfo> StringInfoValue)
        {
            return Observable.Select(StringInfoValue, (StringInfoValueLambda) => StringInfoValueLambda.String);
        }


        public static IObservable<System.Int32> get_LengthInTextElements(this IObservable<System.Globalization.StringInfo> StringInfoValue)
        {
            return Observable.Select(StringInfoValue, (StringInfoValueLambda) => StringInfoValueLambda.LengthInTextElements);
        }


        public static IObservable<System.Reactive.Unit> set_String(this IObservable<System.Globalization.StringInfo> StringInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(StringInfoValue, value, (StringInfoValueLambda, valueLambda) => StringInfoValueLambda.String = valueLambda);
        }

    }
}