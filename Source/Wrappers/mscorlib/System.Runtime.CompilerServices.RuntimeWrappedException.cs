using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.CompilerServices
{
    public static class __RuntimeWrappedException
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Runtime.CompilerServices.RuntimeWrappedException> RuntimeWrappedExceptionValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(RuntimeWrappedExceptionValue, info, context,
                (RuntimeWrappedExceptionValueLambda, infoLambda, contextLambda) =>
                    RuntimeWrappedExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Object> get_WrappedException(
            this IObservable<System.Runtime.CompilerServices.RuntimeWrappedException> RuntimeWrappedExceptionValue)
        {
            return Observable.Select(RuntimeWrappedExceptionValue,
                (RuntimeWrappedExceptionValueLambda) => RuntimeWrappedExceptionValueLambda.WrappedException);
        }
    }
}