using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
public static class _MethodCall
{
    
public static IObservable<System.Reactive.Unit> RootSetObjectData(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> ctx)
{
    return ObservableExt.ZipExecute(MethodCallValue, info, ctx, (MethodCallValueLambda, infoLambda, ctxLambda) => MethodCallValueLambda.RootSetObjectData(infoLambda, ctxLambda));
}


public static IObservable<System.Reactive.Unit> ResolveMethod(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Do(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.ResolveMethod()).ToUnit();
}


public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
{
    return ObservableExt.ZipExecute(MethodCallValue, info, context, (MethodCallValueLambda, infoLambda, contextLambda) => MethodCallValueLambda.GetObjectData(infoLambda, contextLambda));
}


public static IObservable<System.Reactive.Unit> Init(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Do(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.Init()).ToUnit();
}


public static IObservable<System.Object> GetArg(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue, IObservable<System.Int32> argNum)
{
    return Observable.Zip(MethodCallValue, argNum, (MethodCallValueLambda, argNumLambda) => MethodCallValueLambda.GetArg(argNumLambda));
}


public static IObservable<System.String> GetArgName(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue, IObservable<System.Int32> index)
{
    return Observable.Zip(MethodCallValue, index, (MethodCallValueLambda, indexLambda) => MethodCallValueLambda.GetArgName(indexLambda));
}


public static IObservable<System.Object> GetInArg(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue, IObservable<System.Int32> argNum)
{
    return Observable.Zip(MethodCallValue, argNum, (MethodCallValueLambda, argNumLambda) => MethodCallValueLambda.GetInArg(argNumLambda));
}


public static IObservable<System.String> GetInArgName(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue, IObservable<System.Int32> index)
{
    return Observable.Zip(MethodCallValue, index, (MethodCallValueLambda, indexLambda) => MethodCallValueLambda.GetInArgName(indexLambda));
}


public static IObservable<System.Object> HeaderHandler(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue, IObservable<System.Runtime.Remoting.Messaging.Header[]> h)
{
    return Observable.Zip(MethodCallValue, h, (MethodCallValueLambda, hLambda) => MethodCallValueLambda.HeaderHandler(hLambda));
}


public static IObservable<System.Int32> get_ArgCount(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.ArgCount);
}


public static IObservable<System.Object[]> get_Args(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.Args);
}


public static IObservable<System.Int32> get_InArgCount(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.InArgCount);
}


public static IObservable<System.Object[]> get_InArgs(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.InArgs);
}


public static IObservable<System.String> get_MethodName(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.MethodName);
}


public static IObservable<System.String> get_TypeName(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.TypeName);
}


public static IObservable<System.Object> get_MethodSignature(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.MethodSignature);
}


public static IObservable<System.Reflection.MethodBase> get_MethodBase(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.MethodBase);
}


public static IObservable<System.String> get_Uri(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.Uri);
}


public static IObservable<System.Boolean> get_HasVarArgs(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.HasVarArgs);
}


public static IObservable<System.Collections.IDictionary> get_Properties(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.Properties);
}


public static IObservable<System.Runtime.Remoting.Messaging.LogicalCallContext> get_LogicalCallContext(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue)
{
    return Observable.Select(MethodCallValue, (MethodCallValueLambda) => MethodCallValueLambda.LogicalCallContext);
}


public static IObservable<System.Reactive.Unit> set_Uri(this IObservable<System.Runtime.Remoting.Messaging.MethodCall> MethodCallValue, IObservable<System.String> value)
{
    return ObservableExt.ZipExecute(MethodCallValue, value, (MethodCallValueLambda, valueLambda) => MethodCallValueLambda.Uri = valueLambda);
}

}
}