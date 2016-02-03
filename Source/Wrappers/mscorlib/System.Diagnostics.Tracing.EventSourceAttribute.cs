using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Tracing
{
    public static class __EventSourceAttribute
    {
        
        public static IObservable<System.String> get_Name(this IObservable<System.Diagnostics.Tracing.EventSourceAttribute> EventSourceAttributeValue)
        {
            return Observable.Select(EventSourceAttributeValue, (EventSourceAttributeValueLambda) => EventSourceAttributeValueLambda.Name);
        }


        public static IObservable<System.String> get_Guid(this IObservable<System.Diagnostics.Tracing.EventSourceAttribute> EventSourceAttributeValue)
        {
            return Observable.Select(EventSourceAttributeValue, (EventSourceAttributeValueLambda) => EventSourceAttributeValueLambda.Guid);
        }


        public static IObservable<System.String> get_LocalizationResources(this IObservable<System.Diagnostics.Tracing.EventSourceAttribute> EventSourceAttributeValue)
        {
            return Observable.Select(EventSourceAttributeValue, (EventSourceAttributeValueLambda) => EventSourceAttributeValueLambda.LocalizationResources);
        }


        public static IObservable<System.Reactive.Unit> set_Name(this IObservable<System.Diagnostics.Tracing.EventSourceAttribute> EventSourceAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(EventSourceAttributeValue, value, (EventSourceAttributeValueLambda, valueLambda) => EventSourceAttributeValueLambda.Name = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Guid(this IObservable<System.Diagnostics.Tracing.EventSourceAttribute> EventSourceAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(EventSourceAttributeValue, value, (EventSourceAttributeValueLambda, valueLambda) => EventSourceAttributeValueLambda.Guid = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_LocalizationResources(this IObservable<System.Diagnostics.Tracing.EventSourceAttribute> EventSourceAttributeValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(EventSourceAttributeValue, value, (EventSourceAttributeValueLambda, valueLambda) => EventSourceAttributeValueLambda.LocalizationResources = valueLambda);
        }

    }
}