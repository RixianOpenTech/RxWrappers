using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Tracing
{
    public static class __EventListener
    {
        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.Diagnostics.Tracing.EventListener> EventListenerValue)
        {
            return
                Observable.Do(EventListenerValue, (EventListenerValueLambda) => EventListenerValueLambda.Dispose())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> EnableEvents(
            this IObservable<System.Diagnostics.Tracing.EventListener> EventListenerValue,
            IObservable<System.Diagnostics.Tracing.EventSource> eventSource,
            IObservable<System.Diagnostics.Tracing.EventLevel> level)
        {
            return ObservableExt.ZipExecute(EventListenerValue, eventSource, level,
                (EventListenerValueLambda, eventSourceLambda, levelLambda) =>
                    EventListenerValueLambda.EnableEvents(eventSourceLambda, levelLambda));
        }


        public static IObservable<System.Reactive.Unit> EnableEvents(
            this IObservable<System.Diagnostics.Tracing.EventListener> EventListenerValue,
            IObservable<System.Diagnostics.Tracing.EventSource> eventSource,
            IObservable<System.Diagnostics.Tracing.EventLevel> level,
            IObservable<System.Diagnostics.Tracing.EventKeywords> matchAnyKeyword)
        {
            return ObservableExt.ZipExecute(EventListenerValue, eventSource, level, matchAnyKeyword,
                (EventListenerValueLambda, eventSourceLambda, levelLambda, matchAnyKeywordLambda) =>
                    EventListenerValueLambda.EnableEvents(eventSourceLambda, levelLambda, matchAnyKeywordLambda));
        }


        public static IObservable<System.Reactive.Unit> EnableEvents(
            this IObservable<System.Diagnostics.Tracing.EventListener> EventListenerValue,
            IObservable<System.Diagnostics.Tracing.EventSource> eventSource,
            IObservable<System.Diagnostics.Tracing.EventLevel> level,
            IObservable<System.Diagnostics.Tracing.EventKeywords> matchAnyKeyword,
            IObservable<System.Collections.Generic.IDictionary<System.String, System.String>> arguments)
        {
            return ObservableExt.ZipExecute(EventListenerValue, eventSource, level, matchAnyKeyword, arguments,
                (EventListenerValueLambda, eventSourceLambda, levelLambda, matchAnyKeywordLambda, argumentsLambda) =>
                    EventListenerValueLambda.EnableEvents(eventSourceLambda, levelLambda, matchAnyKeywordLambda,
                        argumentsLambda));
        }


        public static IObservable<System.Reactive.Unit> DisableEvents(
            this IObservable<System.Diagnostics.Tracing.EventListener> EventListenerValue,
            IObservable<System.Diagnostics.Tracing.EventSource> eventSource)
        {
            return ObservableExt.ZipExecute(EventListenerValue, eventSource,
                (EventListenerValueLambda, eventSourceLambda) =>
                    EventListenerValueLambda.DisableEvents(eventSourceLambda));
        }
    }
}