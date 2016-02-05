using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JTokenWriter
    {
        
        public static IObservable<System.Reactive.Unit> Flush(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue)
        {
            return Observable.Do(JTokenWriterValue, (JTokenWriterValueLambda) => JTokenWriterValueLambda.Flush()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Close(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue)
        {
            return Observable.Do(JTokenWriterValue, (JTokenWriterValueLambda) => JTokenWriterValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteStartObject(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue)
        {
            return Observable.Do(JTokenWriterValue, (JTokenWriterValueLambda) => JTokenWriterValueLambda.WriteStartObject()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteStartArray(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue)
        {
            return Observable.Do(JTokenWriterValue, (JTokenWriterValueLambda) => JTokenWriterValueLambda.WriteStartArray()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteStartConstructor(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, name, (JTokenWriterValueLambda, nameLambda) => JTokenWriterValueLambda.WriteStartConstructor(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> WritePropertyName(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, name, (JTokenWriterValueLambda, nameLambda) => JTokenWriterValueLambda.WritePropertyName(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteNull(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue)
        {
            return Observable.Do(JTokenWriterValue, (JTokenWriterValueLambda) => JTokenWriterValueLambda.WriteNull()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteUndefined(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue)
        {
            return Observable.Do(JTokenWriterValue, (JTokenWriterValueLambda) => JTokenWriterValueLambda.WriteUndefined()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> WriteRaw(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.String> json)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, json, (JTokenWriterValueLambda, jsonLambda) => JTokenWriterValueLambda.WriteRaw(jsonLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteComment(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.String> text)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, text, (JTokenWriterValueLambda, textLambda) => JTokenWriterValueLambda.WriteComment(textLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.UInt32> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.UInt64> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Single> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Double> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Int16> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.UInt16> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Char> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.SByte> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.DateTimeOffset> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.TimeSpan> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Guid> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteValue(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue, IObservable<System.Uri> value)
        {
            return ObservableExt.ZipExecute(JTokenWriterValue, value, (JTokenWriterValueLambda, valueLambda) => JTokenWriterValueLambda.WriteValue(valueLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_CurrentToken(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue)
        {
            return Observable.Select(JTokenWriterValue, (JTokenWriterValueLambda) => JTokenWriterValueLambda.CurrentToken);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Token(this IObservable<Newtonsoft.Json.Linq.JTokenWriter> JTokenWriterValue)
        {
            return Observable.Select(JTokenWriterValue, (JTokenWriterValueLambda) => JTokenWriterValueLambda.Token);
        }

    }
}