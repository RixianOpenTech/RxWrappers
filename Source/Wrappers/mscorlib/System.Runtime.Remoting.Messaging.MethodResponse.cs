using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __MethodResponse
    {
        public static IObservable<System.Object> HeaderHandler(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue,
            IObservable<System.Runtime.Remoting.Messaging.Header[]> h)
        {
            return Observable.Zip(MethodResponseValue, h,
                (MethodResponseValueLambda, hLambda) => MethodResponseValueLambda.HeaderHandler(hLambda));
        }


        public static IObservable<System.Reactive.Unit> RootSetObjectData(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> ctx)
        {
            return ObservableExt.ZipExecute(MethodResponseValue, info, ctx,
                (MethodResponseValueLambda, infoLambda, ctxLambda) =>
                    MethodResponseValueLambda.RootSetObjectData(infoLambda, ctxLambda));
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(MethodResponseValue, info, context,
                (MethodResponseValueLambda, infoLambda, contextLambda) =>
                    MethodResponseValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Object> GetArg(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue,
            IObservable<System.Int32> argNum)
        {
            return Observable.Zip(MethodResponseValue, argNum,
                (MethodResponseValueLambda, argNumLambda) => MethodResponseValueLambda.GetArg(argNumLambda));
        }


        public static IObservable<System.String> GetArgName(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(MethodResponseValue, index,
                (MethodResponseValueLambda, indexLambda) => MethodResponseValueLambda.GetArgName(indexLambda));
        }


        public static IObservable<System.Object> GetOutArg(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue,
            IObservable<System.Int32> argNum)
        {
            return Observable.Zip(MethodResponseValue, argNum,
                (MethodResponseValueLambda, argNumLambda) => MethodResponseValueLambda.GetOutArg(argNumLambda));
        }


        public static IObservable<System.String> GetOutArgName(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(MethodResponseValue, index,
                (MethodResponseValueLambda, indexLambda) => MethodResponseValueLambda.GetOutArgName(indexLambda));
        }


        public static IObservable<System.String> get_Uri(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue, (MethodResponseValueLambda) => MethodResponseValueLambda.Uri);
        }


        public static IObservable<System.String> get_MethodName(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.MethodName);
        }


        public static IObservable<System.String> get_TypeName(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.TypeName);
        }


        public static IObservable<System.Object> get_MethodSignature(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.MethodSignature);
        }


        public static IObservable<System.Reflection.MethodBase> get_MethodBase(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.MethodBase);
        }


        public static IObservable<System.Boolean> get_HasVarArgs(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.HasVarArgs);
        }


        public static IObservable<System.Int32> get_ArgCount(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.ArgCount);
        }


        public static IObservable<System.Object[]> get_Args(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue, (MethodResponseValueLambda) => MethodResponseValueLambda.Args);
        }


        public static IObservable<System.Int32> get_OutArgCount(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.OutArgCount);
        }


        public static IObservable<System.Object[]> get_OutArgs(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.OutArgs);
        }


        public static IObservable<System.Exception> get_Exception(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.Exception);
        }


        public static IObservable<System.Object> get_ReturnValue(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.ReturnValue);
        }


        public static IObservable<System.Collections.IDictionary> get_Properties(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.Properties);
        }


        public static IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> get_LogicalCallContext(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue)
        {
            return Observable.Select(MethodResponseValue,
                (MethodResponseValueLambda) => MethodResponseValueLambda.LogicalCallContext);
        }


        public static IObservable<System.Reactive.Unit> set_Uri(
            this IObservable<System.Runtime.Remoting.Messaging.MethodResponse> MethodResponseValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(MethodResponseValue, value,
                (MethodResponseValueLambda, valueLambda) => MethodResponseValueLambda.Uri = valueLambda);
        }
    }
}