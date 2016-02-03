using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __UTF32Encoding
    {
        public static IObservable<System.Int32> GetByteCount(
            this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue, IObservable<System.Char[]> chars,
            IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(UTF32EncodingValue, chars, index, count,
                (UTF32EncodingValueLambda, charsLambda, indexLambda, countLambda) =>
                    UTF32EncodingValueLambda.GetByteCount(charsLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Int32> GetByteCount(
            this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue, IObservable<System.String> s)
        {
            return Observable.Zip(UTF32EncodingValue, s,
                (UTF32EncodingValueLambda, sLambda) => UTF32EncodingValueLambda.GetByteCount(sLambda));
        }


        public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue,
            IObservable<System.String> s, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex)
        {
            return Observable.Zip(UTF32EncodingValue, s, charIndex, charCount, bytes, byteIndex,
                (UTF32EncodingValueLambda, sLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda) =>
                    UTF32EncodingValueLambda.GetBytes(sLambda, charIndexLambda, charCountLambda, bytesLambda,
                        byteIndexLambda));
        }


        public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue,
            IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex)
        {
            return Observable.Zip(UTF32EncodingValue, chars, charIndex, charCount, bytes, byteIndex,
                (UTF32EncodingValueLambda, charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda)
                    =>
                    UTF32EncodingValueLambda.GetBytes(charsLambda, charIndexLambda, charCountLambda, bytesLambda,
                        byteIndexLambda));
        }


        public static IObservable<System.Int32> GetCharCount(
            this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue, IObservable<System.Byte[]> bytes,
            IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(UTF32EncodingValue, bytes, index, count,
                (UTF32EncodingValueLambda, bytesLambda, indexLambda, countLambda) =>
                    UTF32EncodingValueLambda.GetCharCount(bytesLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Int32> GetChars(this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount,
            IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex)
        {
            return Observable.Zip(UTF32EncodingValue, bytes, byteIndex, byteCount, chars, charIndex,
                (UTF32EncodingValueLambda, bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda)
                    =>
                    UTF32EncodingValueLambda.GetChars(bytesLambda, byteIndexLambda, byteCountLambda, charsLambda,
                        charIndexLambda));
        }


        public static IObservable<System.String> GetString(
            this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue, IObservable<System.Byte[]> bytes,
            IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(UTF32EncodingValue, bytes, index, count,
                (UTF32EncodingValueLambda, bytesLambda, indexLambda, countLambda) =>
                    UTF32EncodingValueLambda.GetString(bytesLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Text.Decoder> GetDecoder(
            this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue)
        {
            return Observable.Select(UTF32EncodingValue,
                (UTF32EncodingValueLambda) => UTF32EncodingValueLambda.GetDecoder());
        }


        public static IObservable<System.Text.Encoder> GetEncoder(
            this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue)
        {
            return Observable.Select(UTF32EncodingValue,
                (UTF32EncodingValueLambda) => UTF32EncodingValueLambda.GetEncoder());
        }


        public static IObservable<System.Int32> GetMaxByteCount(
            this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue, IObservable<System.Int32> charCount)
        {
            return Observable.Zip(UTF32EncodingValue, charCount,
                (UTF32EncodingValueLambda, charCountLambda) => UTF32EncodingValueLambda.GetMaxByteCount(charCountLambda));
        }


        public static IObservable<System.Int32> GetMaxCharCount(
            this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue, IObservable<System.Int32> byteCount)
        {
            return Observable.Zip(UTF32EncodingValue, byteCount,
                (UTF32EncodingValueLambda, byteCountLambda) => UTF32EncodingValueLambda.GetMaxCharCount(byteCountLambda));
        }


        public static IObservable<System.Byte[]> GetPreamble(
            this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue)
        {
            return Observable.Select(UTF32EncodingValue,
                (UTF32EncodingValueLambda) => UTF32EncodingValueLambda.GetPreamble());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue,
            IObservable<System.Object> value)
        {
            return Observable.Zip(UTF32EncodingValue, value,
                (UTF32EncodingValueLambda, valueLambda) => UTF32EncodingValueLambda.Equals(valueLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Text.UTF32Encoding> UTF32EncodingValue)
        {
            return Observable.Select(UTF32EncodingValue,
                (UTF32EncodingValueLambda) => UTF32EncodingValueLambda.GetHashCode());
        }
    }
}