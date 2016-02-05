using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __DefaultContractResolver
    {
        
        public static IObservable<Newtonsoft.Json.Serialization.JsonContract> ResolveContract(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue, IObservable<System.Type> type)
        {
            return Observable.Zip(DefaultContractResolverValue, type, (DefaultContractResolverValueLambda, typeLambda) => DefaultContractResolverValueLambda.ResolveContract(typeLambda));
        }


        public static IObservable<System.String> GetResolvedPropertyName(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue, IObservable<System.String> propertyName)
        {
            return Observable.Zip(DefaultContractResolverValue, propertyName, (DefaultContractResolverValueLambda, propertyNameLambda) => DefaultContractResolverValueLambda.GetResolvedPropertyName(propertyNameLambda));
        }


        public static IObservable<System.Boolean> get_DynamicCodeGeneration(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue)
        {
            return Observable.Select(DefaultContractResolverValue, (DefaultContractResolverValueLambda) => DefaultContractResolverValueLambda.DynamicCodeGeneration);
        }


        public static IObservable<System.Reflection.BindingFlags> get_DefaultMembersSearchFlags(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue)
        {
            return Observable.Select(DefaultContractResolverValue, (DefaultContractResolverValueLambda) => DefaultContractResolverValueLambda.DefaultMembersSearchFlags);
        }


        public static IObservable<System.Boolean> get_SerializeCompilerGeneratedMembers(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue)
        {
            return Observable.Select(DefaultContractResolverValue, (DefaultContractResolverValueLambda) => DefaultContractResolverValueLambda.SerializeCompilerGeneratedMembers);
        }


        public static IObservable<System.Boolean> get_IgnoreSerializableInterface(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue)
        {
            return Observable.Select(DefaultContractResolverValue, (DefaultContractResolverValueLambda) => DefaultContractResolverValueLambda.IgnoreSerializableInterface);
        }


        public static IObservable<System.Boolean> get_IgnoreSerializableAttribute(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue)
        {
            return Observable.Select(DefaultContractResolverValue, (DefaultContractResolverValueLambda) => DefaultContractResolverValueLambda.IgnoreSerializableAttribute);
        }


        public static IObservable<System.Reactive.Unit> set_DefaultMembersSearchFlags(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue, IObservable<System.Reflection.BindingFlags> value)
        {
            return ObservableExt.ZipExecute(DefaultContractResolverValue, value, (DefaultContractResolverValueLambda, valueLambda) => DefaultContractResolverValueLambda.DefaultMembersSearchFlags = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_SerializeCompilerGeneratedMembers(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(DefaultContractResolverValue, value, (DefaultContractResolverValueLambda, valueLambda) => DefaultContractResolverValueLambda.SerializeCompilerGeneratedMembers = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IgnoreSerializableInterface(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(DefaultContractResolverValue, value, (DefaultContractResolverValueLambda, valueLambda) => DefaultContractResolverValueLambda.IgnoreSerializableInterface = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_IgnoreSerializableAttribute(this IObservable<Newtonsoft.Json.Serialization.DefaultContractResolver> DefaultContractResolverValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(DefaultContractResolverValue, value, (DefaultContractResolverValueLambda, valueLambda) => DefaultContractResolverValueLambda.IgnoreSerializableAttribute = valueLambda);
        }

    }
}