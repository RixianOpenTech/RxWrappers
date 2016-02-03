using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    public static class __EventRegistrationTokenTable1
    {
        public static IObservable<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> AddEventHandler
            <T>(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>>
                EventRegistrationTokenTableValue, IObservable<T> handler) where T : class
        {
            return Observable.Zip(EventRegistrationTokenTableValue, handler,
                (EventRegistrationTokenTableValueLambda, handlerLambda) =>
                    EventRegistrationTokenTableValueLambda.AddEventHandler(handlerLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveEventHandler<T>(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>>
                EventRegistrationTokenTableValue,
            IObservable<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> token) where T : class
        {
            return ObservableExt.ZipExecute(EventRegistrationTokenTableValue, token,
                (EventRegistrationTokenTableValueLambda, tokenLambda) =>
                    EventRegistrationTokenTableValueLambda.RemoveEventHandler(tokenLambda));
        }


        public static IObservable<System.Reactive.Unit> RemoveEventHandler<T>(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>>
                EventRegistrationTokenTableValue, IObservable<T> handler) where T : class
        {
            return ObservableExt.ZipExecute(EventRegistrationTokenTableValue, handler,
                (EventRegistrationTokenTableValueLambda, handlerLambda) =>
                    EventRegistrationTokenTableValueLambda.RemoveEventHandler(handlerLambda));
        }


        public static
            IObservable
                <
                    Tuple
                        <System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>,
                            System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>>>
            GetOrCreateEventRegistrationTokenTable<T>(
            IObservable<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>> refEventTable)
            where T : class
        {
            return Observable.Select(refEventTable, (refEventTableLambda) =>
            {
                var result =
                    System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>
                        .GetOrCreateEventRegistrationTokenTable(ref refEventTableLambda);
                return Tuple.Create(result, refEventTableLambda);
            });
        }


        public static IObservable<T> get_InvocationList<T>(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>>
                EventRegistrationTokenTableValue) where T : class
        {
            return Observable.Select(EventRegistrationTokenTableValue,
                (EventRegistrationTokenTableValueLambda) => EventRegistrationTokenTableValueLambda.InvocationList);
        }


        public static IObservable<System.Reactive.Unit> set_InvocationList<T>(
            this IObservable<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>>
                EventRegistrationTokenTableValue, IObservable<T> value) where T : class
        {
            return ObservableExt.ZipExecute(EventRegistrationTokenTableValue, value,
                (EventRegistrationTokenTableValueLambda, valueLambda) =>
                    EventRegistrationTokenTableValueLambda.InvocationList = valueLambda);
        }
    }
}