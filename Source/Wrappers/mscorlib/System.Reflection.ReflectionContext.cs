using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __ReflectionContext
    {
        
        public static IObservable<System.Reflection.Assembly> MapAssembly(this IObservable<System.Reflection.ReflectionContext> ReflectionContextValue, IObservable<System.Reflection.Assembly> assembly)
        {
            return Observable.Zip(ReflectionContextValue, assembly, (ReflectionContextValueLambda, assemblyLambda) => ReflectionContextValueLambda.MapAssembly(assemblyLambda));
        }


        public static IObservable<System.Reflection.TypeInfo> MapType(this IObservable<System.Reflection.ReflectionContext> ReflectionContextValue, IObservable<System.Reflection.TypeInfo> type)
        {
            return Observable.Zip(ReflectionContextValue, type, (ReflectionContextValueLambda, typeLambda) => ReflectionContextValueLambda.MapType(typeLambda));
        }


        public static IObservable<System.Reflection.TypeInfo> GetTypeForObject(this IObservable<System.Reflection.ReflectionContext> ReflectionContextValue, IObservable<System.Object> value)
        {
            return Observable.Zip(ReflectionContextValue, value, (ReflectionContextValueLambda, valueLambda) => ReflectionContextValueLambda.GetTypeForObject(valueLambda));
        }

    }
}