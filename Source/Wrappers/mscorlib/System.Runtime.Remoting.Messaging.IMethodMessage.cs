using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
public static class _IMethodMessage
{
    
public static IObservable<System.String> GetArgName(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue, IObservable<System.Int32> index)
{
    return Observable.Zip(IMethodMessageValue, index, (IMethodMessageValueLambda, indexLambda) => IMethodMessageValueLambda.GetArgName(indexLambda));
}


public static IObservable<System.Object> GetArg(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue, IObservable<System.Int32> argNum)
{
    return Observable.Zip(IMethodMessageValue, argNum, (IMethodMessageValueLambda, argNumLambda) => IMethodMessageValueLambda.GetArg(argNumLambda));
}


public static IObservable<System.String> get_Uri(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue)
{
    return Observable.Select(IMethodMessageValue, (IMethodMessageValueLambda) => IMethodMessageValueLambda.Uri);
}


public static IObservable<System.String> get_MethodName(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue)
{
    return Observable.Select(IMethodMessageValue, (IMethodMessageValueLambda) => IMethodMessageValueLambda.MethodName);
}


public static IObservable<System.String> get_TypeName(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue)
{
    return Observable.Select(IMethodMessageValue, (IMethodMessageValueLambda) => IMethodMessageValueLambda.TypeName);
}


public static IObservable<System.Object> get_MethodSignature(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue)
{
    return Observable.Select(IMethodMessageValue, (IMethodMessageValueLambda) => IMethodMessageValueLambda.MethodSignature);
}


public static IObservable<System.Int32> get_ArgCount(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue)
{
    return Observable.Select(IMethodMessageValue, (IMethodMessageValueLambda) => IMethodMessageValueLambda.ArgCount);
}


public static IObservable<System.Object[]> get_Args(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue)
{
    return Observable.Select(IMethodMessageValue, (IMethodMessageValueLambda) => IMethodMessageValueLambda.Args);
}


public static IObservable<System.Boolean> get_HasVarArgs(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue)
{
    return Observable.Select(IMethodMessageValue, (IMethodMessageValueLambda) => IMethodMessageValueLambda.HasVarArgs);
}


public static IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> get_LogicalCallContext(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue)
{
    return Observable.Select(IMethodMessageValue, (IMethodMessageValueLambda) => IMethodMessageValueLambda.LogicalCallContext);
}


public static IObservable<System.Reflection.MethodBase> get_MethodBase(this IObservable<System.Runtime.Remoting.Messaging.IMethodMessage> IMethodMessageValue)
{
    return Observable.Select(IMethodMessageValue, (IMethodMessageValueLambda) => IMethodMessageValueLambda.MethodBase);
}

}
}