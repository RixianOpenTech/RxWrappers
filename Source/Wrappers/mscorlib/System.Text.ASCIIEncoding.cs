using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
public static class _ASCIIEncoding
{
    
public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.String> chars, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount, IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex)
{
    return Observable.Zip(ASCIIEncodingValue, chars, charIndex, charCount, bytes, byteIndex, (ASCIIEncodingValueLambda, charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda) => ASCIIEncodingValueLambda.GetBytes(charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda));
}


public static IObservable<System.String> GetString(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount)
{
    return Observable.Zip(ASCIIEncodingValue, bytes, byteIndex, byteCount, (ASCIIEncodingValueLambda, bytesLambda, byteIndexLambda, byteCountLambda) => ASCIIEncodingValueLambda.GetString(bytesLambda, byteIndexLambda, byteCountLambda));
}


public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Char[]> chars, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(ASCIIEncodingValue, chars, index, count, (ASCIIEncodingValueLambda, charsLambda, indexLambda, countLambda) => ASCIIEncodingValueLambda.GetByteCount(charsLambda, indexLambda, countLambda));
}


public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.String> chars)
{
    return Observable.Zip(ASCIIEncodingValue, chars, (ASCIIEncodingValueLambda, charsLambda) => ASCIIEncodingValueLambda.GetByteCount(charsLambda));
}


public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Char*> chars, IObservable<System.Int32> count)
{
    return Observable.Zip(ASCIIEncodingValue, chars, count, (ASCIIEncodingValueLambda, charsLambda, countLambda) => ASCIIEncodingValueLambda.GetByteCount(charsLambda, countLambda));
}


public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount, IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex)
{
    return Observable.Zip(ASCIIEncodingValue, chars, charIndex, charCount, bytes, byteIndex, (ASCIIEncodingValueLambda, charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda) => ASCIIEncodingValueLambda.GetBytes(charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda));
}


public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Char*> chars, IObservable<System.Int32> charCount, IObservable<System.Byte*> bytes, IObservable<System.Int32> byteCount)
{
    return Observable.Zip(ASCIIEncodingValue, chars, charCount, bytes, byteCount, (ASCIIEncodingValueLambda, charsLambda, charCountLambda, bytesLambda, byteCountLambda) => ASCIIEncodingValueLambda.GetBytes(charsLambda, charCountLambda, bytesLambda, byteCountLambda));
}


public static IObservable<System.Int32> GetCharCount(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Byte[]> bytes, IObservable<System.Int32> index, IObservable<System.Int32> count)
{
    return Observable.Zip(ASCIIEncodingValue, bytes, index, count, (ASCIIEncodingValueLambda, bytesLambda, indexLambda, countLambda) => ASCIIEncodingValueLambda.GetCharCount(bytesLambda, indexLambda, countLambda));
}


public static IObservable<System.Int32> GetCharCount(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Byte*> bytes, IObservable<System.Int32> count)
{
    return Observable.Zip(ASCIIEncodingValue, bytes, count, (ASCIIEncodingValueLambda, bytesLambda, countLambda) => ASCIIEncodingValueLambda.GetCharCount(bytesLambda, countLambda));
}


public static IObservable<System.Int32> GetChars(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount, IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex)
{
    return Observable.Zip(ASCIIEncodingValue, bytes, byteIndex, byteCount, chars, charIndex, (ASCIIEncodingValueLambda, bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda) => ASCIIEncodingValueLambda.GetChars(bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda));
}


public static IObservable<System.Int32> GetChars(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Byte*> bytes, IObservable<System.Int32> byteCount, IObservable<System.Char*> chars, IObservable<System.Int32> charCount)
{
    return Observable.Zip(ASCIIEncodingValue, bytes, byteCount, chars, charCount, (ASCIIEncodingValueLambda, bytesLambda, byteCountLambda, charsLambda, charCountLambda) => ASCIIEncodingValueLambda.GetChars(bytesLambda, byteCountLambda, charsLambda, charCountLambda));
}


public static IObservable<System.Int32> GetMaxByteCount(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Int32> charCount)
{
    return Observable.Zip(ASCIIEncodingValue, charCount, (ASCIIEncodingValueLambda, charCountLambda) => ASCIIEncodingValueLambda.GetMaxByteCount(charCountLambda));
}


public static IObservable<System.Int32> GetMaxCharCount(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue, IObservable<System.Int32> byteCount)
{
    return Observable.Zip(ASCIIEncodingValue, byteCount, (ASCIIEncodingValueLambda, byteCountLambda) => ASCIIEncodingValueLambda.GetMaxCharCount(byteCountLambda));
}


public static IObservable<System.Text.Decoder> GetDecoder(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue)
{
    return Observable.Select(ASCIIEncodingValue, (ASCIIEncodingValueLambda) => ASCIIEncodingValueLambda.GetDecoder());
}


public static IObservable<System.Text.Encoder> GetEncoder(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue)
{
    return Observable.Select(ASCIIEncodingValue, (ASCIIEncodingValueLambda) => ASCIIEncodingValueLambda.GetEncoder());
}


public static IObservable<System.Boolean> get_IsSingleByte(this IObservable<System.Text.ASCIIEncoding> ASCIIEncodingValue)
{
    return Observable.Select(ASCIIEncodingValue, (ASCIIEncodingValueLambda) => ASCIIEncodingValueLambda.IsSingleByte);
}

}
}