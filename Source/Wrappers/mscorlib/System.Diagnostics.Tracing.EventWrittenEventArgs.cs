using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Tracing
{
    public static class __EventWrittenEventArgs
    {
        
        public static IObservable<System.String> get_EventName(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.EventName);
        }


        public static IObservable<System.Int32> get_EventId(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.EventId);
        }


        public static IObservable<System.Guid> get_ActivityId(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.ActivityId);
        }


        public static IObservable<System.Guid> get_RelatedActivityId(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.RelatedActivityId);
        }


        public static IObservable<System.Collections.ObjectModel.ReadOnlyCollection<System.Object>> get_Payload(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.Payload);
        }


        public static IObservable<System.Collections.ObjectModel.ReadOnlyCollection<System.String>> get_PayloadNames(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.PayloadNames);
        }


        public static IObservable<System.Diagnostics.Tracing.EventSource> get_EventSource(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.EventSource);
        }


        public static IObservable<System.Diagnostics.Tracing.EventKeywords> get_Keywords(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.Keywords);
        }


        public static IObservable<System.Diagnostics.Tracing.EventOpcode> get_Opcode(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.Opcode);
        }


        public static IObservable<System.Diagnostics.Tracing.EventTask> get_Task(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.Task);
        }


        public static IObservable<System.Diagnostics.Tracing.EventTags> get_Tags(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.Tags);
        }


        public static IObservable<System.String> get_Message(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.Message);
        }


        public static IObservable<System.Diagnostics.Tracing.EventChannel> get_Channel(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.Channel);
        }


        public static IObservable<System.Byte> get_Version(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.Version);
        }


        public static IObservable<System.Diagnostics.Tracing.EventLevel> get_Level(this IObservable<System.Diagnostics.Tracing.EventWrittenEventArgs> EventWrittenEventArgsValue)
        {
            return Observable.Select(EventWrittenEventArgsValue, (EventWrittenEventArgsValueLambda) => EventWrittenEventArgsValueLambda.Level);
        }

    }
}