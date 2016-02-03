using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __IMethodReturnMessage
    {
        
        public static IObservable<System.String> GetOutArgName(this IObservable<System.Runtime.Remoting.Messaging.IMethodReturnMessage> IMethodReturnMessageValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(IMethodReturnMessageValue, index, (IMethodReturnMessageValueLambda, indexLambda) => IMethodReturnMessageValueLambda.GetOutArgName(indexLambda));
        }


        public static IObservable<System.Object> GetOutArg(this IObservable<System.Runtime.Remoting.Messaging.IMethodReturnMessage> IMethodReturnMessageValue, IObservable<System.Int32> argNum)
        {
            return Observable.Zip(IMethodReturnMessageValue, argNum, (IMethodReturnMessageValueLambda, argNumLambda) => IMethodReturnMessageValueLambda.GetOutArg(argNumLambda));
        }


        public static IObservable<System.Int32> get_OutArgCount(this IObservable<System.Runtime.Remoting.Messaging.IMethodReturnMessage> IMethodReturnMessageValue)
        {
            return Observable.Select(IMethodReturnMessageValue, (IMethodReturnMessageValueLambda) => IMethodReturnMessageValueLambda.OutArgCount);
        }


        public static IObservable<System.Object[]> get_OutArgs(this IObservable<System.Runtime.Remoting.Messaging.IMethodReturnMessage> IMethodReturnMessageValue)
        {
            return Observable.Select(IMethodReturnMessageValue, (IMethodReturnMessageValueLambda) => IMethodReturnMessageValueLambda.OutArgs);
        }


        public static IObservable<System.Exception> get_Exception(this IObservable<System.Runtime.Remoting.Messaging.IMethodReturnMessage> IMethodReturnMessageValue)
        {
            return Observable.Select(IMethodReturnMessageValue, (IMethodReturnMessageValueLambda) => IMethodReturnMessageValueLambda.Exception);
        }


        public static IObservable<System.Object> get_ReturnValue(this IObservable<System.Runtime.Remoting.Messaging.IMethodReturnMessage> IMethodReturnMessageValue)
        {
            return Observable.Select(IMethodReturnMessageValue, (IMethodReturnMessageValueLambda) => IMethodReturnMessageValueLambda.ReturnValue);
        }

    }
}