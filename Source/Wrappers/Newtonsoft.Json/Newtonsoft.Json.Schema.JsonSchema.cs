using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Schema
{
    public static class __JsonSchema
    {
        
        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> Read(IObservable<Newtonsoft.Json.JsonReader> reader)
        {
            return Observable.Select(reader, (readerLambda) => Newtonsoft.Json.Schema.JsonSchema.Read(readerLambda));
        }


        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> Read(IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<Newtonsoft.Json.Schema.JsonSchemaResolver> resolver)
        {
            return Observable.Zip(reader, resolver, (readerLambda, resolverLambda) => Newtonsoft.Json.Schema.JsonSchema.Read(readerLambda, resolverLambda));
        }


        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> Parse(IObservable<System.String> json)
        {
            return Observable.Select(json, (jsonLambda) => Newtonsoft.Json.Schema.JsonSchema.Parse(jsonLambda));
        }


        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> Parse(IObservable<System.String> json, IObservable<Newtonsoft.Json.Schema.JsonSchemaResolver> resolver)
        {
            return Observable.Zip(json, resolver, (jsonLambda, resolverLambda) => Newtonsoft.Json.Schema.JsonSchema.Parse(jsonLambda, resolverLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteTo(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<Newtonsoft.Json.JsonWriter> writer)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, writer, (JsonSchemaValueLambda, writerLambda) => JsonSchemaValueLambda.WriteTo(writerLambda));
        }


        public static IObservable<System.Reactive.Unit> WriteTo(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<Newtonsoft.Json.JsonWriter> writer, IObservable<Newtonsoft.Json.Schema.JsonSchemaResolver> resolver)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, writer, resolver, (JsonSchemaValueLambda, writerLambda, resolverLambda) => JsonSchemaValueLambda.WriteTo(writerLambda, resolverLambda));
        }


        public static IObservable<System.String> ToString(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.ToString());
        }


        public static IObservable<System.String> get_Id(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Id);
        }


        public static IObservable<System.String> get_Title(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Title);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_Required(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Required);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_ReadOnly(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.ReadOnly);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_Hidden(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Hidden);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_Transient(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Transient);
        }


        public static IObservable<System.String> get_Description(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Description);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType>> get_Type(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Type);
        }


        public static IObservable<System.String> get_Pattern(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Pattern);
        }


        public static IObservable<System.Nullable<System.Int32>> get_MinimumLength(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.MinimumLength);
        }


        public static IObservable<System.Nullable<System.Int32>> get_MaximumLength(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.MaximumLength);
        }


        public static IObservable<System.Nullable<System.Double>> get_DivisibleBy(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.DivisibleBy);
        }


        public static IObservable<System.Nullable<System.Double>> get_Minimum(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Minimum);
        }


        public static IObservable<System.Nullable<System.Double>> get_Maximum(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Maximum);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_ExclusiveMinimum(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.ExclusiveMinimum);
        }


        public static IObservable<System.Nullable<System.Boolean>> get_ExclusiveMaximum(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.ExclusiveMaximum);
        }


        public static IObservable<System.Nullable<System.Int32>> get_MinimumItems(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.MinimumItems);
        }


        public static IObservable<System.Nullable<System.Int32>> get_MaximumItems(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.MaximumItems);
        }


        public static IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema>> get_Items(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Items);
        }


        public static IObservable<System.Boolean> get_PositionalItemsValidation(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.PositionalItemsValidation);
        }


        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> get_AdditionalItems(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.AdditionalItems);
        }


        public static IObservable<System.Boolean> get_AllowAdditionalItems(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.AllowAdditionalItems);
        }


        public static IObservable<System.Boolean> get_UniqueItems(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.UniqueItems);
        }


        public static IObservable<System.Collections.Generic.IDictionary<System.String, Newtonsoft.Json.Schema.JsonSchema>> get_Properties(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Properties);
        }


        public static IObservable<Newtonsoft.Json.Schema.JsonSchema> get_AdditionalProperties(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.AdditionalProperties);
        }


        public static IObservable<System.Collections.Generic.IDictionary<System.String, Newtonsoft.Json.Schema.JsonSchema>> get_PatternProperties(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.PatternProperties);
        }


        public static IObservable<System.Boolean> get_AllowAdditionalProperties(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.AllowAdditionalProperties);
        }


        public static IObservable<System.String> get_Requires(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Requires);
        }


        public static IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>> get_Enum(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Enum);
        }


        public static IObservable<System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType>> get_Disallow(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Disallow);
        }


        public static IObservable<Newtonsoft.Json.Linq.JToken> get_Default(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Default);
        }


        public static IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema>> get_Extends(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Extends);
        }


        public static IObservable<System.String> get_Format(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue)
        {
            return Observable.Select(JsonSchemaValue, (JsonSchemaValueLambda) => JsonSchemaValueLambda.Format);
        }


        public static IObservable<System.Reactive.Unit> set_Id(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Id = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Title(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Title = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Required(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Required = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReadOnly(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.ReadOnly = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Hidden(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Hidden = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Transient(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Transient = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Description(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Description = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Type(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Type = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Pattern(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Pattern = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MinimumLength(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Int32>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.MinimumLength = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaximumLength(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Int32>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.MaximumLength = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DivisibleBy(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Double>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.DivisibleBy = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Minimum(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Double>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Minimum = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Maximum(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Double>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Maximum = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ExclusiveMinimum(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.ExclusiveMinimum = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ExclusiveMaximum(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Boolean>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.ExclusiveMaximum = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MinimumItems(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Int32>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.MinimumItems = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaximumItems(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<System.Int32>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.MaximumItems = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Items(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Items = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PositionalItemsValidation(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.PositionalItemsValidation = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AdditionalItems(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<Newtonsoft.Json.Schema.JsonSchema> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.AdditionalItems = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AllowAdditionalItems(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.AllowAdditionalItems = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_UniqueItems(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.UniqueItems = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Properties(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Collections.Generic.IDictionary<System.String, Newtonsoft.Json.Schema.JsonSchema>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Properties = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AdditionalProperties(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<Newtonsoft.Json.Schema.JsonSchema> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.AdditionalProperties = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PatternProperties(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Collections.Generic.IDictionary<System.String, Newtonsoft.Json.Schema.JsonSchema>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.PatternProperties = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AllowAdditionalProperties(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.AllowAdditionalProperties = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Requires(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Requires = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Enum(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Enum = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Disallow(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Disallow = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Default(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<Newtonsoft.Json.Linq.JToken> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Default = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Extends(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema>> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Extends = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Format(this IObservable<Newtonsoft.Json.Schema.JsonSchema> JsonSchemaValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonSchemaValue, value, (JsonSchemaValueLambda, valueLambda) => JsonSchemaValueLambda.Format = valueLambda);
        }

    }
}