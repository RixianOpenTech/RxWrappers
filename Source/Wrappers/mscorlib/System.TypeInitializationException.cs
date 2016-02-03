using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __TypeInitializationException
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.TypeInitializationException> TypeInitializationExceptionValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(TypeInitializationExceptionValue, info, context,
                (TypeInitializationExceptionValueLambda, infoLambda, contextLambda) =>
                    TypeInitializationExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_TypeName(
            this IObservable<System.TypeInitializationException> TypeInitializationExceptionValue)
        {
            return Observable.Select(TypeInitializationExceptionValue,
                (TypeInitializationExceptionValueLambda) => TypeInitializationExceptionValueLambda.TypeName);
        }
    }
}