using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Threading
{
    public static class __AbandonedMutexException
    {
        
        public static IObservable<System.Threading.Mutex> get_Mutex(this IObservable<System.Threading.AbandonedMutexException> AbandonedMutexExceptionValue)
        {
            return Observable.Select(AbandonedMutexExceptionValue, (AbandonedMutexExceptionValueLambda) => AbandonedMutexExceptionValueLambda.Mutex);
        }


        public static IObservable<System.Int32> get_MutexIndex(this IObservable<System.Threading.AbandonedMutexException> AbandonedMutexExceptionValue)
        {
            return Observable.Select(AbandonedMutexExceptionValue, (AbandonedMutexExceptionValueLambda) => AbandonedMutexExceptionValueLambda.MutexIndex);
        }

    }
}