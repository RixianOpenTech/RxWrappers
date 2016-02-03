using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __UnicodeEncoding
    {
        public static IObservable<System.Int32> GetByteCount(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue, IObservable<System.Char[]> chars,
            IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(UnicodeEncodingValue, chars, index, count,
                (UnicodeEncodingValueLambda, charsLambda, indexLambda, countLambda) =>
                    UnicodeEncodingValueLambda.GetByteCount(charsLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Int32> GetByteCount(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue, IObservable<System.String> s)
        {
            return Observable.Zip(UnicodeEncodingValue, s,
                (UnicodeEncodingValueLambda, sLambda) => UnicodeEncodingValueLambda.GetByteCount(sLambda));
        }


        public static IObservable<System.Int32> GetBytes(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue, IObservable<System.String> s,
            IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount, IObservable<System.Byte[]> bytes,
            IObservable<System.Int32> byteIndex)
        {
            return Observable.Zip(UnicodeEncodingValue, s, charIndex, charCount, bytes, byteIndex,
                (UnicodeEncodingValueLambda, sLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda) =>
                    UnicodeEncodingValueLambda.GetBytes(sLambda, charIndexLambda, charCountLambda, bytesLambda,
                        byteIndexLambda));
        }


        public static IObservable<System.Int32> GetBytes(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue, IObservable<System.Char[]> chars,
            IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount, IObservable<System.Byte[]> bytes,
            IObservable<System.Int32> byteIndex)
        {
            return Observable.Zip(UnicodeEncodingValue, chars, charIndex, charCount, bytes, byteIndex,
                (UnicodeEncodingValueLambda, charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda)
                    =>
                    UnicodeEncodingValueLambda.GetBytes(charsLambda, charIndexLambda, charCountLambda, bytesLambda,
                        byteIndexLambda));
        }


        public static IObservable<System.Int32> GetCharCount(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue, IObservable<System.Byte[]> bytes,
            IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(UnicodeEncodingValue, bytes, index, count,
                (UnicodeEncodingValueLambda, bytesLambda, indexLambda, countLambda) =>
                    UnicodeEncodingValueLambda.GetCharCount(bytesLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Int32> GetChars(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue, IObservable<System.Byte[]> bytes,
            IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount, IObservable<System.Char[]> chars,
            IObservable<System.Int32> charIndex)
        {
            return Observable.Zip(UnicodeEncodingValue, bytes, byteIndex, byteCount, chars, charIndex,
                (UnicodeEncodingValueLambda, bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda)
                    =>
                    UnicodeEncodingValueLambda.GetChars(bytesLambda, byteIndexLambda, byteCountLambda, charsLambda,
                        charIndexLambda));
        }


        public static IObservable<System.String> GetString(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue, IObservable<System.Byte[]> bytes,
            IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(UnicodeEncodingValue, bytes, index, count,
                (UnicodeEncodingValueLambda, bytesLambda, indexLambda, countLambda) =>
                    UnicodeEncodingValueLambda.GetString(bytesLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Text.Encoder> GetEncoder(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue)
        {
            return Observable.Select(UnicodeEncodingValue,
                (UnicodeEncodingValueLambda) => UnicodeEncodingValueLambda.GetEncoder());
        }


        public static IObservable<System.Text.Decoder> GetDecoder(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue)
        {
            return Observable.Select(UnicodeEncodingValue,
                (UnicodeEncodingValueLambda) => UnicodeEncodingValueLambda.GetDecoder());
        }


        public static IObservable<System.Byte[]> GetPreamble(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue)
        {
            return Observable.Select(UnicodeEncodingValue,
                (UnicodeEncodingValueLambda) => UnicodeEncodingValueLambda.GetPreamble());
        }


        public static IObservable<System.Int32> GetMaxByteCount(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue, IObservable<System.Int32> charCount)
        {
            return Observable.Zip(UnicodeEncodingValue, charCount,
                (UnicodeEncodingValueLambda, charCountLambda) =>
                    UnicodeEncodingValueLambda.GetMaxByteCount(charCountLambda));
        }


        public static IObservable<System.Int32> GetMaxCharCount(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue, IObservable<System.Int32> byteCount)
        {
            return Observable.Zip(UnicodeEncodingValue, byteCount,
                (UnicodeEncodingValueLambda, byteCountLambda) =>
                    UnicodeEncodingValueLambda.GetMaxCharCount(byteCountLambda));
        }


        public static IObservable<System.Boolean> Equals(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue, IObservable<System.Object> value)
        {
            return Observable.Zip(UnicodeEncodingValue, value,
                (UnicodeEncodingValueLambda, valueLambda) => UnicodeEncodingValueLambda.Equals(valueLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.Text.UnicodeEncoding> UnicodeEncodingValue)
        {
            return Observable.Select(UnicodeEncodingValue,
                (UnicodeEncodingValueLambda) => UnicodeEncodingValueLambda.GetHashCode());
        }
    }
}