using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonSerializer
    {
        
        public static IObservable<Newtonsoft.Json.JsonSerializer> Create()
        {
            return ObservableExt.Factory(() => Newtonsoft.Json.JsonSerializer.Create());
        }


        public static IObservable<Newtonsoft.Json.JsonSerializer> Create(IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Select(settings, (settingsLambda) => Newtonsoft.Json.JsonSerializer.Create(settingsLambda));
        }


        public static IObservable<Newtonsoft.Json.JsonSerializer> CreateDefault()
        {
            return ObservableExt.Factory(() => Newtonsoft.Json.JsonSerializer.CreateDefault());
        }


        public static IObservable<Newtonsoft.Json.JsonSerializer> CreateDefault(IObservable<Newtonsoft.Json.JsonSerializerSettings> settings)
        {
            return Observable.Select(settings, (settingsLambda) => Newtonsoft.Json.JsonSerializer.CreateDefault(settingsLambda));
        }


        public static IObservable<System.Reactive.Unit> Populate(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.IO.TextReader> reader, IObservable<System.Object> target)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, reader, target, (JsonSerializerValueLambda, readerLambda, targetLambda) => JsonSerializerValueLambda.Populate(readerLambda, targetLambda));
        }


        public static IObservable<System.Reactive.Unit> Populate(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Object> target)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, reader, target, (JsonSerializerValueLambda, readerLambda, targetLambda) => JsonSerializerValueLambda.Populate(readerLambda, targetLambda));
        }


        public static IObservable<System.Object> Deserialize(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.JsonReader> reader)
        {
            return Observable.Zip(JsonSerializerValue, reader, (JsonSerializerValueLambda, readerLambda) => JsonSerializerValueLambda.Deserialize(readerLambda));
        }


        public static IObservable<System.Object> Deserialize(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.IO.TextReader> reader, IObservable<System.Type> objectType)
        {
            return Observable.Zip(JsonSerializerValue, reader, objectType, (JsonSerializerValueLambda, readerLambda, objectTypeLambda) => JsonSerializerValueLambda.Deserialize(readerLambda, objectTypeLambda));
        }


        public static IObservable<T> Deserialize<T>(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.JsonReader> reader)
        {
            return Observable.Zip(JsonSerializerValue, reader, (JsonSerializerValueLambda, readerLambda) => JsonSerializerValueLambda.Deserialize<T>(readerLambda));
        }


        public static IObservable<System.Object> Deserialize(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.JsonReader> reader, IObservable<System.Type> objectType)
        {
            return Observable.Zip(JsonSerializerValue, reader, objectType, (JsonSerializerValueLambda, readerLambda, objectTypeLambda) => JsonSerializerValueLambda.Deserialize(readerLambda, objectTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> Serialize(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.IO.TextWriter> textWriter, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, textWriter, value, (JsonSerializerValueLambda, textWriterLambda, valueLambda) => JsonSerializerValueLambda.Serialize(textWriterLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> Serialize(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.JsonWriter> jsonWriter, IObservable<System.Object> value, IObservable<System.Type> objectType)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, jsonWriter, value, objectType, (JsonSerializerValueLambda, jsonWriterLambda, valueLambda, objectTypeLambda) => JsonSerializerValueLambda.Serialize(jsonWriterLambda, valueLambda, objectTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> Serialize(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.IO.TextWriter> textWriter, IObservable<System.Object> value, IObservable<System.Type> objectType)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, textWriter, value, objectType, (JsonSerializerValueLambda, textWriterLambda, valueLambda, objectTypeLambda) => JsonSerializerValueLambda.Serialize(textWriterLambda, valueLambda, objectTypeLambda));
        }


        public static IObservable<System.Reactive.Unit> Serialize(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.JsonWriter> jsonWriter, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, jsonWriter, value, (JsonSerializerValueLambda, jsonWriterLambda, valueLambda) => JsonSerializerValueLambda.Serialize(jsonWriterLambda, valueLambda));
        }


        public static IObservable<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolver(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.ReferenceResolver);
        }


        public static IObservable<System.Runtime.Serialization.SerializationBinder> get_Binder(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.Binder);
        }


        public static IObservable<Newtonsoft.Json.Serialization.ITraceWriter> get_TraceWriter(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.TraceWriter);
        }


        public static IObservable<System.Collections.IEqualityComparer> get_EqualityComparer(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.EqualityComparer);
        }


        public static IObservable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.TypeNameHandling);
        }


        public static IObservable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> get_TypeNameAssemblyFormat(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.TypeNameAssemblyFormat);
        }


        public static IObservable<Newtonsoft.Json.PreserveReferencesHandling> get_PreserveReferencesHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.PreserveReferencesHandling);
        }


        public static IObservable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.ReferenceLoopHandling);
        }


        public static IObservable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.MissingMemberHandling);
        }


        public static IObservable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.NullValueHandling);
        }


        public static IObservable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.DefaultValueHandling);
        }


        public static IObservable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.ObjectCreationHandling);
        }


        public static IObservable<Newtonsoft.Json.ConstructorHandling> get_ConstructorHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.ConstructorHandling);
        }


        public static IObservable<Newtonsoft.Json.MetadataPropertyHandling> get_MetadataPropertyHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.MetadataPropertyHandling);
        }


        public static IObservable<Newtonsoft.Json.JsonConverterCollection> get_Converters(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.Converters);
        }


        public static IObservable<Newtonsoft.Json.Serialization.IContractResolver> get_ContractResolver(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.ContractResolver);
        }


        public static IObservable<System.Runtime.Serialization.StreamingContext> get_Context(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.Context);
        }


        public static IObservable<Newtonsoft.Json.Formatting> get_Formatting(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.Formatting);
        }


        public static IObservable<Newtonsoft.Json.DateFormatHandling> get_DateFormatHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.DateFormatHandling);
        }


        public static IObservable<Newtonsoft.Json.DateTimeZoneHandling> get_DateTimeZoneHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.DateTimeZoneHandling);
        }


        public static IObservable<Newtonsoft.Json.DateParseHandling> get_DateParseHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.DateParseHandling);
        }


        public static IObservable<Newtonsoft.Json.FloatParseHandling> get_FloatParseHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.FloatParseHandling);
        }


        public static IObservable<Newtonsoft.Json.FloatFormatHandling> get_FloatFormatHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.FloatFormatHandling);
        }


        public static IObservable<Newtonsoft.Json.StringEscapeHandling> get_StringEscapeHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.StringEscapeHandling);
        }


        public static IObservable<System.String> get_DateFormatString(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.DateFormatString);
        }


        public static IObservable<System.Globalization.CultureInfo> get_Culture(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.Culture);
        }


        public static IObservable<System.Nullable<System.Int32>> get_MaxDepth(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.MaxDepth);
        }


        public static IObservable<System.Boolean> get_CheckAdditionalContent(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue)
        {
            return Observable.Select(JsonSerializerValue, (JsonSerializerValueLambda) => JsonSerializerValueLambda.CheckAdditionalContent);
        }


        public static IObservable<System.Reactive.Unit> set_ReferenceResolver(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.Serialization.IReferenceResolver> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.ReferenceResolver = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Binder(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.Runtime.Serialization.SerializationBinder> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.Binder = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TraceWriter(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.Serialization.ITraceWriter> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.TraceWriter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_EqualityComparer(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.Collections.IEqualityComparer> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.EqualityComparer = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TypeNameHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.TypeNameHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.TypeNameHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TypeNameAssemblyFormat(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.TypeNameAssemblyFormat = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PreserveReferencesHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.PreserveReferencesHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.PreserveReferencesHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReferenceLoopHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.ReferenceLoopHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.ReferenceLoopHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MissingMemberHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.MissingMemberHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.MissingMemberHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NullValueHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.NullValueHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.NullValueHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultValueHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.DefaultValueHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.DefaultValueHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ObjectCreationHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.ObjectCreationHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.ObjectCreationHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ConstructorHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.ConstructorHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.ConstructorHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MetadataPropertyHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.MetadataPropertyHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.MetadataPropertyHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ContractResolver(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.Serialization.IContractResolver> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.ContractResolver = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Context(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.Runtime.Serialization.StreamingContext> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.Context = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Formatting(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.Formatting> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.Formatting = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateFormatHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.DateFormatHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.DateFormatHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateTimeZoneHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.DateTimeZoneHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.DateTimeZoneHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateParseHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.DateParseHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.DateParseHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FloatParseHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.FloatParseHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.FloatParseHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FloatFormatHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.FloatFormatHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.FloatFormatHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_StringEscapeHandling(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<Newtonsoft.Json.StringEscapeHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.StringEscapeHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateFormatString(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.DateFormatString = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Culture(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.Globalization.CultureInfo> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.Culture = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxDepth(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.Nullable<System.Int32>> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.MaxDepth = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CheckAdditionalContent(this IObservable<Newtonsoft.Json.JsonSerializer> JsonSerializerValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerValue, value, (JsonSerializerValueLambda, valueLambda) => JsonSerializerValueLambda.CheckAdditionalContent = valueLambda);
        }

    }
}