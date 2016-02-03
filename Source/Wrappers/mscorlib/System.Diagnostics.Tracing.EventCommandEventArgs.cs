using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Tracing
{
    public static class __EventCommandEventArgs
    {
        
        public static IObservable<System.Boolean> EnableEvent(this IObservable<System.Diagnostics.Tracing.EventCommandEventArgs> EventCommandEventArgsValue, IObservable<System.Int32> eventId)
        {
            return Observable.Zip(EventCommandEventArgsValue, eventId, (EventCommandEventArgsValueLambda, eventIdLambda) => EventCommandEventArgsValueLambda.EnableEvent(eventIdLambda));
        }


        public static IObservable<System.Boolean> DisableEvent(this IObservable<System.Diagnostics.Tracing.EventCommandEventArgs> EventCommandEventArgsValue, IObservable<System.Int32> eventId)
        {
            return Observable.Zip(EventCommandEventArgsValue, eventId, (EventCommandEventArgsValueLambda, eventIdLambda) => EventCommandEventArgsValueLambda.DisableEvent(eventIdLambda));
        }


        public static IObservable<System.Diagnostics.Tracing.EventCommand> get_Command(this IObservable<System.Diagnostics.Tracing.EventCommandEventArgs> EventCommandEventArgsValue)
        {
            return Observable.Select(EventCommandEventArgsValue, (EventCommandEventArgsValueLambda) => EventCommandEventArgsValueLambda.Command);
        }


        public static IObservable<System.Collections.Generic.IDictionary<System.String, System.String>> get_Arguments(this IObservable<System.Diagnostics.Tracing.EventCommandEventArgs> EventCommandEventArgsValue)
        {
            return Observable.Select(EventCommandEventArgsValue, (EventCommandEventArgsValueLambda) => EventCommandEventArgsValueLambda.Arguments);
        }

    }
}