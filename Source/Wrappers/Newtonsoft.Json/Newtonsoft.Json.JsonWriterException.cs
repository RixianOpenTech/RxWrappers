using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonWriterException
    {
        
        public static IObservable<System.String> get_Path(this IObservable<Newtonsoft.Json.JsonWriterException> JsonWriterExceptionValue)
        {
            return Observable.Select(JsonWriterExceptionValue, (JsonWriterExceptionValueLambda) => JsonWriterExceptionValueLambda.Path);
        }

    }
}