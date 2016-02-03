using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __EventWaitHandle
    {
        
        public static IObservable<System.Threading.EventWaitHandle> OpenExisting(IObservable<System.String> name)
        {
            return Observable.Select(name, (nameLambda) => System.Threading.EventWaitHandle.OpenExisting(nameLambda));
        }


        public static IObservable<System.Threading.EventWaitHandle> OpenExisting(IObservable<System.String> name, IObservable<System.Security.AccessControl.EventWaitHandleRights> rights)
        {
            return Observable.Zip(name, rights, (nameLambda, rightsLambda) => System.Threading.EventWaitHandle.OpenExisting(nameLambda, rightsLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Threading.EventWaitHandle>> TryOpenExisting(IObservable<System.String> name)
        {
            return Observable.Select(name, (nameLambda) => {
System.Threading.EventWaitHandle resultOutput = default(System.Threading.EventWaitHandle);
var result = System.Threading.EventWaitHandle.TryOpenExisting(nameLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<Tuple<System.Boolean, System.Threading.EventWaitHandle>> TryOpenExisting(IObservable<System.String> name, IObservable<System.Security.AccessControl.EventWaitHandleRights> rights)
        {
            return Observable.Zip(name, rights, (nameLambda, rightsLambda) => {
System.Threading.EventWaitHandle resultOutput = default(System.Threading.EventWaitHandle);
var result = System.Threading.EventWaitHandle.TryOpenExisting(nameLambda, rightsLambda, out resultOutput);
return Tuple.Create(result, resultOutput);
});
        }


        public static IObservable<System.Boolean> Reset(this IObservable<System.Threading.EventWaitHandle> EventWaitHandleValue)
        {
            return Observable.Select(EventWaitHandleValue, (EventWaitHandleValueLambda) => EventWaitHandleValueLambda.Reset());
        }


        public static IObservable<System.Boolean> Set(this IObservable<System.Threading.EventWaitHandle> EventWaitHandleValue)
        {
            return Observable.Select(EventWaitHandleValue, (EventWaitHandleValueLambda) => EventWaitHandleValueLambda.Set());
        }


        public static IObservable<System.Security.AccessControl.EventWaitHandleSecurity> GetAccessControl(this IObservable<System.Threading.EventWaitHandle> EventWaitHandleValue)
        {
            return Observable.Select(EventWaitHandleValue, (EventWaitHandleValueLambda) => EventWaitHandleValueLambda.GetAccessControl());
        }


        public static IObservable<System.Reactive.Unit> SetAccessControl(this IObservable<System.Threading.EventWaitHandle> EventWaitHandleValue, IObservable<System.Security.AccessControl.EventWaitHandleSecurity> eventSecurity)
        {
            return ObservableExt.ZipExecute(EventWaitHandleValue, eventSecurity, (EventWaitHandleValueLambda, eventSecurityLambda) => EventWaitHandleValueLambda.SetAccessControl(eventSecurityLambda));
        }

    }
}