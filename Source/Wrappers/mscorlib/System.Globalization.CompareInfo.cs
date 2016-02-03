using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Globalization
{
public static class _CompareInfo
{
    
public static IObservable<System.Globalization.CompareInfo> GetCompareInfo(IObservable<System.Int32> culture, IObservable<System.Reflection.Assembly> assembly)
{
    return Observable.Zip(culture, assembly, (cultureLambda, assemblyLambda) => System.Globalization.CompareInfo.GetCompareInfo(cultureLambda, assemblyLambda));
}


public static IObservable<System.Globalization.CompareInfo> GetCompareInfo(IObservable<System.String> name, IObservable<System.Reflection.Assembly> assembly)
{
    return Observable.Zip(name, assembly, (nameLambda, assemblyLambda) => System.Globalization.CompareInfo.GetCompareInfo(nameLambda, assemblyLambda));
}


public static IObservable<System.Globalization.CompareInfo> GetCompareInfo(IObservable<System.Int32> culture)
{
    return Observable.Select(culture, (cultureLambda) => System.Globalization.CompareInfo.GetCompareInfo(cultureLambda));
}


public static IObservable<System.Globalization.CompareInfo> GetCompareInfo(IObservable<System.String> name)
{
    return Observable.Select(name, (nameLambda) => System.Globalization.CompareInfo.GetCompareInfo(nameLambda));
}


public static IObservable<System.Boolean> IsSortable(IObservable<System.Char> ch)
{
    return Observable.Select(ch, (chLambda) => System.Globalization.CompareInfo.IsSortable(chLambda));
}


public static IObservable<System.Boolean> IsSortable(IObservable<System.String> text)
{
    return Observable.Select(text, (textLambda) => System.Globalization.CompareInfo.IsSortable(textLambda));
}


public static IObservable<System.Int32> Compare(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> string1, IObservable<System.String> string2)
{
    return Observable.Zip(CompareInfoValue, string1, string2, (CompareInfoValueLambda, string1Lambda, string2Lambda) => CompareInfoValueLambda.Compare(string1Lambda, string2Lambda));
}


public static IObservable<System.Int32> Compare(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> string1, IObservable<System.String> string2, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, string1, string2, options, (CompareInfoValueLambda, string1Lambda, string2Lambda, optionsLambda) => CompareInfoValueLambda.Compare(string1Lambda, string2Lambda, optionsLambda));
}


public static IObservable<System.Int32> Compare(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> string1, IObservable<System.Int32> offset1, IObservable<System.Int32> length1, IObservable<System.String> string2, IObservable<System.Int32> offset2, IObservable<System.Int32> length2)
{
    return Observable.Zip(CompareInfoValue, string1, offset1, length1, string2, offset2, length2, (CompareInfoValueLambda, string1Lambda, offset1Lambda, length1Lambda, string2Lambda, offset2Lambda, length2Lambda) => CompareInfoValueLambda.Compare(string1Lambda, offset1Lambda, length1Lambda, string2Lambda, offset2Lambda, length2Lambda));
}


public static IObservable<System.Int32> Compare(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> string1, IObservable<System.Int32> offset1, IObservable<System.String> string2, IObservable<System.Int32> offset2, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, string1, offset1, string2, offset2, options, (CompareInfoValueLambda, string1Lambda, offset1Lambda, string2Lambda, offset2Lambda, optionsLambda) => CompareInfoValueLambda.Compare(string1Lambda, offset1Lambda, string2Lambda, offset2Lambda, optionsLambda));
}


public static IObservable<System.Int32> Compare(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> string1, IObservable<System.Int32> offset1, IObservable<System.String> string2, IObservable<System.Int32> offset2)
{
    return Observable.Zip(CompareInfoValue, string1, offset1, string2, offset2, (CompareInfoValueLambda, string1Lambda, offset1Lambda, string2Lambda, offset2Lambda) => CompareInfoValueLambda.Compare(string1Lambda, offset1Lambda, string2Lambda, offset2Lambda));
}


public static IObservable<System.Int32> Compare(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> string1, IObservable<System.Int32> offset1, IObservable<System.Int32> length1, IObservable<System.String> string2, IObservable<System.Int32> offset2, IObservable<System.Int32> length2, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, string1, offset1, length1, string2, offset2, length2, options, (CompareInfoValueLambda, string1Lambda, offset1Lambda, length1Lambda, string2Lambda, offset2Lambda, length2Lambda, optionsLambda) => CompareInfoValueLambda.Compare(string1Lambda, offset1Lambda, length1Lambda, string2Lambda, offset2Lambda, length2Lambda, optionsLambda));
}


public static IObservable<System.Boolean> IsPrefix(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> prefix, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, prefix, options, (CompareInfoValueLambda, sourceLambda, prefixLambda, optionsLambda) => CompareInfoValueLambda.IsPrefix(sourceLambda, prefixLambda, optionsLambda));
}


public static IObservable<System.Boolean> IsPrefix(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> prefix)
{
    return Observable.Zip(CompareInfoValue, source, prefix, (CompareInfoValueLambda, sourceLambda, prefixLambda) => CompareInfoValueLambda.IsPrefix(sourceLambda, prefixLambda));
}


