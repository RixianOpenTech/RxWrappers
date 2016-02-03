using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __IProgress1
    {
        
        public static IObservable<System.Reactive.Unit> Report<T>(this IObservable<System.IProgress<T>> IProgressValue, IObservable<T> value)
        {
            return ObservableExt.ZipExecute(IProgressValue, value, (IProgressValueLambda, valueLambda) => IProgressValueLambda.Report(valueLambda));
        }

    }
}