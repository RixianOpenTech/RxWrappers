using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __SerializationBinder
    {
        
        public static IObservable<Tuple<System.String, System.String>> BindToName(this IObservable<System.Runtime.Serialization.SerializationBinder> SerializationBinderValue, IObservable<System.Type> serializedType)
        {
            return Observable.Zip(SerializationBinderValue, serializedType, (SerializationBinderValueLambda, serializedTypeLambda) => {
System.String assemblyNameOutput = default(System.String);
System.String typeNameOutput = default(System.String);
SerializationBinderValueLambda.BindToName(serializedTypeLambda, out assemblyNameOutput, out typeNameOutput);
return Tuple.Create(assemblyNameOutput, typeNameOutput);
});
        }


        public static IObservable<System.Type> BindToType(this IObservable<System.Runtime.Serialization.SerializationBinder> SerializationBinderValue, IObservable<System.String> assemblyName, IObservable<System.String> typeName)
        {
            return Observable.Zip(SerializationBinderValue, assemblyName, typeName, (SerializationBinderValueLambda, assemblyNameLambda, typeNameLambda) => SerializationBinderValueLambda.BindToType(assemblyNameLambda, typeNameLambda));
        }

    }
}