using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Bson
{
    public static class __BsonReader
    {
        
        public static IObservable<System.Boolean> Read(this IObservable<Newtonsoft.Json.Bson.BsonReader> BsonReaderValue)
        {
            return Observable.Select(BsonReaderValue, (BsonReaderValueLambda) => BsonReaderValueLambda.Read());
        }


        public static IObservable<System.Reactive.Unit> Close(this IObservable<Newtonsoft.Json.Bson.BsonReader> BsonReaderValue)
        {
            return Observable.Do(BsonReaderValue, (BsonReaderValueLambda) => BsonReaderValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Boolean> get_JsonNet35BinaryCompatibility(this IObservable<Newtonsoft.Json.Bson.BsonReader> BsonReaderValue)
        {
            return Observable.Select(BsonReaderValue, (BsonReaderValueLambda) => BsonReaderValueLambda.JsonNet35BinaryCompatibility);
        }


        public static IObservable<System.Boolean> get_ReadRootValueAsArray(this IObservable<Newtonsoft.Json.Bson.BsonReader> BsonReaderValue)
        {
            return Observable.Select(BsonReaderValue, (BsonReaderValueLambda) => BsonReaderValueLambda.ReadRootValueAsArray);
        }


        public static IObservable<System.DateTimeKind> get_DateTimeKindHandling(this IObservable<Newtonsoft.Json.Bson.BsonReader> BsonReaderValue)
        {
            return Observable.Select(BsonReaderValue, (BsonReaderValueLambda) => BsonReaderValueLambda.DateTimeKindHandling);
        }


        public static IObservable<System.Reactive.Unit> set_JsonNet35BinaryCompatibility(this IObservable<Newtonsoft.Json.Bson.BsonReader> BsonReaderValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(BsonReaderValue, value, (BsonReaderValueLambda, valueLambda) => BsonReaderValueLambda.JsonNet35BinaryCompatibility = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReadRootValueAsArray(this IObservable<Newtonsoft.Json.Bson.BsonReader> BsonReaderValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(BsonReaderValue, value, (BsonReaderValueLambda, valueLambda) => BsonReaderValueLambda.ReadRootValueAsArray = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateTimeKindHandling(this IObservable<Newtonsoft.Json.Bson.BsonReader> BsonReaderValue, IObservable<System.DateTimeKind> value)
        {
            return ObservableExt.ZipExecute(BsonReaderValue, value, (BsonReaderValueLambda, valueLambda) => BsonReaderValueLambda.DateTimeKindHandling = valueLambda);
        }

    }
}