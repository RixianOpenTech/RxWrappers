using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __WaitHandleExtensions
    {
        
        public static IObservable<Microsoft.Win32.SafeHandles.SafeWaitHandle> GetSafeWaitHandle(IObservable<System.Threading.WaitHandle> waitHandle)
        {
            return Observable.Select(waitHandle, (waitHandleLambda) => System.Threading.WaitHandleExtensions.GetSafeWaitHandle(waitHandleLambda));
        }


        public static IObservable<System.Reactive.Unit> SetSafeWaitHandle(IObservable<System.Threading.WaitHandle> waitHandle, IObservable<Microsoft.Win32.SafeHandles.SafeWaitHandle> value)
        {
            return ObservableExt.ZipExecute(waitHandle, value, (waitHandleLambda, valueLambda) => System.Threading.WaitHandleExtensions.SetSafeWaitHandle(waitHandleLambda, valueLambda));
        }

    }
}