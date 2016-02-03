using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
public static class _UTF8Encoding
{
    
public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Char[]> chars, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(UTF8EncodingValue, chars, index, count, (UTF8EncodingValueLambda, charsLambda, indexLambda, countLambda) => UTF8EncodingValueLambda.GetByteCount(charsLambda, indexLambda, countLambda));
}


public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.String> chars)
{
    return Observable.Zip(UTF8EncodingValue, chars, (UTF8EncodingValueLambda, charsLambda) => UTF8EncodingValueLambda.GetByteCount(charsLambda));
}


public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Char*> chars, IObservable<System.Int32> count)
{
    return Observable.Zip(UTF8EncodingValue, chars, count, (UTF8EncodingValueLambda, charsLambda, countLambda) => UTF8EncodingValueLambda.GetByteCount(charsLambda, countLambda));
}


public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.String> s, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount, IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex)
{
    return Observable.Zip(UTF8EncodingValue, s, charIndex, charCount, bytes, byteIndex, (UTF8EncodingValueLambda, sLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda) => UTF8EncodingValueLambda.GetBytes(sLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda));
}


public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount, IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex)
{
    return Observable.Zip(UTF8EncodingValue, chars, charIndex, charCount, bytes, byteIndex, (UTF8EncodingValueLambda, charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda) => UTF8EncodingValueLambda.GetBytes(charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda));
}


public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Char*> chars, IObservable<System.Int32> charCount, IObservable<System.Byte*> bytes, IObservable<System.Int32> byteCount)
{
    return Observable.Zip(UTF8EncodingValue, chars, charCount, bytes, byteCount, (UTF8EncodingValueLambda, charsLambda, charCountLambda, bytesLambda, byteCountLambda) => UTF8EncodingValueLambda.GetBytes(charsLambda, charCountLambda, bytesLambda, byteCountLambda));
}


public static IObservable<System.Int32> GetCharCount(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Byte[]> bytes, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(UTF8EncodingValue, bytes, index, count, (UTF8EncodingValueLambda, bytesLambda, indexLambda, countLambda) => UTF8EncodingValueLambda.GetCharCount(bytesLambda, indexLambda, countLambda));
}


public static IObservable<System.Int32> GetCharCount(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Byte*> bytes, IObservable<System.Int32> count)
{
    return Observable.Zip(UTF8EncodingValue, bytes, count, (UTF8EncodingValueLambda, bytesLambda, countLambda) => UTF8EncodingValueLambda.GetCharCount(bytesLambda, countLambda));
}


public static IObservable<System.Int32> GetChars(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount, IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex)
{
    return Observable.Zip(UTF8EncodingValue, bytes, byteIndex, byteCount, chars, charIndex, (UTF8EncodingValueLambda, bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda) => UTF8EncodingValueLambda.GetChars(bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda));
}


public static IObservable<System.Int32> GetChars(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Byte*> bytes, IObservable<System.Int32> byteCount, IObservable<System.Char*> chars, IObservable<System.Int32> charCount)
{
    return Observable.Zip(UTF8EncodingValue, bytes, byteCount, chars, charCount, (UTF8EncodingValueLambda, bytesLambda, byteCountLambda, charsLambda, charCountLambda) => UTF8EncodingValueLambda.GetChars(bytesLambda, byteCountLambda, charsLambda, charCountLambda));
}


public static IObservable<System.String> GetString(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Byte[]> bytes, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(UTF8EncodingValue, bytes, index, count, (UTF8EncodingValueLambda, bytesLambda, indexLambda, countLambda) => UTF8EncodingValueLambda.GetString(bytesLambda, indexLambda, countLambda));
}


public static IObservable<System.Text.Decoder> GetDecoder(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue)
{
    return Observable.Select(UTF8EncodingValue, (UTF8EncodingValueLambda) => UTF8EncodingValueLambda.GetDecoder());
}


public static IObservable<System.Text.Encoder> GetEncoder(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue)
{
    return Observable.Select(UTF8EncodingValue, (UTF8EncodingValueLambda) => UTF8EncodingValueLambda.GetEncoder());
}


public static IObservable<System.Int32> GetMaxByteCount(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Int32> charCount)
{
    return Observable.Zip(UTF8EncodingValue, charCount, (UTF8EncodingValueLambda, charCountLambda) => UTF8EncodingValueLambda.GetMaxByteCount(charCountLambda));
}


public static IObservable<System.Int32> GetMaxCharCount(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Int32> byteCount)
{
    return Observable.Zip(UTF8EncodingValue, byteCount, (UTF8EncodingValueLambda, byteCountLambda) => UTF8EncodingValueLambda.GetMaxCharCount(byteCountLambda));
}


public static IObservable<System.Byte[]> GetPreamble(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue)
{
    return Observable.Select(UTF8EncodingValue, (UTF8EncodingValueLambda) => UTF8EncodingValueLambda.GetPreamble());
}


public static IObservable<System.Boolean> Equals(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue, IObservable<System.Object> value)
{
    return Observable.Zip(UTF8EncodingValue, value, (UTF8EncodingValueLambda, valueLambda) => UTF8EncodingValueLambda.Equals(valueLambda));
}


public static IObservable<System.Int32> GetHashCode(this IObservable<System.Text.UTF8Encoding> UTF8EncodingValue)
{
    return Observable.Select(UTF8EncodingValue, (UTF8EncodingValueLambda) => UTF8EncodingValueLambda.GetHashCode());
}

}
}