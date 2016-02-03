using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
public static class _String
{
    
public static IObservable<System.String> Join(IObservable<System.String> separator, IObservable<System.String[]> value)
{
    return Observable.Zip(separator, value, (separatorLambda, valueLambda) => System.String.Join(separatorLambda, valueLambda));
}


public static IObservable<System.String> Join(IObservable<System.String> separator, IObservable<System.Object[]> values)
{
    return Observable.Zip(separator, values, (separatorLambda, valuesLambda) => System.String.Join(separatorLambda, valuesLambda));
}


public static IObservable<System.String> Join<T>(IObservable<System.String> separator, IObservable<IEnumerable<T>> values)
{
    return Observable.Zip(separator, values, (separatorLambda, valuesLambda) => System.String.Join(separatorLambda, valuesLambda));
}


public static IObservable<System.String> Join(IObservable<System.String> separator, IObservable<System.Collections.Generic.IEnumerable<System.String>> values)
{
    return Observable.Zip(separator, values, (separatorLambda, valuesLambda) => System.String.Join(separatorLambda, valuesLambda));
}


public static IObservable<System.String> Join(IObservable<System.String> separator, IObservable<System.String[]> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(separator, value, startIndex, count, (separatorLambda, valueLambda, startIndexLambda, countLambda) => System.String.Join(separatorLambda, valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.String> StringValue, IObservable<System.Object> obj)
{
    return Observable.Zip(StringValue, obj, (StringValueLambda, objLambda) => StringValueLambda.Equals(objLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.String> StringValue, IObservable<System.String> value)
{
    return Observable.Zip(StringValue, value, (StringValueLambda, valueLambda) => StringValueLambda.Equals(valueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(StringValue, value, comparisonType, (StringValueLambda, valueLambda, comparisonTypeLambda) => StringValueLambda.Equals(valueLambda, comparisonTypeLambda));
}


public static IObservable<System.Boolean> Equals(IObservable<System.String> a, IObservable<System.String> b)
{
    return Observable.Zip(a, b, (aLambda, bLambda) => System.String.Equals(aLambda, bLambda));
}


public static IObservable<System.Boolean> Equals(IObservable<System.String> a, IObservable<System.String> b, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(a, b, comparisonType, (aLambda, bLambda, comparisonTypeLambda) => System.String.Equals(aLambda, bLambda, comparisonTypeLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.String> StringValue, IObservable<System.Int32> sourceIndex, IObservable<System.Char[]> destination, IObservable<System.Int32> destinationIndex, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(StringValue, sourceIndex, destination, destinationIndex, count, (StringValueLambda, sourceIndexLambda, destinationLambda, destinationIndexLambda, countLambda) => StringValueLambda.CopyTo(sourceIndexLambda, destinationLambda, destinationIndexLambda, countLambda));
}


public static IObservable<System.Char[]> ToCharArray(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.ToCharArray());
}


public static IObservable<System.Char[]> ToCharArray(this IObservable<System.String> StringValue, IObservable<System.Int32> startIndex, IObservable<System.Int32> length)
{
    return Observable.Zip(StringValue, startIndex, length, (StringValueLambda, startIndexLambda, lengthLambda) => StringValueLambda.ToCharArray(startIndexLambda, lengthLambda));
}


public static IObservable<System.Boolean> IsNullOrEmpty(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.String.IsNullOrEmpty(valueLambda));
}


public static IObservable<System.Boolean> IsNullOrWhiteSpace(IObservable<System.String> value)
{
    return Observable.Select(value, (valueLambda) => System.String.IsNullOrWhiteSpace(valueLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.GetHashCode());
}


public static IObservable<System.String[]> Split(this IObservable<System.String> StringValue, IObservable<System.Char[]> separator)
{
    return Observable.Zip(StringValue, separator, (StringValueLambda, separatorLambda) => StringValueLambda.Split(separatorLambda));
}


public static IObservable<System.String[]> Split(this IObservable<System.String> StringValue, IObservable<System.Char[]> separator, IObservable<System.Int32> count)
{
    return Observable.Zip(StringValue, separator, count, (StringValueLambda, separatorLambda, countLambda) => StringValueLambda.Split(separatorLambda, countLambda));
}


public static IObservable<System.String[]> Split(this IObservable<System.String> StringValue, IObservable<System.Char[]> separator, IObservable<System.StringSplitOptions> options)
{
    return Observable.Zip(StringValue, separator, options, (StringValueLambda, separatorLambda, optionsLambda) => StringValueLambda.Split(separatorLambda, optionsLambda));
}


public static IObservable<System.String[]> Split(this IObservable<System.String> StringValue, IObservable<System.Char[]> separator, IObservable<System.Int32> count, IObservable<System.StringSplitOptions> options)
{
    return Observable.Zip(StringValue, separator, count, options, (StringValueLambda, separatorLambda, countLambda, optionsLambda) => StringValueLambda.Split(separatorLambda, countLambda, optionsLambda));
}


public static IObservable<System.String[]> Split(this IObservable<System.String> StringValue, IObservable<System.String[]> separator, IObservable<System.StringSplitOptions> options)
{
    return Observable.Zip(StringValue, separator, options, (StringValueLambda, separatorLambda, optionsLambda) => StringValueLambda.Split(separatorLambda, optionsLambda));
}


public static IObservable<System.String[]> Split(this IObservable<System.String> StringValue, IObservable<System.String[]> separator, IObservable<System.Int32> count, IObservable<System.StringSplitOptions> options)
{
    return Observable.Zip(StringValue, separator, count, options, (StringValueLambda, separatorLambda, countLambda, optionsLambda) => StringValueLambda.Split(separatorLambda, countLambda, optionsLambda));
}


public static IObservable<System.String> Substring(this IObservable<System.String> StringValue, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(StringValue, startIndex, (StringValueLambda, startIndexLambda) => StringValueLambda.Substring(startIndexLambda));
}


public static IObservable<System.String> Substring(this IObservable<System.String> StringValue, IObservable<System.Int32> startIndex, IObservable<System.Int32> length)
{
    return Observable.Zip(StringValue, startIndex, length, (StringValueLambda, startIndexLambda, lengthLambda) => StringValueLambda.Substring(startIndexLambda, lengthLambda));
}


public static IObservable<System.String> Trim(this IObservable<System.String> StringValue, IObservable<System.Char[]> trimChars)
{
    return Observable.Zip(StringValue, trimChars, (StringValueLambda, trimCharsLambda) => StringValueLambda.Trim(trimCharsLambda));
}


public static IObservable<System.String> TrimStart(this IObservable<System.String> StringValue, IObservable<System.Char[]> trimChars)
{
    return Observable.Zip(StringValue, trimChars, (StringValueLambda, trimCharsLambda) => StringValueLambda.TrimStart(trimCharsLambda));
}


public static IObservable<System.String> TrimEnd(this IObservable<System.String> StringValue, IObservable<System.Char[]> trimChars)
{
    return Observable.Zip(StringValue, trimChars, (StringValueLambda, trimCharsLambda) => StringValueLambda.TrimEnd(trimCharsLambda));
}


public static IObservable<System.Boolean> IsNormalized(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.IsNormalized());
}


public static IObservable<System.Boolean> IsNormalized(this IObservable<System.String> StringValue, IObservable<System.Text.NormalizationForm> normalizationForm)
{
    return Observable.Zip(StringValue, normalizationForm, (StringValueLambda, normalizationFormLambda) => StringValueLambda.IsNormalized(normalizationFormLambda));
}


public static IObservable<System.String> Normalize(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.Normalize());
}


public static IObservable<System.String> Normalize(this IObservable<System.String> StringValue, IObservable<System.Text.NormalizationForm> normalizationForm)
{
    return Observable.Zip(StringValue, normalizationForm, (StringValueLambda, normalizationFormLambda) => StringValueLambda.Normalize(normalizationFormLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.String> strA, IObservable<System.String> strB)
{
    return Observable.Zip(strA, strB, (strALambda, strBLambda) => System.String.Compare(strALambda, strBLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.String> strA, IObservable<System.String> strB, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(strA, strB, ignoreCase, (strALambda, strBLambda, ignoreCaseLambda) => System.String.Compare(strALambda, strBLambda, ignoreCaseLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.String> strA, IObservable<System.String> strB, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(strA, strB, comparisonType, (strALambda, strBLambda, comparisonTypeLambda) => System.String.Compare(strALambda, strBLambda, comparisonTypeLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.String> strA, IObservable<System.String> strB, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(strA, strB, culture, options, (strALambda, strBLambda, cultureLambda, optionsLambda) => System.String.Compare(strALambda, strBLambda, cultureLambda, optionsLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.String> strA, IObservable<System.String> strB, IObservable<System.Boolean> ignoreCase, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(strA, strB, ignoreCase, culture, (strALambda, strBLambda, ignoreCaseLambda, cultureLambda) => System.String.Compare(strALambda, strBLambda, ignoreCaseLambda, cultureLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.String> strA, IObservable<System.Int32> indexA, IObservable<System.String> strB, IObservable<System.Int32> indexB, IObservable<System.Int32> length)
{
    return Observable.Zip(strA, indexA, strB, indexB, length, (strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda) => System.String.Compare(strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.String> strA, IObservable<System.Int32> indexA, IObservable<System.String> strB, IObservable<System.Int32> indexB, IObservable<System.Int32> length, IObservable<System.Boolean> ignoreCase)
{
    return Observable.Zip(strA, indexA, strB, indexB, length, ignoreCase, (strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda, ignoreCaseLambda) => System.String.Compare(strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda, ignoreCaseLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.String> strA, IObservable<System.Int32> indexA, IObservable<System.String> strB, IObservable<System.Int32> indexB, IObservable<System.Int32> length, IObservable<System.Boolean> ignoreCase, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(strA, indexA, strB, indexB, length, ignoreCase, culture, (strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda, ignoreCaseLambda, cultureLambda) => System.String.Compare(strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda, ignoreCaseLambda, cultureLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.String> strA, IObservable<System.Int32> indexA, IObservable<System.String> strB, IObservable<System.Int32> indexB, IObservable<System.Int32> length, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(strA, indexA, strB, indexB, length, culture, options, (strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda, cultureLambda, optionsLambda) => System.String.Compare(strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda, cultureLambda, optionsLambda));
}


public static IObservable<System.Int32> Compare(IObservable<System.String> strA, IObservable<System.Int32> indexA, IObservable<System.String> strB, IObservable<System.Int32> indexB, IObservable<System.Int32> length, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(strA, indexA, strB, indexB, length, comparisonType, (strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda, comparisonTypeLambda) => System.String.Compare(strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda, comparisonTypeLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.String> StringValue, IObservable<System.Object> value)
{
    return Observable.Zip(StringValue, value, (StringValueLambda, valueLambda) => StringValueLambda.CompareTo(valueLambda));
}


public static IObservable<System.Int32> CompareTo(this IObservable<System.String> StringValue, IObservable<System.String> strB)
{
    return Observable.Zip(StringValue, strB, (StringValueLambda, strBLambda) => StringValueLambda.CompareTo(strBLambda));
}


public static IObservable<System.Int32> CompareOrdinal(IObservable<System.String> strA, IObservable<System.String> strB)
{
    return Observable.Zip(strA, strB, (strALambda, strBLambda) => System.String.CompareOrdinal(strALambda, strBLambda));
}


public static IObservable<System.Int32> CompareOrdinal(IObservable<System.String> strA, IObservable<System.Int32> indexA, IObservable<System.String> strB, IObservable<System.Int32> indexB, IObservable<System.Int32> length)
{
    return Observable.Zip(strA, indexA, strB, indexB, length, (strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda) => System.String.CompareOrdinal(strALambda, indexALambda, strBLambda, indexBLambda, lengthLambda));
}


public static IObservable<System.Boolean> Contains(this IObservable<System.String> StringValue, IObservable<System.String> value)
{
    return Observable.Zip(StringValue, value, (StringValueLambda, valueLambda) => StringValueLambda.Contains(valueLambda));
}


public static IObservable<System.Boolean> EndsWith(this IObservable<System.String> StringValue, IObservable<System.String> value)
{
    return Observable.Zip(StringValue, value, (StringValueLambda, valueLambda) => StringValueLambda.EndsWith(valueLambda));
}


public static IObservable<System.Boolean> EndsWith(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(StringValue, value, comparisonType, (StringValueLambda, valueLambda, comparisonTypeLambda) => StringValueLambda.EndsWith(valueLambda, comparisonTypeLambda));
}


public static IObservable<System.Boolean> EndsWith(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.Boolean> ignoreCase, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(StringValue, value, ignoreCase, culture, (StringValueLambda, valueLambda, ignoreCaseLambda, cultureLambda) => StringValueLambda.EndsWith(valueLambda, ignoreCaseLambda, cultureLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.String> StringValue, IObservable<System.Char> value)
{
    return Observable.Zip(StringValue, value, (StringValueLambda, valueLambda) => StringValueLambda.IndexOf(valueLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.String> StringValue, IObservable<System.Char> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(StringValue, value, startIndex, (StringValueLambda, valueLambda, startIndexLambda) => StringValueLambda.IndexOf(valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.String> StringValue, IObservable<System.Char> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(StringValue, value, startIndex, count, (StringValueLambda, valueLambda, startIndexLambda, countLambda) => StringValueLambda.IndexOf(valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> IndexOfAny(this IObservable<System.String> StringValue, IObservable<System.Char[]> anyOf)
{
    return Observable.Zip(StringValue, anyOf, (StringValueLambda, anyOfLambda) => StringValueLambda.IndexOfAny(anyOfLambda));
}


public static IObservable<System.Int32> IndexOfAny(this IObservable<System.String> StringValue, IObservable<System.Char[]> anyOf, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(StringValue, anyOf, startIndex, (StringValueLambda, anyOfLambda, startIndexLambda) => StringValueLambda.IndexOfAny(anyOfLambda, startIndexLambda));
}


public static IObservable<System.Int32> IndexOfAny(this IObservable<System.String> StringValue, IObservable<System.Char[]> anyOf, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(StringValue, anyOf, startIndex, count, (StringValueLambda, anyOfLambda, startIndexLambda, countLambda) => StringValueLambda.IndexOfAny(anyOfLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value)
{
    return Observable.Zip(StringValue, value, (StringValueLambda, valueLambda) => StringValueLambda.IndexOf(valueLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(StringValue, value, startIndex, (StringValueLambda, valueLambda, startIndexLambda) => StringValueLambda.IndexOf(valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(StringValue, value, startIndex, count, (StringValueLambda, valueLambda, startIndexLambda, countLambda) => StringValueLambda.IndexOf(valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(StringValue, value, comparisonType, (StringValueLambda, valueLambda, comparisonTypeLambda) => StringValueLambda.IndexOf(valueLambda, comparisonTypeLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(StringValue, value, startIndex, comparisonType, (StringValueLambda, valueLambda, startIndexLambda, comparisonTypeLambda) => StringValueLambda.IndexOf(valueLambda, startIndexLambda, comparisonTypeLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(StringValue, value, startIndex, count, comparisonType, (StringValueLambda, valueLambda, startIndexLambda, countLambda, comparisonTypeLambda) => StringValueLambda.IndexOf(valueLambda, startIndexLambda, countLambda, comparisonTypeLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.String> StringValue, IObservable<System.Char> value)
{
    return Observable.Zip(StringValue, value, (StringValueLambda, valueLambda) => StringValueLambda.LastIndexOf(valueLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.String> StringValue, IObservable<System.Char> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(StringValue, value, startIndex, (StringValueLambda, valueLambda, startIndexLambda) => StringValueLambda.LastIndexOf(valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.String> StringValue, IObservable<System.Char> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(StringValue, value, startIndex, count, (StringValueLambda, valueLambda, startIndexLambda, countLambda) => StringValueLambda.LastIndexOf(valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> LastIndexOfAny(this IObservable<System.String> StringValue, IObservable<System.Char[]> anyOf)
{
    return Observable.Zip(StringValue, anyOf, (StringValueLambda, anyOfLambda) => StringValueLambda.LastIndexOfAny(anyOfLambda));
}


public static IObservable<System.Int32> LastIndexOfAny(this IObservable<System.String> StringValue, IObservable<System.Char[]> anyOf, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(StringValue, anyOf, startIndex, (StringValueLambda, anyOfLambda, startIndexLambda) => StringValueLambda.LastIndexOfAny(anyOfLambda, startIndexLambda));
}


public static IObservable<System.Int32> LastIndexOfAny(this IObservable<System.String> StringValue, IObservable<System.Char[]> anyOf, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(StringValue, anyOf, startIndex, count, (StringValueLambda, anyOfLambda, startIndexLambda, countLambda) => StringValueLambda.LastIndexOfAny(anyOfLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value)
{
    return Observable.Zip(StringValue, value, (StringValueLambda, valueLambda) => StringValueLambda.LastIndexOf(valueLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(StringValue, value, startIndex, (StringValueLambda, valueLambda, startIndexLambda) => StringValueLambda.LastIndexOf(valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(StringValue, value, startIndex, count, (StringValueLambda, valueLambda, startIndexLambda, countLambda) => StringValueLambda.LastIndexOf(valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(StringValue, value, comparisonType, (StringValueLambda, valueLambda, comparisonTypeLambda) => StringValueLambda.LastIndexOf(valueLambda, comparisonTypeLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(StringValue, value, startIndex, comparisonType, (StringValueLambda, valueLambda, startIndexLambda, comparisonTypeLambda) => StringValueLambda.LastIndexOf(valueLambda, startIndexLambda, comparisonTypeLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(StringValue, value, startIndex, count, comparisonType, (StringValueLambda, valueLambda, startIndexLambda, countLambda, comparisonTypeLambda) => StringValueLambda.LastIndexOf(valueLambda, startIndexLambda, countLambda, comparisonTypeLambda));
}


public static IObservable<System.String> PadLeft(this IObservable<System.String> StringValue, IObservable<System.Int32> totalWidth)
{
    return Observable.Zip(StringValue, totalWidth, (StringValueLambda, totalWidthLambda) => StringValueLambda.PadLeft(totalWidthLambda));
}


public static IObservable<System.String> PadLeft(this IObservable<System.String> StringValue, IObservable<System.Int32> totalWidth, IObservable<System.Char> paddingChar)
{
    return Observable.Zip(StringValue, totalWidth, paddingChar, (StringValueLambda, totalWidthLambda, paddingCharLambda) => StringValueLambda.PadLeft(totalWidthLambda, paddingCharLambda));
}


public static IObservable<System.String> PadRight(this IObservable<System.String> StringValue, IObservable<System.Int32> totalWidth)
{
    return Observable.Zip(StringValue, totalWidth, (StringValueLambda, totalWidthLambda) => StringValueLambda.PadRight(totalWidthLambda));
}


public static IObservable<System.String> PadRight(this IObservable<System.String> StringValue, IObservable<System.Int32> totalWidth, IObservable<System.Char> paddingChar)
{
    return Observable.Zip(StringValue, totalWidth, paddingChar, (StringValueLambda, totalWidthLambda, paddingCharLambda) => StringValueLambda.PadRight(totalWidthLambda, paddingCharLambda));
}


public static IObservable<System.Boolean> StartsWith(this IObservable<System.String> StringValue, IObservable<System.String> value)
{
    return Observable.Zip(StringValue, value, (StringValueLambda, valueLambda) => StringValueLambda.StartsWith(valueLambda));
}


public static IObservable<System.Boolean> StartsWith(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.StringComparison> comparisonType)
{
    return Observable.Zip(StringValue, value, comparisonType, (StringValueLambda, valueLambda, comparisonTypeLambda) => StringValueLambda.StartsWith(valueLambda, comparisonTypeLambda));
}


public static IObservable<System.Boolean> StartsWith(this IObservable<System.String> StringValue, IObservable<System.String> value, IObservable<System.Boolean> ignoreCase, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(StringValue, value, ignoreCase, culture, (StringValueLambda, valueLambda, ignoreCaseLambda, cultureLambda) => StringValueLambda.StartsWith(valueLambda, ignoreCaseLambda, cultureLambda));
}


public static IObservable<System.String> ToLower(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.ToLower());
}


public static IObservable<System.String> ToLower(this IObservable<System.String> StringValue, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(StringValue, culture, (StringValueLambda, cultureLambda) => StringValueLambda.ToLower(cultureLambda));
}


public static IObservable<System.String> ToLowerInvariant(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.ToLowerInvariant());
}


public static IObservable<System.String> ToUpper(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.ToUpper());
}


public static IObservable<System.String> ToUpper(this IObservable<System.String> StringValue, IObservable<System.Globalization.CultureInfo> culture)
{
    return Observable.Zip(StringValue, culture, (StringValueLambda, cultureLambda) => StringValueLambda.ToUpper(cultureLambda));
}


public static IObservable<System.String> ToUpperInvariant(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.ToUpperInvariant());
}


public static IObservable<System.String> ToString(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.String> StringValue, IObservable<System.IFormatProvider> provider)
{
    return Observable.Zip(StringValue, provider, (StringValueLambda, providerLambda) => StringValueLambda.ToString(providerLambda));
}


public static IObservable<System.Object> Clone(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.Clone());
}


public static IObservable<System.String> Trim(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.Trim());
}


public static IObservable<System.String> Insert(this IObservable<System.String> StringValue, IObservable<System.Int32> startIndex, IObservable<System.String> value)
{
    return Observable.Zip(StringValue, startIndex, value, (StringValueLambda, startIndexLambda, valueLambda) => StringValueLambda.Insert(startIndexLambda, valueLambda));
}


public static IObservable<System.String> Replace(this IObservable<System.String> StringValue, IObservable<System.Char> oldChar, IObservable<System.Char> newChar)
{
    return Observable.Zip(StringValue, oldChar, newChar, (StringValueLambda, oldCharLambda, newCharLambda) => StringValueLambda.Replace(oldCharLambda, newCharLambda));
}


public static IObservable<System.String> Replace(this IObservable<System.String> StringValue, IObservable<System.String> oldValue, IObservable<System.String> newValue)
{
    return Observable.Zip(StringValue, oldValue, newValue, (StringValueLambda, oldValueLambda, newValueLambda) => StringValueLambda.Replace(oldValueLambda, newValueLambda));
}


public static IObservable<System.String> Remove(this IObservable<System.String> StringValue, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(StringValue, startIndex, count, (StringValueLambda, startIndexLambda, countLambda) => StringValueLambda.Remove(startIndexLambda, countLambda));
}


public static IObservable<System.String> Remove(this IObservable<System.String> StringValue, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(StringValue, startIndex, (StringValueLambda, startIndexLambda) => StringValueLambda.Remove(startIndexLambda));
}


public static IObservable<System.String> Format(IObservable<System.String> format, IObservable<System.Object> arg0)
{
    return Observable.Zip(format, arg0, (formatLambda, arg0Lambda) => System.String.Format(formatLambda, arg0Lambda));
}


public static IObservable<System.String> Format(IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1)
{
    return Observable.Zip(format, arg0, arg1, (formatLambda, arg0Lambda, arg1Lambda) => System.String.Format(formatLambda, arg0Lambda, arg1Lambda));
}


public static IObservable<System.String> Format(IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2)
{
    return Observable.Zip(format, arg0, arg1, arg2, (formatLambda, arg0Lambda, arg1Lambda, arg2Lambda) => System.String.Format(formatLambda, arg0Lambda, arg1Lambda, arg2Lambda));
}


public static IObservable<System.String> Format(IObservable<System.String> format, IObservable<System.Object[]> args)
{
    return Observable.Zip(format, args, (formatLambda, argsLambda) => System.String.Format(formatLambda, argsLambda));
}


public static IObservable<System.String> Format(IObservable<System.IFormatProvider> provider, IObservable<System.String> format, IObservable<System.Object> arg0)
{
    return Observable.Zip(provider, format, arg0, (providerLambda, formatLambda, arg0Lambda) => System.String.Format(providerLambda, formatLambda, arg0Lambda));
}


public static IObservable<System.String> Format(IObservable<System.IFormatProvider> provider, IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1)
{
    return Observable.Zip(provider, format, arg0, arg1, (providerLambda, formatLambda, arg0Lambda, arg1Lambda) => System.String.Format(providerLambda, formatLambda, arg0Lambda, arg1Lambda));
}


public static IObservable<System.String> Format(IObservable<System.IFormatProvider> provider, IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2)
{
    return Observable.Zip(provider, format, arg0, arg1, arg2, (providerLambda, formatLambda, arg0Lambda, arg1Lambda, arg2Lambda) => System.String.Format(providerLambda, formatLambda, arg0Lambda, arg1Lambda, arg2Lambda));
}


public static IObservable<System.String> Format(IObservable<System.IFormatProvider> provider, IObservable<System.String> format, IObservable<System.Object[]> args)
{
    return Observable.Zip(provider, format, args, (providerLambda, formatLambda, argsLambda) => System.String.Format(providerLambda, formatLambda, argsLambda));
}


public static IObservable<System.String> Copy(IObservable<System.String> str)
{
    return Observable.Select(str, (strLambda) => System.String.Copy(strLambda));
}


public static IObservable<System.String> Concat(IObservable<System.Object> arg0)
{
    return Observable.Select(arg0, (arg0Lambda) => System.String.Concat(arg0Lambda));
}


public static IObservable<System.String> Concat(IObservable<System.Object> arg0, IObservable<System.Object> arg1)
{
    return Observable.Zip(arg0, arg1, (arg0Lambda, arg1Lambda) => System.String.Concat(arg0Lambda, arg1Lambda));
}


public static IObservable<System.String> Concat(IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2)
{
    return Observable.Zip(arg0, arg1, arg2, (arg0Lambda, arg1Lambda, arg2Lambda) => System.String.Concat(arg0Lambda, arg1Lambda, arg2Lambda));
}


public static IObservable<System.String> Concat(IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2, IObservable<System.Object> arg3)
{
    return Observable.Zip(arg0, arg1, arg2, arg3, (arg0Lambda, arg1Lambda, arg2Lambda, arg3Lambda) => System.String.Concat(arg0Lambda, arg1Lambda, arg2Lambda, arg3Lambda));
}


public static IObservable<System.String> Concat(IObservable<System.Object[]> args)
{
    return Observable.Select(args, (argsLambda) => System.String.Concat(argsLambda));
}


public static IObservable<System.String> Concat<T>(IObservable<IEnumerable<T>> values)
{
    return Observable.Select(values, (valuesLambda) => System.String.Concat(valuesLambda));
}


public static IObservable<System.String> Concat(IObservable<System.Collections.Generic.IEnumerable<System.String>> values)
{
    return Observable.Select(values, (valuesLambda) => System.String.Concat(valuesLambda));
}


public static IObservable<System.String> Concat(IObservable<System.String> str0, IObservable<System.String> str1)
{
    return Observable.Zip(str0, str1, (str0Lambda, str1Lambda) => System.String.Concat(str0Lambda, str1Lambda));
}


public static IObservable<System.String> Concat(IObservable<System.String> str0, IObservable<System.String> str1, IObservable<System.String> str2)
{
    return Observable.Zip(str0, str1, str2, (str0Lambda, str1Lambda, str2Lambda) => System.String.Concat(str0Lambda, str1Lambda, str2Lambda));
}


public static IObservable<System.String> Concat(IObservable<System.String> str0, IObservable<System.String> str1, IObservable<System.String> str2, IObservable<System.String> str3)
{
    return Observable.Zip(str0, str1, str2, str3, (str0Lambda, str1Lambda, str2Lambda, str3Lambda) => System.String.Concat(str0Lambda, str1Lambda, str2Lambda, str3Lambda));
}


public static IObservable<System.String> Concat(IObservable<System.String[]> values)
{
    return Observable.Select(values, (valuesLambda) => System.String.Concat(valuesLambda));
}


public static IObservable<System.String> Intern(IObservable<System.String> str)
{
    return Observable.Select(str, (strLambda) => System.String.Intern(strLambda));
}


public static IObservable<System.String> IsInterned(IObservable<System.String> str)
{
    return Observable.Select(str, (strLambda) => System.String.IsInterned(strLambda));
}


public static IObservable<System.TypeCode> GetTypeCode(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.GetTypeCode());
}


public static IObservable<System.CharEnumerator> GetEnumerator(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.GetEnumerator());
}


public static IObservable<System.Char> get_Chars(this IObservable<System.String> StringValue, IObservable<System.Int32> index)
{
    return Observable.Zip(StringValue, index, (StringValueLambda, indexLambda) => StringValueLambda.Chars);
}


public static IObservable<System.Int32> get_Length(this IObservable<System.String> StringValue)
{
    return Observable.Select(StringValue, (StringValueLambda) => StringValueLambda.Length);
}

}
}