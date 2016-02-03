using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
public static class _StringBuilder
{
    
public static IObservable<System.Int32> EnsureCapacity(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> capacity)
{
    return Observable.Zip(StringBuilderValue, capacity, (StringBuilderValueLambda, capacityLambda) => StringBuilderValueLambda.EnsureCapacity(capacityLambda));
}


public static IObservable<System.String> ToString(this IObservable<System.Text.StringBuilder> StringBuilderValue)
{
    return Observable.Select(StringBuilderValue, (StringBuilderValueLambda) => StringBuilderValueLambda.ToString());
}


public static IObservable<System.String> ToString(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> startIndex, IObservable<System.Int32> length)
{
    return Observable.Zip(StringBuilderValue, startIndex, length, (StringBuilderValueLambda, startIndexLambda, lengthLambda) => StringBuilderValueLambda.ToString(startIndexLambda, lengthLambda));
}


public static IObservable<System.Text.StringBuilder> Clear(this IObservable<System.Text.StringBuilder> StringBuilderValue)
{
    return Observable.Select(StringBuilderValue, (StringBuilderValueLambda) => StringBuilderValueLambda.Clear());
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Char> value, IObservable<System.Int32> repeatCount)
{
    return Observable.Zip(StringBuilderValue, value, repeatCount, (StringBuilderValueLambda, valueLambda, repeatCountLambda) => StringBuilderValueLambda.Append(valueLambda, repeatCountLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Char[]> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> charCount)
{
    return Observable.Zip(StringBuilderValue, value, startIndex, charCount, (StringBuilderValueLambda, valueLambda, startIndexLambda, charCountLambda) => StringBuilderValueLambda.Append(valueLambda, startIndexLambda, charCountLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.String> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.String> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(StringBuilderValue, value, startIndex, count, (StringBuilderValueLambda, valueLambda, startIndexLambda, countLambda) => StringBuilderValueLambda.Append(valueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Text.StringBuilder> AppendLine(this IObservable<System.Text.StringBuilder> StringBuilderValue)
{
    return Observable.Select(StringBuilderValue, (StringBuilderValueLambda) => StringBuilderValueLambda.AppendLine());
}


public static IObservable<System.Text.StringBuilder> AppendLine(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.String> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.AppendLine(valueLambda));
}


public static IObservable<System.Reactive.Unit> CopyTo(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> sourceIndex, IObservable<System.Char[]> destination, IObservable<System.Int32> destinationIndex, IObservable<System.Int32> count)
{
    return ObservableExt.ZipExecute(StringBuilderValue, sourceIndex, destination, destinationIndex, count, (StringBuilderValueLambda, sourceIndexLambda, destinationLambda, destinationIndexLambda, countLambda) => StringBuilderValueLambda.CopyTo(sourceIndexLambda, destinationLambda, destinationIndexLambda, countLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.String> value, IObservable<System.Int32> count)
{
    return Observable.Zip(StringBuilderValue, index, value, count, (StringBuilderValueLambda, indexLambda, valueLambda, countLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda, countLambda));
}


public static IObservable<System.Text.StringBuilder> Remove(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> startIndex, IObservable<System.Int32> length)
{
    return Observable.Zip(StringBuilderValue, startIndex, length, (StringBuilderValueLambda, startIndexLambda, lengthLambda) => StringBuilderValueLambda.Remove(startIndexLambda, lengthLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Boolean> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.SByte> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Byte> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Char> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int16> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int64> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Single> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Double> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Decimal> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.UInt16> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.UInt32> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.UInt64> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Object> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Char[]> value)
{
    return Observable.Zip(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Append(valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.String> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Boolean> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.SByte> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Byte> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Int16> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Char> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Char[]> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Char[]> value, IObservable<System.Int32> startIndex, IObservable<System.Int32> charCount)
{
    return Observable.Zip(StringBuilderValue, index, value, startIndex, charCount, (StringBuilderValueLambda, indexLambda, valueLambda, startIndexLambda, charCountLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda, startIndexLambda, charCountLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Int32> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Int64> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Single> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Double> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Decimal> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.UInt16> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.UInt32> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.UInt64> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> Insert(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Object> value)
{
    return Observable.Zip(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Insert(indexLambda, valueLambda));
}


public static IObservable<System.Text.StringBuilder> AppendFormat(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.String> format, IObservable<System.Object> arg0)
{
    return Observable.Zip(StringBuilderValue, format, arg0, (StringBuilderValueLambda, formatLambda, arg0Lambda) => StringBuilderValueLambda.AppendFormat(formatLambda, arg0Lambda));
}


public static IObservable<System.Text.StringBuilder> AppendFormat(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1)
{
    return Observable.Zip(StringBuilderValue, format, arg0, arg1, (StringBuilderValueLambda, formatLambda, arg0Lambda, arg1Lambda) => StringBuilderValueLambda.AppendFormat(formatLambda, arg0Lambda, arg1Lambda));
}


public static IObservable<System.Text.StringBuilder> AppendFormat(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2)
{
    return Observable.Zip(StringBuilderValue, format, arg0, arg1, arg2, (StringBuilderValueLambda, formatLambda, arg0Lambda, arg1Lambda, arg2Lambda) => StringBuilderValueLambda.AppendFormat(formatLambda, arg0Lambda, arg1Lambda, arg2Lambda));
}


public static IObservable<System.Text.StringBuilder> AppendFormat(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.String> format, IObservable<System.Object[]> args)
{
    return Observable.Zip(StringBuilderValue, format, args, (StringBuilderValueLambda, formatLambda, argsLambda) => StringBuilderValueLambda.AppendFormat(formatLambda, argsLambda));
}


public static IObservable<System.Text.StringBuilder> AppendFormat(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.IFormatProvider> provider, IObservable<System.String> format, IObservable<System.Object> arg0)
{
    return Observable.Zip(StringBuilderValue, provider, format, arg0, (StringBuilderValueLambda, providerLambda, formatLambda, arg0Lambda) => StringBuilderValueLambda.AppendFormat(providerLambda, formatLambda, arg0Lambda));
}


public static IObservable<System.Text.StringBuilder> AppendFormat(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.IFormatProvider> provider, IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1)
{
    return Observable.Zip(StringBuilderValue, provider, format, arg0, arg1, (StringBuilderValueLambda, providerLambda, formatLambda, arg0Lambda, arg1Lambda) => StringBuilderValueLambda.AppendFormat(providerLambda, formatLambda, arg0Lambda, arg1Lambda));
}


public static IObservable<System.Text.StringBuilder> AppendFormat(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.IFormatProvider> provider, IObservable<System.String> format, IObservable<System.Object> arg0, IObservable<System.Object> arg1, IObservable<System.Object> arg2)
{
    return Observable.Zip(StringBuilderValue, provider, format, arg0, arg1, arg2, (StringBuilderValueLambda, providerLambda, formatLambda, arg0Lambda, arg1Lambda, arg2Lambda) => StringBuilderValueLambda.AppendFormat(providerLambda, formatLambda, arg0Lambda, arg1Lambda, arg2Lambda));
}


public static IObservable<System.Text.StringBuilder> AppendFormat(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.IFormatProvider> provider, IObservable<System.String> format, IObservable<System.Object[]> args)
{
    return Observable.Zip(StringBuilderValue, provider, format, args, (StringBuilderValueLambda, providerLambda, formatLambda, argsLambda) => StringBuilderValueLambda.AppendFormat(providerLambda, formatLambda, argsLambda));
}


public static IObservable<System.Text.StringBuilder> Replace(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.String> oldValue, IObservable<System.String> newValue)
{
    return Observable.Zip(StringBuilderValue, oldValue, newValue, (StringBuilderValueLambda, oldValueLambda, newValueLambda) => StringBuilderValueLambda.Replace(oldValueLambda, newValueLambda));
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Text.StringBuilder> sb)
{
    return Observable.Zip(StringBuilderValue, sb, (StringBuilderValueLambda, sbLambda) => StringBuilderValueLambda.Equals(sbLambda));
}


public static IObservable<System.Text.StringBuilder> Replace(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.String> oldValue, IObservable<System.String> newValue, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(StringBuilderValue, oldValue, newValue, startIndex, count, (StringBuilderValueLambda, oldValueLambda, newValueLambda, startIndexLambda, countLambda) => StringBuilderValueLambda.Replace(oldValueLambda, newValueLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Text.StringBuilder> Replace(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Char> oldChar, IObservable<System.Char> newChar)
{
    return Observable.Zip(StringBuilderValue, oldChar, newChar, (StringBuilderValueLambda, oldCharLambda, newCharLambda) => StringBuilderValueLambda.Replace(oldCharLambda, newCharLambda));
}


public static IObservable<System.Text.StringBuilder> Replace(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Char> oldChar, IObservable<System.Char> newChar, IObservable<System.Int32> startIndex, IObservable<System.Int32> count)
{
    return Observable.Zip(StringBuilderValue, oldChar, newChar, startIndex, count, (StringBuilderValueLambda, oldCharLambda, newCharLambda, startIndexLambda, countLambda) => StringBuilderValueLambda.Replace(oldCharLambda, newCharLambda, startIndexLambda, countLambda));
}


public static IObservable<System.Text.StringBuilder> Append(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Char*> value, IObservable<System.Int32> valueCount)
{
    return Observable.Zip(StringBuilderValue, value, valueCount, (StringBuilderValueLambda, valueLambda, valueCountLambda) => StringBuilderValueLambda.Append(valueLambda, valueCountLambda));
}


public static IObservable<System.Int32> get_Capacity(this IObservable<System.Text.StringBuilder> StringBuilderValue)
{
    return Observable.Select(StringBuilderValue, (StringBuilderValueLambda) => StringBuilderValueLambda.Capacity);
}


public static IObservable<System.Int32> get_MaxCapacity(this IObservable<System.Text.StringBuilder> StringBuilderValue)
{
    return Observable.Select(StringBuilderValue, (StringBuilderValueLambda) => StringBuilderValueLambda.MaxCapacity);
}


public static IObservable<System.Int32> get_Length(this IObservable<System.Text.StringBuilder> StringBuilderValue)
{
    return Observable.Select(StringBuilderValue, (StringBuilderValueLambda) => StringBuilderValueLambda.Length);
}


public static IObservable<System.Char> get_Chars(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index)
{
    return Observable.Zip(StringBuilderValue, index, (StringBuilderValueLambda, indexLambda) => StringBuilderValueLambda.Chars);
}


public static IObservable<System.Reactive.Unit> set_Capacity(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Capacity = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Length(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> value)
{
    return ObservableExt.ZipExecute(StringBuilderValue, value, (StringBuilderValueLambda, valueLambda) => StringBuilderValueLambda.Length = valueLambda);
}


public static IObservable<System.Reactive.Unit> set_Chars(this IObservable<System.Text.StringBuilder> StringBuilderValue, IObservable<System.Int32> index, IObservable<System.Char> value)
{
    return ObservableExt.ZipExecute(StringBuilderValue, index, value, (StringBuilderValueLambda, indexLambda, valueLambda) => StringBuilderValueLambda.Chars = valueLambda);
}

}
}