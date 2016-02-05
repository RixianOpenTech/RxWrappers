using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Net.Http.Headers
{
    public static class __ContentDispositionHeaderValue
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.ToString());
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(ContentDispositionHeaderValueValue, obj, (ContentDispositionHeaderValueValueLambda, objLambda) => ContentDispositionHeaderValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.GetHashCode());
        }


        public static IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> Parse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => System.Net.Http.Headers.ContentDispositionHeaderValue.Parse(inputLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Net.Http.Headers.ContentDispositionHeaderValue>> TryParse(IObservable<System.String> input)
        {
            return Observable.Select(input, (inputLambda) => {
System.Net.Http.Headers.ContentDispositionHeaderValue parsedValueOutput = default(System.Net.Http.Headers.ContentDispositionHeaderValue);
var result = System.Net.Http.Headers.ContentDispositionHeaderValue.TryParse(inputLambda, out parsedValueOutput);
return Tuple.Create(result, parsedValueOutput);
});
        }


        public static IObservable<System.String> get_DispositionType(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.DispositionType);
        }


        public static IObservable<System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue>> get_Parameters(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.Parameters);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.Name);
        }


        public static IObservable<System.String> get_FileName(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.FileName);
        }


        public static IObservable<System.String> get_FileNameStar(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.FileNameStar);
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_CreationDate(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.CreationDate);
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_ModificationDate(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.ModificationDate);
        }


        public static IObservable<System.Nullable<System.DateTimeOffset>> get_ReadDate(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.ReadDate);
        }


        public static IObservable<System.Nullable<System.Int64>> get_Size(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue)
        {
            return Observable.Select(ContentDispositionHeaderValueValue, (ContentDispositionHeaderValueValueLambda) => ContentDispositionHeaderValueValueLambda.Size);
        }


        public static IObservable<System.Reactive.Unit> set_DispositionType(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ContentDispositionHeaderValueValue, value, (ContentDispositionHeaderValueValueLambda, valueLambda) => ContentDispositionHeaderValueValueLambda.DispositionType = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Name(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ContentDispositionHeaderValueValue, value, (ContentDispositionHeaderValueValueLambda, valueLambda) => ContentDispositionHeaderValueValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FileName(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ContentDispositionHeaderValueValue, value, (ContentDispositionHeaderValueValueLambda, valueLambda) => ContentDispositionHeaderValueValueLambda.FileName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FileNameStar(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ContentDispositionHeaderValueValue, value, (ContentDispositionHeaderValueValueLambda, valueLambda) => ContentDispositionHeaderValueValueLambda.FileNameStar = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CreationDate(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue, IObservable<System.Nullable<System.DateTimeOffset>> value)
        {
            return ObservableExt.ZipExecute(ContentDispositionHeaderValueValue, value, (ContentDispositionHeaderValueValueLambda, valueLambda) => ContentDispositionHeaderValueValueLambda.CreationDate = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ModificationDate(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue, IObservable<System.Nullable<System.DateTimeOffset>> value)
        {
            return ObservableExt.ZipExecute(ContentDispositionHeaderValueValue, value, (ContentDispositionHeaderValueValueLambda, valueLambda) => ContentDispositionHeaderValueValueLambda.ModificationDate = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReadDate(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue, IObservable<System.Nullable<System.DateTimeOffset>> value)
        {
            return ObservableExt.ZipExecute(ContentDispositionHeaderValueValue, value, (ContentDispositionHeaderValueValueLambda, valueLambda) => ContentDispositionHeaderValueValueLambda.ReadDate = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Size(this IObservable<System.Net.Http.Headers.ContentDispositionHeaderValue> ContentDispositionHeaderValueValue, IObservable<System.Nullable<System.Int64>> value)
        {
            return ObservableExt.ZipExecute(ContentDispositionHeaderValueValue, value, (ContentDispositionHeaderValueValueLambda, valueLambda) => ContentDispositionHeaderValueValueLambda.Size = valueLambda);
        }

    }
}