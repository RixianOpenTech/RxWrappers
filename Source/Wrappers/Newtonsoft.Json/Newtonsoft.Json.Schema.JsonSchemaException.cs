using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Schema
{
    public static class __JsonSchemaException
    {
        
        public static IObservable<System.Int32> get_LineNumber(this IObservable<Newtonsoft.Json.Schema.JsonSchemaException> JsonSchemaExceptionValue)
        {
            return Observable.Select(JsonSchemaExceptionValue, (JsonSchemaExceptionValueLambda) => JsonSchemaExceptionValueLambda.LineNumber);
        }


        public static IObservable<System.Int32> get_LinePosition(this IObservable<Newtonsoft.Json.Schema.JsonSchemaException> JsonSchemaExceptionValue)
        {
            return Observable.Select(JsonSchemaExceptionValue, (JsonSchemaExceptionValueLambda) => JsonSchemaExceptionValueLambda.LinePosition);
        }


        public static IObservable<System.String> get_Path(this IObservable<Newtonsoft.Json.Schema.JsonSchemaException> JsonSchemaExceptionValue)
        {
            return Observable.Select(JsonSchemaExceptionValue, (JsonSchemaExceptionValueLambda) => JsonSchemaExceptionValueLambda.Path);
        }

    }
}