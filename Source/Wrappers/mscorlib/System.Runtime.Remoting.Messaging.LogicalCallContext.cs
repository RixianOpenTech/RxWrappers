using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __LogicalCallContext
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> LogicalCallContextValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(LogicalCallContextValue, info, context,
                (LogicalCallContextValueLambda, infoLambda, contextLambda) =>
                    LogicalCallContextValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Object> Clone(
            this IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> LogicalCallContextValue)
        {
            return Observable.Select(LogicalCallContextValue,
                (LogicalCallContextValueLambda) => LogicalCallContextValueLambda.Clone());
        }


        public static IObservable<System.Reactive.Unit> FreeNamedDataSlot(
            this IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> LogicalCallContextValue,
            IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(LogicalCallContextValue, name,
                (LogicalCallContextValueLambda, nameLambda) =>
                    LogicalCallContextValueLambda.FreeNamedDataSlot(nameLambda));
        }


        public static IObservable<System.Object> GetData(
            this IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> LogicalCallContextValue,
            IObservable<System.String> name)
        {
            return Observable.Zip(LogicalCallContextValue, name,
                (LogicalCallContextValueLambda, nameLambda) => LogicalCallContextValueLambda.GetData(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> SetData(
            this IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> LogicalCallContextValue,
            IObservable<System.String> name, IObservable<System.Object> data)
        {
            return ObservableExt.ZipExecute(LogicalCallContextValue, name, data,
                (LogicalCallContextValueLambda, nameLambda, dataLambda) =>
                    LogicalCallContextValueLambda.SetData(nameLambda, dataLambda));
        }


        public static IObservable<System.Boolean> get_HasInfo(
            this IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> LogicalCallContextValue)
        {
            return Observable.Select(LogicalCallContextValue,
                (LogicalCallContextValueLambda) => LogicalCallContextValueLambda.HasInfo);
        }
    }
}