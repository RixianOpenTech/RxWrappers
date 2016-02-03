using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __CompressedStack
    {
        
        public static IObservable<System.Threading.CompressedStack> Capture()
        {
            return ObservableExt.Factory(() => System.Threading.CompressedStack.Capture());
        }


        public static IObservable<System.Reactive.Unit> Run(IObservable<System.Threading.CompressedStack> compressedStack, IObservable<System.Threading.ContextCallback> callback, IObservable<System.Object> state)
        {
            return ObservableExt.ZipExecute(compressedStack, callback, state, (compressedStackLambda, callbackLambda, stateLambda) => System.Threading.CompressedStack.Run(compressedStackLambda, callbackLambda, stateLambda));
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Threading.CompressedStack> CompressedStackValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(CompressedStackValue, info, context, (CompressedStackValueLambda, infoLambda, contextLambda) => CompressedStackValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Threading.CompressedStack> GetCompressedStack()
        {
            return ObservableExt.Factory(() => System.Threading.CompressedStack.GetCompressedStack());
        }


        public static IObservable<System.Threading.CompressedStack> CreateCopy(this IObservable<System.Threading.CompressedStack> CompressedStackValue)
        {
            return Observable.Select(CompressedStackValue, (CompressedStackValueLambda) => CompressedStackValueLambda.CreateCopy());
        }

    }
}