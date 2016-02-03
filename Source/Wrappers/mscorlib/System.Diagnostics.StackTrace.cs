using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics
{
    public static class __StackTrace
    {
        public static IObservable<System.Diagnostics.StackFrame> GetFrame(
            this IObservable<System.Diagnostics.StackTrace> StackTraceValue, IObservable<System.Int32> index)
        {
            return Observable.Zip(StackTraceValue, index,
                (StackTraceValueLambda, indexLambda) => StackTraceValueLambda.GetFrame(indexLambda));
        }


        public static IObservable<System.Diagnostics.StackFrame[]> GetFrames(
            this IObservable<System.Diagnostics.StackTrace> StackTraceValue)
        {
            return Observable.Select(StackTraceValue, (StackTraceValueLambda) => StackTraceValueLambda.GetFrames());
        }


        public static IObservable<System.String> ToString(
            this IObservable<System.Diagnostics.StackTrace> StackTraceValue)
        {
            return Observable.Select(StackTraceValue, (StackTraceValueLambda) => StackTraceValueLambda.ToString());
        }


        public static IObservable<System.Int32> get_FrameCount(
            this IObservable<System.Diagnostics.StackTrace> StackTraceValue)
        {
            return Observable.Select(StackTraceValue, (StackTraceValueLambda) => StackTraceValueLambda.FrameCount);
        }
    }
}