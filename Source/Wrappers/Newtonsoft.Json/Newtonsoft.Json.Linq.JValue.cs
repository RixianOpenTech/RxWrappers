using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JValue
    {
        
        public static IObservable<Newtonsoft.Json.Linq.JValue> CreateComment(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.Linq.JValue.CreateComment(valueLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JValue> CreateString(IObservable<System.String> value)
        {
            return Observable.Select(value, (valueLambda) => Newtonsoft.Json.Linq.JValue.CreateString(valueLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JValue> CreateNull()
        {
            return ObservableExt.Factory(() => Newtonsoft.Json.Linq.JValue.CreateNull());
        }


        public static IObservable<Newtonsoft.Json.Linq.JValue> CreateUndefined()
        {
            return ObservableExt.Factory(() => Newtonsoft.Json.Linq.JValue.CreateUndefined());
        }


        public static IObservable<System.Reactive.Unit> WriteTo(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return ObservableExt.ZipExecute(JValueValue, writer, converters, (JValueValueLambda, writerLambda, convertersLambda) => JValueValueLambda.WriteTo(writerLambda, convertersLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue, IObservable<Newtonsoft.Json.Linq.JValue> other)
        {
            return Observable.Zip(JValueValue, other, (JValueValueLambda, otherLambda) => JValueValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(JValueValue, obj, (JValueValueLambda, objLambda) => JValueValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue)
        {
            return Observable.Select(JValueValue, (JValueValueLambda) => JValueValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue)
        {
            return Observable.Select(JValueValue, (JValueValueLambda) => JValueValueLambda.ToString());
        }


        public static IObservable<System.String> ToString(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue, IObservable<System.String> format)
        {
            return Observable.Zip(JValueValue, format, (JValueValueLambda, formatLambda) => JValueValueLambda.ToString(formatLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue, IObservable<System.IFormatProvider> formatProvider)
        {
            return Observable.Zip(JValueValue, formatProvider, (JValueValueLambda, formatProviderLambda) => JValueValueLambda.ToString(formatProviderLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue, IObservable<System.String> format, IObservable<System.IFormatProvider> formatProvider)
        {
            return Observable.Zip(JValueValue, format, formatProvider, (JValueValueLambda, formatLambda, formatProviderLambda) => JValueValueLambda.ToString(formatLambda, formatProviderLambda));
        }


        public static IObservable<System.Int32> CompareTo(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue, IObservable<Newtonsoft.Json.Linq.JValue> obj)
        {
            return Observable.Zip(JValueValue, obj, (JValueValueLambda, objLambda) => JValueValueLambda.CompareTo(objLambda));
        }


        public static IObservable<System.Boolean> get_HasValues(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue)
        {
            return Observable.Select(JValueValue, (JValueValueLambda) => JValueValueLambda.HasValues);
        }


        public static IObservable<Newtonsoft.Json.Linq.JTokenType> get_Type(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue)
        {
            return Observable.Select(JValueValue, (JValueValueLambda) => JValueValueLambda.Type);
        }


        public static IObservable<System.Object> get_Value(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue)
        {
            return Observable.Select(JValueValue, (JValueValueLambda) => JValueValueLambda.Value);
        }


        public static IObservable<System.Reactive.Unit> set_Value(this IObservable<Newtonsoft.Json.Linq.JValue> JValueValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(JValueValue, value, (JValueValueLambda, valueLambda) => JValueValueLambda.Value = valueLambda);
        }

    }
}