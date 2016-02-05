using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Schema
{
    public static class __Extensions
    {
        
        public static IObservable<System.Boolean> IsValid_Static(IObservable<Newtonsoft.Json.Linq.JToken> source, IObservable<Newtonsoft.Json.Schema.JsonSchema> schema)
        {
            return Observable.Zip(source, schema, (sourceLambda, schemaLambda) => Newtonsoft.Json.Schema.Extensions.IsValid(sourceLambda, schemaLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Collections.Generic.IList<System.String>>> IsValid(IObservable<Newtonsoft.Json.Linq.JToken> source, IObservable<Newtonsoft.Json.Schema.JsonSchema> schema)
        {
            return Observable.Zip(source, schema, (sourceLambda, schemaLambda) => {
System.Collections.Generic.IList<System.String> errorMessagesOutput = default(System.Collections.Generic.IList<System.String>);
var result = Newtonsoft.Json.Schema.Extensions.IsValid(sourceLambda, schemaLambda, out errorMessagesOutput);
return Tuple.Create(result, errorMessagesOutput);
});
        }


        public static IObservable<System.Reactive.Unit> Validate(IObservable<Newtonsoft.Json.Linq.JToken> source, IObservable<Newtonsoft.Json.Schema.JsonSchema> schema)
        {
            return ObservableExt.ZipExecute(source, schema, (sourceLambda, schemaLambda) => Newtonsoft.Json.Schema.Extensions.Validate(sourceLambda, schemaLambda));
        }


        public static IObservable<System.Reactive.Unit> Validate(IObservable<Newtonsoft.Json.Linq.JToken> source, IObservable<Newtonsoft.Json.Schema.JsonSchema> schema, IObservable<Newtonsoft.Json.Schema.ValidationEventHandler> validationEventHandler)
        {
            return ObservableExt.ZipExecute(source, schema, validationEventHandler, (sourceLambda, schemaLambda, validationEventHandlerLambda) => Newtonsoft.Json.Schema.Extensions.Validate(sourceLambda, schemaLambda, validationEventHandlerLambda));
        }

    }
}