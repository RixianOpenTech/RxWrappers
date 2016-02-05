using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __DiagnosticsTraceWriter
    {
        
        public static IObservable<System.Reactive.Unit> Trace(this IObservable<Newtonsoft.Json.Serialization.DiagnosticsTraceWriter> DiagnosticsTraceWriterValue, IObservable<System.Diagnostics.TraceLevel> level, IObservable<System.String> message, IObservable<System.Exception> ex)
        {
            return ObservableExt.ZipExecute(DiagnosticsTraceWriterValue, level, message, ex, (DiagnosticsTraceWriterValueLambda, levelLambda, messageLambda, exLambda) => DiagnosticsTraceWriterValueLambda.Trace(levelLambda, messageLambda, exLambda));
        }


        public static IObservable<System.Diagnostics.TraceLevel> get_LevelFilter(this IObservable<Newtonsoft.Json.Serialization.DiagnosticsTraceWriter> DiagnosticsTraceWriterValue)
        {
            return Observable.Select(DiagnosticsTraceWriterValue, (DiagnosticsTraceWriterValueLambda) => DiagnosticsTraceWriterValueLambda.LevelFilter);
        }


        public static IObservable<System.Reactive.Unit> set_LevelFilter(this IObservable<Newtonsoft.Json.Serialization.DiagnosticsTraceWriter> DiagnosticsTraceWriterValue, IObservable<System.Diagnostics.TraceLevel> value)
        {
            return ObservableExt.ZipExecute(DiagnosticsTraceWriterValue, value, (DiagnosticsTraceWriterValueLambda, valueLambda) => DiagnosticsTraceWriterValueLambda.LevelFilter = valueLambda);
        }

    }
}