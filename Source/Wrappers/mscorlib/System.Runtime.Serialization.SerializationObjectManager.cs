using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __SerializationObjectManager
    {
        public static IObservable<System.Reactive.Unit> RegisterObject(
            this IObservable<System.Runtime.Serialization.SerializationObjectManager> SerializationObjectManagerValue,
            IObservable<System.Object> obj)
        {
            return ObservableExt.ZipExecute(SerializationObjectManagerValue, obj,
                (SerializationObjectManagerValueLambda, objLambda) =>
                    SerializationObjectManagerValueLambda.RegisterObject(objLambda));
        }


        public static IObservable<System.Reactive.Unit> RaiseOnSerializedEvent(
            this IObservable<System.Runtime.Serialization.SerializationObjectManager> SerializationObjectManagerValue)
        {
            return
                Observable.Do(SerializationObjectManagerValue,
                    (SerializationObjectManagerValueLambda) =>
                        SerializationObjectManagerValueLambda.RaiseOnSerializedEvent()).ToUnit();
        }
    }
}