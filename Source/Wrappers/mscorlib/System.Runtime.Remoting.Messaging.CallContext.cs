using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Remoting.Messaging
{
    public static class __CallContext
    {
        public static IObservable<System.Reactive.Unit> FreeNamedDataSlot(IObservable<System.String> name)
        {
            return
                Observable.Do(name,
                    (nameLambda) => System.Runtime.Remoting.Messaging.CallContext.FreeNamedDataSlot(nameLambda))
                    .ToUnit();
        }


        public static IObservable<System.Object> LogicalGetData(IObservable<System.String> name)
        {
            return Observable.Select(name,
                (nameLambda) => System.Runtime.Remoting.Messaging.CallContext.LogicalGetData(nameLambda));
        }


        public static IObservable<System.Object> GetData(IObservable<System.String> name)
        {
            return Observable.Select(name,
                (nameLambda) => System.Runtime.Remoting.Messaging.CallContext.GetData(nameLambda));
        }


        public static IObservable<System.Reactive.Unit> SetData(IObservable<System.String> name,
            IObservable<System.Object> data)
        {
            return ObservableExt.ZipExecute(name, data,
                (nameLambda, dataLambda) =>
                    System.Runtime.Remoting.Messaging.CallContext.SetData(nameLambda, dataLambda));
        }


        public static IObservable<System.Reactive.Unit> LogicalSetData(IObservable<System.String> name,
            IObservable<System.Object> data)
        {
            return ObservableExt.ZipExecute(name, data,
                (nameLambda, dataLambda) =>
                    System.Runtime.Remoting.Messaging.CallContext.LogicalSetData(nameLambda, dataLambda));
        }


        public static IObservable<System.Runtime.Remoting.Messaging.Header[]> GetHeaders()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Messaging.CallContext.GetHeaders());
        }


        public static IObservable<System.Reactive.Unit> SetHeaders(
            IObservable<System.Runtime.Remoting.Messaging.Header[]> headers)
        {
            return
                Observable.Do(headers,
                    (headersLambda) => System.Runtime.Remoting.Messaging.CallContext.SetHeaders(headersLambda)).ToUnit();
        }


        public static IObservable<System.Object> get_HostContext()
        {
            return ObservableExt.Factory(() => System.Runtime.Remoting.Messaging.CallContext.HostContext);
        }


        public static IObservable<System.Reactive.Unit> set_HostContext(IObservable<System.Object> value)
        {
            return
                Observable.Do(value,
                    (valueLambda) => System.Runtime.Remoting.Messaging.CallContext.HostContext = valueLambda).ToUnit();
        }
    }
}