using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json
{
    public static class __JsonSerializerSettings
    {
        
        public static IObservable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.ReferenceLoopHandling);
        }


        public static IObservable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.MissingMemberHandling);
        }


        public static IObservable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.ObjectCreationHandling);
        }


        public static IObservable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.NullValueHandling);
        }


        public static IObservable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.DefaultValueHandling);
        }


        public static IObservable<System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter>> get_Converters(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.Converters);
        }


        public static IObservable<Newtonsoft.Json.PreserveReferencesHandling> get_PreserveReferencesHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.PreserveReferencesHandling);
        }


        public static IObservable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.TypeNameHandling);
        }


        public static IObservable<Newtonsoft.Json.MetadataPropertyHandling> get_MetadataPropertyHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.MetadataPropertyHandling);
        }


        public static IObservable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> get_TypeNameAssemblyFormat(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.TypeNameAssemblyFormat);
        }


        public static IObservable<Newtonsoft.Json.ConstructorHandling> get_ConstructorHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.ConstructorHandling);
        }


        public static IObservable<Newtonsoft.Json.Serialization.IContractResolver> get_ContractResolver(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.ContractResolver);
        }


        public static IObservable<System.Collections.IEqualityComparer> get_EqualityComparer(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.EqualityComparer);
        }


        public static IObservable<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolver(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.ReferenceResolver);
        }


        public static IObservable<System.Func<Newtonsoft.Json.Serialization.IReferenceResolver>> get_ReferenceResolverProvider(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.ReferenceResolverProvider);
        }


        public static IObservable<Newtonsoft.Json.Serialization.ITraceWriter> get_TraceWriter(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.TraceWriter);
        }


        public static IObservable<System.Runtime.Serialization.SerializationBinder> get_Binder(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.Binder);
        }


        public static IObservable<System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>> get_Error(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.Error);
        }


        public static IObservable<System.Runtime.Serialization.StreamingContext> get_Context(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.Context);
        }


        public static IObservable<System.String> get_DateFormatString(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.DateFormatString);
        }


        public static IObservable<System.Nullable<System.Int32>> get_MaxDepth(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.MaxDepth);
        }


        public static IObservable<Newtonsoft.Json.Formatting> get_Formatting(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.Formatting);
        }


        public static IObservable<Newtonsoft.Json.DateFormatHandling> get_DateFormatHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.DateFormatHandling);
        }


        public static IObservable<Newtonsoft.Json.DateTimeZoneHandling> get_DateTimeZoneHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.DateTimeZoneHandling);
        }


        public static IObservable<Newtonsoft.Json.DateParseHandling> get_DateParseHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.DateParseHandling);
        }


        public static IObservable<Newtonsoft.Json.FloatFormatHandling> get_FloatFormatHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.FloatFormatHandling);
        }


        public static IObservable<Newtonsoft.Json.FloatParseHandling> get_FloatParseHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.FloatParseHandling);
        }


        public static IObservable<Newtonsoft.Json.StringEscapeHandling> get_StringEscapeHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.StringEscapeHandling);
        }


        public static IObservable<System.Globalization.CultureInfo> get_Culture(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.Culture);
        }


        public static IObservable<System.Boolean> get_CheckAdditionalContent(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue)
        {
            return Observable.Select(JsonSerializerSettingsValue, (JsonSerializerSettingsValueLambda) => JsonSerializerSettingsValueLambda.CheckAdditionalContent);
        }


        public static IObservable<System.Reactive.Unit> set_ReferenceLoopHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.ReferenceLoopHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.ReferenceLoopHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MissingMemberHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.MissingMemberHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.MissingMemberHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ObjectCreationHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.ObjectCreationHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.ObjectCreationHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_NullValueHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.NullValueHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.NullValueHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultValueHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.DefaultValueHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.DefaultValueHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Converters(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter>> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.Converters = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_PreserveReferencesHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.PreserveReferencesHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.PreserveReferencesHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TypeNameHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.TypeNameHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.TypeNameHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MetadataPropertyHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.MetadataPropertyHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.MetadataPropertyHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TypeNameAssemblyFormat(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.TypeNameAssemblyFormat = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ConstructorHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.ConstructorHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.ConstructorHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ContractResolver(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.Serialization.IContractResolver> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.ContractResolver = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_EqualityComparer(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.Collections.IEqualityComparer> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.EqualityComparer = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReferenceResolver(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.Serialization.IReferenceResolver> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.ReferenceResolver = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReferenceResolverProvider(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.Func<Newtonsoft.Json.Serialization.IReferenceResolver>> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.ReferenceResolverProvider = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_TraceWriter(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.Serialization.ITraceWriter> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.TraceWriter = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Binder(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.Runtime.Serialization.SerializationBinder> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.Binder = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Error(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.Error = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Context(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.Runtime.Serialization.StreamingContext> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.Context = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateFormatString(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.DateFormatString = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MaxDepth(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.Nullable<System.Int32>> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.MaxDepth = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Formatting(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.Formatting> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.Formatting = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateFormatHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.DateFormatHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.DateFormatHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateTimeZoneHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.DateTimeZoneHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.DateTimeZoneHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_DateParseHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.DateParseHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.DateParseHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FloatFormatHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.FloatFormatHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.FloatFormatHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FloatParseHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.FloatParseHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.FloatParseHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_StringEscapeHandling(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<Newtonsoft.Json.StringEscapeHandling> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.StringEscapeHandling = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Culture(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.Globalization.CultureInfo> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.Culture = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CheckAdditionalContent(this IObservable<Newtonsoft.Json.JsonSerializerSettings> JsonSerializerSettingsValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(JsonSerializerSettingsValue, value, (JsonSerializerSettingsValueLambda, valueLambda) => JsonSerializerSettingsValueLambda.CheckAdditionalContent = valueLambda);
        }

    }
}