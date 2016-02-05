using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Schema
{
    public static class __JsonSchemaResolver
    {
        
        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> GetSchema(this IObservable<Newtonsoft.Json.Schema.JsonSchemaResolver> JsonSchemaResolverValue, IObservable<System.String> reference)
        {
            return Observable.Zip(JsonSchemaResolverValue, reference, (JsonSchemaResolverValueLambda, referenceLambda) => JsonSchemaResolverValueLambda.GetSchema(referenceLambda));
        }


        public static IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema>> get_LoadedSchemas(this IObservable<Newtonsoft.Json.Schema.JsonSchemaResolver> JsonSchemaResolverValue)
        {
            return Observable.Select(JsonSchemaResolverValue, (JsonSchemaResolverValueLambda) => JsonSchemaResolverValueLambda.LoadedSchemas);
        }

    }
}