public static IObservable<System.Boolean> IsSuffix(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> suffix, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, suffix, options, (CompareInfoValueLambda, sourceLambda, suffixLambda, optionsLambda) => CompareInfoValueLambda.IsSuffix(sourceLambda, suffixLambda, optionsLambda));
}


public static IObservable<System.Boolean> IsSuffix(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> suffix)
{
    return Observable.Zip(CompareInfoValue, source, suffix, (CompareInfoValueLambda, sourceLambda, suffixLambda) => CompareInfoValueLambda.IsSuffix(sourceLambda, suffixLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value)
{
    return Observable.Zip(CompareInfoValue, source, value, (CompareInfoValueLambda, sourceLambda, valueLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value)
{
    return Observable.Zip(CompareInfoValue, source, value, (CompareInfoValueLambda, sourceLambda, valueLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, options, (CompareInfoValueLambda, sourceLambda, valueLambda, optionsLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda, optionsLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, options, (CompareInfoValueLambda, sourceLambda, valueLambda, optionsLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda, optionsLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value, IObservable<System.Int32> startIndex, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, options, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, optionsLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda, startIndexLambda, optionsLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, options, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, optionsLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda, startIndexLambda, optionsLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, count, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, countLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, count, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, countLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, count, options, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, countLambda, optionsLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda, startIndexLambda, countLambda, optionsLambda));
}


public static IObservable<System.Int32> IndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, count, options, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, countLambda, optionsLambda) => CompareInfoValueLambda.IndexOf(sourceLambda, valueLambda, startIndexLambda, countLambda, optionsLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value)
{
    return Observable.Zip(CompareInfoValue, source, value, (CompareInfoValueLambda, sourceLambda, valueLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value)
{
    return Observable.Zip(CompareInfoValue, source, value, (CompareInfoValueLambda, sourceLambda, valueLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, options, (CompareInfoValueLambda, sourceLambda, valueLambda, optionsLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda, optionsLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, options, (CompareInfoValueLambda, sourceLambda, valueLambda, optionsLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda, optionsLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value, IObservable<System.Int32> startIndex)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda, startIndexLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value, IObservable<System.Int32> startIndex, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, options, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, optionsLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda, startIndexLambda, optionsLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, options, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, optionsLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda, startIndexLambda, optionsLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, count, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, countLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, count, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, countLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Char> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, count, options, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, countLambda, optionsLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda, startIndexLambda, countLambda, optionsLambda));
}


public static IObservable<System.Int32> LastIndexOf(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, value, startIndex, count, options, (CompareInfoValueLambda, sourceLambda, valueLambda, startIndexLambda, countLambda, optionsLambda) => CompareInfoValueLambda.LastIndexOf(sourceLambda, valueLambda, startIndexLambda, countLambda, optionsLambda));
}


public static IObservable<System.Globalization.SortKey> GetSortKey(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, options, (CompareInfoValueLambda, sourceLambda, optionsLambda) => CompareInfoValueLambda.GetSortKey(sourceLambda, optionsLambda));
}


public static IObservable<System.Globalization.SortKey> GetSortKey(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source)
{
    return Observable.Zip(CompareInfoValue, source, (CompareInfoValueLambda, sourceLambda) => CompareInfoValueLambda.GetSortKey(sourceLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.Object> value)
{
    return Observable.Zip(CompareInfoValue, value, (CompareInfoValueLambda, valueLambda) => CompareInfoValueLambda.Equals(valueLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Globalization.CompareInfo> CompareInfoValue)
{
    return Observable.Select(CompareInfoValue, (CompareInfoValueLambda) => CompareInfoValueLambda.GetHashCode());
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Globalization.CompareInfo> CompareInfoValue, IObservable<System.String> source, IObservable<System.Globalization.CompareOptions> options)
{
    return Observable.Zip(CompareInfoValue, source, options, (CompareInfoValueLambda, sourceLambda, optionsLambda) => CompareInfoValueLambda.GetHashCode(sourceLambda, optionsLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Globalization.CompareInfo> CompareInfoValue)
{
    return Observable.Select(CompareInfoValue, (CompareInfoValueLambda) => CompareInfoValueLambda.ToString());
}


public static IObservable<System.String> get_Name(this IObservable<System.Globalization.CompareInfo> CompareInfoValue)
{
    return Observable.Select(CompareInfoValue, (CompareInfoValueLambda) => CompareInfoValueLambda.Name);
}


public static IObservable<System.Int32> get_LCID(this IObservable<System.Globalization.CompareInfo> CompareInfoValue)
{
    return Observable.Select(CompareInfoValue, (CompareInfoValueLambda) => CompareInfoValueLambda.LCID);
}


public static IObservable<System.Globalization.SortVersion> get_Version(this IObservable<System.Globalization.CompareInfo> CompareInfoValue)
{
    return Observable.Select(CompareInfoValue, (CompareInfoValueLambda) => CompareInfoValueLambda.Version);
}

}
}