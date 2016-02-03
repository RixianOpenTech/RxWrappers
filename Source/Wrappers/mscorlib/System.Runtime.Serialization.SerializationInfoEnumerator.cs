using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __SerializationInfoEnumerator
    {
        public static IObservable<System.Boolean> MoveNext(
            this IObservable<System.Runtime.Serialization.SerializationInfoEnumerator> SerializationInfoEnumeratorValue)
        {
            return Observable.Select(SerializationInfoEnumeratorValue,
                (SerializationInfoEnumeratorValueLambda) => SerializationInfoEnumeratorValueLambda.MoveNext());
        }


        public static IObservable<System.Reactive.Unit> Reset(
            this IObservable<System.Runtime.Serialization.SerializationInfoEnumerator> SerializationInfoEnumeratorValue)
        {
            return
                Observable.Do(SerializationInfoEnumeratorValue,
                    (SerializationInfoEnumeratorValueLambda) => SerializationInfoEnumeratorValueLambda.Reset()).ToUnit();
        }


        public static IObservable<System.Runtime.Serialization.SerializationEntry> get_Current(
            this IObservable<System.Runtime.Serialization.SerializationInfoEnumerator> SerializationInfoEnumeratorValue)
        {
            return Observable.Select(SerializationInfoEnumeratorValue,
                (SerializationInfoEnumeratorValueLambda) => SerializationInfoEnumeratorValueLambda.Current);
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Runtime.Serialization.SerializationInfoEnumerator> SerializationInfoEnumeratorValue)
        {
            return Observable.Select(SerializationInfoEnumeratorValue,
                (SerializationInfoEnumeratorValueLambda) => SerializationInfoEnumeratorValueLambda.Name);
        }


        public static IObservable<System.Object> get_Value(
            this IObservable<System.Runtime.Serialization.SerializationInfoEnumerator> SerializationInfoEnumeratorValue)
        {
            return Observable.Select(SerializationInfoEnumeratorValue,
                (SerializationInfoEnumeratorValueLambda) => SerializationInfoEnumeratorValueLambda.Value);
        }


        public static IObservable<System.Type> get_ObjectType(
            this IObservable<System.Runtime.Serialization.SerializationInfoEnumerator> SerializationInfoEnumeratorValue)
        {
            return Observable.Select(SerializationInfoEnumeratorValue,
                (SerializationInfoEnumeratorValueLambda) => SerializationInfoEnumeratorValueLambda.ObjectType);
        }
    }
}