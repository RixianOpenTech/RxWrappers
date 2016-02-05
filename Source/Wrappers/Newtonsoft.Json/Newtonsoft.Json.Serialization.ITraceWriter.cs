using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __ITraceWriter
    {
        
        public static IObservable<System.Reactive.Unit> Trace(this IObservable<Newtonsoft.Json.Serialization.ITraceWriter> ITraceWriterValue, IObservable<System.Diagnostics.TraceLevel> level, IObservable<System.String> message, IObservable<System.Exception> ex)
        {
            return ObservableExt.ZipExecute(ITraceWriterValue, level, message, ex, (ITraceWriterValueLambda, levelLambda, messageLambda, exLambda) => ITraceWriterValueLambda.Trace(levelLambda, messageLambda, exLambda));
        }


        public static IObservable<System.Diagnostics.TraceLevel> get_LevelFilter(this IObservable<Newtonsoft.Json.Serialization.ITraceWriter> ITraceWriterValue)
        {
            return Observable.Select(ITraceWriterValue, (ITraceWriterValueLambda) => ITraceWriterValueLambda.LevelFilter);
        }

    }
}