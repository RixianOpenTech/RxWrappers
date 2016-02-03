using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.Tracing
{
    public static class __EventDataAttribute
    {
        public static IObservable<System.String> get_Name(
            this IObservable<System.Diagnostics.Tracing.EventDataAttribute> EventDataAttributeValue)
        {
            return Observable.Select(EventDataAttributeValue,
                (EventDataAttributeValueLambda) => EventDataAttributeValueLambda.Name);
        }


        public static IObservable<System.Reactive.Unit> set_Name(
            this IObservable<System.Diagnostics.Tracing.EventDataAttribute> EventDataAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(EventDataAttributeValue, value,
                (EventDataAttributeValueLambda, valueLambda) => EventDataAttributeValueLambda.Name = valueLambda);
        }
    }
}