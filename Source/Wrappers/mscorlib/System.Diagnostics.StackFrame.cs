using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics
{
public static class _StackFrame
{
    
public static IObservable<System.Reflection.MethodBase> GetMethod(this IObservable<System.Diagnostics.StackFrame> StackFrameValue)
{
    return Observable.Select(StackFrameValue, (StackFrameValueLambda) => StackFrameValueLambda.GetMethod());
}


public static IObservable<System.Int32> GetNativeOffset(this IObservable<System.Diagnostics.StackFrame> StackFrameValue)
{
    return Observable.Select(StackFrameValue, (StackFrameValueLambda) => StackFrameValueLambda.GetNativeOffset());
}


public static IObservable<System.Int32> GetILOffset(this IObservable<System.Diagnostics.StackFrame> StackFrameValue)
{
    return Observable.Select(StackFrameValue, (StackFrameValueLambda) => StackFrameValueLambda.GetILOffset());
}


public static IObservable<System.String> GetFileName(this IObservable<System.Diagnostics.StackFrame> StackFrameValue)
{
    return Observable.Select(StackFrameValue, (StackFrameValueLambda) => StackFrameValueLambda.GetFileName());
}


public static IObservable<System.Int32> GetFileLineNumber(this IObservable<System.Diagnostics.StackFrame> StackFrameValue)
{
    return Observable.Select(StackFrameValue, (StackFrameValueLambda) => StackFrameValueLambda.GetFileLineNumber());
}


public static IObservable<System.Int32> GetFileColumnNumber(this IObservable<System.Diagnostics.StackFrame> StackFrameValue)
{
    return Observable.Select(StackFrameValue, (StackFrameValueLambda) => StackFrameValueLambda.GetFileColumnNumber());
}


public static IObservable<System.String> ToString(this IObservable<System.Diagnostics.StackFrame> StackFrameValue)
{
    return Observable.Select(StackFrameValue, (StackFrameValueLambda) => StackFrameValueLambda.ToString());
}

}
}