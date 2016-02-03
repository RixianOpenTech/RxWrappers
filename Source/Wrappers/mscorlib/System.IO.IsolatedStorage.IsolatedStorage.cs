using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO.IsolatedStorage
{
    public static class __IsolatedStorage
    {
        public static IObservable<System.Boolean> IncreaseQuotaTo(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue,
            IObservable<System.Int64> newQuotaSize)
        {
            return Observable.Zip(IsolatedStorageValue, newQuotaSize,
                (IsolatedStorageValueLambda, newQuotaSizeLambda) =>
                    IsolatedStorageValueLambda.IncreaseQuotaTo(newQuotaSizeLambda));
        }


        public static IObservable<System.Reactive.Unit> Remove(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue)
        {
            return
                Observable.Do(IsolatedStorageValue, (IsolatedStorageValueLambda) => IsolatedStorageValueLambda.Remove())
                    .ToUnit();
        }


        public static IObservable<System.UInt64> get_MaximumSize(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue)
        {
            return Observable.Select(IsolatedStorageValue,
                (IsolatedStorageValueLambda) => IsolatedStorageValueLambda.MaximumSize);
        }


        public static IObservable<System.UInt64> get_CurrentSize(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue)
        {
            return Observable.Select(IsolatedStorageValue,
                (IsolatedStorageValueLambda) => IsolatedStorageValueLambda.CurrentSize);
        }


        public static IObservable<System.Int64> get_UsedSize(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue)
        {
            return Observable.Select(IsolatedStorageValue,
                (IsolatedStorageValueLambda) => IsolatedStorageValueLambda.UsedSize);
        }


        public static IObservable<System.Int64> get_Quota(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue)
        {
            return Observable.Select(IsolatedStorageValue,
                (IsolatedStorageValueLambda) => IsolatedStorageValueLambda.Quota);
        }


        public static IObservable<System.Int64> get_AvailableFreeSpace(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue)
        {
            return Observable.Select(IsolatedStorageValue,
                (IsolatedStorageValueLambda) => IsolatedStorageValueLambda.AvailableFreeSpace);
        }


        public static IObservable<System.Object> get_DomainIdentity(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue)
        {
            return Observable.Select(IsolatedStorageValue,
                (IsolatedStorageValueLambda) => IsolatedStorageValueLambda.DomainIdentity);
        }


        public static IObservable<System.Object> get_ApplicationIdentity(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue)
        {
            return Observable.Select(IsolatedStorageValue,
                (IsolatedStorageValueLambda) => IsolatedStorageValueLambda.ApplicationIdentity);
        }


        public static IObservable<System.Object> get_AssemblyIdentity(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue)
        {
            return Observable.Select(IsolatedStorageValue,
                (IsolatedStorageValueLambda) => IsolatedStorageValueLambda.AssemblyIdentity);
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageScope> get_Scope(
            this IObservable<System.IO.IsolatedStorage.IsolatedStorage> IsolatedStorageValue)
        {
            return Observable.Select(IsolatedStorageValue,
                (IsolatedStorageValueLambda) => IsolatedStorageValueLambda.Scope);
        }
    }
}