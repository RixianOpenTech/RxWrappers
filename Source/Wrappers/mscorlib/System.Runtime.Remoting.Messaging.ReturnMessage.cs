using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __ReturnMessage
    {
        public static IObservable<System.Object> GetArg(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue,
            IObservable<System.Int32> argNum)
        {
            return Observable.Zip(ReturnMessageValue, argNum,
                (ReturnMessageValueLambda, argNumLambda) => ReturnMessageValueLambda.GetArg(argNumLambda));
        }


        public static IObservable<System.String> GetArgName(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(ReturnMessageValue, index,
                (ReturnMessageValueLambda, indexLambda) => ReturnMessageValueLambda.GetArgName(indexLambda));
        }


        public static IObservable<System.Object> GetOutArg(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue,
            IObservable<System.Int32> argNum)
        {
            return Observable.Zip(ReturnMessageValue, argNum,
                (ReturnMessageValueLambda, argNumLambda) => ReturnMessageValueLambda.GetOutArg(argNumLambda));
        }


        public static IObservable<System.String> GetOutArgName(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(ReturnMessageValue, index,
                (ReturnMessageValueLambda, indexLambda) => ReturnMessageValueLambda.GetOutArgName(indexLambda));
        }


        public static IObservable<System.String> get_Uri(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue, (ReturnMessageValueLambda) => ReturnMessageValueLambda.Uri);
        }


        public static IObservable<System.String> get_MethodName(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue,
                (ReturnMessageValueLambda) => ReturnMessageValueLambda.MethodName);
        }


        public static IObservable<System.String> get_TypeName(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue, (ReturnMessageValueLambda) => ReturnMessageValueLambda.TypeName);
        }


        public static IObservable<System.Object> get_MethodSignature(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue,
                (ReturnMessageValueLambda) => ReturnMessageValueLambda.MethodSignature);
        }


        public static IObservable<System.Reflection.MethodBase> get_MethodBase(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue,
                (ReturnMessageValueLambda) => ReturnMessageValueLambda.MethodBase);
        }


        public static IObservable<System.Boolean> get_HasVarArgs(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue,
                (ReturnMessageValueLambda) => ReturnMessageValueLambda.HasVarArgs);
        }


        public static IObservable<System.Int32> get_ArgCount(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue, (ReturnMessageValueLambda) => ReturnMessageValueLambda.ArgCount);
        }


        public static IObservable<System.Object[]> get_Args(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue, (ReturnMessageValueLambda) => ReturnMessageValueLambda.Args);
        }


        public static IObservable<System.Int32> get_OutArgCount(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue,
                (ReturnMessageValueLambda) => ReturnMessageValueLambda.OutArgCount);
        }


        public static IObservable<System.Object[]> get_OutArgs(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue, (ReturnMessageValueLambda) => ReturnMessageValueLambda.OutArgs);
        }


        public static IObservable<System.Exception> get_Exception(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue,
                (ReturnMessageValueLambda) => ReturnMessageValueLambda.Exception);
        }


        public static IObservable<System.Object> get_ReturnValue(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue,
                (ReturnMessageValueLambda) => ReturnMessageValueLambda.ReturnValue);
        }


        public static IObservable<System.Collections.IDictionary> get_Properties(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue,
                (ReturnMessageValueLambda) => ReturnMessageValueLambda.Properties);
        }


        public static IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> get_LogicalCallContext(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue)
        {
            return Observable.Select(ReturnMessageValue,
                (ReturnMessageValueLambda) => ReturnMessageValueLambda.LogicalCallContext);
        }


        public static IObservable<System.Reactive.Unit> set_Uri(
            this IObservable<System.Runtime.Remoting.Messaging.ReturnMessage> ReturnMessageValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ReturnMessageValue, value,
                (ReturnMessageValueLambda, valueLambda) => ReturnMessageValueLambda.Uri = valueLambda);
        }
    }
}