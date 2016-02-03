using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO.IsolatedStorage
{
    public static class __IsolatedStorageSecurityState
    {
        
        public static IObservable<System.Reactive.Unit> EnsureState(this IObservable<System.IO.IsolatedStorage.IsolatedStorageSecurityState> IsolatedStorageSecurityStateValue)
        {
            return Observable.Do(IsolatedStorageSecurityStateValue, (IsolatedStorageSecurityStateValueLambda) => IsolatedStorageSecurityStateValueLambda.EnsureState()).ToUnit();
        }


        public static IObservable<System.IO.IsolatedStorage.IsolatedStorageSecurityOptions> get_Options(this IObservable<System.IO.IsolatedStorage.IsolatedStorageSecurityState> IsolatedStorageSecurityStateValue)
        {
            return Observable.Select(IsolatedStorageSecurityStateValue, (IsolatedStorageSecurityStateValueLambda) => IsolatedStorageSecurityStateValueLambda.Options);
        }


        public static IObservable<System.Int64> get_UsedSize(this IObservable<System.IO.IsolatedStorage.IsolatedStorageSecurityState> IsolatedStorageSecurityStateValue)
        {
            return Observable.Select(IsolatedStorageSecurityStateValue, (IsolatedStorageSecurityStateValueLambda) => IsolatedStorageSecurityStateValueLambda.UsedSize);
        }


        public static IObservable<System.Int64> get_Quota(this IObservable<System.IO.IsolatedStorage.IsolatedStorageSecurityState> IsolatedStorageSecurityStateValue)
        {
            return Observable.Select(IsolatedStorageSecurityStateValue, (IsolatedStorageSecurityStateValueLambda) => IsolatedStorageSecurityStateValueLambda.Quota);
        }


        public static IObservable<System.Reactive.Unit> set_Quota(this IObservable<System.IO.IsolatedStorage.IsolatedStorageSecurityState> IsolatedStorageSecurityStateValue, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(IsolatedStorageSecurityStateValue, value, (IsolatedStorageSecurityStateValueLambda, valueLambda) => IsolatedStorageSecurityStateValueLambda.Quota = valueLambda);
        }

    }
}