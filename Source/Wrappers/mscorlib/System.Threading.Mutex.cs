using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __Mutex
    {
        public static IObservable<System.Threading.Mutex> OpenExisting(IObservable<System.String> name)
        {
            return Observable.Select(name, (nameLambda) => System.Threading.Mutex.OpenExisting(nameLambda));
        }


        public static IObservable<System.Threading.Mutex> OpenExisting(IObservable<System.String> name,
            IObservable<System.Security.AccessControl.MutexRights> rights)
        {
            return Observable.Zip(name, rights,
                (nameLambda, rightsLambda) => System.Threading.Mutex.OpenExisting(nameLambda, rightsLambda));
        }


        public static IObservable<Tuple<System.Boolean, System.Threading.Mutex>> TryOpenExisting(
            IObservable<System.String> name)
        {
            return Observable.Select(name, (nameLambda) =>
            {
                System.Threading.Mutex resultOutput = default(System.Threading.Mutex);
                var result = System.Threading.Mutex.TryOpenExisting(nameLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<Tuple<System.Boolean, System.Threading.Mutex>> TryOpenExisting(
            IObservable<System.String> name, IObservable<System.Security.AccessControl.MutexRights> rights)
        {
            return Observable.Zip(name, rights, (nameLambda, rightsLambda) =>
            {
                System.Threading.Mutex resultOutput = default(System.Threading.Mutex);
                var result = System.Threading.Mutex.TryOpenExisting(nameLambda, rightsLambda, out resultOutput);
                return Tuple.Create(result, resultOutput);
            });
        }


        public static IObservable<System.Reactive.Unit> ReleaseMutex(this IObservable<System.Threading.Mutex> MutexValue)
        {
            return Observable.Do(MutexValue, (MutexValueLambda) => MutexValueLambda.ReleaseMutex()).ToUnit();
        }


        public static IObservable<System.Security.AccessControl.MutexSecurity> GetAccessControl(
            this IObservable<System.Threading.Mutex> MutexValue)
        {
            return Observable.Select(MutexValue, (MutexValueLambda) => MutexValueLambda.GetAccessControl());
        }


        public static IObservable<System.Reactive.Unit> SetAccessControl(
            this IObservable<System.Threading.Mutex> MutexValue,
            IObservable<System.Security.AccessControl.MutexSecurity> mutexSecurity)
        {
            return ObservableExt.ZipExecute(MutexValue, mutexSecurity,
                (MutexValueLambda, mutexSecurityLambda) => MutexValueLambda.SetAccessControl(mutexSecurityLambda));
        }
    }
}