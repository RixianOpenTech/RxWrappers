using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __DefaultSerializationBinder
    {
        
        public static IObservable<System.Type> BindToType(this IObservable<Newtonsoft.Json.Serialization.DefaultSerializationBinder> DefaultSerializationBinderValue, IObservable<System.String> assemblyName, IObservable<System.String> typeName)
        {
            return Observable.Zip(DefaultSerializationBinderValue, assemblyName, typeName, (DefaultSerializationBinderValueLambda, assemblyNameLambda, typeNameLambda) => DefaultSerializationBinderValueLambda.BindToType(assemblyNameLambda, typeNameLambda));
        }


        public static IObservable<Tuple<System.String, System.String>> BindToName(this IObservable<Newtonsoft.Json.Serialization.DefaultSerializationBinder> DefaultSerializationBinderValue, IObservable<System.Type> serializedType)
        {
            return Observable.Zip(DefaultSerializationBinderValue, serializedType, (DefaultSerializationBinderValueLambda, serializedTypeLambda) => {
System.String assemblyNameOutput = default(System.String);
System.String typeNameOutput = default(System.String);
DefaultSerializationBinderValueLambda.BindToName(serializedTypeLambda, out assemblyNameOutput, out typeNameOutput);
return Tuple.Create(assemblyNameOutput, typeNameOutput);
});
        }

    }
}