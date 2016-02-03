using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __LocalBuilder
    {
        public static IObservable<System.Reactive.Unit> SetLocalSymInfo(
            this IObservable<System.Reflection.Emit.LocalBuilder> LocalBuilderValue, IObservable<System.String> name)
        {
            return ObservableExt.ZipExecute(LocalBuilderValue, name,
                (LocalBuilderValueLambda, nameLambda) => LocalBuilderValueLambda.SetLocalSymInfo(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> SetLocalSymInfo(
            this IObservable<System.Reflection.Emit.LocalBuilder> LocalBuilderValue, IObservable<System.String> name,
            IObservable<System.Int32> startOffset, IObservable<System.Int32> endOffset)
        {
            return ObservableExt.ZipExecute(LocalBuilderValue, name, startOffset, endOffset,
                (LocalBuilderValueLambda, nameLambda, startOffsetLambda, endOffsetLambda) =>
                    LocalBuilderValueLambda.SetLocalSymInfo(nameLambda, startOffsetLambda, endOffsetLambda));
        }


        public static IObservable<System.Boolean> get_IsPinned(
            this IObservable<System.Reflection.Emit.LocalBuilder> LocalBuilderValue)
        {
            return Observable.Select(LocalBuilderValue, (LocalBuilderValueLambda) => LocalBuilderValueLambda.IsPinned);
        }


        public static IObservable<System.Type> get_LocalType(
            this IObservable<System.Reflection.Emit.LocalBuilder> LocalBuilderValue)
        {
            return Observable.Select(LocalBuilderValue, (LocalBuilderValueLambda) => LocalBuilderValueLambda.LocalType);
        }


        public static IObservable<System.Int32> get_LocalIndex(
            this IObservable<System.Reflection.Emit.LocalBuilder> LocalBuilderValue)
        {
            return Observable.Select(LocalBuilderValue, (LocalBuilderValueLambda) => LocalBuilderValueLambda.LocalIndex);
        }
    }
}