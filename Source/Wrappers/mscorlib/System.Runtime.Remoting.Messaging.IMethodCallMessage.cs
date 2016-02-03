using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __IMethodCallMessage
    {
        public static IObservable<System.String> GetInArgName(
            this IObservable<System.Runtime.Remoting.Messaging.IMethodCallMessage> IMethodCallMessageValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(IMethodCallMessageValue, index,
                (IMethodCallMessageValueLambda, indexLambda) => IMethodCallMessageValueLambda.GetInArgName(indexLambda));
        }


        public static IObservable<System.Object> GetInArg(
            this IObservable<System.Runtime.Remoting.Messaging.IMethodCallMessage> IMethodCallMessageValue,
            IObservable<System.Int32> argNum)
        {
            return Observable.Zip(IMethodCallMessageValue, argNum,
                (IMethodCallMessageValueLambda, argNumLambda) => IMethodCallMessageValueLambda.GetInArg(argNumLambda));
        }


        public static IObservable<System.Int32> get_InArgCount(
            this IObservable<System.Runtime.Remoting.Messaging.IMethodCallMessage> IMethodCallMessageValue)
        {
            return Observable.Select(IMethodCallMessageValue,
                (IMethodCallMessageValueLambda) => IMethodCallMessageValueLambda.InArgCount);
        }


        public static IObservable<System.Object[]> get_InArgs(
            this IObservable<System.Runtime.Remoting.Messaging.IMethodCallMessage> IMethodCallMessageValue)
        {
            return Observable.Select(IMethodCallMessageValue,
                (IMethodCallMessageValueLambda) => IMethodCallMessageValueLambda.InArgs);
        }
    }
}