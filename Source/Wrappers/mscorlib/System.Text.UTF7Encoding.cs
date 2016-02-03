using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __UTF7Encoding
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue, IObservable<System.Object> value)
        {
            return Observable.Zip(UTF7EncodingValue, value, (UTF7EncodingValueLambda, valueLambda) => UTF7EncodingValueLambda.Equals(valueLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue)
        {
            return Observable.Select(UTF7EncodingValue, (UTF7EncodingValueLambda) => UTF7EncodingValueLambda.GetHashCode());
        }


        public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue, IObservable<System.Char[]> chars, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(UTF7EncodingValue, chars, index, count, (UTF7EncodingValueLambda, charsLambda, indexLambda, countLambda) => UTF7EncodingValueLambda.GetByteCount(charsLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue, IObservable<System.String> s)
        {
            return Observable.Zip(UTF7EncodingValue, s, (UTF7EncodingValueLambda, sLambda) => UTF7EncodingValueLambda.GetByteCount(sLambda));
        }


        public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue, IObservable<System.String> s, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount, IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex)
        {
            return Observable.Zip(UTF7EncodingValue, s, charIndex, charCount, bytes, byteIndex, (UTF7EncodingValueLambda, sLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda) => UTF7EncodingValueLambda.GetBytes(sLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda));
        }


        public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue, IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount, IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex)
        {
            return Observable.Zip(UTF7EncodingValue, chars, charIndex, charCount, bytes, byteIndex, (UTF7EncodingValueLambda, charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda) => UTF7EncodingValueLambda.GetBytes(charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda));
        }


        public static IObservable<System.Int32> GetCharCount(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue, IObservable<System.Byte[]> bytes, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(UTF7EncodingValue, bytes, index, count, (UTF7EncodingValueLambda, bytesLambda, indexLambda, countLambda) => UTF7EncodingValueLambda.GetCharCount(bytesLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Int32> GetChars(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue, IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount, IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex)
        {
            return Observable.Zip(UTF7EncodingValue, bytes, byteIndex, byteCount, chars, charIndex, (UTF7EncodingValueLambda, bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda) => UTF7EncodingValueLambda.GetChars(bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda));
        }


        public static IObservable<System.String> GetString(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue, IObservable<System.Byte[]> bytes, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(UTF7EncodingValue, bytes, index, count, (UTF7EncodingValueLambda, bytesLambda, indexLambda, countLambda) => UTF7EncodingValueLambda.GetString(bytesLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Text.Decoder> GetDecoder(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue)
        {
            return Observable.Select(UTF7EncodingValue, (UTF7EncodingValueLambda) => UTF7EncodingValueLambda.GetDecoder());
        }


        public static IObservable<System.Text.Encoder> GetEncoder(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue)
        {
            return Observable.Select(UTF7EncodingValue, (UTF7EncodingValueLambda) => UTF7EncodingValueLambda.GetEncoder());
        }


        public static IObservable<System.Int32> GetMaxByteCount(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue, IObservable<System.Int32> charCount)
        {
            return Observable.Zip(UTF7EncodingValue, charCount, (UTF7EncodingValueLambda, charCountLambda) => UTF7EncodingValueLambda.GetMaxByteCount(charCountLambda));
        }


        public static IObservable<System.Int32> GetMaxCharCount(this IObservable<System.Text.UTF7Encoding> UTF7EncodingValue, IObservable<System.Int32> byteCount)
        {
            return Observable.Zip(UTF7EncodingValue, byteCount, (UTF7EncodingValueLambda, byteCountLambda) => UTF7EncodingValueLambda.GetMaxCharCount(byteCountLambda));
        }

    }
}