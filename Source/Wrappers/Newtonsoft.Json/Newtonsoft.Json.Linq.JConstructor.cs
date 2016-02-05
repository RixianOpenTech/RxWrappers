using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JConstructor
    {
        
        public static IObservable<System.Reactive.Unit> WriteTo(this IObservable<Newtonsoft.Json.Linq.JConstructor> JConstructorValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<Newtonsoft.Json.JsonConverter[]> converters)
        {
            return ObservableExt.ZipExecute(JConstructorValue, writer, converters, (JConstructorValueLambda, writerLambda, convertersLambda) => JConstructorValueLambda.WriteTo(writerLambda, convertersLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JConstructor> Load(IObservable<Newtonsoft.Json.JsonReader> reader)
        {
            return Observable.Select(reader, (readerLambda) => Newtonsoft.Json.Linq.JConstructor.Load(readerLambda));
        }


        public static IObservable<Newtonsoft.Json.Linq.JConstructor> Load(IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<Newtonsoft.Json.Linq.JsonLoadSettings> settings)
        {
            return Observable.Zip(reader, settings, (readerLambda, settingsLambda) => Newtonsoft.Json.Linq.JConstructor.Load(readerLambda, settingsLambda));
        }


        public static IObservable<System.String> get_Name(this IObservable<Newtonsoft.Json.Linq.JConstructor> JConstructorValue)
        {
            return Observable.Select(JConstructorValue, (JConstructorValueLambda) => JConstructorValueLambda.Name);
        }


        public static IObservable<Newtonsoft.Json.Linq.JTokenType> get_Type(this IObservable<Newtonsoft.Json.Linq.JConstructor> JConstructorValue)
        {
            return Observable.Select(JConstructorValue, (JConstructorValueLambda) => JConstructorValueLambda.Type);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Item(this IObservable<Newtonsoft.Json.Linq.JConstructor> JConstructorValue, IObservable<System.Object> key)
        {
            return Observable.Zip(JConstructorValue, key, (JConstructorValueLambda, keyLambda) => JConstructorValueLambda[keyLambda]);
        }


        public static IObservable<System.Reactive.Unit> set_Name(this IObservable<Newtonsoft.Json.Linq.JConstructor> JConstructorValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JConstructorValue, value, (JConstructorValueLambda, valueLambda) => JConstructorValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Item(this IObservable<Newtonsoft.Json.Linq.JConstructor> JConstructorValue, IObservable<System.Object> key, IObservable<Newtonsoft.Json.Linq.JToken> value)
        {
            return ObservableExt.ZipExecute(JConstructorValue, key, value, (JConstructorValueLambda, keyLambda, valueLambda) => JConstructorValueLambda[keyLambda] = valueLambda);
        }

    }
}