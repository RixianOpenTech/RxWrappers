using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __IReflectableType
    {
        public static IObservable<System.Reflection.TypeInfo> GetTypeInfo(
            this IObservable<System.Reflection.IReflectableType> IReflectableTypeValue)
        {
            return Observable.Select(IReflectableTypeValue,
                (IReflectableTypeValueLambda) => IReflectableTypeValueLambda.GetTypeInfo());
        }
    }
}