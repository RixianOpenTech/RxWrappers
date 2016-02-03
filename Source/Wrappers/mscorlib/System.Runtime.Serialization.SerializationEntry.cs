using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __SerializationEntry
    {
        
        public static IObservable<System.Object> get_Value(this IObservable<System.Runtime.Serialization.SerializationEntry> SerializationEntryValue)
        {
            return Observable.Select(SerializationEntryValue, (SerializationEntryValueLambda) => SerializationEntryValueLambda.Value);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Runtime.Serialization.SerializationEntry> SerializationEntryValue)
        {
            return Observable.Select(SerializationEntryValue, (SerializationEntryValueLambda) => SerializationEntryValueLambda.Name);
        }


        public static IObservable<System.Type> get_ObjectType(this IObservable<System.Runtime.Serialization.SerializationEntry> SerializationEntryValue)
        {
            return Observable.Select(SerializationEntryValue, (SerializationEntryValueLambda) => SerializationEntryValueLambda.ObjectType);
        }

    }
}