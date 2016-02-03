using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Tracing
{
    public static class __EventAttribute
    {
        public static IObservable<System.Int32> get_EventId(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue)
        {
            return Observable.Select(EventAttributeValue,
                (EventAttributeValueLambda) => EventAttributeValueLambda.EventId);
        }


        public static IObservable<System.Diagnostics.Tracing.EventLevel> get_Level(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue)
        {
            return Observable.Select(EventAttributeValue, (EventAttributeValueLambda) => EventAttributeValueLambda.Level);
        }


        public static IObservable<System.Diagnostics.Tracing.EventKeywords> get_Keywords(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue)
        {
            return Observable.Select(EventAttributeValue,
                (EventAttributeValueLambda) => EventAttributeValueLambda.Keywords);
        }


        public static IObservable<System.Diagnostics.Tracing.EventOpcode> get_Opcode(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue)
        {
            return Observable.Select(EventAttributeValue,
                (EventAttributeValueLambda) => EventAttributeValueLambda.Opcode);
        }


        public static IObservable<System.Diagnostics.Tracing.EventTask> get_Task(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue)
        {
            return Observable.Select(EventAttributeValue, (EventAttributeValueLambda) => EventAttributeValueLambda.Task);
        }


        public static IObservable<System.Diagnostics.Tracing.EventChannel> get_Channel(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue)
        {
            return Observable.Select(EventAttributeValue,
                (EventAttributeValueLambda) => EventAttributeValueLambda.Channel);
        }


        public static IObservable<System.Byte> get_Version(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue)
        {
            return Observable.Select(EventAttributeValue,
                (EventAttributeValueLambda) => EventAttributeValueLambda.Version);
        }


        public static IObservable<System.String> get_Message(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue)
        {
            return Observable.Select(EventAttributeValue,
                (EventAttributeValueLambda) => EventAttributeValueLambda.Message);
        }


        public static IObservable<System.Diagnostics.Tracing.EventTags> get_Tags(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue)
        {
            return Observable.Select(EventAttributeValue, (EventAttributeValueLambda) => EventAttributeValueLambda.Tags);
        }


        public static IObservable<System.Diagnostics.Tracing.EventActivityOptions> get_ActivityOptions(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue)
        {
            return Observable.Select(EventAttributeValue,
                (EventAttributeValueLambda) => EventAttributeValueLambda.ActivityOptions);
        }


        public static IObservable<System.Reactive.Unit> set_Level(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue,
            IObservable<System.Diagnostics.Tracing.EventLevel> value)
        {
            return ObservableExt.ZipExecute(EventAttributeValue, value,
                (EventAttributeValueLambda, valueLambda) => EventAttributeValueLambda.Level = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Keywords(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue,
            IObservable<System.Diagnostics.Tracing.EventKeywords> value)
        {
            return ObservableExt.ZipExecute(EventAttributeValue, value,
                (EventAttributeValueLambda, valueLambda) => EventAttributeValueLambda.Keywords = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Opcode(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue,
            IObservable<System.Diagnostics.Tracing.EventOpcode> value)
        {
            return ObservableExt.ZipExecute(EventAttributeValue, value,
                (EventAttributeValueLambda, valueLambda) => EventAttributeValueLambda.Opcode = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Task(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue,
            IObservable<System.Diagnostics.Tracing.EventTask> value)
        {
            return ObservableExt.ZipExecute(EventAttributeValue, value,
                (EventAttributeValueLambda, valueLambda) => EventAttributeValueLambda.Task = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Channel(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue,
            IObservable<System.Diagnostics.Tracing.EventChannel> value)
        {
            return ObservableExt.ZipExecute(EventAttributeValue, value,
                (EventAttributeValueLambda, valueLambda) => EventAttributeValueLambda.Channel = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Version(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue,
            IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(EventAttributeValue, value,
                (EventAttributeValueLambda, valueLambda) => EventAttributeValueLambda.Version = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Message(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(EventAttributeValue, value,
                (EventAttributeValueLambda, valueLambda) => EventAttributeValueLambda.Message = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Tags(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue,
            IObservable<System.Diagnostics.Tracing.EventTags> value)
        {
            return ObservableExt.ZipExecute(EventAttributeValue, value,
                (EventAttributeValueLambda, valueLambda) => EventAttributeValueLambda.Tags = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_ActivityOptions(
            this IObservable<System.Diagnostics.Tracing.EventAttribute> EventAttributeValue,
            IObservable<System.Diagnostics.Tracing.EventActivityOptions> value)
        {
            return ObservableExt.ZipExecute(EventAttributeValue, value,
                (EventAttributeValueLambda, valueLambda) => EventAttributeValueLambda.ActivityOptions = valueLambda);
        }
    }
}