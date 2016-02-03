using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Text
{
    public static class __Encoding
    {
        public static IObservable<System.Byte[]> Convert(IObservable<System.Text.Encoding> srcEncoding,
            IObservable<System.Text.Encoding> dstEncoding, IObservable<System.Byte[]> bytes)
        {
            return Observable.Zip(srcEncoding, dstEncoding, bytes,
                (srcEncodingLambda, dstEncodingLambda, bytesLambda) =>
                    System.Text.Encoding.Convert(srcEncodingLambda, dstEncodingLambda, bytesLambda));
        }


        public static IObservable<System.Byte[]> Convert(IObservable<System.Text.Encoding> srcEncoding,
            IObservable<System.Text.Encoding> dstEncoding, IObservable<System.Byte[]> bytes,
            IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(srcEncoding, dstEncoding, bytes, index, count,
                (srcEncodingLambda, dstEncodingLambda, bytesLambda, indexLambda, countLambda) =>
                    System.Text.Encoding.Convert(srcEncodingLambda, dstEncodingLambda, bytesLambda, indexLambda,
                        countLambda));
        }


        public static IObservable<System.Reactive.Unit> RegisterProvider(
            IObservable<System.Text.EncodingProvider> provider)
        {
            return
                Observable.Do(provider, (providerLambda) => System.Text.Encoding.RegisterProvider(providerLambda))
                    .ToUnit();
        }


        public static IObservable<System.Text.Encoding> GetEncoding(IObservable<System.Int32> codepage)
        {
            return Observable.Select(codepage, (codepageLambda) => System.Text.Encoding.GetEncoding(codepageLambda));
        }


        public static IObservable<System.Text.Encoding> GetEncoding(IObservable<System.Int32> codepage,
            IObservable<System.Text.EncoderFallback> encoderFallback,
            IObservable<System.Text.DecoderFallback> decoderFallback)
        {
            return Observable.Zip(codepage, encoderFallback, decoderFallback,
                (codepageLambda, encoderFallbackLambda, decoderFallbackLambda) =>
                    System.Text.Encoding.GetEncoding(codepageLambda, encoderFallbackLambda, decoderFallbackLambda));
        }


        public static IObservable<System.Text.Encoding> GetEncoding(IObservable<System.String> name)
        {
            return Observable.Select(name, (nameLambda) => System.Text.Encoding.GetEncoding(nameLambda));
        }


        public static IObservable<System.Text.Encoding> GetEncoding(IObservable<System.String> name,
            IObservable<System.Text.EncoderFallback> encoderFallback,
            IObservable<System.Text.DecoderFallback> decoderFallback)
        {
            return Observable.Zip(name, encoderFallback, decoderFallback,
                (nameLambda, encoderFallbackLambda, decoderFallbackLambda) =>
                    System.Text.Encoding.GetEncoding(nameLambda, encoderFallbackLambda, decoderFallbackLambda));
        }


        public static IObservable<System.Text.EncodingInfo[]> GetEncodings()
        {
            return ObservableExt.Factory(() => System.Text.Encoding.GetEncodings());
        }


        public static IObservable<System.Byte[]> GetPreamble(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.GetPreamble());
        }


        public static IObservable<System.Object> Clone(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.Clone());
        }


        public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Char[]> chars)
        {
            return Observable.Zip(EncodingValue, chars,
                (EncodingValueLambda, charsLambda) => EncodingValueLambda.GetByteCount(charsLambda));
        }


        public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.String> s)
        {
            return Observable.Zip(EncodingValue, s,
                (EncodingValueLambda, sLambda) => EncodingValueLambda.GetByteCount(sLambda));
        }


        public static IObservable<System.Int32> GetByteCount(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Char[]> chars, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(EncodingValue, chars, index, count,
                (EncodingValueLambda, charsLambda, indexLambda, countLambda) =>
                    EncodingValueLambda.GetByteCount(charsLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Char[]> chars)
        {
            return Observable.Zip(EncodingValue, chars,
                (EncodingValueLambda, charsLambda) => EncodingValueLambda.GetBytes(charsLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Char[]> chars, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(EncodingValue, chars, index, count,
                (EncodingValueLambda, charsLambda, indexLambda, countLambda) =>
                    EncodingValueLambda.GetBytes(charsLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex)
        {
            return Observable.Zip(EncodingValue, chars, charIndex, charCount, bytes, byteIndex,
                (EncodingValueLambda, charsLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda) =>
                    EncodingValueLambda.GetBytes(charsLambda, charIndexLambda, charCountLambda, bytesLambda,
                        byteIndexLambda));
        }


        public static IObservable<System.Byte[]> GetBytes(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.String> s)
        {
            return Observable.Zip(EncodingValue, s,
                (EncodingValueLambda, sLambda) => EncodingValueLambda.GetBytes(sLambda));
        }


        public static IObservable<System.Int32> GetBytes(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.String> s, IObservable<System.Int32> charIndex, IObservable<System.Int32> charCount,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex)
        {
            return Observable.Zip(EncodingValue, s, charIndex, charCount, bytes, byteIndex,
                (EncodingValueLambda, sLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda) =>
                    EncodingValueLambda.GetBytes(sLambda, charIndexLambda, charCountLambda, bytesLambda, byteIndexLambda));
        }


        public static IObservable<System.Int32> GetCharCount(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Byte[]> bytes)
        {
            return Observable.Zip(EncodingValue, bytes,
                (EncodingValueLambda, bytesLambda) => EncodingValueLambda.GetCharCount(bytesLambda));
        }


        public static IObservable<System.Int32> GetCharCount(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(EncodingValue, bytes, index, count,
                (EncodingValueLambda, bytesLambda, indexLambda, countLambda) =>
                    EncodingValueLambda.GetCharCount(bytesLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Char[]> GetChars(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Byte[]> bytes)
        {
            return Observable.Zip(EncodingValue, bytes,
                (EncodingValueLambda, bytesLambda) => EncodingValueLambda.GetChars(bytesLambda));
        }


        public static IObservable<System.Char[]> GetChars(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(EncodingValue, bytes, index, count,
                (EncodingValueLambda, bytesLambda, indexLambda, countLambda) =>
                    EncodingValueLambda.GetChars(bytesLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Int32> GetChars(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> byteIndex, IObservable<System.Int32> byteCount,
            IObservable<System.Char[]> chars, IObservable<System.Int32> charIndex)
        {
            return Observable.Zip(EncodingValue, bytes, byteIndex, byteCount, chars, charIndex,
                (EncodingValueLambda, bytesLambda, byteIndexLambda, byteCountLambda, charsLambda, charIndexLambda) =>
                    EncodingValueLambda.GetChars(bytesLambda, byteIndexLambda, byteCountLambda, charsLambda,
                        charIndexLambda));
        }


        public static IObservable<System.Boolean> IsAlwaysNormalized(
            this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.IsAlwaysNormalized());
        }


        public static IObservable<System.Boolean> IsAlwaysNormalized(
            this IObservable<System.Text.Encoding> EncodingValue, IObservable<System.Text.NormalizationForm> form)
        {
            return Observable.Zip(EncodingValue, form,
                (EncodingValueLambda, formLambda) => EncodingValueLambda.IsAlwaysNormalized(formLambda));
        }


        public static IObservable<System.Text.Decoder> GetDecoder(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.GetDecoder());
        }


        public static IObservable<System.Text.Encoder> GetEncoder(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.GetEncoder());
        }


        public static IObservable<System.Int32> GetMaxByteCount(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Int32> charCount)
        {
            return Observable.Zip(EncodingValue, charCount,
                (EncodingValueLambda, charCountLambda) => EncodingValueLambda.GetMaxByteCount(charCountLambda));
        }


        public static IObservable<System.Int32> GetMaxCharCount(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Int32> byteCount)
        {
            return Observable.Zip(EncodingValue, byteCount,
                (EncodingValueLambda, byteCountLambda) => EncodingValueLambda.GetMaxCharCount(byteCountLambda));
        }


        public static IObservable<System.String> GetString(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Byte[]> bytes)
        {
            return Observable.Zip(EncodingValue, bytes,
                (EncodingValueLambda, bytesLambda) => EncodingValueLambda.GetString(bytesLambda));
        }


        public static IObservable<System.String> GetString(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Byte[]> bytes, IObservable<System.Int32> index, IObservable<System.Int32> count)
        {
            return Observable.Zip(EncodingValue, bytes, index, count,
                (EncodingValueLambda, bytesLambda, indexLambda, countLambda) =>
                    EncodingValueLambda.GetString(bytesLambda, indexLambda, countLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Text.Encoding> EncodingValue,
            IObservable<System.Object> value)
        {
            return Observable.Zip(EncodingValue, value,
                (EncodingValueLambda, valueLambda) => EncodingValueLambda.Equals(valueLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.GetHashCode());
        }


        public static IObservable<System.String> get_BodyName(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.BodyName);
        }


        public static IObservable<System.String> get_EncodingName(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.EncodingName);
        }


        public static IObservable<System.String> get_HeaderName(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.HeaderName);
        }


        public static IObservable<System.String> get_WebName(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.WebName);
        }


        public static IObservable<System.Int32> get_WindowsCodePage(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.WindowsCodePage);
        }


        public static IObservable<System.Boolean> get_IsBrowserDisplay(
            this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.IsBrowserDisplay);
        }


        public static IObservable<System.Boolean> get_IsBrowserSave(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.IsBrowserSave);
        }


        public static IObservable<System.Boolean> get_IsMailNewsDisplay(
            this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.IsMailNewsDisplay);
        }


        public static IObservable<System.Boolean> get_IsMailNewsSave(
            this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.IsMailNewsSave);
        }


        public static IObservable<System.Boolean> get_IsSingleByte(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.IsSingleByte);
        }


        public static IObservable<System.Text.EncoderFallback> get_EncoderFallback(
            this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.EncoderFallback);
        }


        public static IObservable<System.Text.DecoderFallback> get_DecoderFallback(
            this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.DecoderFallback);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.IsReadOnly);
        }


        public static IObservable<System.Text.Encoding> get_ASCII()
        {
            return ObservableExt.Factory(() => System.Text.Encoding.ASCII);
        }


        public static IObservable<System.Int32> get_CodePage(this IObservable<System.Text.Encoding> EncodingValue)
        {
            return Observable.Select(EncodingValue, (EncodingValueLambda) => EncodingValueLambda.CodePage);
        }


        public static IObservable<System.Text.Encoding> get_Default()
        {
            return ObservableExt.Factory(() => System.Text.Encoding.Default);
        }


        public static IObservable<System.Text.Encoding> get_Unicode()
        {
            return ObservableExt.Factory(() => System.Text.Encoding.Unicode);
        }


        public static IObservable<System.Text.Encoding> get_BigEndianUnicode()
        {
            return ObservableExt.Factory(() => System.Text.Encoding.BigEndianUnicode);
        }


        public static IObservable<System.Text.Encoding> get_UTF7()
        {
            return ObservableExt.Factory(() => System.Text.Encoding.UTF7);
        }


        public static IObservable<System.Text.Encoding> get_UTF8()
        {
            return ObservableExt.Factory(() => System.Text.Encoding.UTF8);
        }


        public static IObservable<System.Text.Encoding> get_UTF32()
        {
            return ObservableExt.Factory(() => System.Text.Encoding.UTF32);
        }


        public static IObservable<System.Reactive.Unit> set_EncoderFallback(
            this IObservable<System.Text.Encoding> EncodingValue, IObservable<System.Text.EncoderFallback> value)
        {
            return ObservableExt.ZipExecute(EncodingValue, value,
                (EncodingValueLambda, valueLambda) => EncodingValueLambda.EncoderFallback = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DecoderFallback(
            this IObservable<System.Text.Encoding> EncodingValue, IObservable<System.Text.DecoderFallback> value)
        {
            return ObservableExt.ZipExecute(EncodingValue, value,
                (EncodingValueLambda, valueLambda) => EncodingValueLambda.DecoderFallback = valueLambda);
        }
    }
}