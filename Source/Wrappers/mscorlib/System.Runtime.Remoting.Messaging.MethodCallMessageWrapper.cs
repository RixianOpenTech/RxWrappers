using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __MethodCallMessageWrapper
    {
        
        public static IObservable<System.String> GetArgName(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(MethodCallMessageWrapperValue, index, (MethodCallMessageWrapperValueLambda, indexLambda) => MethodCallMessageWrapperValueLambda.GetArgName(indexLambda));
        }


        public static IObservable<System.Object> GetArg(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue, IObservable<System.Int32> argNum)
        {
            return Observable.Zip(MethodCallMessageWrapperValue, argNum, (MethodCallMessageWrapperValueLambda, argNumLambda) => MethodCallMessageWrapperValueLambda.GetArg(argNumLambda));
        }


        public static IObservable<System.Object> GetInArg(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue, IObservable<System.Int32> argNum)
        {
            return Observable.Zip(MethodCallMessageWrapperValue, argNum, (MethodCallMessageWrapperValueLambda, argNumLambda) => MethodCallMessageWrapperValueLambda.GetInArg(argNumLambda));
        }


        public static IObservable<System.String> GetInArgName(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(MethodCallMessageWrapperValue, index, (MethodCallMessageWrapperValueLambda, indexLambda) => MethodCallMessageWrapperValueLambda.GetInArgName(indexLambda));
        }


        public static IObservable<System.String> get_Uri(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.Uri);
        }


        public static IObservable<System.String> get_MethodName(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.MethodName);
        }


        public static IObservable<System.String> get_TypeName(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.TypeName);
        }


        public static IObservable<System.Object> get_MethodSignature(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.MethodSignature);
        }


        public static IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> get_LogicalCallContext(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.LogicalCallContext);
        }


        public static IObservable<System.Reflection.MethodBase> get_MethodBase(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.MethodBase);
        }


        public static IObservable<System.Int32> get_ArgCount(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.ArgCount);
        }


        public static IObservable<System.Object[]> get_Args(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.Args);
        }


        public static IObservable<System.Boolean> get_HasVarArgs(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.HasVarArgs);
        }


        public static IObservable<System.Int32> get_InArgCount(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.InArgCount);
        }


        public static IObservable<System.Object[]> get_InArgs(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.InArgs);
        }


        public static IObservable<System.Collections.IDictionary> get_Properties(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue)
        {
            return Observable.Select(MethodCallMessageWrapperValue, (MethodCallMessageWrapperValueLambda) => MethodCallMessageWrapperValueLambda.Properties);
        }


        public static IObservable<System.Reactive.Unit> set_Uri(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(MethodCallMessageWrapperValue, value, (MethodCallMessageWrapperValueLambda, valueLambda) => MethodCallMessageWrapperValueLambda.Uri = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Args(this IObservable<System.Runtime.Remoting.Messaging.MethodCallMessageWrapper> MethodCallMessageWrapperValue, IObservable<System.Object[]> value)
        {
            return ObservableExt.ZipExecute(MethodCallMessageWrapperValue, value, (MethodCallMessageWrapperValueLambda, valueLambda) => MethodCallMessageWrapperValueLambda.Args = valueLambda);
        }

    }
}