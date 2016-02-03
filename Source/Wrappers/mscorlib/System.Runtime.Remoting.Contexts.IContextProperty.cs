using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Contexts
{
    public static class __IContextProperty
    {
        public static IObservable<System.Boolean> IsNewContextOK(
            this IObservable<System.Runtime.Remoting.Contexts.IContextProperty> IContextPropertyValue,
            IObservable<System.Runtime.Remoting.Contexts.Context> newCtx)
        {
            return Observable.Zip(IContextPropertyValue, newCtx,
                (IContextPropertyValueLambda, newCtxLambda) => IContextPropertyValueLambda.IsNewContextOK(newCtxLambda));
        }


        public static IObservable<System.Reactive.Unit> Freeze(
            this IObservable<System.Runtime.Remoting.Contexts.IContextProperty> IContextPropertyValue,
            IObservable<System.Runtime.Remoting.Contexts.Context> newContext)
        {
            return ObservableExt.ZipExecute(IContextPropertyValue, newContext,
                (IContextPropertyValueLambda, newContextLambda) => IContextPropertyValueLambda.Freeze(newContextLambda));
        }


        public static IObservable<System.String> get_Name(
            this IObservable<System.Runtime.Remoting.Contexts.IContextProperty> IContextPropertyValue)
        {
            return Observable.Select(IContextPropertyValue,
                (IContextPropertyValueLambda) => IContextPropertyValueLambda.Name);
        }
    }
}