using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __MethodReturnMessageWrapper
    {
        
        public static IObservable<System.String> GetArgName(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(MethodReturnMessageWrapperValue, index, (MethodReturnMessageWrapperValueLambda, indexLambda) => MethodReturnMessageWrapperValueLambda.GetArgName(indexLambda));
        }


        public static IObservable<System.Object> GetArg(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue, IObservable<System.Int32> argNum)
        {
            return Observable.Zip(MethodReturnMessageWrapperValue, argNum, (MethodReturnMessageWrapperValueLambda, argNumLambda) => MethodReturnMessageWrapperValueLambda.GetArg(argNumLambda));
        }


        public static IObservable<System.Object> GetOutArg(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue, IObservable<System.Int32> argNum)
        {
            return Observable.Zip(MethodReturnMessageWrapperValue, argNum, (MethodReturnMessageWrapperValueLambda, argNumLambda) => MethodReturnMessageWrapperValueLambda.GetOutArg(argNumLambda));
        }


        public static IObservable<System.String> GetOutArgName(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(MethodReturnMessageWrapperValue, index, (MethodReturnMessageWrapperValueLambda, indexLambda) => MethodReturnMessageWrapperValueLambda.GetOutArgName(indexLambda));
        }


        public static IObservable<System.String> get_Uri(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.Uri);
        }


        public static IObservable<System.String> get_MethodName(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.MethodName);
        }


        public static IObservable<System.String> get_TypeName(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.TypeName);
        }


        public static IObservable<System.Object> get_MethodSignature(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.MethodSignature);
        }


        public static IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> get_LogicalCallContext(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.LogicalCallContext);
        }


        public static IObservable<System.Reflection.MethodBase> get_MethodBase(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.MethodBase);
        }


        public static IObservable<System.Int32> get_ArgCount(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.ArgCount);
        }


        public static IObservable<System.Object[]> get_Args(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.Args);
        }


        public static IObservable<System.Boolean> get_HasVarArgs(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.HasVarArgs);
        }


        public static IObservable<System.Int32> get_OutArgCount(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.OutArgCount);
        }


        public static IObservable<System.Object[]> get_OutArgs(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.OutArgs);
        }


        public static IObservable<System.Exception> get_Exception(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.Exception);
        }


        public static IObservable<System.Object> get_ReturnValue(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.ReturnValue);
        }


        public static IObservable<System.Collections.IDictionary> get_Properties(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue)
        {
            return Observable.Select(MethodReturnMessageWrapperValue, (MethodReturnMessageWrapperValueLambda) => MethodReturnMessageWrapperValueLambda.Properties);
        }


        public static IObservable<System.Reactive.Unit> set_Uri(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(MethodReturnMessageWrapperValue, value, (MethodReturnMessageWrapperValueLambda, valueLambda) => MethodReturnMessageWrapperValueLambda.Uri = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Args(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue, IObservable<System.Object[]> value)
        {
            return ObservableExt.ZipExecute(MethodReturnMessageWrapperValue, value, (MethodReturnMessageWrapperValueLambda, valueLambda) => MethodReturnMessageWrapperValueLambda.Args = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Exception(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue, IObservable<System.Exception> value)
        {
            return ObservableExt.ZipExecute(MethodReturnMessageWrapperValue, value, (MethodReturnMessageWrapperValueLambda, valueLambda) => MethodReturnMessageWrapperValueLambda.Exception = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ReturnValue(this IObservable<System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper> MethodReturnMessageWrapperValue, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(MethodReturnMessageWrapperValue, value, (MethodReturnMessageWrapperValueLambda, valueLambda) => MethodReturnMessageWrapperValueLambda.ReturnValue = valueLambda);
        }

    }
}