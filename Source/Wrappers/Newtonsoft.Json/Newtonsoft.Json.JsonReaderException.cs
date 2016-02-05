using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonReaderException
    {
        
        public static IObservable<System.Int32> get_LineNumber(this IObservable<Newtonsoft.Json.JsonReaderException> JsonReaderExceptionValue)
        {
            return Observable.Select(JsonReaderExceptionValue, (JsonReaderExceptionValueLambda) => JsonReaderExceptionValueLambda.LineNumber);
        }


        public static IObservable<System.Int32> get_LinePosition(this IObservable<Newtonsoft.Json.JsonReaderException> JsonReaderExceptionValue)
        {
            return Observable.Select(JsonReaderExceptionValue, (JsonReaderExceptionValueLambda) => JsonReaderExceptionValueLambda.LinePosition);
        }


        public static IObservable<System.String> get_Path(this IObservable<Newtonsoft.Json.JsonReaderException> JsonReaderExceptionValue)
        {
            return Observable.Select(JsonReaderExceptionValue, (JsonReaderExceptionValueLambda) => JsonReaderExceptionValueLambda.Path);
        }

    }
}