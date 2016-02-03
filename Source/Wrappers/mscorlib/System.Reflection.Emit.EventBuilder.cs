using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __EventBuilder
    {
        
        public static IObservable<System.Reflection.Emit.EventToken> GetEventToken(this IObservable<System.Reflection.Emit.EventBuilder> EventBuilderValue)
        {
            return Observable.Select(EventBuilderValue, (EventBuilderValueLambda) => EventBuilderValueLambda.GetEventToken());
        }


        public static IObservable<System.Reactive.Unit> SetAddOnMethod(this IObservable<System.Reflection.Emit.EventBuilder> EventBuilderValue, IObservable<System.Reflection.Emit.MethodBuilder> mdBuilder)
        {
            return ObservableExt.ZipExecute(EventBuilderValue, mdBuilder, (EventBuilderValueLambda, mdBuilderLambda) => EventBuilderValueLambda.SetAddOnMethod(mdBuilderLambda));
        }


        public static IObservable<System.Reactive.Unit> SetRemoveOnMethod(this IObservable<System.Reflection.Emit.EventBuilder> EventBuilderValue, IObservable<System.Reflection.Emit.MethodBuilder> mdBuilder)
        {
            return ObservableExt.ZipExecute(EventBuilderValue, mdBuilder, (EventBuilderValueLambda, mdBuilderLambda) => EventBuilderValueLambda.SetRemoveOnMethod(mdBuilderLambda));
        }


        public static IObservable<System.Reactive.Unit> SetRaiseMethod(this IObservable<System.Reflection.Emit.EventBuilder> EventBuilderValue, IObservable<System.Reflection.Emit.MethodBuilder> mdBuilder)
        {
            return ObservableExt.ZipExecute(EventBuilderValue, mdBuilder, (EventBuilderValueLambda, mdBuilderLambda) => EventBuilderValueLambda.SetRaiseMethod(mdBuilderLambda));
        }


        public static IObservable<System.Reactive.Unit> AddOtherMethod(this IObservable<System.Reflection.Emit.EventBuilder> EventBuilderValue, IObservable<System.Reflection.Emit.MethodBuilder> mdBuilder)
        {
            return ObservableExt.ZipExecute(EventBuilderValue, mdBuilder, (EventBuilderValueLambda, mdBuilderLambda) => EventBuilderValueLambda.AddOtherMethod(mdBuilderLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.EventBuilder> EventBuilderValue, IObservable<System.Reflection.ConstructorInfo> con, IObservable<System.Byte[]> binaryAttribute)
        {
            return ObservableExt.ZipExecute(EventBuilderValue, con, binaryAttribute, (EventBuilderValueLambda, conLambda, binaryAttributeLambda) => EventBuilderValueLambda.SetCustomAttribute(conLambda, binaryAttributeLambda));
        }


        public static IObservable<System.Reactive.Unit> SetCustomAttribute(this IObservable<System.Reflection.Emit.EventBuilder> EventBuilderValue, IObservable<System.Reflection.Emit.CustomAttributeBuilder> customBuilder)
        {
            return ObservableExt.ZipExecute(EventBuilderValue, customBuilder, (EventBuilderValueLambda, customBuilderLambda) => EventBuilderValueLambda.SetCustomAttribute(customBuilderLambda));
        }

    }
}