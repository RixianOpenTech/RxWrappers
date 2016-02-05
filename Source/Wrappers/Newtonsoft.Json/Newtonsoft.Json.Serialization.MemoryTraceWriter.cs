using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __MemoryTraceWriter
    {
        
        public static IObservable<System.Reactive.Unit> Trace(this IObservable<Newtonsoft.Json.Serialization.MemoryTraceWriter> MemoryTraceWriterValue, IObservable<System.Diagnostics.TraceLevel> level, IObservable<System.String> message, IObservable<System.Exception> ex)
        {
            return ObservableExt.ZipExecute(MemoryTraceWriterValue, level, message, ex, (MemoryTraceWriterValueLambda, levelLambda, messageLambda, exLambda) => MemoryTraceWriterValueLambda.Trace(levelLambda, messageLambda, exLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerable<System.String>> GetTraceMessages(this IObservable<Newtonsoft.Json.Serialization.MemoryTraceWriter> MemoryTraceWriterValue)
        {
            return Observable.Select(MemoryTraceWriterValue, (MemoryTraceWriterValueLambda) => MemoryTraceWriterValueLambda.GetTraceMessages());
        }


        public static IObservable<System.String> ToString(this IObservable<Newtonsoft.Json.Serialization.MemoryTraceWriter> MemoryTraceWriterValue)
        {
            return Observable.Select(MemoryTraceWriterValue, (MemoryTraceWriterValueLambda) => MemoryTraceWriterValueLambda.ToString());
        }


        public static IObservable<System.Diagnostics.TraceLevel> get_LevelFilter(this IObservable<Newtonsoft.Json.Serialization.MemoryTraceWriter> MemoryTraceWriterValue)
        {
            return Observable.Select(MemoryTraceWriterValue, (MemoryTraceWriterValueLambda) => MemoryTraceWriterValueLambda.LevelFilter);
        }


        public static IObservable<System.Reactive.Unit> set_LevelFilter(this IObservable<Newtonsoft.Json.Serialization.MemoryTraceWriter> MemoryTraceWriterValue, IObservable<System.Diagnostics.TraceLevel> value)
        {
            return ObservableExt.ZipExecute(MemoryTraceWriterValue, value, (MemoryTraceWriterValueLambda, valueLambda) => MemoryTraceWriterValueLambda.LevelFilter = valueLambda);
        }

    }
}