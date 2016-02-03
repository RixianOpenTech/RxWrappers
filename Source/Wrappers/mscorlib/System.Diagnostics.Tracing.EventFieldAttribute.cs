using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Tracing
{
    public static class __EventFieldAttribute
    {
        public static IObservable<System.Diagnostics.Tracing.EventFieldTags> get_Tags(
            this IObservable<System.Diagnostics.Tracing.EventFieldAttribute> EventFieldAttributeValue)
        {
            return Observable.Select(EventFieldAttributeValue,
                (EventFieldAttributeValueLambda) => EventFieldAttributeValueLambda.Tags);
        }


        public static IObservable<System.Diagnostics.Tracing.EventFieldFormat> get_Format(
            this IObservable<System.Diagnostics.Tracing.EventFieldAttribute> EventFieldAttributeValue)
        {
            return Observable.Select(EventFieldAttributeValue,
                (EventFieldAttributeValueLambda) => EventFieldAttributeValueLambda.Format);
        }


        public static IObservable<System.Reactive.Unit> set_Tags(
            this IObservable<System.Diagnostics.Tracing.EventFieldAttribute> EventFieldAttributeValue,
            IObservable<System.Diagnostics.Tracing.EventFieldTags> value)
        {
            return ObservableExt.ZipExecute(EventFieldAttributeValue, value,
                (EventFieldAttributeValueLambda, valueLambda) => EventFieldAttributeValueLambda.Tags = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Format(
            this IObservable<System.Diagnostics.Tracing.EventFieldAttribute> EventFieldAttributeValue,
            IObservable<System.Diagnostics.Tracing.EventFieldFormat> value)
        {
            return ObservableExt.ZipExecute(EventFieldAttributeValue, value,
                (EventFieldAttributeValueLambda, valueLambda) => EventFieldAttributeValueLambda.Format = valueLambda);
        }
    }
}