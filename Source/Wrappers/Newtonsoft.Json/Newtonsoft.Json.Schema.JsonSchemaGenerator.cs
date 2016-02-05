using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Schema
{
    public static class __JsonSchemaGenerator
    {
        
        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> Generate(this IObservable<Newtonsoft.Json.Schema.JsonSchemaGenerator> JsonSchemaGeneratorValue, IObservable<System.Type> type)
        {
            return Observable.Zip(JsonSchemaGeneratorValue, type, (JsonSchemaGeneratorValueLambda, typeLambda) => JsonSchemaGeneratorValueLambda.Generate(typeLambda));
        }


        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> Generate(this IObservable<Newtonsoft.Json.Schema.JsonSchemaGenerator> JsonSchemaGeneratorValue, IObservable<System.Type> type, IObservable<Newtonsoft.Json.Schema.JsonSchemaResolver> resolver)
        {
            return Observable.Zip(JsonSchemaGeneratorValue, type, resolver, (JsonSchemaGeneratorValueLambda, typeLambda, resolverLambda) => JsonSchemaGeneratorValueLambda.Generate(typeLambda, resolverLambda));
        }


        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> Generate(this IObservable<Newtonsoft.Json.Schema.JsonSchemaGenerator> JsonSchemaGeneratorValue, IObservable<System.Type> type, IObservable<System.Boolean> rootSchemaNullable)
        {
            return Observable.Zip(JsonSchemaGeneratorValue, type, rootSchemaNullable, (JsonSchemaGeneratorValueLambda, typeLambda, rootSchemaNullableLambda) => JsonSchemaGeneratorValueLambda.Generate(typeLambda, rootSchemaNullableLambda));
        }


        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> Generate(this IObservable<Newtonsoft.Json.Schema.JsonSchemaGenerator> JsonSchemaGeneratorValue, IObservable<System.Type> type, IObservable<Newtonsoft.Json.Schema.JsonSchemaResolver> resolver, IObservable<System.Boolean> rootSchemaNullable)
        {
            return Observable.Zip(JsonSchemaGeneratorValue, type, resolver, rootSchemaNullable, (JsonSchemaGeneratorValueLambda, typeLambda, resolverLambda, rootSchemaNullableLambda) => JsonSchemaGeneratorValueLambda.Generate(typeLambda, resolverLambda, rootSchemaNullableLambda));
        }


        public static IObservable<Newtonsoft.Json.Schema.UndefinedSchemaIdHandling> get_UndefinedSchemaIdHandling(this IObservable<Newtonsoft.Json.Schema.JsonSchemaGenerator> JsonSchemaGeneratorValue)
        {
            return Observable.Select(JsonSchemaGeneratorValue, (JsonSchemaGeneratorValueLambda) => JsonSchemaGeneratorValueLambda.UndefinedSchemaIdHandling);
        }


        public static IObservable<Newtonsoft.Json.Serialization.IContractResolver> get_ContractResolver(this IObservable<Newtonsoft.Json.Schema.JsonSchemaGenerator> JsonSchemaGeneratorValue)
        {
            return Observable.Select(JsonSchemaGeneratorValue, (JsonSchemaGeneratorValueLambda) => JsonSchemaGeneratorValueLambda.ContractResolver);
        }


        public static IObservable<System.Reactive.Unit> set_UndefinedSchemaIdHandling(this IObservable<Newtonsoft.Json.Schema.JsonSchemaGenerator> JsonSchemaGeneratorValue, IObservable<Newtonsoft.Json.Schema.UndefinedSchemaIdHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaGeneratorValue, value, (JsonSchemaGeneratorValueLambda, valueLambda) => JsonSchemaGeneratorValueLambda.UndefinedSchemaIdHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ContractResolver(this IObservable<Newtonsoft.Json.Schema.JsonSchemaGenerator> JsonSchemaGeneratorValue, IObservable<Newtonsoft.Json.Serialization.IContractResolver> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaGeneratorValue, value, (JsonSchemaGeneratorValueLambda, valueLambda) => JsonSchemaGeneratorValueLambda.ContractResolver = valueLambda);
        }

    }
}