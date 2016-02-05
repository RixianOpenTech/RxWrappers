using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Linq
{
    public static class __JTokenReader
    {
        
        public static IObservable<System.Boolean> Read(this IObservable<Newtonsoft.Json.Linq.JTokenReader> JTokenReaderValue)
        {
            return Observable.Select(JTokenReaderValue, (JTokenReaderValueLambda) => JTokenReaderValueLambda.Read());
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_CurrentToken(this IObservable<Newtonsoft.Json.Linq.JTokenReader> JTokenReaderValue)
        {
            return Observable.Select(JTokenReaderValue, (JTokenReaderValueLambda) => JTokenReaderValueLambda.CurrentToken);
        }


        public static IObservable<System.String> get_Path(this IObservable<Newtonsoft.Json.Linq.JTokenReader> JTokenReaderValue)
        {
            return Observable.Select(JTokenReaderValue, (JTokenReaderValueLambda) => JTokenReaderValueLambda.Path);
        }

    }
}